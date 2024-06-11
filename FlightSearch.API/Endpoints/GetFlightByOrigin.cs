using FlightSearch.Application.Dtos;
using FlightSearch.Application.Queries;
namespace FlightSearch.API.Endpoints;

// Add Flight Dto Object for custom display.
public record GetFlightByOriginResponse(IEnumerable<FlightDto> flights);
public class GetFlightByOrigin : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("/GetFlightByOrigin/{originName}", async (string originName, ISender sender) =>
        
       {
            var result = await sender.Send(new GetFlightByOriginQuery(originName));

            var response = result.Adapt<GetFlightByOriginResponse>();

            return Results.Ok(response);
        })
            .WithName("GetFlightByOrigin")
            .Produces<GetFlightByOriginResponse>(StatusCodes.Status200OK)
            .ProducesProblem(StatusCodes.Status400BadRequest)
            .ProducesProblem(StatusCodes.Status404NotFound)
            .WithSummary("Get Flight By Origin")
            .WithDescription("Get Flight By Origin");
    }
}
