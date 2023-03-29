﻿namespace DO;

/// <summary>
/// Represents a location on Earth.
/// </summary>
public class Location
{
    /// <summary>
    /// Gets or sets the unique identifier for the location.
    /// </summary>
    public int LocationId { set; get; }

    /// <summary>
    /// Gets or sets the longitude of the location.
    /// </summary>
    public double Longitude { set; get; }

    /// <summary>
    /// Gets or sets the latitude of the location.
    /// </summary>
    public double Latitude { set; get; }

    /// <summary>
    /// Gets or sets the country of the location.
    /// </summary>
    public string Country { get; set; }

    /// <summary>
    /// Gets or sets the city of the location.
    /// </summary>
    public string City { get; set; }

    /// <summary>
    /// Gets or sets the street of the location.
    /// </summary>
    public string Street { get; set; }

    /// <summary>
    /// Gets or sets the place number of the location.
    /// </summary>
    public int PlaceNumber { get; set; }

    /// <summary>
    /// Gets or sets the postal code of the location.
    /// </summary>
    public int PostalCode { get; set; }
}