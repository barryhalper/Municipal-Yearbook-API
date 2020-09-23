using MYB.Core.Api.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MYB.Core.Api.DTO
{
    public class CouncilDTO
    {
        [JsonProperty(PropertyName = "Id")]
        [Key]
        public int OrganisationId { get; set; }
        [JsonProperty(PropertyName = "Name")]
        public string Organisation1 { get; set; }
        public string PublishedName { get; set; }
        public string LocalName { get; set; }
        public string Abbreviation { get; set; }
       
        public int? PublishingSequence { get; set; }
        public string CouncilType { get; set; }

        public ContactDTO Tel { get; set; }
        public ContactDTO Fax { get; set; }
        public ContactDTO Email { get; set; }

        public ContactDTO Website { get; set; }

        public PersonEntryDTO AdminContact { get; set; }


        //public virtual ICollection<AttributeData> AttributeData { get; set; }

    }
}
