using System;
using System.Collections.Generic;

namespace MYB.Core.Api.Models
{
    public partial class LookUp
    {
        public int Uid { get; set; }
        public int LookUpId { get; set; }
        public string DataValue { get; set; }
        public int? ParentUid { get; set; }
        public int? PubSeq { get; set; }
        public Guid Rowguid { get; set; }
        public string DataDescription { get; set; }
        public Guid MsreplTranVersion { get; set; }
    }
}
