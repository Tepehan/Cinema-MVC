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
    public class CastController : Controller
    {
        // GET: Cast
        CastManager castManager = new CastManager(new EfCastKadroDal());

        public ActionResult Index()
        {
            var castList = castManager.list();
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
            castManager.addBL(castKadro);
            return RedirectToAction("Index");
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