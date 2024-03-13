using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace proje_kahve.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        [Route("hakkimizda")]
        public ActionResult Hakkimizda()
        {
            return View();
        }
        [Route("urunler")]
        public ActionResult Urunler()
        {
            return View();
        }
        [Route("magaza")]
        public ActionResult Magaza()
        {
            return View();
        }
    }
}