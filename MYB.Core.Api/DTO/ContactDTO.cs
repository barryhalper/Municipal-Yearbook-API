using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MYB.Core.Api.DTO
{
    public class ContactDTO: ILookupDTO
    {
        public int? Id { get; set; }
        public String Name { get; set; }
    }
}
