using System;
using System.Collections.Generic;

namespace MYB.Core.Api.Models
{
    public partial class FunctionStatus
    {
        public string FunctionStatusCode { get; set; }
        public string FunctionStatus1 { get; set; }
        public bool? WebDisplay { get; set; }
        public bool? DeskTopDisplay { get; set; }
        public Guid Rowguid { get; set; }
        public Guid MsreplTranVersion { get; set; }
    }
}
