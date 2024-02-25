using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aud6.Models
{
    public class MovieRentals
    {
        public List<Movie> movies { get; set; }
        public List<Client> clients { get; set; }
        public MovieRentals() { 
        clients = new List<Client>();
           movies = new List<Movie>();
        }
    }
}