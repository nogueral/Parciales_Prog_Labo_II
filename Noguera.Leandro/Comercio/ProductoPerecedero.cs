using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comercio
{

    public class ProductoPerecedero : Producto
    {
        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="descripcion"></param>
        /// <param name="idProducto"></param>
        /// <param name="precio"></param>
        /// <param name="stock"></param>
        /// <param name="tipoProducto"></param>
        public ProductoPerecedero(string descripcion, int idProducto, double precio, int stock, ETipo tipoProducto) : base(descripcion, idProducto, precio, stock, tipoProducto)
        {

        }
        #endregion

        #region Metodos
        /// <summary>
        /// override del metodo Mostrar
        /// </summary>
        /// <returns></returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("PRODUCTO PERECEDERO");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("Recuerde que este producto debe conservarse a baja temperatura");


            return sb.ToString();
        }
        #endregion
    }


}
