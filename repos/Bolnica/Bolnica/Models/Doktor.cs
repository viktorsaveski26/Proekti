using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bolnica.Models
{
    public class Doktor
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Sname { get; set; }
        public string Odel { get; set; }
    }
}