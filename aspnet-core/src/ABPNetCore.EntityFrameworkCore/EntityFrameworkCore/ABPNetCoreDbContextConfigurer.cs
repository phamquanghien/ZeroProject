using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ABPNetCore.EntityFrameworkCore
{
    public static class ABPNetCoreDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ABPNetCoreDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ABPNetCoreDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
