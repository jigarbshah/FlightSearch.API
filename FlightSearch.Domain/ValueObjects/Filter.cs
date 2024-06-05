namespace FlightSearch.Domain.ValueObjects;

public record Filter
{
 
    public string name { get; set; }
    public bool enabled { get; set; }
    public int count { get; set; }
    public List<Value> values { get; set; }
    public string displayName { get; set; }
    public List<Link> links { get; set; }
    private Filter(string name, bool enabled, int count, List<Value> values, string displayName, List<Link> links)
    {
        this.name = name;
        this.enabled = enabled;
        this.count = count;
        this.values = values;
        this.displayName = displayName;
        this.links = links;
    }
    public static Filter Of(string name, bool enabled, int count, List<Value> values, string displayName, List<Link> links)
    {
        return new Filter(name, enabled, count, values, displayName, links);
    }
}
