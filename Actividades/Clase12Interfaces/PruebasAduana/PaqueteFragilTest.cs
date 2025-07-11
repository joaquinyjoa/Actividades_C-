using Microsoft.VisualStudio.TestTools.UnitTesting;
using Paquetes;

namespace PruebasCartuchera
{
    [TestClass]
    public class PaqueteFragilTest
    {
        [TestMethod]
        public void AplicarImpuestos_DeberiaRetornarCostoDeEnvioMasImpuestoAduana()
        {
            //Arrage
            string codigoSeguimiento = "das4sa54d5as4d";
            decimal costoEnvio = 45;
            string destino = "Bolivia";
            string origen = "Argentina";
            double pesoKG = 145;
            decimal impuestoEsperado = costoEnvio + (costoEnvio * 0.35M);

            PaqueteFragil paqueteFragil = new PaqueteFragil(codigoSeguimiento, costoEnvio, destino, origen, pesoKG);

            // Act
            decimal resultado = paqueteFragil.AplicarImpuestos();

            // Assert
            Assert.AreEqual(impuestoEsperado, resultado);
        }

        [TestMethod]
        public void Impuestos_DeberiaReotornarValorImpuestosDel35PorcientoSobreCostoEnvio() 
        {
            //Arrage
            string codigoSeguimiento = "das4sa54d5as4d";
            decimal costoEnvio = 45;
            string destino = "Bolivia";
            string origen = "Argentina";
            double pesoKG = 145;

            //Act
            PaqueteFragil paqueteFragil = new PaqueteFragil(codigoSeguimiento, costoEnvio, destino, origen, pesoKG);

            //Assert
            Assert.AreEqual(0.35M, ((IAduana)paqueteFragil).Impuestos);
        }

        [TestMethod]
        public void TienePrioridad_DeberiaRetornarTrue() 
        {
            //Arrage
            string codigoSeguimiento = "das4sa54d5as4d";
            decimal costoEnvio = 45;
            string destino = "Bolivia";
            string origen = "Argentina";
            double pesoKG = 145;

            //Act
            PaqueteFragil paqueteFragil = new PaqueteFragil(codigoSeguimiento, costoEnvio, destino,origen, pesoKG);
            
            //Assert
            Assert.IsTrue(paqueteFragil.TienePrioridad);
        }
    }
}