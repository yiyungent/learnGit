using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using learnGit.Configuration.Dto;

namespace learnGit.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : learnGitAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
