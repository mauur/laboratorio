using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Core.Numero;

namespace Tests.Calculadora
{

    [TestClass]
    public class TestResta
    {
        
        [TestMethod]
        public void Resta()
        {
            //definicion del escenario
            Numero elPrimerOperando = new Numero("2", 10);
            Numero elSegundoOperando = new Numero("2", 10);
            Numero elResultadoEsperado = new Numero("0", 10);
            Numero elResultadoReal;

            //Invoque el metodo que se prueba
            var laReferencia = new Core.Numero.Dominio.Acciones.Resta();
            elResultadoReal = laReferencia.RestaOperar(elPrimerOperando, elSegundoOperando,10,10);

            //Verificar si el resultado obtenido es el mismo que es el espereado
            Assert.AreEqual<Numero>(elResultadoEsperado, elResultadoReal);
        }



    }
}
