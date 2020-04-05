using DJValeting.Domain.Data.Entities;
using DJValeting.Domain.Data.EntityConfigurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DJValeting.Domain.Data
{
    public class DJValetingDbContext : DbContext
    {
        public DbSet<DJValetingBookingEntity> DJValetingBookings { get; set; }

        public DJValetingDbContext(DbContextOptions<DJValetingDbContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new DJValetingBookingEntityConfiguration());
        }
    }
}
