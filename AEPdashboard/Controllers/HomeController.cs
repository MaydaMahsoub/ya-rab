using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.EntityClient;
using System.Data.Objects;

namespace AEPdashboard.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult IS()
        {
            return View();
        }

        public ActionResult Financial()
        {
            return View();
        }

        public ActionResult Socialactivity()   
        {
            return View();
        }

        
    }
}