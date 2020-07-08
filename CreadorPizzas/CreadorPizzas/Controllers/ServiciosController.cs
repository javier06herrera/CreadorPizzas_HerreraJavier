using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CreadorPizzas.Models;

namespace CreadorPizzas.Controllers
{
    
    public class ServiciosController : Controller
    {
        public void initializer(ref OrdenModel orden)
        {

        }

        public void generadorCaso(ref OrdenModel orden)
        {
            orden.factura = new List<String>();
            orden.factura.Add("Tamaño: Grande");
            orden.factura.Add("2000");
            orden.factura.Add("Grosor: Pasta Gruesa");
            orden.factura.Add("500");
            orden.factura.Add("Mozarrela");
            orden.factura.Add("500");
            for (int index= 0; index < orden.nombreIngredientes.Count();index++)
            {
                orden.factura.Add(orden.nombreIngredientes[index]);
                orden.factura.Add(Convert.ToString(orden.precios[index]));
            }
            orden.precioFinal = Convert.ToInt32((orden.precios.Sum() + 3000)*1.13);
            orden.impuestos = Convert.ToInt32(orden.precioFinal - (orden.precioFinal / 1.13));
        }


    }
}