using MYB.Core.Api.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MYB.Core.Api.Business
{
    public interface ICouncillorService
    {
        Task<IEnumerable<CouncillorDTO>> Read(int organisationId);
        Task<CouncillorEntryDTO> ReadEntry(int id);
    }
}