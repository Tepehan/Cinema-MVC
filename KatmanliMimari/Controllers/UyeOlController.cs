using Business.Concrete;
using Business.Validators;
using DataAccesLayer.Concrete.EntityFramework;
using DataAccesLayer.Migrations;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace KatmanliMimari.Controllers
{
    public class UyeOlController : Controller
    {
        MusteriManager musteriManager = new MusteriManager(new EfMusteriDal());
        // GET: UyeOl
        [HttpGet,]
        public ActionResult UyeOl()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UyeOl(Musteri musteri)
        {

            MusteriValidator validations = new  MusteriValidator();
            var sonuc = validations.Validate(musteri);

            if (sonuc.IsValid)
            {
                musteriManager.AddMusteri(musteri);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                foreach (var item in sonuc.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
           
            
              

        }

    }
}