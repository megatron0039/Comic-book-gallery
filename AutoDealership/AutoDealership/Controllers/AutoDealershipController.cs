using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static System.Console;

namespace AutoDealership.Controllers
{
    public class AutoDealershipController : Controller
    {
        // GET: AutoDealership
        public ActionResult Index()
        {
            return View();
        }
    }
}