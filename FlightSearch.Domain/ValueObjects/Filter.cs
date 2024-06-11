namespace FlightSearch.Domain.ValueObjects;

public record Filter
{
 
    public string name { get; set; } = default!;
    public bool enabled { get; set; } = default!;
    public int count { get; set; } = default!;
    public List<Value> values { get; set; } = default!;
    public string displayName { get; set; } = default!;
    public List<Link> links { get; set; } = default!;
   
}
