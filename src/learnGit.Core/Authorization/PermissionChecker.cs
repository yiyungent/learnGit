using Abp.Authorization;
using learnGit.Authorization.Roles;
using learnGit.Authorization.Users;

namespace learnGit.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
