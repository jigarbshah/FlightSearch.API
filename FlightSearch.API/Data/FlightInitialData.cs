using FlightSearch.Application.Dtos;
using Marten;
using Marten.Schema;

namespace FlightSearch.API.Data;

public class FlightInitialData : IInitialData
{
    public async Task Populate(IDocumentStore store, CancellationToken cancellation)
    {
        using var session = store.LightweightSession();

        if (await session.Query<FlightDto>().AnyAsync())
            return;

        // Marten UPSERT will cater for existing records
        session.Store<FlightDto>(GetPreconfiguredFlightResult());
        await session.SaveChangesAsync();
    }

    public static IEnumerable<FlightDto> GetPreconfiguredFlightResult() => new List<FlightDto>()
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
                },
            };

  
}
