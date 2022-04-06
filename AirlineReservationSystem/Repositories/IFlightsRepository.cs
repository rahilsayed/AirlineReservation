using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AirlineReservationSystem.Entities;

namespace AirlineReservationSystem.Repositories
{
    public interface IFlightsRepository
    {
        List<Flight> ViewFlights();
        List<Flight> AddFlight(int FlightID, string Origin, string Destination, DateTime DepartureTime, DateTime ArrivalTime, int NumberOfSeats, float Fare);
        List<Flight> RemoveFlight(int FlightID);

    }
}
