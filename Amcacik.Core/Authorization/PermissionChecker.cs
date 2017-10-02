using Abp.Authorization;
using Amcacik.Authorization.Roles;
using Amcacik.Authorization.Users;

namespace Amcacik.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
