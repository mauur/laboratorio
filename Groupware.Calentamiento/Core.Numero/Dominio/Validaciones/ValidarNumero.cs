using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Numero.Dominio.Validaciones
{
    public class ValidarNumero
    {
        private static char[] base32 = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9',
                'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'n',
                'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w'};

        public bool ElNumeroEsValidoEnLaBase (string elNumero, int laBase)
        {
            bool elResultado = true;
            for(int i=0; (elResultado == true) & (i < elNumero.Length); i++)
            {
                elResultado = ElDigitoEsValidoEnLaBase(elNumero[i], laBase);
            }
            return (elResultado);
        }

        private bool ElDigitoEsValidoEnLaBase (char elDigito, int laBase)
        {
            for (int j = 0; j < laBase; j++)
                if (Char.ToLower(elDigito) == base32[j])
                    return true;
             
            return false;
        }
    }
}
