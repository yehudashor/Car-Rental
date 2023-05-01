namespace CarRentalBL.BusinessEntities.CarRental;

public class CarRental
{
    public RentalRequest RentalRequest { get; set; }

    public IDictionary<Car.Car, PriceOffer.PriceOffer> RentalCarsPriceOffers { set; get; }


}
