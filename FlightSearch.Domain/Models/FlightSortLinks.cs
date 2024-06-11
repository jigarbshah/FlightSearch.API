using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSearch.Domain.Models
{
    public class FlightSortLinks
    {
        public string SelectedSort;
        public List<string> AvailableSortFields;
        public List<Link> Links;
    }
}
