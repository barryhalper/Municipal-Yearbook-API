using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MYB.Core.Api.DTO
{
    public class ConstiuencyDTO : ILookupDTO
    {
        public int? Id { get; set; }
        public string Name { get ; set; }
    }
}
