using Business.Concrete;
using DataAccesLayer.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entity.Concrete;
using Business.Validators;
using PagedList;

namespace KatmanliMimari.Controllers
{
    public class TurController : Controller
    {
        TurManager turManager = new TurManager(new EfTurDal());
        // GET: Tur
        public ActionResult Index(int pageNumber=1)
        {
            var turList= turManager.ListBL().ToPagedList(pageNumber, 5);
            return View(turList);
        }
        [HttpPost]
        public ActionResult AddTur(Tur tur)
        {
            TurValidator validations = new TurValidator();
            var sonuc = validations.Validate(tur);

            if (sonuc.IsValid)
            {
                turManager.AddBL(tur);
                return RedirectToAction("Index");
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
        [HttpGet]
        public ActionResult AddTur()
        {
            return View();
        }
        public ActionResult deleteTur(int id)
        {
            var tur = turManager.getTurById(id);
            tur.durum = false;
            turManager.UpdateBL(tur);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult updateTur(int id)
        {
            var tur = turManager.getTurById(id);
            return View(tur);
        }
        [HttpPost]
        public ActionResult updateTur(Tur tur)
        {
            turManager.UpdateBL(tur);
            return RedirectToAction("Index");
        }
        //Bu bir yorum satırı
    }
}