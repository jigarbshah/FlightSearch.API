namespace FlightSearch.Domain.Models;

public class Segment : Entity
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

    public static Segment Create(int id , List<Metal> metal, Airline airline, 
        string flightNumber, string operatingFlightNumber, OperatingAirline operatingAirline,
        Origin origin, Destination destination, string duration, DateTime departure,
        DateTime arrival, int stopCount, string connection, List<Leg> legs, 
        string bookingClass, string fareBasisCode, string dominantFareProduct)
    {
        var segment = new Segment
        {
            Id = id,
            metal = metal,
            airline = airline,
            flightNumber = flightNumber,
            operatingFlightNumber = operatingFlightNumber,
            operatingAirline = operatingAirline,
            origin = origin,
            destination = destination,
            duration = duration,
            departure = departure,
            arrival = arrival,
            stopCount = stopCount,
            connection = connection,
            legs = legs,
            bookingClass = bookingClass,
            fareBasisCode = fareBasisCode,
            dominantFareProduct = dominantFareProduct
        };
        return segment;
    }

}
