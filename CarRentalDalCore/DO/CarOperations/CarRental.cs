using DalApi.IEntity;

namespace DO;

/// <summary>
/// Represents a car rental transaction.
/// </summary>
public class CarRental : IEntity
{
    /// <summary>
    /// The unique identifier of the car rental transaction.
    /// </summary>
    public int CarRentalId { set; get; }

    /// <summary>
    /// The unique identifier of the rented car.
    /// </summary>
    public int CarId { get; set; }

    /// <summary>
    /// The rented car.
    /// </summary>
    public Car Car { set; get; }

    /// <summary>
    /// The unique identifier of the branch where the rental car is picked up and returned.
    /// </summary>
    public int BranchId { set; get; }

    /// <summary>
    /// The branch where the rental car is picked up and returned.
    /// </summary>
    public Branch Branch { set; get; }

    /// <summary>
    /// The unique identifier of the customer details associated with this rental transaction.
    /// </summary>
    public int CustomerDetailsId { set; get; }

    /// <summary>
    /// The customer details associated with this rental transaction.
    /// </summary>
    public CustomerDetails CustomerDetails { set; get; }

    /// <summary>
    /// The unique identifier of the customer payment associated with this rental transaction.
    /// </summary>
    public int CustomerPaymentId { set; get; }

    /// <summary>
    /// The customer payment associated with this rental transaction.
    /// </summary>
    public CustomerPayment CustomerPayment { set; get; }

    /// <summary>
    /// The date of the rental order.
    /// </summary>
    public DateTime OrderDate { set; get; }

    /// <summary>
    /// The start date of the rental period.
    /// </summary>
    public DateTime RentalStart { set; get; }

    /// <summary>
    /// The end date of the rental period.
    /// </summary>
    public DateTime RentalEnd { set; get; }

    /// <summary>
    /// The rental price per day.
    /// </summary>
    public double DayPrice { get; set; }

    /// <summary>
    /// The driver's age.
    /// </summary>
    public int DriverAge { get; set; }

    /// <summary>
    /// Indicates whether the rented car is currently in use or available for rent.
    /// </summary>
    public CurrentlyInRented CurrentlyInRented { set; get; }
}