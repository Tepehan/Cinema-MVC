using Business.Concrete;
using DataAccesLayer.Concrete.EntityFramework;
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
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Musteri musteri)
        {
            if (ModelState.IsValid)
            {
                musteriManager.AddMusteri(musteri);
            }

            return View();
            
            

        }

    }
}