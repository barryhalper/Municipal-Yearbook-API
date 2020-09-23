using System;
using System.Collections.Generic;

namespace MYB.Core.Api.Models
{
    public partial class FunctionGroup
    {
        public int FunctionGroupId { get; set; }
        public string FunctionGroup1 { get; set; }
        public int? DisplayOrder { get; set; }
        public Guid Rowguid { get; set; }
        public Guid MsreplTranVersion { get; set; }
    }
}
