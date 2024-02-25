using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AudMVC3.Models
{
    public class ClientMovie
    {
       public int MovieId { get; set; }
        public int ClientId { get; set; }
        public Movie movie { get; set; }
        public List<Client> clietns { get;set; }
      public ClientMovie()
        {
            clietns = new List<Client>();
        }

    }
}