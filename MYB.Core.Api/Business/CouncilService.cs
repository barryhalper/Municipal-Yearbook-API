using Microsoft.EntityFrameworkCore;
using MYB.Core.Api.DTO;
using MYB.Core.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MYB.Core.Api.Business
{


    public class CouncilService : ICouncilService
    {
        private readonly MYBContext db;
        private readonly IContactService contactService;
        private readonly IAttributeService attributeService;
        private readonly IPersonService personService;


        public CouncilService(MYBContext mybContext, IContactService contactService, IAttributeService attributeService, IPersonService personService)
        {
            db = mybContext;
            this.contactService = contactService;
            this.attributeService = attributeService;
            this.personService = personService;
        }

        public async Task<IEnumerable<CouncilDTO>> Read()
        {
            return await db.Organisation.Where(x => x.OrganisationTypeId == 5)
                .Select(x => new CouncilDTO
                {
                    OrganisationId = x.OrganisationId,
                    Organisation1 = x.Organisation1,
                    PublishedName = x.PublishedName,
                    PublishingSequence = x.PublishingSequence,

                }
                    ).ToListAsync();
        }


        public async Task<CouncilEntryDTO> Read(int id)
        {
            CouncilEntryDTO dto = await db.Organisation.Where(x => x.OrganisationId == id)
                .Select(x => new CouncilEntryDTO
                {
                    OrganisationId = x.OrganisationId,
                    Organisation1 = x.Organisation1,
                    PublishedName = x.PublishedName,
                    PublishingSequence = x.PublishingSequence,
                    Abbreviation = x.Abbreviation,
                    Address = new AddressDTO
                    {
                        Address1 = x.Address.FirstOrDefault().Address1,
                        Address2 = x.Address.FirstOrDefault().Address2,
                        Address3 = x.Address.FirstOrDefault().Address3,
                        Postcode = String.Format("{0} {1}", x.Address.FirstOrDefault().Pcl, x.Address.FirstOrDefault().Pcr),
                        Town = x.Address.FirstOrDefault().Town,
                        Region = x.Address.FirstOrDefault().Region,

                        AddressId = Convert.ToInt32(x.AddressId),
                        Longitude = x.Address.FirstOrDefault().Longitude,
                        Latitude = x.Address.FirstOrDefault().Latitude,
                        Country = x.Address.FirstOrDefault().Country,


                    },

                    //Tel =await contactService.Read(ContactService.Medium.Phone, ContactService.ContactEntity.Organisation, id)

                }
                    ).FirstOrDefaultAsync();

            dto.Tel = await contactService.Read((int)Medium.Phone, (int)ContactEntity.Organisation, id);
            dto.Email = await contactService.Read((int)Medium.Email, (int)ContactEntity.Organisation, id);
            dto.Website = await contactService.Read((int)Medium.Web, (int)ContactEntity.Organisation, id);
            dto.Fax = await contactService.Read((int)Medium.Web, (int)ContactEntity.Organisation, id);
            dto.CouncilType = await attributeService.Read(id, 25);

            try
            {
                int auditId = Convert.ToInt32(await attributeService.Read((int)ContactEntity.Organisation, id, 40));

                dto.Audit = db.Organisation.FirstOrDefault(x => x.OrganisationId == auditId).Organisation1;
            }
            catch { }

            try
            {
                var policeAuthorityId = Convert.ToInt32(await attributeService.Read((int)ContactEntity.Organisation, id, 146));
                dto.PoliceAuthority = db.Organisation.FirstOrDefault(x => x.OrganisationId == policeAuthorityId).Organisation1;
            }
            catch { }
            try
            {
                var healthAuthorityId = Convert.ToInt32(await attributeService.Read((int)ContactEntity.Organisation, id, 48));
                dto.HealthAuthority = db.Organisation.FirstOrDefault(x => x.OrganisationId == healthAuthorityId).Organisation1;
            }
            catch { }

            dto.ElectionFrequency = await attributeService.Read((int)ContactEntity.Organisation, id, 32);
            dto.CabinetOption = await attributeService.Read((int)ContactEntity.Organisation, id, 53);
            dto.EuConstituency = await attributeService.Read((int)ContactEntity.Organisation, id, 39);

            dto.AdminContact = await personService.CouncilContact(id);

            return dto;

        }



        public async Task<IEnumerable<LookupDTO>> Constiuencies(int organissationId)
        {
            return await (from cc in db.ConstituencyCouncil
                                        join c in db.Constituency on cc.ConstituencyId equals c.ConstituencyId
                                         where cc.CouncilId == organissationId && c.Constituency1 != ""
                                        select new LookupDTO {
                                                       Id  = c.ConstituencyId,
                                                       Name= c.Constituency1
                                                }
                                      ).ToListAsync();

         

           

        }

        


    }
}
