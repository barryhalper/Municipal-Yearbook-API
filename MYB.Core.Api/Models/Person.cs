using System;
using System.Collections.Generic;

namespace MYB.Core.Api.Models
{
    public partial class Person
    {
        public int PersonId { get; set; }
        public int? AddressId { get; set; }
        public string Title { get; set; }
        public string Initial { get; set; }
        public string Forename { get; set; }
        public string Surname { get; set; }
        public string Suffix { get; set; }
        public string FullName { get; set; }
        public string JobTitle { get; set; }
        public string Gender { get; set; }
        public string Department { get; set; }
        public string DeliveryPoint { get; set; }
        public string Mobile { get; set; }
        public string Mobile2 { get; set; }
        public string PersonalEmail { get; set; }
        public string Web { get; set; }
        public string Web2 { get; set; }
        public string Note { get; set; }
        public string AdditionalResponsibility { get; set; }
        public int? MybtableId { get; set; }
        public int? MybentityId { get; set; }
        public bool? ToBurst { get; set; }
        public Guid Rowguid { get; set; }
        public bool? NoMail { get; set; }
        public bool? NoSell { get; set; }
        public bool? NoTpemail { get; set; }
        public bool? NoEmail { get; set; }
        public Guid MsreplTranVersion { get; set; }
    }
}
