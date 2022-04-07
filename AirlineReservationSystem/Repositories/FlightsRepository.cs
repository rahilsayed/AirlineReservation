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

        public string AddFlight(string FlightID,
                                        string Origin, 
                                        string Destination, 
                                        string DepartureTime, 
                                        string ArrivalTime, 
                                        int NumberOfSeats, 
                                        float Fare)
        {

            var flights = DB.Flights.ToList();

            //check if the FlightID already exists
            var results = DB.Flights.Where(x => x.FlightID == FlightID).ToList();
            if (results.Count > 0)
            {
                return "FlightExistsError";
            }
            else
            {
                Flight flight = new Flight();

                flight.FlightID = FlightID;
                flight.LaunchDate = DateTime.Today;
                flight.Origin = Origin;
                flight.Destination = Destination;
                flight.DeptTime = DepartureTime;
                flight.ArrivalTime = ArrivalTime;
                flight.NoOfSeats = NumberOfSeats;
                flight.Fare = Fare;

                DB.Flights.Add(flight);
                DB.SaveChanges();

                return "FlightAddedSucccesfully";
            }
        }

        public List<Flight> RemoveFlight(string FlightID)
        {
            var flight = DB.Flights.Where(x => x.FlightID == FlightID).SingleOrDefault();

            DB.Remove(flight);
            DB.SaveChanges();

            return DB.Flights.ToList();
        }

        public List<Flight> ViewFlights()
        {
            return DB.Flights.ToList();
        }
    }
}
