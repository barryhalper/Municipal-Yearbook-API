using System;
using System.Collections.Generic;

namespace MYB.Core.Api.Models
{
    public partial class Constituency
    {
        public int ConstituencyId { get; set; }
        public string ConstituencyTypeCode { get; set; }
        public string Constituency1 { get; set; }
        public string Country { get; set; }
        public Guid Rowguid { get; set; }
        public Guid MsreplTranVersion { get; set; }
    }
}
