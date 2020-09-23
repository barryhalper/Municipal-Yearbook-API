using System;
using System.Collections.Generic;

namespace MYB.Core.Api.Models
{
    public partial class FunctionTypeStatusCode
    {
        public int FunctionTypeId { get; set; }
        public string FunctionStatusCode { get; set; }
        public bool PersonRequired { get; set; }
        public Guid Rowguid { get; set; }
        public Guid MsreplTranVersion { get; set; }
    }
}
