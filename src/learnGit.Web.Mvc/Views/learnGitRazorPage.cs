using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace learnGit.Web.Views
{
    public abstract class learnGitRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected learnGitRazorPage()
        {
            LocalizationSourceName = learnGitConsts.LocalizationSourceName;
        }
    }
}
