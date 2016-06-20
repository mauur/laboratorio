using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Numero.Dominio.Acciones
{
    public class Division
    {
        
        public Numero DividirOperar(Numero elPrimerNumero, Numero elSegundoNumero)
        {
            Numero resultado = null;
            Numero resultadoCero = null;

            var validarBases = new Validaciones.ValidarBase();

            if (elSegundoNumero.Equals(0))
            {
                resultadoCero = new Numero("El divisor no puede ser 0",10);

                return (resultadoCero);
            }

            else
            {

                if (validarBases.LasDosBasesSonIguiales(elPrimerNumero, elSegundoNumero))
                {
                    double elResultadoNumerico = (elPrimerNumero.elNumeroEnDecimal / elSegundoNumero.elNumeroEnDecimal);
                    //TODO: Covertir el resultado en la base 10 del punto anterior a la base de los numeros
                    //por ejemplo, originalmente, podria estar sumando "2A" + "3F" en base hexadecimal 
                    resultado = new Numero(elResultadoNumerico.ToString(), elPrimerNumero.laBase);
                }
                return (resultado);
            }

            
        }









    }
}
