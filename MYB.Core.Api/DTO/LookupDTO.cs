using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MYB.Core.Api.DTO
{
    public class LookupDTO : ILookupDTO
    {
        [Key]
        public int? Id { get; set; }
        public String Name { get; set; }
    }
}
