using Business.Concrete;
using Business.Validators;
using DataAccesLayer.Concrete.EntityFramework;
using Entity.Concrete;
using Entity.Concrete.Modals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using PagedList;

namespace KatmanliMimari.Controllers
{
    public class FilmController : Controller
    {
        FilmManagerBL filmManagerBL = new FilmManagerBL(new EfFilmDal());
        TurManager turManagerBL = new TurManager(new EfTurDal());
        TurFilmModal turFilmModal = new TurFilmModal();
        
        public ActionResult Index()
        {
            return View();
        }



        public ActionResult List(int pageNumber = 1) {
            turFilmModal.filmModal = filmManagerBL.ListBL().ToPagedList(pageNumber, 2);
            turFilmModal.turModal = turManagerBL.ListBL();
            return View(turFilmModal);
        }

        [HttpGet]
        public ActionResult AddFilm()
        {
            setTurViewBag();
            return View();
        }
        [HttpPost] //ekleme işlemi için
        public ActionResult AddFilm(Film film)
        {
            setTurViewBag();

            FilmValidator filmValidator = new FilmValidator();
            var result=filmValidator.Validate(film);
            if (result.IsValid)
            {

                filmManagerBL.AddBL(film);
                return RedirectToAction("List");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
                }
            }
            return View();
        }
        public ActionResult deleteFilm(int id) {
            var film = filmManagerBL.GetByIdBL(id);
            filmManagerBL.DeleteBL(film);
            return RedirectToAction("List");
        }
        [HttpGet]
        public ActionResult updateFilm(int id) {
            setTurViewBag();
            var film = filmManagerBL.GetByIdBL(id);
            return View(film) ;
        }
        [HttpPost]
        public ActionResult updateFilm(Film film)
        {


            setTurViewBag();
            filmManagerBL.UpdateBL(film);
            return RedirectToAction("List");
           
        }
        [HttpGet]
        public ActionResult filterByTur(int id) {
            turFilmModal.filmModal= filmManagerBL.GetListByTurBL(id);
            turFilmModal.turModal = turManagerBL.ListBL();
            return View(turFilmModal);
        }
        public PartialViewResult popup() {
            return PartialView();
        }
        public void setTurViewBag() {
            List<SelectListItem> items = (from turler in turManagerBL.ListBL()
                                          select new SelectListItem
                                          {
                                              Text = turler.turIsim,
                                              Value = turler.turId.ToString()
                                          }).ToList();
            ViewBag.tur = items;
        }
    }
}