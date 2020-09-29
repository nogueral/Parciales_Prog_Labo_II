using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comercio
{

#pragma warning disable CS0660
#pragma warning disable CS0661

    public class Cliente : Persona
    {
        double dni;

        #region Constructor

        /// <summary>
        /// Constructor de objetos de tipo Cliente
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        public Cliente(string nombre, string apellido, double dni) : base(nombre, apellido)
        {

            this.dni = dni;
        }
        #endregion

        #region Properties

        /// <summary>
        /// Getter de atributo DNI
        /// </summary>
        public double Dni
        {
            get { return this.dni; }
        }
        #endregion

        #region Sobrecarga de operadores
        /// <summary>
        /// Sobrecarga operador ==
        /// </summary>
        /// <param name="listaPersonas"></param>
        /// <param name="auxCliente"></param>
        /// <returns></returns>
        public static bool operator ==(List<Cliente> listaClientes, Cliente auxCliente)
        {
            for (int i = 0; i < listaClientes.Count; i++)
             {
                 if (listaClientes[i].dni == auxCliente.dni)
                 {
                     return true;
                 }
             }

            return false;
        }

        /// <summary>
        /// Sobrecarga operador !=
        /// </summary>
        /// <param name="listaClientes"></param>
        /// <param name="auxCliente"></param>
        /// <returns></returns>
        public static bool operator !=(List<Cliente> listaClientes, Cliente auxCliente)
        {
            return !(listaClientes == auxCliente);
        }

        #endregion
    }
}
