using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ABPNetCore.Authorization.Roles;
using ABPNetCore.Authorization.Users;
using ABPNetCore.MultiTenancy;

namespace ABPNetCore.EntityFrameworkCore
{
    public class ABPNetCoreDbContext : AbpZeroDbContext<Tenant, Role, User, ABPNetCoreDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ABPNetCoreDbContext(DbContextOptions<ABPNetCoreDbContext> options)
            : base(options)
        {
        }
    }
}
