using Business.Concrete;
using Business.Validators;
using DataAccesLayer.Concrete.EntityFramework;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;

namespace KatmanliMimari.Controllers
{
    public class FilmCastKadroController : Controller
    {

        // GET: FilmCastKadro
        FilmCastKadroManager filmCastKadroManager = new FilmCastKadroManager(new EfFilmCastKadroDal());
        //FilmFilmCastKadroModal FilmFilmCastKadroModal = new FilmFilmCastKadroModal();
        FilmManagerBL filmManagerBL = new FilmManagerBL(new EfFilmDal());
        CastManager castManager = new CastManager(new EfCastKadroDal());

        public ActionResult Index(int pageNumber = 1)
        {
            var filmcastkadrolist = filmCastKadroManager.list().ToPagedList(pageNumber, 5);
            return View(filmcastkadrolist);
        }
        [HttpPost]
        public ActionResult AddFilmCastKadro(FilmCastKadro filmCastKadro)
        {
            setCastViewBag();
            setFilmViewBag();
            FilmCastKadroValidator filmValidator = new FilmCastKadroValidator();
            var result = filmValidator.Validate(filmCastKadro);
            if (result.IsValid)
            {

                filmCastKadroManager.addBL(filmCastKadro);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();


            
        }
        [HttpGet]
        public ActionResult AddFilmCastKadro()
        {
            setCastViewBag();
            setFilmViewBag();
            return View();
        }
        public ActionResult deleteFilmCastKadro(int id)
        {
            var filmCastKadro = filmCastKadroManager.getById(id);
            filmCastKadro.durum = false;
            filmCastKadroManager.update(filmCastKadro);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult updateFilmCastKadro(int id)
        {
            setCastViewBag();
            setFilmViewBag();
            var filmCastKadro = filmCastKadroManager.getById(id);
            return View(filmCastKadro);
        }
        [HttpPost]
        public ActionResult updateFilmCastKadro(FilmCastKadro filmCastKadro)
        {
            setCastViewBag();
            setFilmViewBag();
            filmCastKadroManager.update(filmCastKadro);
            return RedirectToAction("Index");
        }
        public void setFilmViewBag() {
            List<SelectListItem> items = (from filmler in filmManagerBL.ListBL()
                                          select new SelectListItem
                                          {
                                              Text = filmler.filmIsim,
                                              Value = filmler.filmId.ToString()
                                          }).ToList();
            ViewBag.film = items;
        }
        public void setCastViewBag()
        {
            List<SelectListItem> items = (from castlar in castManager.list()
                                          select new SelectListItem
                                          {
                                              Text = castlar.ad,
                                              Value = castlar.castKadroId.ToString()
                                          }).ToList();
            ViewBag.castKadro = items;
        }
    }
}