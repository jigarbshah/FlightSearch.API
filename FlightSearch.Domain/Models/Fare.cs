//Use in Flight search result
namespace FlightSearch.Domain.Models;

public class Fare :Entity
{
    public string Availability { get;  private set; } = default!;
    public string FareId { get; private  set; } = default!;
    public string Content { get; private  set; } = default!;
    public PriceFare Price { get; private set; } = default!;
    public List<FareSegment> FareSegments { get; private set; } = new()!;
    public string Available { get; private set; }  = default!;
    public string FareFamilyType { get; private set; } = default!;
    public bool CabinSelected { get; private set; } = default!;

    public List<Link> Links { get; private set; } = new()!;
    //public IReadOnlyList<Link> Link => _links.AsReadOnly();

    public static Fare Create(int _id, string _avability, string _fareId, string   _content, PriceFare _price,
        List<FareSegment> _fareSegments, string _available, string _fareFamilyType, bool _cabinSelected, List<Link> _links)
    {
        var fare = new Fare
        {
          Id = _id,
          Availability = _avability,
          FareId = _fareId,
          Content = _content,
          Price = _price,
          FareSegments = _fareSegments,
          Available = _available,
          FareFamilyType =_fareFamilyType,
          CabinSelected = _cabinSelected,
          Links = _links
        };
        return fare;
    }

}
