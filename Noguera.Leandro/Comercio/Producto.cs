using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comercio
{
#pragma warning disable CS0660
#pragma warning disable CS0661

    public class Producto
    {
        string descripcion;
        int idProducto;
        double precio;
        int stock;

        #region Constructores
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        private Producto()
        {
            this.descripcion = "sin descripcion";
            this.idProducto = -1;
            this.precio = -1;
            this.stock = -1;

        }
        /// <summary>
        /// Constructor de objetos de tipo Producto
        /// </summary>
        /// <param name="descripcion"></param>
        /// <param name="idProducto"></param>
        /// <param name="precio"></param>
        /// <param name="stock"></param>
        public Producto(string descripcion, int idProducto, double precio, int stock):this()
        {
            this.descripcion = descripcion;
            this.idProducto = idProducto;
            this.precio = precio;
            this.stock = stock;
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
        /// Getter ID
        /// </summary>
        public int Id
        {
            get { return this.idProducto; }
        }

        /// <summary>
        /// Getter Precio
        /// </summary>
        public double Precio
        {
            get { return this.precio; }
        }

        /// <summary>
        /// Setter / Getter Stock
        /// </summary>
        public int Stock
        {
            get { return this.stock; }

            set
            {
                this.stock = value;

                if (this.stock < 0)
                {
                    this.stock = 0;
                }
            }
        }
        #endregion

        #region Sobrecarga de operadores
        /// <summary>
        /// Sobrecarga operador ==
        /// </summary>
        /// <param name="listaProductos"></param>
        /// <param name="auxProducto"></param>
        /// <returns></returns>
        public static bool operator == (List<Producto> listaProductos, Producto auxProducto)
        {
            for (int i = 0; i < listaProductos.Count; i++)
            {
                if (listaProductos[i].idProducto == auxProducto.idProducto)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Sobrecarga operador !=
        /// </summary>
        /// <param name="listaProductos"></param>
        /// <param name="auxProducto"></param>
        /// <returns></returns>
        public static bool operator !=(List<Producto> listaProductos, Producto auxProducto)
        {
            return !(listaProductos == auxProducto);
        }

        /// <summary>
        /// Sobrecarga operador +
        /// </summary>
        /// <param name="listaProductos"></param>
        /// <param name="auxProducto"></param>
        /// <returns></returns>
        public static bool operator +(List<Producto> listaProductos, Producto auxProducto)
        {
            bool retorno=false;

            if(listaProductos != auxProducto)
            {
                listaProductos.Add(auxProducto);
                retorno = true;
                
            } else
            {
                for (int i = 0; i < listaProductos.Count; i++)
                {
                    if (listaProductos[i].idProducto == auxProducto.idProducto)
                    {
                        listaProductos[i].Stock = auxProducto.Stock;
                        
                    }
                }
            }

            return retorno;
        }

        #endregion

    }
}
