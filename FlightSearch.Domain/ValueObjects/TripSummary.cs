namespace FlightSearch.Domain.ValueObjects;

public class TripSummary
{

    public List<string> SliceDetails { get; set; }
    public string Currency { get; set; }
    public int TotalPrice { get; set; }
    public string TotalAwardPoints { get; set; }

    public TripSummary(List<string> sliceDetails, string currency, int totalPrice, string totalAwardPoints)
    {
        SliceDetails = sliceDetails;
        this.Currency = currency;
        this.TotalPrice = totalPrice;
        this.TotalAwardPoints = totalAwardPoints;
    }
    public static TripSummary Of(List<string> sliceDetails, string currency, int totalPrice, string totalAwardPoints)
    {
        return new TripSummary(sliceDetails, currency, totalPrice, totalAwardPoints);

    }
}
