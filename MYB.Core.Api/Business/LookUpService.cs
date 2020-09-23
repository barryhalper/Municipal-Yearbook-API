using Microsoft.EntityFrameworkCore;
using MYB.Core.Api.DTO;
using MYB.Core.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MYB.Core.Api.Business
{
    public class LookUpService : ILookUpService
    {
        private readonly MYBContext db;

        public LookUpService(MYBContext db)
        {
            this.db = db;
        }

        public async Task<IEnumerable<LookupDTO>> OfficerFunctions()
        {
            return await GetFunctions(1);
        }

        public async Task<IEnumerable<LookupDTO>> Titles()
        {
            return await db.Title.Select(x => new LookupDTO { Id = x.PTitleId, Name = x.TitleDescription }).ToListAsync();
        }

        public async Task<IEnumerable<LookupDTO>> Status()
        {
            return await db.FunctionStatus.Select(x => new LookupDTO { Name = x.FunctionStatus1 }).ToListAsync();

        }

        public string[] Gender()
        {
            return new string[] { "M", "F" };



        }

        public async Task<IEnumerable<LookupDTO>> CouncillorFunctions()
        {
            return await GetFunctions(2);
        }

        public async Task<IEnumerable<LookupDTO>> Parties()
        {
            return await db.Organisation.Where(x => x.OrganisationTypeId == 10).Select(x => new LookupDTO { Id = x.OrganisationId, Name = x.Organisation1 }).ToListAsync();
        }

        public string[] Countries()
        {
            return new string[] { "England", "Scotland", "Wales", "Northern Ireland", "Isles" };
        }

        public async Task<IEnumerable<LookupDTO>> CouncilTypes()
        {
            return await db.LookUp.Where(x => x.LookUpId == 1).Select(x => new LookupDTO { Id = x.Uid, Name = x.DataValue }).ToListAsync();
        }

        private async Task<IEnumerable<LookupDTO>> GetFunctions(int id)
        {
            return await db.Function.Where(x => x.FunctionTypeId == id).Select(x => new LookupDTO { Id = x.FunctionId, Name = x.Function1 }).ToListAsync();
        }

        public async Task<IEnumerable<LookupDTO>> Committees()
        {
            return await db.Function.Where(x => x.FunctionTypeId == 4).Select(x => new LookupDTO { Id = x.FunctionId, Name = x.Function1 }).ToListAsync();
        }
    }
}
