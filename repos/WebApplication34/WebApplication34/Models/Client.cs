﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication34.Models
{
    public class Client

    {
        Client() { 
        movies = new List<Movie>();
        }
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Range(1,99,ErrorMessage ="Age must be between 1 and 99")]
        public int Age { get; set; }
        [Required]
        public string Address { get; set; }
        public string Phone { get; set; }
        public string MovieCard { get; set; }    

        public virtual ICollection<Movie> movies { get; set; }
       
    }
}