namespace DO;

public class Location
{
    public int LocationId { set; get; }
    public double Longitude { set; get; }
    public double Latitude { set; get; }
    public string Country { get; set; }
    public string City { get; set; }
    public string Street { get; set; }
    public int PlaceNumber { get; set; }
    public int PostalCode { get; set; }
}
