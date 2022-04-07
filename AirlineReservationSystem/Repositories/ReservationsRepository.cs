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

        public Reservation BookTicket(int FlightID)
        {
            throw new NotImplementedException();
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
