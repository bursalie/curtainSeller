using System.Threading.Tasks;
using Abp.Application.Services;
using Amcacik.Authorization.Accounts.Dto;

namespace Amcacik.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
