//Use in Flight search result

namespace FlightSearch.Domain.ValueObjects;

public record Destination
{
    public string Code { get; } = default!;
    public string CityName { get; } = default!;
    public string CountryName { get; } = default!;
    public string AirportName { get; } = default!;


    private Destination(string code, string cityName, string countryName, string airportName)
    {
        this.Code = code;
        this.CityName = cityName;
        this.CountryName = countryName;
        this.AirportName = airportName;
    }

    public static Destination Of(string code, string cityName, string countryName, string airportName)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(code);
        ArgumentException.ThrowIfNullOrWhiteSpace(airportName);
        return new Destination(code, cityName, countryName, airportName);
    }
}
