using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TeknikServis.UI.AppClasses;

namespace TeknikServis.UI.Controllers
{
    public class KullaniciController : Controller
    {
       
        [Authorize]
        // GET: Kullanici
        public ActionResult Index()
        {
            MembershipUserCollection users = Membership.GetAllUsers();
            return View(users);
        }
        public ActionResult Ekle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Ekle(Kullanici k)
        {
            MembershipCreateStatus durum;
            Membership.CreateUser(k.KullaniciAdi, k.Parola, k.Email, k.GizliSoru, k.GizliCevap, true, out durum);
            string mesaj = "";
            switch (durum)
            {
                case MembershipCreateStatus.Success:
                    break;
                case MembershipCreateStatus.InvalidUserName:
                    mesaj += "Gecersız kullanıcı adı";
                    break;
                case MembershipCreateStatus.InvalidPassword:
                    mesaj += "Gecersiz parola";
                    break;
                case MembershipCreateStatus.InvalidQuestion:
                    mesaj += "gecersiz soru";
                    break;
                case MembershipCreateStatus.InvalidAnswer:
                    mesaj += "Geçersiz gizli cevap";
                    break;
                case MembershipCreateStatus.InvalidEmail:
                    mesaj += "Gecersiz mail";
                    break;
                case MembershipCreateStatus.DuplicateUserName:
                    mesaj += "Kullanılmıs kul adı";
                    break;
                case MembershipCreateStatus.DuplicateEmail:
                    mesaj += "Kullanılmış mail adresi girildi";
                    break;
                case MembershipCreateStatus.UserRejected:
                    mesaj += "Kullanıcı engel hatası";
                    break;
                case MembershipCreateStatus.InvalidProviderUserKey:
                    mesaj += "Gecersiz kullanıcı key hatası";
                    break;
                case MembershipCreateStatus.DuplicateProviderUserKey:
                    mesaj += "Kullanılmış kullanıcı key hatası";
                    break;
                case MembershipCreateStatus.ProviderError:
                    mesaj += "Üye yonetımı saglayıcısı hatası";
                    break;
                default:
                    break;
            }

            ViewBag.Mesaj = mesaj;
            if (durum == MembershipCreateStatus.Success)
                return RedirectToAction("Index");
            else
                return View();

        }
       
    }
}