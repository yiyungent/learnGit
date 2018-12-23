using System.Threading.Tasks;
using learnGit.Configuration.Dto;

namespace learnGit.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
