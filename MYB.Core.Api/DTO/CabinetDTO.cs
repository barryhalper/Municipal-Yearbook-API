using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MYB.Core.Api.DTO
{
    public class CabinetDTO: ILookupDTO
    {
        public int? Id { get; set; }
        public string Name { get; set; }

        public  PersonDTO Person { get; set; }

        public FunctionDTO Function { get; set; }

        public int? Pubsequnece { get; set; }
    }
}
