using System;
using System.Collections.Generic;

namespace MYB.Core.Api.Models
{
    public partial class Title
    {
        public int PTitleId { get; set; }
        public string TitleDescription { get; set; }
        public string TitleOrder { get; set; }
        public string Gender { get; set; }
        public bool? DeletedFlag { get; set; }
        public DateTime? DateArchived { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateAmended { get; set; }
        public int? FAmendedBy { get; set; }
        public int? FTitleId { get; set; }
        public int? OldTitleId { get; set; }
        public Guid MsreplTranVersion { get; set; }
        public Guid Rowguid { get; set; }
    }
}
