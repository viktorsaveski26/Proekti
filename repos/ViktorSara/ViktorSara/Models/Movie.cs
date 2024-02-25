using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ViktorSara.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string URL { get; set; }
        public string ImageUrl { get; set; }
        public int Rating { get; set; }
    }
}