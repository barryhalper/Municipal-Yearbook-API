using MYB.Core.Api.DTO;
using MYB.Core.Api.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MYB.Core.Api.Business
{
    public interface ICouncilService
    {
        Task<IEnumerable<LookupDTO>> Constiuencies(int organissationId);
        Task<IEnumerable<CouncilDTO>> Read();
            Task<CouncilEntryDTO> Read(int id);
       
    }
}