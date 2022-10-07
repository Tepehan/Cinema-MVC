using Business.Concrete;
using DataAccesLayer;
using DataAccesLayer.Concrete.EntityFramework;
using Entity.Concrete;
using Entity.Concrete.Modals;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KatmanliMimari.Controllers
{
    
    public class HomeController : Controller
    {
        Context _context = new Context();

        SliderManager sliderManager = new SliderManager(new EfSliderDal());
        FilmManagerBL filmManager = new FilmManagerBL(new EfFilmDal());
        MenuManager menuManager = new MenuManager(new EfMenuDal());

        public ActionResult Index()
        {
            HomeModal modal = new HomeModal();
           
            _context.menuler.Load();

            var menus = _context.menuler.Include("children").OrderBy(m => m.menuName).ToList();
            var sliderList = sliderManager.listBL();
            var filmList = filmManager.ListBL();


            modal.filmModal = filmList;
            modal.sliderModal = sliderList;
            modal.menuModal = mapListToTreview(menus);



            return View(modal);
        }
        private List<Menu> mapListToTreview(List<Menu> menus)
        { //Menü listesi dönen bir fonksiyon oluşturdum. Parametre olarak menü listesi yollanıyor.
            var altMenuler = new List<Menu>(); // alt menüler için bir menü liste oluşturdum.
            foreach (var menu in menus)
            { //parametre olarak alınan menü listesini foreach ile döndürüyorum.
                altMenuler.Add(new Menu
                { //dönülen listeyi oluşturdugum alt listeye ekledim.
                    menuId = menu.menuId,
                    parentId = menu.parentId,
                    menuName = menu.menuName,
                    children = menu.children.Count > 0 ? mapListToTreview(menu.children.ToList()) // childleri varsa tekrardan recursive ediyor. Fonksiyon tekrardan çalışıyor. Yoksada boş liste dönüyor.
                        : new List<Menu>()
                });
            }
            return altMenuler;
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