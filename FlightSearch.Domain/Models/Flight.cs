//Use in Flight search result

namespace FlightSearch.Domain.Models;

public class Flight
{
    public List<Segment> Segments { get; set; } = new()!;
    public string Duration { get; set; } = default!;
    public Origin Origin { get; set; } = default!;
    public Destination Destination { get; set; } = default!;
    public DateTime Departure { get; set; } = default!;
    public DateTime Arrival { get; set; } = default!;
    public List<Link> Links { get; set; } = new()!;


}
