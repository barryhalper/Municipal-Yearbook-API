using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MYB.Core.Api.DTO
{
    public class PersonEntryDTO : PersonDTO
    {

        public IEnumerable<CouncilDTO> Organisations { get; set; }
        //public IEnumerable<string> Functions{ get; set; }

        public ContactDTO Email { get; set; }

        public ContactDTO Tel { get; set; }

        public string Notes { get; set; }

      
    }
}
