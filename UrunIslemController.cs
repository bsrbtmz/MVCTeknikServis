using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeknikServis.DAL;

namespace TeknikServis.UI.Controllers
{
    [Authorize]
    public class UrunIslemController : Controller
    {
        TekServisEntities tekServis = new TekServisEntities();
        // GET: UrunIslem
        public ActionResult Tamirde()
        {
            var tamir = tekServis.Islems.Where(x => x.ServisDurum.Id == 1).ToList();
            return View(tamir);
        }
        public ActionResult Tamamlandi()
        {
            var tamir = tekServis.Islems.Where(x => x.ServisDurum.Id == 2).ToList();
            return View(tamir);
        }
        public ActionResult Islemde()
        {
            var tamir = tekServis.Islems.Where(x => x.ServisDurum.Id == 3).ToList();
            return View(tamir);
        }
        public ActionResult ParcaDegisimi()
        {
            var tamir = tekServis.Islems.Where(x => x.ServisDurum.Id == 4).ToList();
            return View(tamir);
        }
        public ActionResult IptalEdildi()
        {
            var tamir = tekServis.Islems.Where(x => x.ServisDurum.Id == 5).ToList();
            return View(tamir);
        }
        public ActionResult TeslimEdildi()
        {
            var tamir = tekServis.Islems.Where(x => x.ServisDurum.Id == 6).ToList();
            return View(tamir);
        }
    }
}