﻿using CarRentalDalCore.DalApi.IEntity;

namespace CarRentalDalCore.DataObjects.Car;

/// <summary>
/// This class represents an image of a car
/// </summary>
public class CarImage : IEntity
{
    /// <summary>
    /// Name of the car image
    /// </summary>
    public string CarImageId { set; get; }

    /// <summary>
    /// Foreign key of the car this image belongs to
    /// </summary>
    public int CarId { set; get; }

    /// <summary>
    /// Navigation property to the car this image belongs to
    /// </summary>
    public Car Car { set; get; }
}

