﻿using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;

namespace WaterSubMeter.core.DataAccess.Abstract
{
    public interface IWaterSubmeterContext
    {
        public DbSet<Meter> Brands { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}