using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Galeri302.Controllers
{
    public class HomeController : Controller
    {
        Models.G302Context db = new Models.G302Context();
        // GET: Home
        public ActionResult Index()
        {
            var araclar = db.Araclars.ToList();
            return View(araclar);
        }
    }
}