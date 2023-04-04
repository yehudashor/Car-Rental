using DalApi.IEntity;

namespace DO;

/// <summary>
/// Represents a credit card entity.
/// </summary>
public class CreditCard : IEntity
{
    /// <summary>
    /// Gets or sets the credit card id.
    /// </summary>
    public int CreditCardId { get; set; }

    /// <summary>
    /// Gets or sets the validity date of the credit card.
    /// </summary>
    public DateOnly Validity { get; set; }

    /// <summary>
    /// Gets or sets the CVV number of the credit card.
    /// </summary>
    public int CVV { get; set; }

    public ICollection<CreditCardPayment> CreditCardPayments { set; get; }

}

