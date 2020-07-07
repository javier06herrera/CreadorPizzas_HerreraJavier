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
            return View();
        }
        [HttpPost]
        public ActionResult TamanoGrosor(OrdenModel orden)
        {
            TempData["Modelo"] = orden;
            return RedirectToAction("Ingredientes");
        }


        public ActionResult Ingredientes()
        {
            //OrdenModel orden = TempData["Modelo"] as OrdenModel;
            //TempData["Modelo"] = orden;
            OrdenModel orden = new OrdenModel();
            return View(orden);
        }
        [HttpPost]
        public ActionResult Ingredientes(OrdenModel orden)
        {
            TempData["Modelo"] = orden;
            return RedirectToAction("Ingredientes");
        }


    }

    
}