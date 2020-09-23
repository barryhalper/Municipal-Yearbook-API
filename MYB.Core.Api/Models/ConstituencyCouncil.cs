using System;
using System.Collections.Generic;

namespace MYB.Core.Api.Models
{
    public partial class ConstituencyCouncil
    {
        public int ConstituencyId { get; set; }
        public int CouncilId { get; set; }
        public Guid Rowguid { get; set; }
        public Guid MsreplTranVersion { get; set; }
    }
}
