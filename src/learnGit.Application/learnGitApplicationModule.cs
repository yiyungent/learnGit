using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using learnGit.Authorization;

namespace learnGit
{
    [DependsOn(
        typeof(learnGitCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class learnGitApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<learnGitAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(learnGitApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
