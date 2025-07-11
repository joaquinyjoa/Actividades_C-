using Microsoft.VisualStudio.TestTools.UnitTesting;
using Paquetes;

namespace PruebasAduana
{
    [TestClass]
    public class PaquetePesadoTest
    {
        [TestMethod]
        public void AplicarImpuestos_DeberiaRetornarCostoDeEnvioMasImpuestosAfipYAduana() 
        {
            //Arrage
            string codigoSeguimiento = "das4sa54d5as4d";
            decimal costoEnvio = 45;
            string destino = "Bolivia";
            string origen = "Argentina";
            double pesoKG = 145;
            decimal impuestoEsperado = costoEnvio + (costoEnvio * 0.35M) + (costoEnvio * 0.25M);

            PaquetePesado paquetePesado = new PaquetePesado(codigoSeguimiento, costoEnvio, destino, origen, pesoKG);

            // Act
            decimal resultado = paquetePesado.AplicarImpuestos();

            // Assert
            Assert.AreEqual(impuestoEsperado, resultado);
        }

        [TestMethod]
        public void Impuestos_DeberiaRetornarValorImpuestoDel25PorcientoSobreCostoEnvio_CuandoEsImplementacionExplicitaAfip() 
        {
            //Arrage
            string codigoSeguimiento = "das4sa54d5as4d";
            decimal costoEnvio = 45;
            string destino = "Bolivia";
            string origen = "Argentina";
            double pesoKG = 145;


            //Act
            PaquetePesado paquetePesado = new PaquetePesado(codigoSeguimiento, costoEnvio, destino, origen, pesoKG);

            //Assert
            Assert.AreEqual(0.25M, ((IAfip)paquetePesado).Impuestos);
        }

        [TestMethod]
        public void Impuestos_DeberiaRetornarValorImpuestoDel35PorcientoSobreCostoEnvio_CuandoEsImplementacionExplicita()
        {
            //Arrage
            string codigoSeguimiento = "das4sa54d5as4d";
            decimal costoEnvio = 45;
            string destino = "Bolivia";
            string origen = "Argentina";
            double pesoKG = 145;

            //Act
            PaquetePesado paquetePesado = new PaquetePesado(codigoSeguimiento, costoEnvio, destino, origen, pesoKG);

            //Assert
            Assert.AreEqual(0.35M, ((IAduana)paquetePesado).Impuestos);
        }

        [TestMethod]
        public void TienePrioridad_DeberiaRetornarFalse() 
        {
            //Arrage
            string codigoSeguimiento = "das4sa54d5as4d";
            decimal costoEnvio = 45;
            string destino = "Bolivia";
            string origen = "Argentina";
            double pesoKG = 145;

            //Act
            PaquetePesado paquetePesado = new PaquetePesado(codigoSeguimiento, costoEnvio, destino, origen, pesoKG);

            //Assert
            Assert.IsFalse(paquetePesado.TienePrioridad);
        }


    }
}
