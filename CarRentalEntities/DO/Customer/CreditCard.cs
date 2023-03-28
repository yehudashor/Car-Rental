using CarRentalEntities.IEntity;

namespace DO;

public class CreditCard : IEntity
{
    public int CreditCardId { get; set; }

    public DateOnly Validity { get; set; }

    public int CVV { get; set; }
}
