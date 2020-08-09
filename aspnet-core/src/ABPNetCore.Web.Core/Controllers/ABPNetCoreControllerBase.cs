using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ABPNetCore.Controllers
{
    public abstract class ABPNetCoreControllerBase: AbpController
    {
        protected ABPNetCoreControllerBase()
        {
            LocalizationSourceName = ABPNetCoreConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
