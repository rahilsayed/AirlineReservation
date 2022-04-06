using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AirlineReservationSystem.Entities;

namespace AirlineReservationSystem.Repositories
{
    interface IFlightsRepository
    {
        List<Flight> ViewFlights(int FlightID);
        List<Flight> AddFlight(int FlightID, string Origin, string Destination, DateTime DepartureTime, DateTime ArrivalTime, int NumberOfSeats, double Fare);
        List<Flight> RemoveFlight(int FlightID);

    }
}
