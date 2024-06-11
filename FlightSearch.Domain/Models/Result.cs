using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSearch.Domain.Models
{
    public class Result
    {
        public Slices Slices { get; set; } = default!;
        public Criteria Criteria { get; set; } = default!;  
        public Slice Slice { get; set; } = default!;    
        public List<Link> Links { get; set; } = default!;
        public FlightSortLinks FlightSortLinks { get; set; } = default!;    
        public FlightSearchFilters FlightSearchFilters { get; set; } = default!;
        public TripSummary TripSummary { get; set; } = default!;
    }
}
