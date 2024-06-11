using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSearch.Domain.Models
{
    public class Calendar
    {
        public Object FromPrices { get; set; } = new Object();
        public string From { get; set; } = default!;
        public string To { get; set; } = default!;
    }
}
