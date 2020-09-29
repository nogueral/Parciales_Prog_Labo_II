using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comercio
{
    public class Compra
    {
        string descripcion;
        double precio;
        int idCompra;

        #region Constructores
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        private Compra()
        {
            this.descripcion = "Sin descripcion";
            this.precio = -1;
        }

        /// <summary>
        /// Constructor de objetos de tipo Compra
        /// </summary>
        /// <param name="descripcion"></param>
        /// <param name="precio"></param>
        /// /// <param name="idCompra"></param>
        public Compra(string descripcion, double precio, int idCompra):this()
        {
            this.descripcion = descripcion;
            this.precio = precio;
            this.idCompra = idCompra;
        }
        #endregion

        #region Properties
        /// <summary>
        /// Getter Descripcion
        /// </summary>
        public string Descripcion
        {
            get { return this.descripcion; }
        }

        /// <summary>
        /// 
        /// </summary>
        public double IdCompra
        {
            get { return this.idCompra; }
        }

        /// <summary>
        /// Getter Precio
        /// </summary>
        public double Precio
        {
            get { return this.precio; }
        }
        #endregion
    }


}
