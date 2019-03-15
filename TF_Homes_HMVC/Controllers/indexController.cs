using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TF_Homes_HMVC.Controllers
{
    public class indexController : Controller
    {
        public ActionResult Login()
        {
            return View();

        }


        // GET: index
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Icons()
        {
            return View();
        }

        public ActionResult Tables()
        {
            return View();
        }

        public ActionResult Components()
        {
            return View();
        }

        public ActionResult Forms()
        {
            return View();
        }

        public ActionResult Notifications()
        {
            return View();
        }

        public ActionResult Typography()
        {
            return View();
        }
    }
}