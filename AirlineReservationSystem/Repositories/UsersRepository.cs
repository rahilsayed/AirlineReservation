using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AirlineReservationSystem.Entities;

namespace AirlineReservationSystem.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        private readonly AirlineDBContext DB = new AirlineDBContext();
        public string Authenticate(string user, string pw)
        {
            var res = DB.Users.Where(x => x.Username == user && x.Password == pw).ToList();
            if (res != null && res.Count == 1)
                return "Logged In";
            else
                return "LogIn Failed";
        }
    }
}
