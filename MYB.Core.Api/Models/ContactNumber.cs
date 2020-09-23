using System;
using System.Collections.Generic;

namespace MYB.Core.Api.Models
{
    public partial class ContactNumber
    {
        public int ContactNumberId { get; set; }
        public int? EntityTypeId { get; set; }
        public int? EntityId { get; set; }
        public int? ContactMediumId { get; set; }
        public string Label { get; set; }
        public string ContactNumber1 { get; set; }
        public int? IsMain { get; set; }
        public Guid Rowguid { get; set; }
        public int? OrganisationId { get; set; }
        public Guid MsreplTranVersion { get; set; }
    }
}
