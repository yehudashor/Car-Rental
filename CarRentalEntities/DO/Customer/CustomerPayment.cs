using CarRentalEntities.IEntity;

namespace DO;

public class CustomerPayment : IEntity
{
    public int CustomerPaymentId { get; set; }
    public int CarRentalId { set; get; }
    public CarRental CarRental { set; get; }
    public int CreditCardId { get; set; }
    public CreditCard CreditCard { get; set; }
}
