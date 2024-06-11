//Use in Flight search result
namespace FlightSearch.Domain.Models;

public class Fare 
{
    public string Availability { get;  set; } = default!;
    public string FareId { get; private  set; } = default!;
    public string Content { get; private  set; } = default!;
    public PriceFare Price { get; set; } = default!;
    public List<FareSegment> FareSegments { get; set; } = new()!;
    public string Available { get; set; }  = default!;
    public string FareFamilyType { get; set; } = default!;
    public bool CabinSelected { get; set; } = default!;

    public List<Link> Links { get; set; } = new()!;
    //public IReadOnlyList<Link> Link => _links.AsReadOnly();

 
}
