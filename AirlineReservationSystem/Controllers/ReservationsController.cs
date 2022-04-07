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

        [HttpPut]
        [Route("TicketNo")]
        public Reservation CancelTicket(int TicketNo)
        {
            return reservationsRepository.CancelTicket(TicketNo);
        }
        
        [HttpGet]
        [Route("TicketNo")]
        public Reservation ViewTicketStatus(int TicketNo)
        {
            return reservationsRepository.ViewTicketStatus(TicketNo);
        }
    }
}
