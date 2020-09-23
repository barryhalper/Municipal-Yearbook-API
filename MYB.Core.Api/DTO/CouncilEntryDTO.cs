using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MYB.Core.Api.DTO
{
    public class CouncilEntryDTO : CouncilDTO
    {
        public ContactDTO Tel { get; set; }
        public ContactDTO Fax { get; set; }
        public ContactDTO Email { get; set; }
        public ContactDTO Website { get; set; }

        public string Audit { get; set; }
        public string PoliceAuthority { get; set; }
        public string HealthAuthority { get; set; }
        public string ElectionFrequency { get; set; }
        public string CabinetOption { get; set; }
        public string EuConstituency { get; set; }

        public PersonDTO AdminContact { get; set; }

        public AddressDTO Address { get; set; }
    }
}
