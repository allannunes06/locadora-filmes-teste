using Location.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Location.Services
{
    public interface IUsersService
    {
        List<Users> GetUsers();
        Users InsertUsers(Users newUsers);
        Users DeleteUsers(string id);
        Users UpdateUsers(Users newUsers);
    }
}
