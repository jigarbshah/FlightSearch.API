namespace FlightSearch.Domain.ValueObjects
{
    public class FareSegment
    {

        public string CabinName { get; set; } = default!;
        public string BookingClass { get; set; } = default!;
        public bool isDominantLeg { get; set; } = default!;
        public object FlightSegmentRefID { get; set; } = default!;


    }
}
