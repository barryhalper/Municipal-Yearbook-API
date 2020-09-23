using System;
using System.Collections.Generic;

namespace MYB.Core.Api.Models
{
    public partial class AttributeData
    {
        public int AttributeDataId { get; set; }
        public int? Entity { get; set; }
        public int? AttributeId { get; set; }
        public int EntityId { get; set; }
        public string AttributeAbbreviation { get; set; }
        public string AttributeData1 { get; set; }
        public int? PublishingSequence { get; set; }
        public string Profile { get; set; }
        public int? EditorialContactId { get; set; }
        public DateTime? LastUpdated { get; set; }
        public string UpdatedBy { get; set; }
        public Guid Rowguid { get; set; }
        public string Year { get; set; }
        public bool? IsCurrent { get; set; }
        public short? DataYear { get; set; }
        public Guid MsreplTranVersion { get; set; }

        public virtual Attribute Attribute { get; set; }
        public virtual Organisation EntityNavigation { get; set; }
    }
}
