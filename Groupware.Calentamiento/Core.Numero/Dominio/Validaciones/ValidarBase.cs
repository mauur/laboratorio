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


        public String BaseCambiarPrimero(Numero elPrimerNumero, int laBase)
        {

            string Primero = Convert.ToString(elPrimerNumero.elNumero);
            int fromBase = laBase;
            int toBase = 10;
            String primerNumero = Convert.ToString(Convert.ToInt32(Primero, fromBase),toBase);
            return (primerNumero);

            
        }

        public String BaseCambiarSegundo(Numero elSengundoNumero, int laBase)
        {
            string Segundo = Convert.ToString(elSengundoNumero.elNumero);
            int fromBase = laBase;
            int toBase = 10;

            String SegundoNumero = Convert.ToString(Convert.ToInt32(Segundo, fromBase), toBase);
            return (SegundoNumero);
        }









    }
}
