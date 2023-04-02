﻿using DalApi.IEntity;

namespace DO;

/// <summary>
/// Represents the payment details of a customer entity.
/// </summary>
public class CustomerPayment : IEntity
{
    /// <summary>
    /// Gets or sets the customer payment id.
    /// </summary>
    public int CustomerPaymentId { get; set; }

    /// <summary>
    /// Gets or sets the car rental entity associated with the payment.
    /// </summary>
    public CarRental CarRental { set; get; }

    /// <summary>
    /// Gets or sets the credit card id associated with the payment.
    /// </summary>
    public int CreditCardId { get; set; }

    /// <summary>
    /// Gets or sets the credit card entity associated with the payment.
    /// </summary>
    public CreditCard CreditCard { get; set; }
}
