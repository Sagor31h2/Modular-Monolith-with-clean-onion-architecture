using Microsoft.EntityFrameworkCore;
using Shared.Core.Database;
using Shared.Core.Entity;

namespace Shared.Infrastructure.Persistence
{
    public class SharedDbContext : ModuleDbContext, ISharedDbContext
    {
        public SharedDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Locations> Locations { get; set; }

        protected override string Schema => "core";
    }
}
