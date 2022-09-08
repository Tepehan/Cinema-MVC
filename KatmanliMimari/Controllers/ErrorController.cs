using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KatmanliMimari.Controllers
{
    [AllowAnonymous]
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Error400()
        {
            Response.StatusCode = 400;
            Response.TrySkipIisCustomErrors = true;
            return View();
        }

        public ActionResult Error401()
        {
            Response.StatusCode = 401;
            Response.TrySkipIisCustomErrors = true;
            return View();
        }
        public ActionResult Error402()
        {
            Response.StatusCode = 402;
            Response.TrySkipIisCustomErrors = true;
            return View();
        }
        public ActionResult Error403() {
            Response.StatusCode = 403;
            Response.TrySkipIisCustomErrors = true;
            return View();
        }
        public ActionResult Error404()
        {
            Response.StatusCode = 404;
            Response.TrySkipIisCustomErrors = true;
            return View();
        }
    }
}