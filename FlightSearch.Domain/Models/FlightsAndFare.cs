//Use in Flight search result
namespace FlightSearch.Domain.Models;

public class FlightsAndFare 
{
    public Flight Flight { get; set; } = new Flight();
    public List<Fare> Fares { get; set; } = new List<Fare>();


}
