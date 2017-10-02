using System.Threading.Tasks;
using Abp.Application.Services;
using Amcacik.Configuration.Dto;

namespace Amcacik.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}