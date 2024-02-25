using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication34.Models
{
    
    public class Movie
    {
        public Movie() { 
        Clients = new List<Client>();
        }

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string DownloadUrl { get; set; }
        public string ImageUrl { get; set; }
        public float Rating { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
    }
}