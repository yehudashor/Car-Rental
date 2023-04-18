using CarRentalBL.BusinessEntities.PriceOffer;

namespace CarRentalBL.BusinessEntities.CarRental;

public class CarRental
{
    public RentalRequest RentalRequest { get; set; }

    public IDictionary<Car, PriceOffer> RentalCarsPriceOffers { set; get; }


}
