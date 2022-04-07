using AirlineReservationSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirlineReservationSystem.Repositories
{
    public class ReservationsRepository : IReservationsRepository
    {
        private readonly AirlineDBContext DB = new AirlineDBContext();

        public string BookTicket(string FlightID, DateTime JourneyDate, string PassengerName, int ContactNo, string Email, int NoOftickets)
        {
            var BookingsMade = DB.Reservations.Where(x => x.FlightID == FlightID && x.JourneyDate == JourneyDate).ToList().Count;
            var NoOfSeats = DB.Flights.Where(x => x.FlightID == FlightID).Select(x => x.NoOfSeats).ToList()[0];
            if (BookingsMade + NoOftickets > NoOfSeats)
                return "SeatsNotAvailable";
            else
            {
                Reservation reservation = new Reservation();

                reservation.FlightID = FlightID;
                reservation.DateOfBooking = DateTime.Today;
                reservation.JourneyDate = JourneyDate;
                reservation.PassengerName = PassengerName;
                reservation.ContactNo = ContactNo;
                reservation.Email = Email;
                reservation.NoOfTickets = NoOftickets;
                reservation.TotalFare = DB.Flights.Where(x => x.FlightID == FlightID).Select(x => x.Fare).ToList()[0] * NoOftickets;
                reservation.Status = "Booked";

                DB.Reservations.Add(reservation);
                DB.SaveChanges();

                return "BookingSucccesful";
            }
        }

        public Reservation CancelTicket(int TicketNo)
        {
            DB.Reservations.Where(x => x.TicketNo == TicketNo)
                            .ToList()
                            .ForEach(f => f.Status = "Cancelled");

            return DB.Reservations.Where(x => x.TicketNo == TicketNo).SingleOrDefault();
        }

        public Reservation ViewTicketStatus(int TicketNo)
        {
            return DB.Reservations.Where(x => x.TicketNo == TicketNo)
                                    .SingleOrDefault();
        }
    }
}
