using CarRentalDalCore.DalApi.IEntity;

namespace CarRentalDalCore.DataObjects.Customer;

public class CreditCardPayment : IEntity
{
    /// <summary>
    /// The first identifier of the customer payment associated with this rental transaction.
    /// </summary>
    public int CustomerPaymentId { set; get; }

    /// <summary>
    /// The customer payment associated with this rental transaction.
    /// </summary>
    public CustomerPayment CustomerPayment { set; get; }

    /// <summary>
    /// Gets or sets the credit card id associated with the payment.
    /// </summary>
    public int CreditCardId { get; set; }

    /// <summary>
    /// Gets or sets the credit card entity associated with the payment.
    /// </summary>
    public CreditCard CreditCard { get; set; }

    public DateTime PaymentDate { get; set; }
}
