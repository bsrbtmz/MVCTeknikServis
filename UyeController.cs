using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TeknikServis.UI.AppClasses;

namespace TeknikServis.UI.Controllers
{
    [Authorize]
    public class UyeController : Controller
    {
        // GET: Uye
        //Bu actıonları mısafır ya da herhangi farklı kullanıcılarda gırebılır.Authorıze la sorun yasamamak ıcın koyuyoruz bu kontrolu   
        [AllowAnonymous]
        public ActionResult GirisYap()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult GirisYap(Kullanici k, string Hatirla)
        {
            bool sonuc = Membership.ValidateUser(k.KullaniciAdi, k.Parola);
            if (sonuc)
            {
                if (Hatirla == "on")
                    FormsAuthentication.RedirectFromLoginPage(k.KullaniciAdi, true);
                else
                    FormsAuthentication.RedirectFromLoginPage(k.KullaniciAdi, false);
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                ViewBag.Mesaj = "Hatalı Giriş";
                return View();
            }
        }
        public ActionResult Cikis()
        {
            FormsAuthentication.SignOut();
            return Redirect("GirisYap");
        }
    }
}