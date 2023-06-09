﻿using CarRentalDalCore.DalApi.IEntity;
using CarRentalDalCore.DataObjects.Enums;

namespace CarRentalDalCore.DataObjects.Car;

/// <summary>
/// This class represents a car entity with its properties and relationships
/// </summary>
public class Car : IEntity
{
    /// <summary>
    /// Unique identifier for the car
    /// </summary>
    public int CarId { set; get; }

    /// <summary>
    /// Name of the company that produces the car
    /// </summary>
    public string CompanyName { set; get; }

    /// <summary>
    /// Name of the car model
    /// </summary>
    public string ModelName { set; get; }

    /// <summary>
    /// Year the car was published
    /// </summary>
    public int PublishYear { set; get; }

    /// <summary>
    /// Number of seats the car has
    /// </summary>
    public int SeatsNumber { set; get; }

    /// <summary>
    /// Number of kilometers the car has been driven
    /// </summary>
    public int KilometersNumber { set; get; }

    /// <summary>
    /// Date of the last test the car has undergone
    /// </summary>
    public DateOnly LastTestDate { set; get; }

    /// <summary>
    /// Gearbox type of the car (automatic or manual)
    /// </summary>
    public Gearbox Gearbox { set; get; }

    /// <summary>
    /// Daily rental price for this car
    /// </summary>
    public double DayPrice { set; get; }

    public int CarTypeId { get; set; }

    /// <summary>
    /// The car Type.
    /// </summary>
    public CarType CarType { get; set; }

    public string CarColorId { get; set; }

    /// <summary>
    /// The car color.
    /// </summary>
    public CarColor CarColor { set; get; }

    /// <summary>
    /// Collection of images of the car
    /// </summary>
    public ICollection<CarImage> Images { set; get; }

    /// <summary>
    /// Collection of car rentals of the car.
    /// </summary>
    public ICollection<CarRental> CarRentals { set; get; }

}
