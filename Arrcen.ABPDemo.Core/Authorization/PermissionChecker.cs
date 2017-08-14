using Abp.Authorization;
using Arrcen.ABPDemo.Authorization.Roles;
using Arrcen.ABPDemo.Authorization.Users;

namespace Arrcen.ABPDemo.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
