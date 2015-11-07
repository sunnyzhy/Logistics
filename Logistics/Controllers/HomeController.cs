﻿using Logistics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Logistics.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        [ActionAuthentication]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Hello()
        {
            return View();
        }
    }
}
