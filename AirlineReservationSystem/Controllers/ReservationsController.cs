using Microsoft.AspNetCore.Http;
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
    public class ReservationsController : ControllerBase
    {
        private readonly IReservationsRepository reservationsRepository;

        public ReservationsController(IReservationsRepository reservationsRepository)
        {
            this.reservationsRepository = reservationsRepository;
        }

        [HttpPost]
        public string BookTicket(string FlightID, DateTime JourneyDate, string PassengerName, int ContactNo, string Email, int NoOftickets)
        {
            return reservationsRepository.BookTicket(FlightID,  JourneyDate,  PassengerName,  ContactNo,  Email,  NoOftickets);
        }

        [HttpPut]
        [Route("{TicketNo}")]
        public Reservation CancelTicket(int TicketNo)
        {
            return reservationsRepository.CancelTicket(TicketNo);
        }
        
        [HttpGet]
        public Reservation ViewTicketStatus(string PassengerName)
        {
            return reservationsRepository.ViewTickets(PassengerName);
        }
    }
}
