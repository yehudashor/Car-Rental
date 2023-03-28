using DalApi.IEntity;

namespace DO;

public class CarRental : IEntity
{
    public int CarRentalId { set; get; }
    public int CarId { get; set; }
    public Car Car { set; get; }
    public int BranchId { set; get; }
    public Branch Branch { set; get; }
    public int CustomerDetailsId { set; get; }
    public CustomerDetails CustomerDetails { set; get; }
    public int CustomerPaymentId { set; get; }
    public CustomerPayment CustomerPayment { set; get; }
    public DateTime OrderDate { set; get; }
    public DateTime RentalStart { set; get; }
    public DateTime RentalEnd { set; get; }
    public double DayPrice { get; set; }
    public int DriverAge { get; set; }
    public CurrentlyInRented CurrentlyInRented { set; get; }

}
