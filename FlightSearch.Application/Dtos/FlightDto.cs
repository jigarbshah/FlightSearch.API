using FlightSearch.Domain.ValueObjects;

namespace FlightSearch.Application.Dtos;

public class FlightDto
{
    public string Duration { get;  set; } = default!;
    public OriginDto Origin { get;  set; } = default!;
    public DestinationDto Destination { get;  set; } = default!;
    public DateTime Departure { get;  set; } = default!;
    public DateTime Arrival { get; set; } = default!;
    public OperatingAirlineDto OperatingAirline { get; set; } = default!;
}