﻿using CarRentalDalCore.DataObjects.Customer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalDalEF.IEntityConfigurations;

internal class CreditCardPaymentConfiguration : IEntityTypeConfiguration<CreditCardPayment>
{
    public void Configure(EntityTypeBuilder<CreditCardPayment> builder)
    {
        builder.HasKey(ccp => new { ccp.CreditCardId, ccp.CustomerPaymentId });
    }
}
