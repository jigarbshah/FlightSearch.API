//Use in Flight search result
namespace FlightSearch.Domain.Models;
public class Departure : Entity
{
    public string Departing { get; set; } = default!;
    public List<Price> Prices { get; set; } = new();
    public static Departure Create(int Id, string Departing, List<Price> Prices)
    {
        var departure = new Departure
        {
            Id = Id,
            Departing = Departing,
            Prices = Prices
        };
        return departure;
    }
}
