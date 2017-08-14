using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Arrcen.ABPDemo.Configuration.Dto;

namespace Arrcen.ABPDemo.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ABPDemoAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
