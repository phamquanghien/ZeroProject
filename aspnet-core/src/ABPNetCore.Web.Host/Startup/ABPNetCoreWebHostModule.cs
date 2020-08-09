using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ABPNetCore.Configuration;

namespace ABPNetCore.Web.Host.Startup
{
    [DependsOn(
       typeof(ABPNetCoreWebCoreModule))]
    public class ABPNetCoreWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ABPNetCoreWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ABPNetCoreWebHostModule).GetAssembly());
        }
    }
}
