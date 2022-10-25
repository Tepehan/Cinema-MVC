using Entity.Concrete;
using Business.Concrete;
using DataAccesLayer.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace KatmanliMimari.Controllers
{
    [AllowAnonymous]
    public class GirisController : Controller
    {

        MusteriManager musteriManager = new MusteriManager(new EfMusteriDal());
        // GET: Giris
        [HttpGet]
        public ActionResult Index()
        {
            // Buranın ındex olarak kalmasın bence degısıtırn
            return View();
        }
        [HttpPost]
        public ActionResult Index(Musteri musteri)
        {
            var sonuc = musteriManager.GetBy(musteri.ad, musteri.sifre);
            if (sonuc != null)
            {
                //set the logined admin toAuthCookie
                FormsAuthentication.SetAuthCookie(sonuc.ad, false);
                //intiating the session with needed values

                //Session["musteriAd"] = sonuc.ad;
                //Session["musteriSoyad"] = sonuc.soyad;
                
                //yorum satırı yapıldı.

                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult LogOut()
        {
           
            FormsAuthentication.SignOut();
            return RedirectToAction("Index");
        }
    }
}