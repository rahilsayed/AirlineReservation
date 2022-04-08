using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AirlineReservationSystem.Repositories;
using AirlineReservationSystem.Entities;

namespace AirlineReservationSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightsController : ControllerBase
    {
        private readonly IFlightsRepository flightsRepository;

        public FlightsController(IFlightsRepository flightsRepository)
        {
            this.flightsRepository = flightsRepository;
        }

        [HttpPost]
        public string AddFlight(Flight flight)
        {
            return flightsRepository.AddFlight(flight.FlightID, flight.Origin, flight.Destination, flight.DeptTime, flight.ArrivalTime, flight.NoOfSeats, flight.Fare);
        }

        [HttpDelete]
        public List<Flight> RemoveFlight(string FlightID)
        {
            return flightsRepository.RemoveFlight(FlightID);
        }

        [HttpGet]
        public List<Flight> ViewFlights(string Source,string Destination)
        {
            return flightsRepository.ViewFlights(Source,Destination);
        }
    }
}
