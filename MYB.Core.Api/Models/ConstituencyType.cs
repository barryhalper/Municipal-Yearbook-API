using System;
using System.Collections.Generic;

namespace MYB.Core.Api.Models
{
    public partial class ConstituencyType
    {
        public string ConstituencyTypeCode { get; set; }
        public Guid Rowguid { get; set; }
        public Guid MsreplTranVersion { get; set; }
    }
}
