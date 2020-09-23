using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MYB.Core.Api.DTO
{
    public class CouncillorEntryDTO
    {

        [Key]
        public int Id { get; set; }

        public IEnumerable<FunctionDTO> Cabinets { get; set; }
        public LookupDTO Constiuency { get; set; }

        public IEnumerable<CommitteeDTO> Committees { get; set; }

        public PersonDTO Person { get; set; }

        public FunctionDTO  Function { get; set; }

        public ContactDTO Email { get; set; }

        public ContactDTO Tel { get; set; }

        public string Notes { get; set; }

        public LookupDTO Party { get; set; }


    }
}

