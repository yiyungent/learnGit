using Abp.AspNetCore.Mvc.ViewComponents;

namespace learnGit.Web.Views
{
    public abstract class learnGitViewComponent : AbpViewComponent
    {
        protected learnGitViewComponent()
        {
            LocalizationSourceName = learnGitConsts.LocalizationSourceName;
        }
    }
}
