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
        [HttpGet]
        public ActionResult Add(int? id)
        {
            ViewBag.ReasonId = id;
            return View();
        }
        [HttpPost]
        public string Add(PersonReson personReson)
        {
            personReson.Date = DateTime.Now;
            db.PersonResons.Add(personReson);
            db.SaveChanges();
            return personReson.PersonName + " добавлен";
        }
    }
}