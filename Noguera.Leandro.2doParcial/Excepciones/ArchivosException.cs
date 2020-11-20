using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ArchivosException : Exception
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="mensaje"></param>
        public ArchivosException(string mensaje) : base(mensaje)
        {

        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="mensaje"></param>
        /// <param name="innerException"></param>
        public ArchivosException(string mensaje, Exception innerException) : base(mensaje, innerException)
        {

        }

    }
}
