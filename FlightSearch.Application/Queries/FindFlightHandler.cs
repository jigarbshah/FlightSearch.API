using BuildingBlocks.CQRS;

namespace FlightSearch.Application.Queries
{

    public class FindFlightHandler(): IQueryHandler<FindFlightQuery, FindFlightResult>
    {

        public async Task<FindFlightResult> Handle(FindFlightQuery query, CancellationToken cancellationToken)
        {
            // get flights by name using IDoc session
            // return result
            var flightInit = new FlightInitialData();
            
            var flights =  await flightInit.GetPreconfiguredFlightResult();
            var fr = flights.Where(f => f.Origin.Code == query.originame).ToArray();
            return new FindFlightResult(fr);
        }
    
    }


}
