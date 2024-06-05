///Slice associated with FlightSearch Result
namespace FlightSearch.Domain.Models;

public class Slice : Entity
{
    public string FareId { get; private set; } = default!;
    public List<string> FareFamilyTypes { get; private set; } = new List<string>();
    public List<FlightsAndFare> FlightsAndFares { get; private set; } = new();

    public static Slice Create(int _id, string _fareID, List<string> _fareFamilyTypes,
        List<FlightsAndFare> _flightsAndFares)
    {
        var slice = new Slice
        {
            Id = _id,
            FareFamilyTypes = _fareFamilyTypes,
            FareId = _fareID,
            FlightsAndFares = _flightsAndFares
        };
        return slice;

    }
}
