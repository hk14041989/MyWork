﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UserManager.Controllers
{
    public class UserManagerController : Controller
    {
        //
        // GET: /UserManager/
        public ActionResult Index()
        {
            return View("Index");
        }
	}
}