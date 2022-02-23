using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Location.Models
{
    public class Locations
    {
        public Locations()
        {

        }
        public Locations(string idLocations, string idUsers, string idFilm, DateTime dataLocations, DateTime dataDevolution)
        {
            Id = idLocations;
            IdUsers = idUsers;
            IdFilm = idFilm;
            DataLocations = dataLocations;
            DataDevolution = dataDevolution;
        }

        public string Id { get; set; }
        public string IdUsers { get; set; }
        public string IdFilm { get; set; }

        public DateTime DataLocations { get; set; }

        public DateTime DataDevolution { get; set; }
    }
}
