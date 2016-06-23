using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Numero.Dominio.Validaciones
{
    public class ValidarBase
    {
        public bool LaBaseEstaEnElIntervaloCorrecto (int laBase)
        {
            bool resultado;
            resultado = (2 <= laBase) & (laBase <= 16);
            return (resultado);
        }

        public bool LasDosBasesSonIguiales (Numero elPrimerNumero, Numero elSengundoNumero)
        {
            bool resultado;
 
            resultado = (elPrimerNumero.laBase == elSengundoNumero.laBase);
            return (resultado); 
        }

        public String BaseCambiarNumero(Numero elNumero, int laBase)
        {
            string Numero = Convert.ToString(elNumero.elNumero);
            int fromBase = laBase;
            int toBase = 10;
            String primerNumero = Convert.ToString(Convert.ToInt32(Numero, fromBase),toBase);
            return (primerNumero);
        }

        public String BaseCambiarResultado(Numero elNumero, int laBase)
        {
            String Numero = elNumero.elNumero;
            int fromBase = 10;
            int toBase = laBase;

            String resultado = Convert.ToString(Convert.ToInt32(Numero, fromBase), toBase);
            return (resultado);
        }

    }
}
