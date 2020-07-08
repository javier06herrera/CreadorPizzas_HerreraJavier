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
        public void inicializador(ref OrdenModel model)
        {
            model.tamano = "Grande";
            model.grosor = "Gruesa";
            model.queso = "Parmesano";
            model.ingredientesElegidos = new bool[] { true, true, true, true, true, true, true, true, true, true, true, true };
        }
        

        public int precio(String propiedad)
        {
            switch (propiedad)
            {
                case "Pequeña":
                    return 3000;
                case "Mediana":
                    return 5000;
                case "Grande":
                    return 7000;
                case "Delgada":
                    return 500;
                case "Gruesa":
                    return 800;
                case "Parmesano":
                    return 1500;
                case "Mozzarella":
                    return 1000;
                case "Ricotta":
                    return 2000;
                default:
                    return 0;
            }
        }
        
        public void calcularMontos(ref OrdenModel orden)
        {
            orden.precioFinal = 0;
            orden.precioFinal += precio(orden.tamano);
            orden.precioFinal += precio(orden.grosor);
            orden.precioFinal += 500;
            for (int index=0; index<orden.ingredientesElegidos.Count(); index++)
            {
                if (orden.ingredientesElegidos[index])
                {
                    orden.precioFinal += orden.precios[index];
                }
            }
            orden.impuestos = Convert.ToInt32(orden.precioFinal * 0.13);
            orden.precioFinal += orden.impuestos;
        }

        public void crearFactura(ref OrdenModel orden)
        {
            orden.factura = new List<String>();
            orden.factura.Add("Tamaño: " + orden.tamano);
            orden.factura.Add(Convert.ToString(precio(orden.tamano)));
            orden.factura.Add("Grosor: " + orden.grosor);
            orden.factura.Add(Convert.ToString(precio(orden.grosor)));
            orden.factura.Add(orden.queso);
            orden.factura.Add(Convert.ToString(precio(orden.queso)));
            for (int index = 0; index < orden.ingredientesElegidos.Count(); index++)
            {
                if (orden.ingredientesElegidos[index])
                {
                    orden.factura.Add(orden.nombreIngredientes[index]);
                    orden.factura.Add(Convert.ToString(orden.precios[index]));
                }
            }
            calcularMontos(ref orden);
            orden.factura.Add("Impuesto de Ventas");
            orden.factura.Add(Convert.ToString(orden.impuestos));
        }

    }
}