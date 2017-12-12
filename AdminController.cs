using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeknikServis.DAL;

namespace TeknikServis.UI.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        TekServisEntities tekServis = new TekServisEntities();
        // GET: Admin
       
       public ActionResult Index()
        {
            return View();
        }
        public ActionResult Goruntule()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Goruntule(string musteri)
        {
            var ara = tekServis.procMusteriAra(musteri);           
            return View(ara);
        }

    }
}