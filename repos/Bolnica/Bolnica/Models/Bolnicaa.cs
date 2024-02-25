using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bolnica.Models
{
    public class Bolnicaa
    {
        [Key]
        public int BolnicaId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Destinacija { get; set; }
        public string imgurl { get; set; }
    }
}