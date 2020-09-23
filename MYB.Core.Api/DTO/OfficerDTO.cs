using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MYB.Core.Api.DTO
{
    public class OfficerDTO
    {
        public int Id { get; set; }
        public string Directorate { get; set; }
        public DateTime? Updated { get; set; }
        public string UpdatedBy { get; set; }
        public PersonDTO Person { get; set; }
        public FunctionDTO Function { get; set; }

       

    }
}
