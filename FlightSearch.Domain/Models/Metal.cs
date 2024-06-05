//Use in Flight search result
namespace FlightSearch.Domain.Models;

public class Metal :Entity
{
    public string Family { get; private set; } = default!;
    public string Name { get; set; } = default!;

    public static Metal Create(int _id, string _family, string _name)
    {
       var metal = new Metal { Id = _id, Family = _family, Name = _name };    
       return metal;
    }
}
