using System;
using System.Collections.Generic;

namespace MYB.Core.Api.Models
{
    public partial class Address
    {
        public int AddressId { get; set; }
        public int? OrganisationId { get; set; }
        public string DeliveryPoint { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Address4 { get; set; }
        public string Town { get; set; }
        public string Region { get; set; }
        public string Postcode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Phone2 { get; set; }
        public string Fax { get; set; }
        public string Fax2 { get; set; }
        public string Email { get; set; }
        public string Email2 { get; set; }
        public string Web { get; set; }
        public string Web2 { get; set; }
        public string Note { get; set; }
        public int? MybtableId { get; set; }
        public int? MybentityId { get; set; }
        public string Pcl { get; set; }
        public string Pcr { get; set; }
        public Guid Rowguid { get; set; }
        public double? Longitude { get; set; }
        public double? Latitude { get; set; }
        public int? Accuracy { get; set; }
        public Guid MsreplTranVersion { get; set; }

        public virtual Organisation Organisation { get; set; }
    }
}
