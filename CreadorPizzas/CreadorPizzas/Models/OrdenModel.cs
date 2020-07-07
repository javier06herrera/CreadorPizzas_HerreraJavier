using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CreadorPizzas.Models
{
    public class OrdenModel
    {
        public String tamano { get; set; }

        public String grosor { get; set; }

        public String queso { get; set; }

        public bool[] ingredientesElegidos { get; set; }
        public String[] nombreImagenes =
        {
            "/Img/pepperoni.png",
            "/Img/jamón.png",
            "/Img/tocino.png",
            "/Img/salami.png",
            "/Img/chorizo.png",
            "/Img/carneMolida.png",
            "/Img/pollo.png",
            "/Img/champiñones.png",
            "/Img/piña.png",
            "/Img/jalapeños.png",
            "/Img/aceitunas.png",
            "/Img/cebolla.png",
            "/Img/chileDulce.png"
        };

        public String[] nombreIngredientes =
{
            "pepperoni",
            "jamón",
            "tocino",
            "salami",
            "chorizo",
            "carneMolida",
            "pollo",
            "champiñones",
            "piña",
            "jalapeños",
            "aceitunas",
            "cebolla",
            "chileDulce"
        };


        public int[] precios = {
            500,
            500,
            500,
            500,
            500,
            500,
            600,
            250,
            250,
            250,
            250,
            250,
            250,

        };

        public int precioBase = 2500;
        public int precioFinal { get; set; }
    }
}