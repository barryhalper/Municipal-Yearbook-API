using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MYB.Core.Api.DTO
{
    public class CommitteeDTO: ILookupDTO
    {
        public int? Id { get ; set ; }
        public string Name { get ; set; }

        public FunctionDTO Function { get; set;}
    }
}
