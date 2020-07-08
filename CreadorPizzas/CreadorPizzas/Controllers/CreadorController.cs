﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CreadorPizzas.Models;

namespace CreadorPizzas.Controllers
{

    public class CreadorController : Controller
    {
        private ServiciosController servicios = new ServiciosController();
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
            OrdenModel orden = TempData["Modelo"] as OrdenModel;
            TempData["Modelo"] = orden;
            //OrdenModel orden = new OrdenModel();
            return View(orden);
        }
        [HttpPost]
        public ActionResult Ingredientes(OrdenModel elecciones)
        {
            OrdenModel orden = TempData["Modelo"] as OrdenModel;
            orden.ingredientesElegidos = elecciones.ingredientesElegidos;
            TempData["Modelo"] = orden;
            return RedirectToAction("Resumen");
        }

        public ActionResult Resumen()
        {
            OrdenModel orden = TempData["Modelo"] as OrdenModel;
            servicios.crearFactura(ref orden);
            TempData["Modelo"] = orden;
            //OrdenModel orden = new OrdenModel();
            //servicios.generadorCaso(ref orden);
            return View(orden);
        }

        [HttpPost]
        public ActionResult Resumen(OrdenModel orden)
        {
            return RedirectToAction("Agradecimiento");
        }

        public ActionResult Agradecimiento()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Agradecimiento(OrdenModel orden)
        {
            return RedirectToAction("TamanoGrosor");
        }
    }

    
}