using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace learnGit.Controllers
{
    public abstract class learnGitControllerBase: AbpController
    {
        protected learnGitControllerBase()
        {
            LocalizationSourceName = learnGitConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
