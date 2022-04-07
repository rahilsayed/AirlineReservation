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

        public List<Flight> AddFlight(int FlightID, 
                                        string Origin, 
                                        string Destination, 
                                        string DepartureTime, 
                                        string ArrivalTime, 
                                        int NumberOfSeats, 
                                        float Fare)
        {
            Flight flight = new Flight();
            
            flight.FlightID = FlightID;
            flight.LaunchDate = DateTime.Now;
            flight.Origin = Origin;
            flight.Destination = Destination;
            flight.DeptTime = DepartureTime;
            flight.ArrivalTime = ArrivalTime;
            flight.NoOfSeats = NumberOfSeats;
            flight.Fare = Fare;

            DB.Flights.Add(flight);
            DB.SaveChanges();

            var result = DB.Flights.ToList();
            return result;
        }

        public List<Flight> RemoveFlight(int FlightID)
        {
            var flight = DB.Flights.Where(x => x.FlightID == FlightID).SingleOrDefault();

            DB.Remove(flight);
            DB.SaveChanges();

            var result = DB.Flights.ToList();
            return result;
        }

        public List<Flight> ViewFlights()
        {
            var result = DB.Flights.ToList();
            return result;
        }
    }
}
