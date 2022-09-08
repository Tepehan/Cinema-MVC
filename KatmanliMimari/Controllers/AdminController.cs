using DataAccesLayer;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace KatmanliMimari.Controllers
{   [AllowAnonymous]
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult login() { return View(); }
        [HttpPost]
        public ActionResult login(Admin admin) {
            Context c = new Context();
            var sonuc=c.adminler.FirstOrDefault(x => x.kullaniciAd == admin.kullaniciAd && x.sifre == admin.sifre);
            if (sonuc != null) {
                FormsAuthentication.SetAuthCookie(sonuc.kullaniciAd,false);
                Session["adminAdi"] = sonuc.adminAdi;
                Session["adminSoyadi"] = sonuc.adminSoyadi;
                Session["kullaniciAd"] = sonuc.kullaniciAd;
               
                return RedirectToAction("Index","Home");
            }
            else{
                return RedirectToAction("login");
            }
           
        }
        public ActionResult logout() {
            FormsAuthentication.SignOut();
          return  RedirectToAction("login");
        }
    }
}