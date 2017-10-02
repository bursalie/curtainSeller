using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Amcacik.Roles.Dto;

namespace Amcacik.Roles
{
    public interface IRoleAppService : IAsyncCrudAppService<RoleDto, int, PagedResultRequestDto, CreateRoleDto, RoleDto>
    {
        Task<ListResultDto<PermissionDto>> GetAllPermissions();
    }
}
