using AutoMapper;
using MYB.Core.Api.DTO;
using MYB.Core.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MYB.Core.Api.Mappings
{
    public class CouncilMapping: Profile
    {
        public CouncilMapping() {
            CreateMap<CouncilDTO, Organisation>();
            CreateMap<Organisation, CouncilDTO>();
        }
    }
}
