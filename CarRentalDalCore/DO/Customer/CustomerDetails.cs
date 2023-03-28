using DalApi.IEntity;

namespace DO;

/// <summary>
/// Represents the details of a customer entity.
/// </summary>
public class CustomerDetails : IEntity
{
    /// <summary>
    /// Gets or sets the customer details id.
    /// </summary>
    public int CustomerDetailsId { get; set; }

    /// <summary>
    /// Gets or sets the first name of the customer.
    /// </summary>
    public string FirstName { get; set; }

    /// <summary>
    /// Gets or sets the last name of the customer.
    /// </summary>
    public string LastName { get; set; }

    /// <summary>
    /// Gets or sets the email address of the customer.
    /// </summary>
    public string EmailAddress { get; set; }

    /// <summary>
    /// Gets or sets the phone number of the customer.
    /// </summary>
    public int PhoneNumber { get; set; }

    /// <summary>
    /// Gets or sets the image of the driving license of the customer.
    /// </summary>
    public string DrivingLicenseImage { set; get; }

    /// <summary>
    /// Gets or sets the birth date of the customer.
    /// </summary>
    public DateOnly BirthDate { get; set; }

    /// <summary>
    /// Gets or sets the location id of the customer.
    /// </summary>
    public int LocationId { get; set; }

    /// <summary>
    /// Gets or sets the location entity of the customer.
    /// </summary>
    public Location Location { set; get; }
}
