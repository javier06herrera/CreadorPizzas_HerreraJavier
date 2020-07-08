using System.Linq;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CreadorPizzas.Controllers;
using CreadorPizzas.Models;
namespace CreadorPizzas.Tests.Controllers
{
    [TestClass]
    public class CreadorTester
    {
        CreadorController controlador = new CreadorController();
        OrdenModel modelo = new OrdenModel();
        ServiciosController servicios = new ServiciosController();
        [TestMethod]
        public void pasoModelosTests()
        {
            var resultado = controlador.TamanoGrosor() as ViewResult;

            Assert.IsNotNull(resultado);
        }

        [TestMethod]
        public void generadorCasoTester()
        {

            servicios.generadorCaso(ref modelo);

            Assert.AreEqual(modelo.precioFinal, 13786);
        }

        [TestMethod]
        public void inicializadorTester()
        {

            servicios.inicializador(ref modelo);

            Assert.AreEqual(modelo.nombreIngredientes.Count(), modelo.ingredientesElegidos.Count());
        }

        [TestMethod]
        public void preciosTester()
        {

            int resultado = servicios.precio("Grande");

            Assert.AreEqual(resultado, 7000);
        }

        [TestMethod]
        public void calcularMontosTester()
        {

            servicios.inicializador(ref modelo);
            servicios.calcularMontos(ref modelo);

            Assert.AreEqual(modelo.impuestos, 2275);
        }

        [TestMethod]
        public void crearFacturaTester()
        {

            servicios.inicializador(ref modelo);
            servicios.crearFactura(ref modelo);

            Assert.AreEqual(modelo.precioFinal, 19775);
        }

    }
}
