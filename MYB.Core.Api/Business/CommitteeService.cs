using MYB.Core.Api.DTO;
using MYB.Core.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MYB.Core.Api.Business
{
    public class CommitteeService
    {
        private readonly MYBContext db;
        private readonly IContactService contactService;
        private readonly IAttributeService attributeService;

        public CommitteeService(MYBContext db, IContactService contactService, IAttributeService attributeService)
        {
            this.db = db;
            this.contactService = contactService;
            this.attributeService = attributeService;
        }

        //public async Task<IEnumerable<PersonDTO>> Read(int organisationId) {
        //    return await (from fo in db.OrganisationFunction
        //            join f in db.Function on fo.FunctionId equals f.FunctionId
        //                  join p in db.Person on fo.PersonId equals p.PersonId
        //            join c in db.Constituency on fo.ConstituencyId equals c.ConstituencyId
        //            where fo.OrganisationId == organisationId && f.FunctionTypeId == 2
        //            select new PersonDTO
        //            {
                        
        //            }

        //public async Task<PersonDTO> Read(int id)
        //{

        //}
    }
}
