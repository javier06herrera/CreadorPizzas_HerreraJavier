using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CreadorPizzas.Models;

namespace CreadorPizzas.Controllers
{
    public class CreadorController : Controller
    {
        // GET: Creador
        public ActionResult TamanoGrosor()
        {
            //OrdenModel orden = new OrdenModel();
            return View();
        }
        [HttpPost]
        public ActionResult TamanoGrosor(OrdenModel orden)
        {
            //OrdenModel orden = new OrdenModel();
            return View();
        }
    }

    
}