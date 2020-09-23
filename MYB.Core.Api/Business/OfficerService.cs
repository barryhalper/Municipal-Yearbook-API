using Microsoft.EntityFrameworkCore;
using MYB.Core.Api.DTO;
using MYB.Core.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MYB.Core.Api.Business
{
    public class OfficerService : IOfficerService
    {
        private readonly MYBContext db;
        private readonly IContactService contactService;
        private readonly IAttributeService attributeService;

        public OfficerService(MYBContext db, IContactService contactService, IAttributeService attributeService)
        {

            this.db = db;
            this.contactService = contactService;
            this.attributeService = attributeService;

        }

        public async Task<IEnumerable<OfficerDTO>> Read(int typeId, int organisationID)
        {
            var officers = await (from fo in db.OrganisationFunction
                                  join f in db.Function on fo.FunctionId equals f.FunctionId
                                  join pl in db.Person on fo.PersonId equals pl.PersonId into plj
                                  from p in plj.DefaultIfEmpty()
                                      //join dl in db.d on f.directorateID equals dl.ID into dlj
                                      //from d in dlj.DefaultIfEmpty()
                                  where f.FunctionTypeId == typeId && fo.OrganisationId == organisationID
                                  select new OfficerDTO
                                  {
                                      Id = fo.OrganisationFunctionId,
                                      
                                      Function = 
                                      new FunctionDTO { 
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
                                           JobTitle = p.JobTitle
                                       }

                                  }
              ).ToListAsync();

            return officers;
        }



        public async Task<PersonEntryDTO> Read(int id)
        {
            var person = await (from p in db.Person
                                join alj in db.Address on p.AddressId equals alj.AddressId into al
                                from a in al.DefaultIfEmpty()
                                where p.PersonId == id
                                select new PersonEntryDTO
                                {
                                    PersonId = p.PersonId,
                                    Forename = p.Forename,
                                    Surname = p.Surname,
                                    Suffix = p.Suffix,
                                    Title = p.Title,
                                    JobTitle = p.JobTitle,
                                    Notes = p.Note,

                                    Address = new AddressDTO { Address1 = a.Address1, Address2 = a.Address2, Address3 = a.Address3, AddressId = a.AddressId, Country = a.Country, Postcode = a.Postcode, Region = a.Region, Town = a.Town }
                                }).FirstOrDefaultAsync();

            person.Tel = await contactService.Read((int)Medium.Phone, (int)ContactEntity.Person, id);
            person.Email = await contactService.Read((int)Medium.Email, (int)ContactEntity.Person, id);

            person.Organisations = await (from fo in db.OrganisationFunction
                                          join o in db.Organisation on fo.OrganisationId equals o.OrganisationId
                                          where fo.PersonId == id && fo.FunctionStatusCode == "Active"
                                          select new CouncilDTO { OrganisationId = o.OrganisationId, Organisation1 = o.Organisation1 }).Distinct().ToListAsync();

            // person.Functions = await db.OrganisationFunction.Where(x => x.PersonId == id).Select(x => x.FunctionId).ToListAsync();

            return person;
        }
    }
}
