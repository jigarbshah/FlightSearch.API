namespace FlightSearch.Domain.ValueObjects;

public record Link
{

    public string rel { get; set; } = default!;
    public string href { get; set; } = default!;
    public string name { get; set; } = default!;


}
