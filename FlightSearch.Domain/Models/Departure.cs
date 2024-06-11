//Use in Flight search result
namespace FlightSearch.Domain.Models;
public class Departure
{
    public string Departing { get; set; } = default!;
    public List<Price> Prices { get; set; } = new();
   
}
