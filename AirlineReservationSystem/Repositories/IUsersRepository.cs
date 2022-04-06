using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirlineReservationSystem.Repositories
{
    public interface IUsersRepository
    {
        string Authenticate(string user, string pw);
    }
}
