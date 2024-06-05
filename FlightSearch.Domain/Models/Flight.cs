//Use in Flight search result

namespace FlightSearch.Domain.Models;

public class Flight:Entity
{
    public List<Segment> Segments { get; private set; } = new()!;
    public string Duration { get; private set; } = default!;
    public Origin Origin { get; private set; } = default!;
    public Destination Destination { get; private set; } = default!;
    public DateTime Departure { get; private set; } = default!;
    public DateTime Arrival { get; private set; } = default!;
    public List<Link> Links { get; private set; } = new()!;


    public static Flight Create(int _id, List<Segment> _segments, string _duration, Origin _origin,
        Destination _destination,
        DateTime _departure, DateTime _arrival, List<Link> _links)
    {
        var flight = new Flight
        {
            Id = _id,
            Segments = _segments,
            Destination = _destination,
            Departure = _departure,
            Arrival = _arrival,
            Links = _links
        };
        return flight;
    }
}
