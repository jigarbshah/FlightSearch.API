//Use in Flight search result
namespace FlightSearch.Domain.Models;

public class PriceFare 
{
   public Price Price { get; set; } = new Price();
    public double Tax { get; set; } = default!;
    public double AmountIncludingTax { get; set; } = default!;
    public string PriceDifference { get; set; } = default!;
    public string PriceDifferenceSign { get; set; } = default!;
    public string AwardPointsDifference { get; set; } = default!;
    public string AwardPointsDifferenceSign { get; set; } = default!;

}