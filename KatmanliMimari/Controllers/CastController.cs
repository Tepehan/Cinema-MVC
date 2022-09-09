using Business.Concrete;
using Business.Validators;
using DataAccesLayer.Concrete.EntityFramework;
using Entity.Concrete;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KatmanliMimari.Controllers
{
    public class CastController : Controller
    {
        // GET: Cast
        CastManager castManager = new CastManager(new EfCastKadroDal());

        public ActionResult Index(int pageNumber = 1)
        {
            var castList = castManager.list().ToPagedList(pageNumber, 5);
            return View(castList);
        }

        [HttpGet]
        public ActionResult AddCast()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCast(CastKadro castKadro)
        {
            CastValidator validations = new CastValidator();
            var sonuc = validations.Validate(castKadro);
            if (sonuc.IsValid)
            {
                castManager.addBL(castKadro);
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
        public ActionResult deleteCast(int id)
        {
            var cast = castManager.getById(id);
            cast.durum = false;
            castManager.update(cast);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult updateCast(int id)
        {
            var cast = castManager.getById(id);
            return View(cast);
        }
        [HttpPost]
        public ActionResult updateCast(CastKadro castKadro)
        {
            castManager.update(castKadro);
            return RedirectToAction("Index");
        }
    }
}