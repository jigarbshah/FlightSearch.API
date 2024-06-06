using FlightSearch.Application.Dtos;
using FlightSearch.Domain.ValueObjects;
using Marten;
using Marten.Schema;
using Microsoft.VisualBasic;

namespace FlightSearch.Application;

public class FlightInitialData
{


    public async Task<IEnumerable<FlightDto>> GetPreconfiguredFlightResult()
    {
        var flightlist = new List<FlightDto>()
            {
                new FlightDto()
                {
                    Duration = "PT10H5M",
                    Arrival =  DateTime.Now,
                    Departure = DateTime.Now.AddDays(1),
                    Destination =  new DestinationDto("ATL", "Atlanta", "GA","Hartsfield-Jackson Atlanta Intl"),
                    Origin =new OriginDto("LHR", "London", "United Kingdom","Heathrow Airport"),
                    OperatingAirline = new OperatingAirlineDto("DL","Delta Air Lines")
                },
                new FlightDto()
                {
                    Duration = "PT10H",
                    Arrival =  DateTime.Now.AddDays(1),
                    Departure = DateTime.Now.AddDays(2),
                    Destination =  new DestinationDto("ATL", "Atlanta", "GA","Hartsfield-Jackson Atlanta Intl"),
                    Origin =new OriginDto("LHR", "London", "United Kingdom","Heathrow Airport"),
                    OperatingAirline = new OperatingAirlineDto("VS","Virgin Atlantic")
                },
                new FlightDto()
                {
                    Duration = "PT10H10M",
                    Arrival =  DateTime.Now,
                    Departure = DateTime.Now.AddDays(1),
                    Destination =  new DestinationDto("ATL", "Atlanta", "GA","Hartsfield-Jackson Atlanta Intl"),
                    Origin =new OriginDto("BOS", "Boston", "MA","Logan International Airport"),
                    OperatingAirline = new OperatingAirlineDto("VS","Virgin Atlantic")
                },
               new FlightDto()
                {
                    Duration = "PT10H",
                    Arrival =  DateTime.Now.AddDays(1),
                    Departure = DateTime.Now.AddDays(2),
                    Destination =  new DestinationDto("ATL", "Atlanta", "GA","Hartsfield-Jackson Atlanta Intl"),
                    Origin =new OriginDto("MCO", "Orlando", "FL","Orlando International Airport"),
                    OperatingAirline = new OperatingAirlineDto("VS","Virgin Atlantic")
                }, 
                new FlightDto()
                {
                    Duration = "PT10H",
                    Arrival =  DateTime.Now.AddDays(1),
                    Departure = DateTime.Now.AddDays(2),
                    Destination =  new DestinationDto("ATL", "Atlanta", "GA","Hartsfield-Jackson Atlanta Intl"),
                    Origin =new OriginDto("AMS", "Amsterdam", "Netherlands","Schiphol Airport"),
                    OperatingAirline = new OperatingAirlineDto("KL","KLM")
                }
            };

        return flightlist.ToList();
    }
}
