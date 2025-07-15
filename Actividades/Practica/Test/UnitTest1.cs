using System;
using Herramientas;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HerramientasTests
{
    [TestClass]
    public class PersonajeTests
    {
        [TestMethod]
        [ExpectedException(typeof(BusinessException))]
        public void Constructor_DebeLanzarBusinessException_CuandoNivelEsInvalido()
        {
            // Arrange
            decimal id = 1;
            string nombre = "Invalid";
            short nivelInvalido = 150;

            // Act
            var personaje = new Guerrero(id, nombre, nivelInvalido);

            // Assert -> lo maneja el ExpectedException
        }

        [TestMethod]
        public void RecibirAtaque_NoDebeDejarVidaNegativa()
        {
            // Arrange
            var personaje = new Guerrero(1, "Test", 1);
            int ataqueFuerte = 10000;

            // Act
            personaje.RecibirAtaque(ataqueFuerte);

            // Assert
            Assert.AreEqual(0, personaje.PuntosDeVida);
        }

        [TestMethod]
        public void Guerrero_IniciaCon110DeDefensa()
        {
            // Arrange
            var guerrero = new Guerrero(1, "Leonidas", 1);

            // Act
            int defensaEsperada = 110;

            // Assert
            Assert.AreEqual(defensaEsperada, guerrero.PuntosDeDefensa);
        }
    }
}
