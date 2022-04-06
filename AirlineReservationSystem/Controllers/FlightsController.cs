﻿using Microsoft.AspNetCore.Http;
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

        [HttpGet]
        [Route("FlightID/Origin/Destination/DepartureTime/ArrivalTime/NumberOfSeats/Fare")]
        public List<Flight> AddFlight(int FlightID, string Origin, string Destination, DateTime DepartureTime, DateTime ArrivalTime, int NumberOfSeats, float Fare)
        {
            return flightsRepository.AddFlight(FlightID, Origin, Destination, DepartureTime, ArrivalTime, NumberOfSeats, Fare);
        }

        [HttpGet]
        [Route("FlightID")]
        public List<Flight> RemoveFlight(int FlightID)
        {
            return flightsRepository.RemoveFlight(FlightID);
        }

        [HttpGet]
        public List<Flight> ViewFlights()
        {
            return flightsRepository.ViewFlights();
        }
    }
}