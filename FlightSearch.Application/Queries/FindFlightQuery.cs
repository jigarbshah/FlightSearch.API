using BuildingBlocks.CQRS;
using FlightSearch.Application.Dtos;

namespace FlightSearch.Application.Queries;

public record FindFlightQuery(string originame) :  IQuery<FindFlightResult>;
public record FindFlightResult(IEnumerable<FlightDto> Flights);
