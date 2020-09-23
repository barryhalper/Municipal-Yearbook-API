using System;
using System.Collections.Generic;

namespace MYB.Core.Api.Models
{
    public partial class Function
    {
        public int FunctionId { get; set; }
        public int? FunctionTypeId { get; set; }
        public int? OrganisationTypeId { get; set; }
        public string Function1 { get; set; }
        public string PublishingName { get; set; }
        public string MailingName { get; set; }
        public string FunctionCode { get; set; }
        public int? PublishingSequence { get; set; }
        public bool? Publish { get; set; }
        public string Note { get; set; }
        public Guid Rowguid { get; set; }
        public Guid MsreplTranVersion { get; set; }
        public int? DirectorateId { get; set; }
    }
}
