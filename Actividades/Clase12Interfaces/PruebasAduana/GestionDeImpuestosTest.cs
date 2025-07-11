using Microsoft.VisualStudio.TestTools.UnitTesting;
using Paquetes;
using System.Collections.Generic;

namespace PruebasAduana
{
    [TestClass]
    public class GestionDeImpuestosTest
    {
        [TestMethod]
        public void CalcularTotalImpuestosAduana_DeberiaRetornarLaSumaDeLosImpuestosDeAduana() 
        {
            // Arrange: creo paquetes fragiles con costos y creo GestionImpuestos
            var paquete1 = new PaqueteFragil("ABC123", 100m, "Destino1", "Origen1", 5.0);
            var paquete2 = new PaqueteFragil("DEF456", 200m, "Destino2", "Origen2", 3.2);
            var paquete3 = new PaqueteFragil("GHI789", 150m, "Destino3", "Origen3", 4.5);

            List<Paquete> paquetesFragiles = new List<Paquete> { paquete1, paquete2, paquete3 };

            var gestion = new GestionImpuestos();

            // Act: registro los paquetes y calculo la suma de impuestos aduana
            gestion.RegistrarImpuestos(paquetesFragiles);
            decimal totalImpuestos = gestion.CalcularTotalImpuestosAduana();

            // Assert: calculo esperado manualmente
            // AplicarImpuestos() = costoEnvio + (costoEnvio * base.Impuestos)
            // Para PaqueteFragil base.Impuestos = 0.35M (de la clase base)
            // Entonces: total paquete = costoEnvio + costoEnvio*0.35M = costoEnvio * 1.35M

            decimal esperado = (100m * 1.35m) + (200m * 1.35m) + (150m * 1.35m); // = 135 + 270 + 202.5 = 607.5m

            Assert.AreEqual(esperado, totalImpuestos);
        }

        [TestMethod]
        public void CalcularTotalImpuestosAfip_DeberiaRetornarLaSumaDeLosImpuestosDeAfip() 
        {
            // Arrange: creo paquetes pesados con costos y creo GestionImpuestos
            var paquete1 = new PaquetePesado("AAA111", 100m, "Destino1", "Origen1", 10);
            var paquete2 = new PaquetePesado("BBB222", 200m, "Destino2", "Origen2", 20);
            var paquete3 = new PaquetePesado("CCC333", 150m, "Destino3", "Origen3", 15);

            List<Paquete> paquetesPesados = new List<Paquete> { paquete1, paquete2, paquete3 };

            var gestion = new GestionImpuestos();

            // Act: registro los paquetes y calculo la suma de impuestos afip
            gestion.RegistrarImpuestos(paquetesPesados);
            decimal totalImpuestosAfip = gestion.CalcularTotalImpuestosAfip();

            // Assert: calculo esperado manualmente
            // AplicarImpuestos() = costoEnvio + costoEnvio * (Impuestos + base.Impuestos)
            // PaquetePesado tiene:
            // Impuestos (new) = 0.25M
            // base.Impuestos = 0.35M
            // total impuesto adicional = 0.25 + 0.35 = 0.60
            // total paquete = costoEnvio + costoEnvio*0.60 = costoEnvio * 1.60

            decimal esperado = (100m * 1.60m) + (200m * 1.60m) + (150m * 1.60m); // 160 + 320 + 240 = 720m

            Assert.AreEqual(esperado, totalImpuestosAfip);
        }
    }
}
