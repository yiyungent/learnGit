using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using learnGit.Authorization.Roles;
using learnGit.Authorization.Users;
using learnGit.MultiTenancy;

namespace learnGit.EntityFrameworkCore
{
    public class learnGitDbContext : AbpZeroDbContext<Tenant, Role, User, learnGitDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public learnGitDbContext(DbContextOptions<learnGitDbContext> options)
            : base(options)
        {
        }
    }
}
