using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace learnGit.EntityFrameworkCore
{
    public static class learnGitDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<learnGitDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<learnGitDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
