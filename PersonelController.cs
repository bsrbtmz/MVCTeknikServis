using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeknikServis.DAL;
using TeknikServis.UI.Models;
using TeknikServis.UI.Services;

namespace TeknikServis.UI.Controllers
{
    [Authorize]
    public class PersonelController : Controller
    {
        TekServisEntities ts = new TekServisEntities();
        // GET: Personel
        public ActionResult Index()
        {
            List<Personel> personel = DataService.Service.PersonelService.SelectAll();
            return View(personel);
        }
        public ActionResult PersonelEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult PersonelEkle(PersonelDTO p)
        {

            if (ModelState.IsValid)
            {
                Personel personel = new Personel()
                {
                    Ad = p.Ad,
                    Soyad = p.Soyad,
                    DogumTarihi = p.DogumTarihi,
                    IseGirisTarihi = p.IseGirisTarihi,
                    Email = p.Email,
                    Telefon = p.Telefon
                };
                DataService.Service.PersonelService.Insert(personel);

            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public void Sil(int id)
        {
            Personel personel = ts.Personels.FirstOrDefault(x => x.Id == id);
            ts.Personels.Remove(personel);
            ts.SaveChanges();
        }
    }
}