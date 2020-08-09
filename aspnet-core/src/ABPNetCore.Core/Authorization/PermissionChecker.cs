using Abp.Authorization;
using ABPNetCore.Authorization.Roles;
using ABPNetCore.Authorization.Users;

namespace ABPNetCore.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
