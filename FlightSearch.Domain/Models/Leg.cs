//Use in Flight search result
namespace FlightSearch.Domain.Models;

public class Leg 
{
    public Origin origin { get; set; } = default!;
    public Destination destination { get; set; } = default!;
    public string duration { get; set; } = default!;
    public DateTime departure { get; set; } = default!;
    public DateTime arrival { get; set; } = default!;
    public string stopOver { get; set; } = default!;
    public bool isDominantLeg { get; set; } = default!;
   }
