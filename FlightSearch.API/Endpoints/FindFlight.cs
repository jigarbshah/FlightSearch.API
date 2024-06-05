using FlightSearch.Application.Dtos;
using FlightSearch.Application.Queries;
namespace FlightSearch.API.Endpoints;


public record FingFlightByOriginResponse(FlightDto flights);
public class FindFight : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("/findflight/{originName}", async (string originName, ISender sender) =>
        
        {
            var result = await sender.Send(new FindFlightQuery(originName));

            var response = result.Adapt<FingFlightByOriginResponse>();

            return Results.Ok(response);
        })
            .WithName("FingFlightByOrigin")
            .Produces<FingFlightByOriginResponse>(StatusCodes.Status200OK)
            .ProducesProblem(StatusCodes.Status400BadRequest)
            .ProducesProblem(StatusCodes.Status404NotFound)
            .WithSummary("Fing Flight By Origin")
            .WithDescription("Fing Flight By Origin");
    }
}
