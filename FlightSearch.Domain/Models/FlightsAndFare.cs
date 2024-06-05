//Use in Flight search result
namespace FlightSearch.Domain.Models;

public class FlightsAndFare : Entity
{
    public Flight Flight { get; private set; } = new Flight();
    public List<Fare> Fares { get; private set; } = new List<Fare>();


    public static FlightsAndFare Create(int id, Flight flight, List<Fare> fares)
    {
        var flightsAndFare = new FlightsAndFare
        {
            Id = id,
            Fares = fares,
            Flight = flight
        };
        return flightsAndFare;
    }
}
