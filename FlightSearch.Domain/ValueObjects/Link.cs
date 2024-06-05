namespace FlightSearch.Domain.ValueObjects;

public record Link
{

    public string rel { get; set; }
    public string href { get; set; }
    public string name { get; set; }
    private Link(string rel, string href, string name)
    {
        this.rel = rel;
        this.href = href;
        this.name = name;
    }
    public static Link Of(string rel, string href, string name)
    {
       return new Link(rel, href, name);
    }

}
