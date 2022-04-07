using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AirlineReservationSystem.Entities;

namespace AirlineReservationSystem.Repositories
{
    public interface IReservationsRepository
    {
        Reservation BookTicket(int FlightID);
        Reservation CancelTicket(int TicketNo);
        Reservation ViewTicketStatus(int TicketNo);
    }
}
