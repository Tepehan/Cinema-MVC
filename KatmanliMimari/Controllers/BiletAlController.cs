﻿using Business.Concrete;
using DataAccesLayer;
using DataAccesLayer.Concrete.EntityFramework;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace KatmanliMimari.Controllers
{
    [AllowAnonymous]
    public class BiletAlController : Controller
    {
        FilmManagerBL _filmManager = new FilmManagerBL(new EfFilmDal());


        // GET: BiletAl
        public ActionResult GetById(string seo)
        {
            var film = _filmManager.GetBySeoBl(seo);
            return View(film);
        }
        
    }
}