//Criteria associated with FlightSearch Result
namespace FlightSearch.Domain.ValueObjects;

public record Criteria
{
  
    public Origin Origin { get; set; }
    public Destination Destination { get; set; }
    public string Departing { get; set; }
    private Criteria(Origin origin, Destination destination, string departing)
    {
        this.Origin = origin;
        this.Destination = destination;
        this.Departing = departing;
    }
    public static Criteria Of(Origin origin, Destination destination, string departing)
    {
        return new Criteria(origin, destination, departing);
    }

}
