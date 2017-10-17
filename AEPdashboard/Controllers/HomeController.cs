using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.EntityClient;
using System.Data.Objects;
using AEPdashboard.Models;
using System.Linq;

namespace AEPdashboard.Controllers
{
    public class HomeController : Controller
    {
        AEPDB db = new AEPDB();
        public ActionResult Index()
        {
            return View(db.SCORECARD_FACT.ToList());
        }

        public ActionResult IS()
        {
            return View(db.SCORECARD_FACT.ToList());
        }

        public ActionResult Financial()
        {
            return View(db.SCORECARD_FACT.ToList());
        }

        public ActionResult Socialactivity()   
        {
            return View(db.SCORECARD_FACT.ToList());
        }

        
    }
}