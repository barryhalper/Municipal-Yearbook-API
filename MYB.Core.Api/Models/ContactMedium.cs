using System;
using System.Collections.Generic;

namespace MYB.Core.Api.Models
{
    public partial class ContactMedium
    {
        public int ContactMediumId { get; set; }
        public string ContactMedium1 { get; set; }
        public Guid Rowguid { get; set; }
        public Guid MsreplTranVersion { get; set; }
    }
}
