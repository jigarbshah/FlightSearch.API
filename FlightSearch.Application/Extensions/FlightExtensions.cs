//using FlightSearch.Application.Dtos;
//using FlightSearch.Domain.Models;
//using FlightSearch.Domain.ValueObjects;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace FlightSearch.Application.Extensions
//{
//    public static class FlightExtensions
//    {
//        public static IEnumerable<FlightDto> ToFlightDtoList(this IEnumerable<Flight> flights)
//        {
//            return flights.Select(flight => new FlightDto(
//                _duration: flight.Duration,
//                _origin: new OriginDto(flight.Origin.Code, flight.Origin.CityName, flight.Origin.CountryName, flight.Origin.AirportName),
//                _departure: flight.Departure,
//                _destination: new DestinationDto(flight.Destination.Code, flight.Destination.CityName, flight.Destination.CountryName, flight.Destination.AirportName),
//                _arrival: flight.Arrival));

//        }
//    }
//}
