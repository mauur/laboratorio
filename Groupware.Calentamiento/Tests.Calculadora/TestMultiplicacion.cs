using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Core.Numero;

namespace Tests.Calculadora
{
    class TestMultiplicacion
    {

        [TestMethod]
        public void Multiplicacion()
        {
            //definicion del escenario
            Numero elPrimerOperando = new Numero("2", 10);
            Numero elSegundoOperando = new Numero("2", 10);
            Numero elResultadoEsperado = new Numero("4", 10);
            Numero elResultadoReal;

            //Invoque el metodo que se prueba
            var laReferencia = new Core.Numero.Dominio.Acciones.Multiplicacion();
            elResultadoReal = laReferencia.MultiOperar(elPrimerOperando, elSegundoOperando);

            //Verificar si el resultado obtenido es el mismo que es el espereado
            Assert.AreEqual<Numero>(elResultadoEsperado, elResultadoReal);
        }







    }
}
