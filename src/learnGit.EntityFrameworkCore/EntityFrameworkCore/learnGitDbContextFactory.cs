using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using learnGit.Configuration;
using learnGit.Web;

namespace learnGit.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class learnGitDbContextFactory : IDesignTimeDbContextFactory<learnGitDbContext>
    {
        public learnGitDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<learnGitDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            learnGitDbContextConfigurer.Configure(builder, configuration.GetConnectionString(learnGitConsts.ConnectionStringName));

            return new learnGitDbContext(builder.Options);
        }
    }
}
