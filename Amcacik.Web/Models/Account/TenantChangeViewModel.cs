using Abp.AutoMapper;
using Amcacik.Sessions.Dto;

namespace Amcacik.Web.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}