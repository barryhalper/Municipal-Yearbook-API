using MYB.Core.Api.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MYB.Core.Api.Business
{
    public interface IOfficerService
    {
        Task<IEnumerable<OfficerDTO>> Read(int typeId, int organisationID);
        Task<PersonEntryDTO> Read(int id);
    }
}