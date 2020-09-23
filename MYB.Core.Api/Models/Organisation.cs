using System;
using System.Collections.Generic;

namespace MYB.Core.Api.Models
{
    public partial class Organisation
    {
        public Organisation()
        {
            Address = new HashSet<Address>();
            AttributeData = new HashSet<AttributeData>();
        }

        public int OrganisationId { get; set; }
        public int? OrganisationTypeId { get; set; }
        public string Organisation1 { get; set; }
        public string PublishedName { get; set; }
        public string LocalName { get; set; }
        public string Abbreviation { get; set; }
        public int? AddressId { get; set; }
        public int? EditorialContactId { get; set; }
        public string Note { get; set; }
        public int? MybtableId { get; set; }
        public int? MybentityId { get; set; }
        public string Email { get; set; }
        public int? PublishingSequence { get; set; }
        public string AdministrativeRegion { get; set; }
        public int? ElectionPending { get; set; }
        public DateTime? NextElection { get; set; }
        public string Foiemail { get; set; }

        public virtual ICollection<Address> Address { get; set; }
        public virtual ICollection<AttributeData> AttributeData { get; set; }
    }
}
