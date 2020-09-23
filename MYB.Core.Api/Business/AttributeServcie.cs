using Microsoft.EntityFrameworkCore;
using MYB.Core.Api.DTO;
using MYB.Core.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MYB.Core.Api.Business
{
    public class AttributeService : IAttributeService
    {
        private readonly MYBContext db;

        public AttributeService(MYBContext mybContext)
        {
            db = mybContext;

        }

        public async Task<string> Read(int entityId, int? attributeId)
        {
            return await db.AttributeData.Where(x => x.EntityId == entityId && x.AttributeId == attributeId).Select(x =>  x.AttributeData1 ).FirstOrDefaultAsync();
        }

        public async Task<String> Read(int EntityTypeid, int entityId, int? attributeId)
        {
           
            if  ( db.AttributeData.Any(x => x.Entity == EntityTypeid && x.EntityId == entityId && x.AttributeId == attributeId)) { 
                return await db.AttributeData.Where(x => x.Entity == EntityTypeid && x.EntityId == entityId && x.AttributeId == attributeId ).Select(x => x.AttributeData1).FirstOrDefaultAsync();
            }
            return null;
        }

    }
}
