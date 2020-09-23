using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MYB.Core.Api.DTO
{
    public class AddressDTO
    {
        [Key]
        public int AddressId { get; set; }
      
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
      
        public string Town { get; set; }
        public string Region { get; set; }
        public string Postcode { get; set; }
        public string Country { get; set; }
        public double? Longitude { get; set; }
        public double? Latitude { get; set; }

        

    }
}
