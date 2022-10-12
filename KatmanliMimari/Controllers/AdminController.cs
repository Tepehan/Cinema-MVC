using Business.Concrete;
using DataAccesLayer;
using DataAccesLayer.Concrete.EntityFramework;
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
        AdminManager adminManager = new AdminManager(new EfAdminDal());
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult login() 
        {
            return View(); 
        }
        [HttpPost]
        public ActionResult login(Admin admin) {

            var sonuc = adminManager.GetBy(admin.kullaniciAd,admin.sifre);
            if (sonuc != null) {
                //set the logined admin toAuthCookie
                FormsAuthentication.SetAuthCookie(sonuc.kullaniciAd,false);
                //intiating the session with needed values
                Session["adminAdi"] = sonuc.adminAdi;
                Session["adminSoyadi"] = sonuc.adminSoyadi;
                Session["kullaniciAd"] = sonuc.kullaniciAd;
               
                return RedirectToAction("Index","Film");
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