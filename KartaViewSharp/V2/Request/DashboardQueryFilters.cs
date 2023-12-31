using KartaViewSharp.V2.Enums;

namespace KartaViewSharp.V2.Request;

public class DashboardQueryFilters
{
    /// <summary>
    /// Retrieve data based on one of the intervals.
    /// </summary>
    public Interval Interval { get; set; }

    /// <summary>
    /// The starting point of the date interval.
    /// </summary>
    public DateTime StartDate { get; set; }

    /// <summary>
    /// The ending point of the date interval.
    /// </summary>
    public DateTime EndDate { get; set; }

    /// <summary>
    /// The platform of the device that recorded the file.
    /// </summary>
    public Platform Platform { get; set; }

    /// <summary>
    /// Type of the user.
    /// </summary>
    public UserType UserType { get; set; }

    /// <summary>
    /// Unique identifier representing a specific region. Multiple regions can be provided.
    /// </summary>
    public Region[] Region { get; set; } = [];

    /// <summary>
    /// The field of view type.
    /// </summary>
    public FieldOfView FieldOfView { get; set; }

    /// <summary>
    /// The type of the distance measurement.
    /// </summary>
    public Units Units { get; set; }
}