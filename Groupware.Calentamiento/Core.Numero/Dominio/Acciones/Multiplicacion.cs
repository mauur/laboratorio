using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Numero.Dominio.Acciones
{
    public class Multiplicacion
    {

        public Numero MultiOperar(Numero elPrimerNumero, Numero elSegundoNumero, int base1, int base2)
        {
            Numero resultado = null;

            var validarBases = new Validaciones.ValidarBase();

            string PrimerNumero = validarBases.BaseCambiarNumero(elPrimerNumero, base1);
            string SegundoNumero = validarBases.BaseCambiarNumero(elSegundoNumero, base2);

            Numero numeroUno = new Numero(PrimerNumero, 10);
            Numero numeroDos = new Numero(SegundoNumero, 10);


            if (validarBases.LasDosBasesSonIguiales(numeroUno, numeroDos))
            {
                try
                {
                    double elResultadoNumerico = Convert.ToDouble(numeroUno.elNumero) * Convert.ToDouble(numeroDos.elNumero);
                    resultado = new Numero(Math.Round(elResultadoNumerico, 0).ToString(), base1);
                    resultado.elNumero = validarBases.BaseCambiarResultado(resultado, base1);
                }
                catch (OverflowException e)
                {
                    return new Numero( "El resultado es demasiado grande " + e.Message, 10 );
                }

            }
            return (resultado);
        }












    }
}
