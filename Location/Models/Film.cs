using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Location.Models
{
    public class Film
    {
        public string Id { get; set; }
        public string Title { get; set; }

        public Film()
        {

        }
        public Film(string idFilm, string title)
        {
            Id = idFilm;
            Title = title;
        }
    }
}
