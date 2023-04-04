using DalApi.IEntity;

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

    public ICollection<CreditCardPayment> CreditCardPayments { set; get; }
}
