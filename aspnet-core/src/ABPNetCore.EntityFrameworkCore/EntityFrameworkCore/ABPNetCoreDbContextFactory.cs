using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ABPNetCore.Configuration;
using ABPNetCore.Web;

namespace ABPNetCore.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ABPNetCoreDbContextFactory : IDesignTimeDbContextFactory<ABPNetCoreDbContext>
    {
        public ABPNetCoreDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ABPNetCoreDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ABPNetCoreDbContextConfigurer.Configure(builder, configuration.GetConnectionString(ABPNetCoreConsts.ConnectionStringName));

            return new ABPNetCoreDbContext(builder.Options);
        }
    }
}
