﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mpi.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Login2()
        {
            return View();
        }
        public ActionResult Logout()
        {
            return RedirectToAction("Login");
        }
    }
}