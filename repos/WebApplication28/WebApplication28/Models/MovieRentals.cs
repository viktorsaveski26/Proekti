using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication28.Models
{
    public class MovieRentals
    {
        public Movie movie { get; set; }
        public List<Client> clients { get; set; }
        public MovieRentals() { 
        List<Client> clients = new List<Client>();
        }
    }
}