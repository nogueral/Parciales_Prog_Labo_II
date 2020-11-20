using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Excepciones
{

    public class PedidosException : Exception
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public PedidosException(string message) : base(message)
        {

        }
    }
}
