using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comercio
{
    public class Venta
    {
        Empleado vendedor;
        Cliente comprador;
        List<Compra> listaCompra;
        double montoTotal;

        #region Constructores
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        private Venta()
        {
            listaCompra = new List<Compra>();
        }

        /// <summary>
        /// Constructor de objetos de tipo Venta
        /// </summary>
        /// <param name="vendedor"></param>
        /// <param name="comprador"></param>
        /// <param name="listaCompra"></param>
        /// <param name="montoTotal"></param>
        public Venta(Empleado vendedor, Cliente comprador, List<Compra> listaCompra, double montoTotal) : this()
        {
            this.vendedor = vendedor;
            this.comprador = comprador;
            this.listaCompra = listaCompra;
            this.montoTotal = montoTotal;
        }
        #endregion

        #region Properties
        /// <summary>
        /// Getter de atributo apellido del objeto de tipo Empleado
        /// </summary>
        public string ApellidoVendedor
        {
            get { return vendedor.Apellido; }
        }

        /// <summary>
        /// Getter de atributo ID del objeto de tipo Empleado
        /// </summary>
        public int Id
        {
            get { return vendedor.IdEmpleado; }
        }

        /// <summary>
        /// Getter de atributo apellido del objeto de tipo Cliente
        /// </summary>
        public string ApellidoCliente
        {
            get { return comprador.Apellido; }
        }

        /// <summary>
        /// Getter de atributo nombre del objeto de tipo Cliente
        /// </summary>
        public string NombreCliente
        {
            get { return comprador.Nombre; }
        }

        /// <summary>
        /// Getter de la cantidad de articulos contenidos en la lista
        /// </summary>
        public int CantArt
        {
            get { return listaCompra.Count; }

        }

        /// <summary>
        /// Getter del monto total de la compra
        /// </summary>
        public double Total
        {
            get { return montoTotal; }
        }

        #endregion


    }
}
