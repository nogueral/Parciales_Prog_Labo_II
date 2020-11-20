using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Archivo
{
    public class Xml<T> : IArchivo<T>
    {
        /// <summary>
        /// Guarda un archivo en formato xml
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns>true si se guardo correctamente, false caso contrario</returns>
        public bool Guardar(string archivo, T datos)
        {
            try
            {
                if (archivo != null)
                {
                    using (XmlTextWriter writer = new XmlTextWriter(archivo, Encoding.UTF8))
                    {
                        XmlSerializer ser = new XmlSerializer(typeof(T));

                        ser.Serialize(writer, datos);

                        return true;
                    }
                }
            }
            catch (Exception e)
            {

                throw new ArchivosException("Error al intentar guardar archivo xml", e);
            }

            return false;
        }

        /// <summary>
        /// Lee un archivo en formato xml
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns>true si se leyo correctamente, false caso contrario</returns>
        public bool Leer(string archivo, out T datos)
        {
            datos = default(T);

            try
            {
                if (File.Exists(archivo))
                {
                    using (XmlTextReader reader = new XmlTextReader(archivo))
                    {
                        XmlSerializer ser = new XmlSerializer(typeof(T));

                        datos = (T)ser.Deserialize(reader);

                        return true;
                    }
                }
            }
            catch (Exception e)
            {

                throw new ArchivosException("Error al intentar leer archivo xml", e);
            }

            return false;
        }
    }
}
