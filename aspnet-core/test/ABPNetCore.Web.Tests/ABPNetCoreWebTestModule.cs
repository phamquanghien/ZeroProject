using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ABPNetCore.EntityFrameworkCore;
using ABPNetCore.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace ABPNetCore.Web.Tests
{
    [DependsOn(
        typeof(ABPNetCoreWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class ABPNetCoreWebTestModule : AbpModule
    {
        public ABPNetCoreWebTestModule(ABPNetCoreEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ABPNetCoreWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(ABPNetCoreWebMvcModule).Assembly);
        }
    }
}