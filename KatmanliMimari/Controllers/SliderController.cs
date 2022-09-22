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
    public class SliderController : Controller
    {
        SliderManager sliderManager = new SliderManager(new EfSliderDal());
        // GET: Slider
        public ActionResult Index(int pageNumber = 1)
        {
            var sliderList = sliderManager.listBL().ToPagedList(pageNumber, 5);
            return View(sliderList);
        }
        [HttpPost]
        public ActionResult AddSlider(Slider slider)
        {
            SliderValidator validations = new SliderValidator();
            var sonuc = validations.Validate(slider);

            if (sonuc.IsValid)
            {
                sliderManager.Add(slider);
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
        public ActionResult AddSlider()
        {
            return View();
        }
        [HttpGet]
        public ActionResult updateSlider(int id)
        {
            var slider = sliderManager.getById(id);
            return View(slider);
        }
        [HttpPost]
        public ActionResult updateSlider(Slider slider)
        {
            sliderManager.update(slider);
            return RedirectToAction("Index");
        }
        public ActionResult deleteSlider(int id)
        {
            var slider = sliderManager.getById(id);
            sliderManager.Delete(slider);
            return RedirectToAction("Index");
        }
    }
}