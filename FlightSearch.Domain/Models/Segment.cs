namespace FlightSearch.Domain.Models;

public class Segment 
{

    public List<Metal> metal { get; set; } = new List<Metal>();
    public Airline airline { get; set; } = default!;
    public string flightNumber { get; set; } = default!;
    public string operatingFlightNumber { get; set; } = default!;
    public OperatingAirline operatingAirline { get; set; } = default!;
    public Origin origin { get; set; } = default!;
    public Destination destination { get; set; } = default!;
    public string duration { get; set; } = default!;
    public DateTime departure { get; set; } = default!;
    public DateTime arrival { get; set; } = default!;
    public int stopCount { get; set; } = default!;
    public string connection { get; set; } = default!;
    public List<Leg> legs { get; set; } = default!;
    public string bookingClass { get; set; } = default!;
    public string fareBasisCode { get; set; } = default!;
    public string dominantFareProduct { get; set; } = default!;


}
