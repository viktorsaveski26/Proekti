﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC4.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public string Browse()
        {
            return "Hello from Store.Browse()";
        }
        public string Index()
        {
            return "Hello from Store.Index()";
        }
        
        public string Details()
        {
            return "Hello from Store.Details()";
        }
    }
}