namespace FlightSearch.Domain.ValueObjects;
public record OperatingAirline
    {

    public string code { get; set; }
    public string name { get; set; }
    private OperatingAirline(string code, string name)
    {
        this.code = code;
        this.name = name;
    }
    public static  OperatingAirline Of(string code, string name)
    {
        return new OperatingAirline(code, name);
    }
}
