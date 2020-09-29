using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comercio
{
    public static class Validar
    {
        /// <summary>
        /// Verifica si el numero ingresado es menor o igual a 0
        /// </summary>
        /// <param name="auxNumero"></param>
        /// <returns>true si es menor a 0, false si no lo es</returns>
        public static bool CerosYnegativos(double auxNumero)
        {
            if (auxNumero <= 0)
            {
                return true;

            } else
            {
                return false;
            }
        }

        /// <summary>
        /// Verifica si el elemento ingresado es un string null, vacio o menor a 2 caracteres
        /// </summary>
        /// <param name="auxString"></param>
        /// <returns>true si cumple los requisitos, false si no los cumple</returns>
        public static bool ValidarString(string auxString)
        {
            if(String.IsNullOrEmpty(auxString) || auxString.Length < 2)
            {
                return true;

            } else
            {
                return false;
            }
        }
    }
}
