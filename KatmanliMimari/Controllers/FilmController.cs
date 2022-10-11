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
using System.IO;
using DataAccesLayer;

namespace KatmanliMimari.Controllers
{
    public class FilmController : Controller
    {
        FilmManagerBL filmManagerBL = new FilmManagerBL(new EfFilmDal());
        TurManager turManagerBL = new TurManager(new EfTurDal());
        TurFilmModal turFilmModal = new TurFilmModal();
        //Context context = new Context();
        
        public ActionResult Index(int pageNumber = 1)
        {
            turFilmModal.filmModal = filmManagerBL.ListBL().ToPagedList(pageNumber, 20);
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
               Film sonuc= filmManagerBL.GetBySeoBl(film.seoUrl);
                if (sonuc!=null )
                {
                    ViewBag.seo = "zaten kullanılıyor";
                    return View();
                }
                filmManagerBL.AddBL(film);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
                }
            }
            //if (Request.Files.Count>10)
            //{
            //    string dosyaAdi = Path.GetFileName(Request.Files[0].FileName);
            //    string uzanti = Path.GetExtension(Request.Files[0].FileName);
            //    string yol = "/www/web/index/slider/" + dosyaAdi + uzanti;
            //    Request.Files[0].SaveAs(Server.MapPath(yol));
            //    film.afisUrl= "/www/web/index/slider/" + dosyaAdi + uzanti;
            //}
            //context.filmler.Add(film);
            //context.SaveChanges();

            return View();
        }
        public ActionResult deleteFilm(int id) {
            var film = filmManagerBL.GetByIdBL(id);
            filmManagerBL.DeleteBL(film);
            return RedirectToAction("Index");
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
            return RedirectToAction("Index");
           
        }
        public ActionResult searchByFilmName(String filmName) {
            var searchedList=filmManagerBL.GetListByFilmBL(filmName);
            return View(searchedList);
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