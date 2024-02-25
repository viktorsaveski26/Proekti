﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication27.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name{ get; set; }
        public string DownloadUrl { get; set; }
        public string ImageUrl { get; set; }
        public float Rating { get; set; }

    }
}