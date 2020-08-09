using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ABPNetCore.Configuration.Dto;

namespace ABPNetCore.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ABPNetCoreAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
