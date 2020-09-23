using MYB.Core.Api.DTO;
using System.Threading.Tasks;

namespace MYB.Core.Api.Business
{
    public interface IContactService
    {
        Task<ContactDTO> Read(int mediumId, int entityTypeId, int entityid);
    }
}