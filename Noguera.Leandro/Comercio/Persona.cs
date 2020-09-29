using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comercio
{
    public class Persona
    {
        protected string nombre;
        protected string apellido;

        #region Constructores

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        private Persona()
        {
            this.nombre = "Sin nombre";
            this.apellido = "Sin apellido";
        }

        /// <summary>
        /// Constructor de objetos de tipo persona
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        public Persona(string nombre, string apellido):this()
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Getter de atributo nombre
        /// </summary>
        public string Nombre
        {
            get { return this.nombre; }
        }

        /// <summary>
        /// Getter de atributo nombre
        /// </summary>
        public string Apellido
        {
            get { return this.apellido; }
        }
        #endregion
    }
}
