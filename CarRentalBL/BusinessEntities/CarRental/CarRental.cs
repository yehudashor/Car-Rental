
namespace BusinessEntities;

public class CarRental
{
    public RentalRequest RentalRequest { get; set; }

    public IDictionary<Car, PriceOffer.PriceOffer> RentalCarsPriceOffers { set; get; }


}
