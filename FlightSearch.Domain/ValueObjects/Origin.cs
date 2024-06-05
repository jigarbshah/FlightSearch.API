namespace FlightSearch.Domain.ValueObjects;

public record Origin
{
    public string Code { get;  } = default!;
    public string CityName { get;  } = default!;
    public string CountryName { get;  } = default!;
    public string AirportName { get;  } = default!;


    private Origin(string code, string cityName, string countryName, string airportName)
    {
        this.Code = code;
        this.CityName = cityName;
        this.CountryName = countryName;
        this.AirportName = airportName;
    }

    public static Origin Of(string code, string cityName, string countryName, string airportName)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(code);
        ArgumentException.ThrowIfNullOrWhiteSpace(airportName);
        return new Origin(code, cityName, countryName, airportName);
    }
}
