using FlightSearch.Application.Dtos;
using Marten;
using Marten.Schema;
using Microsoft.VisualBasic;

namespace FlightSearch.Application;

public class FlightInitialData 
{


    public async Task<IEnumerable<FlightDto>> GetPreconfiguredFlightResult()
    {
        var flightlist =   new List<FlightDto>()
            {
                new FlightDto()
                {
                    Duration = "30",
                    Arrival =  DateTime.Now,
                    Departure = DateTime.Now.AddDays(1),
                    Destination =  new DestinationDto("11", "s", "w1w","sdsd"),
                    Origin =new OriginDto("111", "dfsd", "sd","dsf"),
                },
                new FlightDto()
                {
                    Duration = "30",
                    Arrival =  DateTime.Now.AddDays(-1),
                    Departure = DateTime.Now.AddDays(1),
                    Destination =  new DestinationDto("f", "sd", "sd","sdf"),
                    Origin =new OriginDto("sdfsdf", "g", "sd","sf"),
                }
            };

        return flightlist.ToList();
    }
}
