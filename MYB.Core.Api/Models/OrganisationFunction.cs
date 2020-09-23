using System;
using System.Collections.Generic;

namespace MYB.Core.Api.Models
{
    public partial class OrganisationFunction
    {
        public int OrganisationFunctionId { get; set; }
        public int OrganisationId { get; set; }
        public int FunctionId { get; set; }
        public string FunctionName { get; set; }
        public int? PersonId { get; set; }
        public string JobTitle { get; set; }
        public string Department { get; set; }
        public int? AddressId { get; set; }
        public string Phone { get; set; }
        public string Phone2 { get; set; }
        public string Fax { get; set; }
        public string Fax2 { get; set; }
        public string Email { get; set; }
        public string Email2 { get; set; }
        public int? ConstituencyId { get; set; }
        public string FunctionStatusCode { get; set; }
        public string Profile { get; set; }
        public string Note { get; set; }
        public int? PublishingSequence { get; set; }
        public int? EditorialContactId { get; set; }
        public string ContactMedium { get; set; }
        public DateTime? LastUpdated { get; set; }
        public DateTime? PositionFilled { get; set; }
        public string UpdatedBy { get; set; }
        public Guid Rowguid { get; set; }
        public Guid MsreplTranVersion { get; set; }
    }
}
