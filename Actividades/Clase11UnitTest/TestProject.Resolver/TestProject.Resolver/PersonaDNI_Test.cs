using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestUnitarios.ClassLibrary;

namespace TestProject.Resolver
{
    [TestClass]
    public class PersonaDNI_Test
    {
        /// <summary>
        /// Comprobar que el DNI en formato texto NO pueda tener:
        /// Coma
        /// Letras
        /// Arroja DniInvalidoException
        /// </summary>
        [TestMethod]
        public void DNI_Invalido_Texto()
        {
            //Arrange
            string dniComa = "30.999,999";
            string dniTexto = "30a00123";

            //Act y Assert
            try
            {
                Persona personaPrimero = new Persona("Juan", "Lopez", dniComa, ENacionalidad.Argentina);
                Assert.Fail("Sin excepción para DNI inválido: {0}.", dniComa);
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(DniInvalidoException));
            }

            //DniTexto
            //Act y Assert
            try
            {
                Persona personaPrimero = new Persona("Juan", "Lopez", dniTexto, ENacionalidad.Argentina);
                Assert.Fail("Sin excepción para DNI inválido: {0}.", dniTexto);
            }
            catch (DniInvalidoException e)
            {
                Assert.IsInstanceOfType(e, typeof(DniInvalidoException));
            }
        }

        /// <summary>
        /// Comprobar que el DNI no pueda ser menor a 1
        /// Arroja NacionalidadInvalidaException
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(NacionalidadInvalidaException))]
        public void DNI_Invalido_Bajo()
        {
            // Arrange
            int dni = 0; // DNI inválido para un extranjero (por ejemplo)

            // Act
            Persona personaPrimero = new Persona("Juan", "Lopez", dni, ENacionalidad.Argentina);

        }

        /// <summary>
        /// Comprobar que el DNI no pueda ser mayor a 99.999.999
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(NacionalidadInvalidaException))]
        public void DNI_Invalido_Alto()
        {
            // Arrange
            int dni = 1000000000; 

            // Act
            Persona personaPrimero = new Persona("Juan", "Lopez", dni, ENacionalidad.Argentina);
        }

        /// <summary>
        /// Comprobar los rangos de DNI para Argentinos
        /// </summary>
        [TestMethod]
        public void DNI_Validos_Argentino()
        {
            // Arrange
            int dniPrimero = 1;
            int dniMedio = new Random().Next(1, 89999999);
            int dniUltimo = 89999999;
            string dniString = "89999999";  

            // Act
            Persona pPrimero = new Persona("Juan", "Lopez", dniPrimero, ENacionalidad.Argentina);
            Persona pMedio = new Persona("Juan", "Lopez", dniMedio, ENacionalidad.Argentina);
            Persona pUltimo = new Persona("Juan", "Lopez", dniUltimo, ENacionalidad.Argentina);
            Persona pString = new Persona("Juan", "Lopez", int.Parse(dniString), ENacionalidad.Argentina);

            // Assert
            Assert.AreEqual(dniPrimero, pPrimero.DNI);
            Assert.AreEqual(dniMedio, pMedio.DNI);
            Assert.AreEqual(dniUltimo, pUltimo.DNI);
            Assert.AreEqual(int.Parse(dniString), pString.DNI);
        }

        /// <summary>
        /// Comprobar los rangos de DNI para Extranjeros
        /// </summary>
        [TestMethod]
        public void DNI_Validos_Extranjeros()
        {
            // Estos son valores dentro del rango válido para extranjeros según tu lógica (89999999 - 99999999)
            int dniMinValido = 89999999;
            int dniMedio = new Random().Next(89999999, 99999999);
            int dniMaxValido = 99999999;

            Persona pMin = new Persona("Juan", "Lopez", dniMinValido, ENacionalidad.Extranjera);
            Persona pMedio = new Persona("Juan", "Lopez", dniMedio, ENacionalidad.Extranjera);
            Persona pMax = new Persona("Juan", "Lopez", dniMaxValido, ENacionalidad.Extranjera);

            Assert.AreEqual(dniMinValido, pMin.DNI);
            Assert.AreEqual(dniMedio, pMedio.DNI);
            Assert.AreEqual(dniMaxValido, pMax.DNI);
        }

    }
}
