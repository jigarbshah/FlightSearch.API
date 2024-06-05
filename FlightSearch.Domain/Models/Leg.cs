//Use in Flight search result
namespace FlightSearch.Domain.Models;

public class Leg : Entity
{
    public Origin origin { get; set; } = default!;
    public Destination destination { get; set; } = default!;
    public string duration { get; set; } = default!;
    public DateTime departure { get; set; } = default!;
    public DateTime arrival { get; set; } = default!;
    public string stopOver { get; set; } = default!;
    public bool isDominantLeg { get; set; } = default!;
    public static Leg Create(int id, Origin origin, Destination destination, string duration, DateTime departure, DateTime arrival, string stopOver, bool isDominantLeg)
    {
        var leg = new Leg
        {
            Id = id,
            origin = origin,
            destination = destination,
            duration = duration,
            departure = departure,
            arrival = arrival,
            stopOver = stopOver,
            isDominantLeg = isDominantLeg
        };
        return leg;

    }
}
