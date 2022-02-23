using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Location.Models
{
    public class Users
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public Users()
        {

        }
        public Users(string idUsers, string name)
        {
            Id = idUsers;
            Name = name;
        }
    }
}
