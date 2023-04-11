
namespace BusinessEntities;

public class CarRental
{
    public RentalRequest RentalRequest { get; set; }

    public IDictionary<CarForCustomer, PriceOffer.PriceOffer> RentalCarsPriceOffers { set; get; }


}
