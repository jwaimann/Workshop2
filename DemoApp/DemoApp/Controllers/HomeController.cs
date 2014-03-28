﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Geeting ready for git! (edited from github)";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
