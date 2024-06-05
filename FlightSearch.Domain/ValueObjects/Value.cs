using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSearch.Domain.ValueObjects;

public record Value
{

    public bool selected { get; set; }
    public bool enabled { get; set; }
    public int count { get; set; }
    public double minPrice { get; set; }
    public string currency { get; set; }
    public string displayName { get; set; }
    public List<Link> links { get; set; }
    private Value(bool selected, bool enabled, int count, double minPrice, string currency, string displayName, List<Link> links)
    {
        this.selected = selected;
        this.enabled = enabled;
        this.count = count;
        this.minPrice = minPrice;
        this.currency = currency;
        this.displayName = displayName;
        this.links = links;
    }
    public static Value Of(bool selected, bool enabled, int count, double minPrice, string currency, string displayName, List<Link> links)
    {
        return new Value(selected, enabled, count, minPrice, currency,displayName, links);
    }

}
