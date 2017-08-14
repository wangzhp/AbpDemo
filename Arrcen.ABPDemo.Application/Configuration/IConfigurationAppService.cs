using System.Threading.Tasks;
using Abp.Application.Services;
using Arrcen.ABPDemo.Configuration.Dto;

namespace Arrcen.ABPDemo.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}