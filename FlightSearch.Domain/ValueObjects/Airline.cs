using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSearch.Domain.ValueObjects
{
    public class Airline
    {
        public string Code { get; set; } = default!;
        public string Name { get; set; } = default!;

    }
}
