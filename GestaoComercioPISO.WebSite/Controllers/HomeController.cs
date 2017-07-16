using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GestaoComercioPISO.WebSite.Controllers
{
    public class HomeController : Controller
    {
        [Route("~/")]
        public ActionResult Index()
        {
            return View();
        }

       [Route("~/sobre")]
        public ActionResult About()
        {
            ViewBag.Message = "Esta é a descrição da minha aplicação";

            return View();
        }

        
        [Route("~/contato")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Esta é a minha pagina de contato";

            return View();
        }

    


    }
}