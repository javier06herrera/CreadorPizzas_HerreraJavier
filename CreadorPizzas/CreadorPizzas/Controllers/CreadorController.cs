using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CreadorPizzas.Controllers
{
    public class CreadorController : Controller
    {
        // GET: Creador
        public ActionResult TamanoGrosor()
        {
            return View();
        }
    }
}