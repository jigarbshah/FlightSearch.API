using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightSearch.Domain.Models;
using Refit;
namespace FlightSearch.Application.Queries
{
    public interface IService
    {
        [Get("/mock/flight/search")]
        Task<Root> GetFlightSerach();

    }
}
