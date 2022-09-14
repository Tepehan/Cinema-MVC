using Business.Concrete;
using DataAccesLayer.Concrete.EntityFramework;
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
        public ActionResult Index()
        {
            var sliderlist=sliderManager.list();
            return View(sliderlist);
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