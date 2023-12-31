using ISO3166;
using NetTopologySuite.Geometries;

namespace KartaViewSharp.V1.Request;

public class QueryFilters
{
    public int ItemsPerPage { get; set; }

    public int Page { get; set; } = 1;

    public string Username { get; set; }

    public Coordinate TopLeft { get; set; }

    public Coordinate BottomRight { get; set; }

    public Country Location { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public bool ObdInfo { get; set; }
}