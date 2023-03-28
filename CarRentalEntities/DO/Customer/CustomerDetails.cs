using CarRentalEntities.IEntity;

namespace DO;

public class CustomerDetails : IEntity
{
    public int CustomerDetailsId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string EmailAddress { get; set; }
    public int PhoneNumber { get; set; }
    public string DrivingLicenseImage { set; get; }
    public DateOnly BirthDate { get; set; }
    public int LocationId { get; set; }
    public Location Location { set; get; }
    public ICollection<CarRentalHistory> CarRentalHistories { get; set; }
}
