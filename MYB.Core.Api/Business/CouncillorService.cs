using Microsoft.EntityFrameworkCore;
using MYB.Core.Api.DTO;
using MYB.Core.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MYB.Core.Api.Business
{
    public class CouncillorService : ICouncillorService
    {
        private readonly MYBContext db;
        private readonly IContactService contactService;
        private readonly IAttributeService attributeService;

        public CouncillorService(MYBContext db, IContactService contactService, IAttributeService attributeService)
        {
            this.db = db;
            this.contactService = contactService;
            this.attributeService = attributeService;
        }

        public async Task<IEnumerable<CouncillorDTO>> Read(int organisationId)
        {
            return await (from fo in db.OrganisationFunction
                          join f in db.Function on fo.FunctionId equals f.FunctionId
                          join p in db.Person on fo.PersonId equals p.PersonId
                          join c in db.Constituency on fo.ConstituencyId equals c.ConstituencyId
                          where fo.OrganisationId == organisationId && f.FunctionTypeId == 2
                          select new CouncillorDTO
                          {

                              PersonId = p.PersonId,
                              Title = p.Title,
                              Forename = p.Forename,
                              Department = fo.Department,
                              Surname = p.Surname,
                              Gender = p.Gender,
                              JobTitle = p.JobTitle,
                              Address = new AddressDTO(),
                              Constituency = c.Constituency1
                              
                          }).ToListAsync();


        }

        public async Task<CouncillorEntryDTO> ReadEntry(int id)
        {
            var councillor = await (from p in db.Person
                                    join fo in db.OrganisationFunction on p.PersonId equals fo.PersonId
                                    join f in db.Function on fo.FunctionId equals f.FunctionId

                                    join alj in db.Address on p.AddressId equals alj.AddressId into al
                                    from a in al.DefaultIfEmpty()
                                    where p.PersonId == id && f.FunctionTypeId == 2
                                    //&& ctel.ContactMediumID == 1 && cemail.ContactMediumID == 4
                                    orderby f.PublishingSequence
                                    select new CouncillorEntryDTO
                                    {
                                        Id = p.PersonId,
                                        Function = new FunctionDTO
                                        {
                                            Id = f.FunctionId,
                                            Name = f.Function1,
                                            Status = fo.FunctionStatusCode,
                                            Updated = fo.LastUpdated,
                                            UpdatedBy = fo.UpdatedBy,
                                           

                                        },

                                        Person = (p == null) ? new PersonDTO() : new PersonDTO
                                        {
                                            PersonId = p.PersonId,
                                            Title = p.Title,
                                            Forename = p.Forename,
                                            Department = fo.Department,
                                            Surname = p.Surname,
                                            Gender = p.Gender,
                                            JobTitle = p.JobTitle,
                                          
                                        },

                                        Constiuency = (from cc in db.ConstituencyCouncil
                                                       join c in db.Constituency on cc.ConstituencyId equals c.ConstituencyId
                                                       where cc.ConstituencyId == fo.ConstituencyId
                                                       select new LookupDTO { Id = c.ConstituencyId, Name = c.Constituency1 }).FirstOrDefault(),

                                        Cabinets =  (from p in db.Person
                                                          join fo in db.OrganisationFunction on p.PersonId equals fo.PersonId
                                                          where fo.FunctionId == 71276 && fo.PersonId == id
                                                          select new FunctionDTO { Name = fo.FunctionName, Id = fo.FunctionId }).ToList(),

                                        Committees = (from fo in db.OrganisationFunction
                                                     join f in db.Function on fo.FunctionId equals f.FunctionId
                                                     where f.FunctionTypeId == 4 & fo.PersonId == id
                                                      select new CommitteeDTO {
                                                          Name = fo.FunctionName,
                                                          Id = fo.OrganisationFunctionId,
                                                          Function = new FunctionDTO {  Id = f.FunctionId, Name = f.Function1, Status = f.FunctionCode,
                                                             
                                                          }
                                                      })

        }
               ).FirstOrDefaultAsync();

            councillor.Tel = await contactService.Read((int)Medium.Phone, (int)ContactEntity.Person, id);
            councillor.Email = await contactService.Read((int)Medium.Email, (int)ContactEntity.Person, id);
           

           var partyId  = await attributeService.Read((int)ContactEntity.Person, id, 65);
            if (partyId != null) { 
              councillor.Party = await db.Organisation.Where(x => x.OrganisationId == Convert.ToInt32(partyId)).Select(x => new LookupDTO { Id = x.OrganisationId, Name = x.Organisation1 }).FirstOrDefaultAsync();
            }



            return councillor;
            ;

        }

    }
}
