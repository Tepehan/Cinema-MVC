using Business.Concrete;
using DataAccesLayer.Concrete.EntityFramework;
using Entity.Concrete;
using Entity.Concrete.Modals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KatmanliMimari.Controllers {
    [Authorize(Roles = "Admin")]
    public class SalonFilmController : Controller
    {
        //Gerekli sınıfları türetiyoruz.
        SalonFilmManager sfm = new SalonFilmManager(new EfSalonFilmDal());
        FilmManagerBL fm = new FilmManagerBL(new EfFilmDal());
        SalonManager sm = new SalonManager(new EfSalonDal());
        SalonFilmModal salonFilmModal = new SalonFilmModal();
        // GET: SalonFilm
       
        public ActionResult Index()
        {
           var salonfilmlist= sfm.list();
            return View(salonfilmlist);
        }
       
        [HttpGet]
        public ActionResult addSalonfilm()
        {
            salonFilmModal.salonModal = sm.list();
            salonFilmModal.filmModal = fm.ListBL();
            
            return View(salonFilmModal);
        }
       
        [HttpPost]
        public ActionResult addSalonfilm(SalonFilm sf)
        {

            sfm.addBL(sf);
            return RedirectToAction("Index");
        }
        public ActionResult deleteSalonFilm(int id) {
            var sf=sfm.getBySalonFilmId(id);
            sf.durum = false;
            sfm.update(sf);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public ActionResult updateSalonFilm(int id) {
            var sf=sfm.getBySalonFilmId(id);
            salonFilmModal.salonFilmModal = sf;
            salonFilmModal.salonModal = sm.list();
            salonFilmModal.filmModal = fm.ListBL();
            return View(salonFilmModal);
        }
        [HttpPost]
        public ActionResult updateSalonFilm(SalonFilm salonFilm)
        {         
            sfm.update(salonFilm);
            return RedirectToAction("Index");
        }
    }
}