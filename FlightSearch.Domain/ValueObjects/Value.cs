using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSearch.Domain.ValueObjects;

public class Value
{

    public bool Selected { get; set; }
    public bool Enabled { get; set; }
    public int Count { get; set; }
    public double MinPrice { get; set; }
    public string Currency { get; set; }
    public string DisplayName { get; set; }
    public List<Link> Links { get; set; }
    
}
