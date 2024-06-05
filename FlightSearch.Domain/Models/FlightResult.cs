//Main flight search result class

namespace FlightSearch.Domain.Models;

public class FlightResult :Entity
{
    public Slices Slices { get; private set; } = default!;
    public Criteria Criteria { get; private set; } = default!;
    public Slice Slice { get; private set; } = default!;
    public FlightSearchFilters FlightSearchFilters { get; private set; } = default!;
    public TripSummary TripSummary { get; private set; } = default!;
    
    public static FlightResult Create(int id, Slices slices, Criteria criteria, Slice slice,
        FlightSearchFilters flightSearchFilters, TripSummary tripSummary)
    {
        var FlightResult = new FlightResult
        {
            Id = id,
            Criteria = criteria,
            Slice = slice,
            FlightSearchFilters = flightSearchFilters,
            TripSummary = tripSummary
        };
        return FlightResult;

    }

}
