//Use in Flight search result
namespace FlightSearch.Domain.Models;

public class FlightSearchFilters 
{
    public List<Filter> Filters { get; set; } = new List<Filter>();
    public int Total { get; set; } = default!;
    public int Count { get; set; } = default!;
    public List<Link> Links { get; set; } = new List<Link>();

 
}
