﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Layoutlearning.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View("Index", "_NewLayout");
                       //view_name //Layout name
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}