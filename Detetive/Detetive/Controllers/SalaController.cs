﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Detetive.Controllers
{
    public class SalaController : Controller
    {
        // GET: ManterSala()
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ManterSala()
        {
            return View();
        }
        public string CriarSala()
        {
            return "1234";
        }
    }
}