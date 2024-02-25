using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bolnica.Models
{
    public class Pacietn
    {
        [Key]
        public int Id { get; set; }
        [Range (10000, 99999)]
        public int Kod { get; set; }
        [Required]
        public string Name { get; set; }
        public string SName { get; set; }
        public string Pol { get; set; }
    }
}