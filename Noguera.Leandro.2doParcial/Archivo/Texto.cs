using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Excepciones;

namespace Archivo
{
    public class Texto : IArchivo<string>
    {
        /// <summary>
        /// Guarda un archivo en formato texto
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns>true si se guardo correctamente, false caso contrario</returns>
        public bool Guardar(string archivo, string datos)
        {
            try
            {

                if (!String.IsNullOrEmpty(archivo) && !String.IsNullOrEmpty(datos))
                {
                    using (StreamWriter sw = new StreamWriter(archivo, false))
                    {
                        sw.WriteLine(datos);
                    }

                    return true;
                }
            }
            catch (Exception e)
            {

                throw new ArchivosException("Error al intentar guardar archivo de texto", e);
            }

            return false;
        }

        /// <summary>
        /// Lee archivos en formato texto
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns>true si se leyo correctamente, false caso contrario</returns>
        public bool Leer(string archivo, out string datos)
        {
            try
            {
                datos = String.Empty;

                if (File.Exists(archivo))
                {
                    using (StreamReader sr = new StreamReader(archivo))
                    {
                        datos = sr.ReadToEnd();
                        return true;
                    }
                }
            }
            catch (Exception e)
            {

                throw new ArchivosException("Error al intentar leer archivo de texto", e);
            }

            return false;
        }
    }
}
