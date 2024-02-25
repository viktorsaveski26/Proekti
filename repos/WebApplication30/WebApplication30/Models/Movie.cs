using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication30.Models
{
    public class Movie
    {
        public Movie() { 
        clients = new List<Client>();

        }
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string DownloadUrl { get; set; }
        public string ImageUrl { get; set; }
        public float Rating { get; set; }
        public virtual ICollection<Client> clients { get; set; }

    }
}