using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comercio
{
    public class Empleado : Persona
    {
        int idEmpleado;
        string usuario;

        #region Constructor
        /// <summary>
        /// Constructor de objetos de tipo Empleado
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="idEmpleado"></param>
        public Empleado(string nombre, string apellido, int idEmpleado, string usuario) : base(nombre, apellido)
        {
            this.idEmpleado = idEmpleado;
            this.usuario = usuario;
        }
        #endregion

        #region Properties
        /// <summary>
        /// Getter idEmpleado
        /// </summary>
        public int IdEmpleado
        {
            get { return this.idEmpleado; }
        }

        public string Usuario
        {
            get { return this.usuario; }
        }

        #endregion


    }
}
