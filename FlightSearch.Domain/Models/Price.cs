//Use in Flight search result
namespace FlightSearch.Domain.Models;

public class Price 
{
    public double Amount { get; set; } = default!;
    public string Currency { get; set; } = default!;
    public string AwardPoints { get; set; } = default!;


}
