using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AudMVC3.Models
{
    public class Client
    {
        public Client() { 
        movies = new List<Movie>();
        }
        [Key]
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Range(1,99,ErrorMessage ="Age must be between 1 and 99")]
        public int age { get; set; }
        [Required]
        public string Address { get; set; }
        public string Phone { get; set; }
        public string MovieCard { get; set; }
        public virtual ICollection<Movie> movies { get; set; } // so ova kazuvam deka ne sakam da mi
        //se zacuva kako realna lista, tuku ova ke bide relacija t.e. megu tabela 
        //vo koja sto ke imam kluc od filmot i kluc od klientot  koj sto go izrental

    }
}