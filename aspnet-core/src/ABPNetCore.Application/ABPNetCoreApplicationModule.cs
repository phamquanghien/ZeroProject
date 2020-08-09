using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ABPNetCore.Authorization;

namespace ABPNetCore
{
    [DependsOn(
        typeof(ABPNetCoreCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ABPNetCoreApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ABPNetCoreAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ABPNetCoreApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
