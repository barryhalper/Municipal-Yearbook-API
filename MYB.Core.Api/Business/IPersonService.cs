using MYB.Core.Api.DTO;
using System.Threading.Tasks;

namespace MYB.Core.Api.Business
{
    public interface IPersonService
    {
        Task<PersonEntryDTO> CouncilContact(int organisationId);
       
    }
}