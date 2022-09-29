using Business.Concrete;
using Business.Validators;
using DataAccesLayer.Concrete.EntityFramework;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KatmanliMimari.Controllers
{
    public class MenuController : Controller
    {
        MenuManager menuManager = new MenuManager(new EfMenuDal());

        // GET: Menu
        public ActionResult Index()
        {
            var menulist = menuManager.ListBL();
            return View(menulist);

        }

        [HttpPost]
        public ActionResult AddMenu(Menu menu)
        {
            MenuValidator validations = new MenuValidator();
            var sonuc = validations.Validate(menu);

            if (sonuc.IsValid)
            {
                menuManager.AddBL(menu);
                return RedirectToAction("Index");

            }
            else
            {
                foreach (var item in sonuc.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                var list = menuManager.ListBL();
                return View(list);
            }

         
        }
        [HttpGet]
        public ActionResult AddMenu()
        {
            var list= menuManager.ListBL();
            return View(list);
        }
        [HttpGet]
        public ActionResult updateMenu(int id)
        {
            var menu = menuManager.GetByIdBL(id);
            return View(menu);
        }
        [HttpPost]
        public ActionResult updateMenu(Menu menu)
        {
            menuManager.UpdateBL(menu);
            return RedirectToAction("Index");
        }
        public ActionResult deleteMenu(int id)
        {
            var menu = menuManager.GetByIdBL(id);
            menu.durum = false;
            menuManager.DeleteBL(menu);
            return RedirectToAction("Index");

        }
    }
}