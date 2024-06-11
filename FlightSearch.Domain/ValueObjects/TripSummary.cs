namespace FlightSearch.Domain.ValueObjects;

public class TripSummary
{

    public List<string> SliceDetails { get; set; }
    public string Currency { get; set; }
    public int TotalPrice { get; set; }
    public string TotalAwardPoints { get; set; }

}
