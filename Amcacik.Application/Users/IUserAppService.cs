using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Amcacik.Roles.Dto;
using Amcacik.Users.Dto;

namespace Amcacik.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}