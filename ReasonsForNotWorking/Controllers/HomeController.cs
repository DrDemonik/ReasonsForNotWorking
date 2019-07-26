using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using ReasonsForNotWorking.Models;

namespace ReasonsForNotWorking.Controllers
{
    public class HomeController : Controller
    {
        ReasonContext db = new ReasonContext();
        public ActionResult Index()
        {
            IEnumerable<Reason> reasons = db.Reasons;
            ViewBag.Reasons = reasons;
            return View();
        }
    }
}