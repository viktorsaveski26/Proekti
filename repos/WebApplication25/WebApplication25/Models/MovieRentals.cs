using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication25.Models
{
    public class MovieRentals
    {
         //ovde ke imame info  za koj film koja lista od klienti ja imame sto go rentale toj film
         public Movie movie { get; set; }
        public List<Client> clients { get; set; }
        //bidejki imame lista ubavo  e da napravime eden konstruktor kade sto inicijalno ke ja inicijaliziram
        // ovaa lista od clients da bide  new list od client, zatoa sto ako probam so add da dodamdam
        // a ne e inicijalizirana ke dobijam null pointer
        public MovieRentals() { 
        clients = new List<Client>();
        
        }
    }
}