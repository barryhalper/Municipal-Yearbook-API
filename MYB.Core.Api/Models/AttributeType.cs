using System;
using System.Collections.Generic;

namespace MYB.Core.Api.Models
{
    public partial class AttributeType
    {
        public int AttributeTypeId { get; set; }
        public string AttributeType1 { get; set; }
        public Guid Rowguid { get; set; }
        public Guid MsreplTranVersion { get; set; }
    }
}
