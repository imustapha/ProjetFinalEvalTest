using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetFinalEval.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Accueil()
        {
            return View("Accueil");
        }
    }
}