using MYB.Core.Api.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MYB.Core.Api.Business
{
    public interface ILookUpService
    {
      
        Task<IEnumerable<LookupDTO>> Committees();
        Task<IEnumerable<LookupDTO>> CouncillorFunctions();
        Task<IEnumerable<LookupDTO>> CouncilTypes();
        string[] Countries();
        string[] Gender();
        Task<IEnumerable<LookupDTO>> OfficerFunctions();
        Task<IEnumerable<LookupDTO>> Parties();
        Task<IEnumerable<LookupDTO>> Status();
        Task<IEnumerable<LookupDTO>> Titles();
    }
}