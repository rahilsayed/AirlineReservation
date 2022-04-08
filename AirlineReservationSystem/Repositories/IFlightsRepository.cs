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
        string AddFlight(string FlightID, string Origin, string Destination, string DepartureTime, string ArrivalTime, int NumberOfSeats, float Fare);
        List<Flight> RemoveFlight(string FlightID);

    }
}
