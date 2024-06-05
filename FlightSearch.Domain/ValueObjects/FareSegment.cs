namespace FlightSearch.Domain.ValueObjects
{
    public record FareSegment
    {

        public string cabinName { get; set; }
        public string bookingClass { get; set; }
        public bool isDominantLeg { get; set; }
        public object flightSegmentRefID { get; set; }
        private FareSegment(string cabinName, string bookingClass, bool isDominantLeg, object flightSegmentRefID)
        {
            this.cabinName = cabinName;
            this.bookingClass = bookingClass;
            this.isDominantLeg = isDominantLeg;
            this.flightSegmentRefID = flightSegmentRefID;
        }

        public static FareSegment Of(string cabinName, string bookingClass, bool isDominantLeg, object flightSegmentRefID)
        {
           return new FareSegment(cabinName, bookingClass, isDominantLeg, flightSegmentRefID);
        }

    }
}
