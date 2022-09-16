using Business.Concrete;
using DataAccesLayer.Concrete.EntityFramework;
using Entity.Concrete.Modals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KatmanliMimari.Controllers
{
    public class HomeController : Controller
    {
       
        SliderManager sliderManager = new SliderManager(new EfSliderDal());
        FilmManagerBL filmmanagr = new FilmManagerBL(new EfFilmDal());
        public ActionResult Index()
        {
            HomeModal modal = new HomeModal();

            var sliderList=sliderManager.list();
            var filmList = filmmanagr.ListBL();
            modal.filmModal = filmList;
            modal.sliderModal = sliderList;
            return View(modal);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}