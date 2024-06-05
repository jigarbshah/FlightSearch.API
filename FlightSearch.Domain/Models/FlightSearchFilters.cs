//Use in Flight search result
namespace FlightSearch.Domain.Models;

public class FlightSearchFilters : Entity
{
    public List<Filter> Filters { get; private set; } = new List<Filter>();
    public int Total { get; private set; } = default!;
    public int Count { get; private set; } = default!;
    public List<Link> Links { get; private set; } = new List<Link>();

    public static FlightSearchFilters Create(int id, List<Filter> filters, int total, int count, List<Link> links)
    {
        var flightsearchfilter = new FlightSearchFilters { Id = id ,Filters = filters, Total = total, Count = count, Links = links };
        return flightsearchfilter;
    }
}
