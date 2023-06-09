﻿using CarRentalDalCore.DataObjects.Car;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalDalEF.IEntityConfigurations;

internal class CarTypeConfiguration : IEntityTypeConfiguration<CarType>
{
    public void Configure(EntityTypeBuilder<CarType> builder)
    {
        builder.HasKey(ct => ct.CarTypeId);

        builder.HasMany(ct => ct.Cars)
            .WithOne(c => c.CarType)
            .HasForeignKey(c => c.CarTypeId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
