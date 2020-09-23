using System;
using System.Collections.Generic;

namespace MYB.Core.Api.Models
{
    public partial class AttributeGroup
    {
        public int AttributeGroupId { get; set; }
        public string AttributeGroup1 { get; set; }
        public int? DisplayOrder { get; set; }
        public int? OrganisationTypeId { get; set; }
        public Guid Rowguid { get; set; }
        public bool? IsShared { get; set; }
        public Guid MsreplTranVersion { get; set; }
    }
}
