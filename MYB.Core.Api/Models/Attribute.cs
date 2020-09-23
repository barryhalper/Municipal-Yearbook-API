using System;
using System.Collections.Generic;

namespace MYB.Core.Api.Models
{
    public partial class Attribute
    {
        public Attribute()
        {
            AttributeData = new HashSet<AttributeData>();
        }

        public int AttributeId { get; set; }
        public int? AttributeSubGroupId { get; set; }
        public string Attribute1 { get; set; }
        public string Abbreviation { get; set; }
        public int? AttributeTypeId { get; set; }
        public int? OrganisationTypeId { get; set; }
        public int? OuidtypeId { get; set; }
        public string DataTypeCode { get; set; }
        public string Relationship { get; set; }
        public int? LookUpId { get; set; }
        public int? PublishingSequence { get; set; }
        public int? DataControlHeight { get; set; }
        public int? DataControlWidth { get; set; }
        public int? ProfileControlHeight { get; set; }
        public int? ProfileControlWidth { get; set; }
        public string ReverseName { get; set; }
        public Guid Rowguid { get; set; }
        public bool? RollOver { get; set; }
        public bool? Compendium { get; set; }
        public string Unit { get; set; }
        public Guid MsreplTranVersion { get; set; }

        public virtual ICollection<AttributeData> AttributeData { get; set; }
    }
}
