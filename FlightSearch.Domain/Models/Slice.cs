///Slice associated with FlightSearch Result
namespace FlightSearch.Domain.Models;

public class Slice 
{
    public string Id { get; set; } = default!;
    public string FareId { get; set; } = default!;
    public List<string> FareFamilyTypes { get; set; } = new List<string>();
    public List<FlightsAndFare> FlightsAndFares { get; set; } = new();

}
