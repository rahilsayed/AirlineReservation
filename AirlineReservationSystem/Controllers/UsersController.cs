using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AirlineReservationSystem.Repositories;
using Microsoft.AspNetCore.Cors;

namespace AirlineReservationSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors]
    public class UsersController : ControllerBase
    {
        private readonly IUsersRepository usersRepository;

        public UsersController(IUsersRepository usersRepository)
        {
            this.usersRepository = usersRepository;
        }

        [HttpGet]
        [Route("login")]
        public string Authenticate(string user, string pw)
        {
            return usersRepository.Authenticate(user, pw);
        }

    }
}
