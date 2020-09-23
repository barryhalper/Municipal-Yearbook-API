using MYB.Core.Api.DTO;
using MYB.Core.Api.Models;
using System.Threading.Tasks;

namespace MYB.Core.Api.Business
{
    public interface IAttributeService
    {
        Task<string> Read(int entityId, int? attributeId);

        Task<string> Read(int EntityTypeid, int entityId, int? attributeId);
    }
}