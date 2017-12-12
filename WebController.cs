using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeknikServis.DAL;

namespace TeknikServis.UI.Controllers
{
    public class WebController : Controller
    {
        TekServisEntities tekservis = new TekServisEntities();
        // GET: Web
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Hakkimizda()
        {
            return View();
        }
        public ActionResult CihazTakibi()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult Sorgula(int islemno)
        {
            var ino = tekservis.Islems.Where(x => x.Urun.IslemNo == islemno).ToList();            
            return View(ino);
        }
        


    }
}