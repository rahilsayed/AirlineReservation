using AirlineReservationSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirlineReservationSystem.Repositories
{
    public class FlightsRepository : IFlightsRepository
    {
        private readonly AirlineDBContext DB = new AirlineDBContext();

        public List<Flight> AddFlight(int FlightID, string Origin, string Destination, DateTime DepartureTime, DateTime ArrivalTime, int NumberOfSeats, double Fare)
        {
            throw new NotImplementedException();
        }

        public List<Flight> RemoveFlight(int FlightID)
        {
            throw new NotImplementedException();
        }

        public List<Flight> ViewFlights(int FlightID)
        {
            throw new NotImplementedException();
        }
    }
}
