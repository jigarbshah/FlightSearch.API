//Criteria associated with FlightSearch Result
namespace FlightSearch.Domain.ValueObjects;

public class Criteria
{
  
    public Origin Origin { get; set; } = default!;
    public Destination Destination { get; set; } = default!;
    public string Departing { get; set; } = default!;


}
