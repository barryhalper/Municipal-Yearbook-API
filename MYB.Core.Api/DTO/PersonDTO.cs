using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MYB.Core.Api.DTO
{
    public class PersonDTO
    {
        [Key]
        public int PersonId { get; set; }
        public string Title { get; set; }
        public string Initial { get; set; }
        public string Forename { get; set; }
        public string Surname { get; set; }
        public string Suffix { get; set; }
        public string FullName { get; set; }
        public string JobTitle { get; set; }
        public string Gender { get; set; }
        public string Department { get; set; }

        public AddressDTO Address { get; set; }
    }
}
