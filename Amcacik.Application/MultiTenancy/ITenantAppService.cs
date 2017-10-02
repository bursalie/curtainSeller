using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Amcacik.MultiTenancy.Dto;

namespace Amcacik.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
