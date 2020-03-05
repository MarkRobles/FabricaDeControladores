using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FabricaDeControladores.Controllers
{
    public class HomeController : Controller
    {
        private ILogger Logger;

        public HomeController():this(new DefaultLogger())
        {

        }

       private HomeController(ILogger logger)
        {
            Logger = logger;
        }
        // GET: Home
        public ActionResult Index()
        {
            Logger.Write("En el metodo de accion index..");
           
            return Content("Bienvedidos!!!");
        }
    }
}