using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MYB.Core.Api.DTO
{
    public class FunctionDTO
    {
        public int? Id { get; set; }
        public String Name { get; set; }

        public string Status { get; set; }

        public DateTime? Updated { get; set; }
        public string UpdatedBy { get; set; }
    }
}
