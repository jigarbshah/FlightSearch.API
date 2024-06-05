//Use in Flight search result
namespace FlightSearch.Domain.Models;

public class Price : Entity
{
    public double Amount { get; set; } = default!;
    public string Currency { get; set; } = default!;
    public string AwardPoints { get; set; } = default!;


    public static Price Create(int _id, double _amount, string _currencty, string _awardPoints )
    {
        var price = new Price { Id = _id,  Amount=_amount, Currency=_currencty, AwardPoints = _awardPoints };
        return price;
    }
}
