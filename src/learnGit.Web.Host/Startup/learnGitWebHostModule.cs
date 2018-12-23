using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using learnGit.Configuration;

namespace learnGit.Web.Host.Startup
{
    [DependsOn(
       typeof(learnGitWebCoreModule))]
    public class learnGitWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public learnGitWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(learnGitWebHostModule).GetAssembly());
        }
    }
}
