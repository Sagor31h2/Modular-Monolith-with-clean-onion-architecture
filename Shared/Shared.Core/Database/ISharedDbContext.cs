using Microsoft.EntityFrameworkCore;
using Shared.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Core.Database
{
    public interface ISharedDbContext
    {
        public DbSet<Locations> Locations { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
