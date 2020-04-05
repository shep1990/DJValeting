using DJValeting.Domain.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DJValeting.Domain.Data.EntityConfigurations
{
    public class DJValetingBookingEntityConfiguration : IEntityTypeConfiguration<DJValetingBookingEntity>
    {
        public void Configure(EntityTypeBuilder<DJValetingBookingEntity> builder)
        {
            builder.ToTable("DJValeting");

            builder.HasIndex(x => x.Id)
                .IsUnique();

            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd();

            builder.Property(x => x.Name).IsRequired(true);
            builder.Property(x => x.BookingDate).IsRequired(true);
            builder.Property(x => x.Flexibility).IsRequired(true);
            builder.Property(x => x.VehicleSize).IsRequired(true);
            builder.Property(x => x.ContactNumber).IsRequired(true);
            builder.Property(x => x.EmailAddress).IsRequired(true);
        }
    }
}
