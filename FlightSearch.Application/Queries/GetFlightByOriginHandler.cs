using BuildingBlocks.CQRS;

namespace FlightSearch.Application.Queries
{

    public class GetFlightByOriginHandler(IService service): IQueryHandler<GetFlightByOriginQuery, GetFlightByOriginResult>
    {

        public async Task<GetFlightByOriginResult?> Handle(GetFlightByOriginQuery query, CancellationToken cancellationToken)
        {
            // IService HTTP client call to get flight data.
            var response = await service.GetFlightSerach();
            var flights = response.Result.Slice.FlightsAndFares.Select(x=>x.Flight).ToList();
             flights.Where(o=>o.Origin.Code == query.originame).ToList();
            return new GetFlightByOriginResult(flights);
        }
    
    }


}
