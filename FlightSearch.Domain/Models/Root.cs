using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSearch.Domain.Models
{
    public class Root
    {
        public PriceGrid PriceGrid { get; set; } = default!;
        public Calendar Calendar { get; set; } = default!;
        public Result Result { get; set; } = default!;
        public List<Link> Links { get; set; } = default!;
    }
}
