using BuildingBlocks.CQRS;
using FlightSearch.Domain.Models;

namespace FlightSearch.Application.Queries;

public record GetFlightByOriginQuery(string originame) :  IQuery<GetFlightByOriginResult>;
public record GetFlightByOriginResult(IEnumerable<Flight> Flights);
