using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSearch.Domain.Models
{
    public class PriceGrid
    {
        public List<string> Returning {  get; set; } =  new List<string>();
        public List<Departure> Departures { get; set; } = default!;
    }
}
