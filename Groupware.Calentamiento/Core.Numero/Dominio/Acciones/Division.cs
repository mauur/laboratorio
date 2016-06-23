using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Numero.Dominio.Acciones
{
    public class Division
    {
        
        public Numero DividirOperar(Numero elPrimerNumero, Numero elSegundoNumero,int base1, int base2)
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
                    double elResultadoNumerico = Convert.ToDouble(numeroUno.elNumero) / Convert.ToDouble(numeroDos.elNumero);
                    resultado = new Numero(Math.Round(elResultadoNumerico, 0).ToString(), base1);
                    resultado.elNumero = validarBases.BaseCambiarResultado(resultado, base1);
                }
                catch (DivideByZeroException e) {
                    return new Numero( "Se ha intentado dividir entre 0" + e.Message, 10 );
                }

            }
            return (resultado);
            
        }

    }
}
