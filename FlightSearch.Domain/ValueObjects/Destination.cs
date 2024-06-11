//Use in Flight search result

namespace FlightSearch.Domain.ValueObjects;

public class Destination
{
    public string Code { get; set; } = default!;
    public string CityName { get; set; } = default!;
    public string CountryName { get; set; } = default!;
    public string AirportName { get; set; } = default!;


}
