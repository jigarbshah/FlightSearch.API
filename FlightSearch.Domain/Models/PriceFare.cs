//Use in Flight search result
namespace FlightSearch.Domain.Models;

public class PriceFare :Entity
{
   public Price Price { get; private set; } = new Price();
    public double Tax { get; private set; } = default!;
    public double AmountIncludingTax { get; private set; } = default!;
    public string PriceDifference { get; private set; } = default!;
    public string PriceDifferenceSign { get; private set; } = default!;
    public string AwardPointsDifference { get; private set; } = default!;
    public string AwardPointsDifferenceSign { get; private set; } = default!;

    public static PriceFare Create(int _id, Price _price, double _tax, double amountIncludingTax,
         string priceDifference ,
         string priceDifferenceSign ,
         string awardPointsDifference ,
         string awardPointsDifferenceSign )
    {
        var priceFare = new PriceFare
        {
            Id = _id,
            Price = _price,
            Tax = _tax,
            AmountIncludingTax = amountIncludingTax,
            PriceDifference = priceDifference,
            PriceDifferenceSign = priceDifferenceSign,
            AwardPointsDifference = awardPointsDifference,
            AwardPointsDifferenceSign = awardPointsDifferenceSign

        };
        return priceFare;
}
}