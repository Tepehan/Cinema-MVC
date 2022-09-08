using Business.Concrete;
using DataAccesLayer.Concrete.EntityFramework;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KatmanliMimari.Controllers
{
    public class SalonController : Controller
    {
        // GET: Salon
        SalonManager salonManagerBL = new SalonManager(new EfSalonDal());
        public ActionResult Index()
        {
            var salonlist = salonManagerBL.list();
            return View(salonlist);
        }
        [HttpPost]
        public ActionResult AddSalon(Salon salon)
        {
            salonManagerBL.addBL(salon);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult AddSalon()
        {
            return View();
        }
        public ActionResult deleteSalon(int id)
        {
            var salon = salonManagerBL.getById(id);
            salon.durum = false;
            salonManagerBL.update(salon);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult updateSalon(int id)
        {
            var salon = salonManagerBL.getById(id);
            return View(salon);
        }
        [HttpPost]
        public ActionResult updateSalon(Salon salon)
        {
            salonManagerBL.update(salon);
            return RedirectToAction("Index");
        }
    }
}