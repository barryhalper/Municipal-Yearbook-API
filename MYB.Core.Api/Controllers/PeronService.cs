using Microsoft.EntityFrameworkCore;
using MYB.Core.Api.Business;
using MYB.Core.Api.DTO;
using MYB.Core.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MYB.Core.Api.Controllers
{
    public class PeronService : IPeronService
    {
        private readonly MYBContext db;
        private readonly IContactService contactService;
        private readonly IAttributeService attributeService;

        public PeronService(MYBContext mybContext, IContactService contactService, IAttributeService attributeService)
        {
            db = mybContext;
            this.contactService = contactService;
            this.attributeService = attributeService;
        }

        //public async Task<IEnumerable<PersonDTO>> ReadOfficers(int organisationId) { 

        //}

        public async Task<PersonDTO> CouncilContact(int organisationId)
        {

            var person = await (from fo in db.OrganisationFunction
                                join p in db.Person on fo.PersonId equals p.PersonId
                                join a in db.Address on fo.AddressId equals a.AddressId
                                select new PersonDTO
                                {
                                    PersonId = p.PersonId,
                                    Forename = p.Forename,
                                    Surname = p.Surname,
                                    Suffix = p.Suffix,
                                    Title = p.Title,
                                    JobTitle = fo.JobTitle,
                                    Address = new AddressDTO { Address1 = a.Address1, Address2 = a.Address2, Address3 = a.Address3, AddressId = a.AddressId, Country = a.Country, Postcode = a.Postcode, Region = a.Region, Town = a.Town }


                                }).FirstOrDefaultAsync();

            person.Email = await contactService.Read((int)Medium.Email, (int)ContactEntity.Person, person.PersonId);
            return person;
        }


    }
}
