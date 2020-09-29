using Comercio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioComercio
{
    public partial class formProducto : Form
    {
        Producto auxProducto;

        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        public formProducto()
        {
            InitializeComponent();
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Convierte la primera letra en mayuscula y el resto en minusculas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDescripcion_Leave(object sender, EventArgs e)
        {
            this.txtDescripcion.Text = this.txtDescripcion.Text.Trim();
            this.txtDescripcion.Text = this.txtDescripcion.Text.ToLower();
            if (this.txtDescripcion.Text.Length > 2)
            {
                this.txtDescripcion.Text = String.Concat(Char.ToUpper(this.txtDescripcion.Text[0]), this.txtDescripcion.Text.Substring(1));
            }
        }

        /// <summary>
        /// Realiza la carga de producto a la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCargarProd_Click(object sender, EventArgs e)
        {
            double precio;
            int stock;
            int id;

            if(double.TryParse(this.txtPrecio.Text, out precio) && int.TryParse(this.txtStock.Text, out stock) 
                && !Validar.ValidarString(this.txtDescripcion.Text) && int.TryParse(this.txtId.Text, out id))
            {
                if(!Validar.CerosYnegativos(precio) && !Validar.CerosYnegativos(stock) && !Validar.CerosYnegativos(id))
                {
                    auxProducto = new Producto(this.txtDescripcion.Text, id, precio, stock);

                    if (Inventario.ListaProductos + auxProducto)
                    {
                        MessageBox.Show("Producto cargado con exitos", Inventario.NombreComercio);

                    }
                    else
                    {
                        MessageBox.Show("Producto previamente cargados", Inventario.NombreComercio);
                        MessageBox.Show("Solo se modifico el stock disponibles", Inventario.NombreComercio);
                    }

                    this.Limpiar();

                } else
                {
                    MessageBox.Show("Verificar campo numericos", Inventario.NombreComercio);
                }
           
            } else
            {
                MessageBox.Show("Verificar datos ingresados", Inventario.NombreComercio);
            }
        }

        /// <summary>
        /// Crea un formulario que muestra el stock
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStock_Click(object sender, EventArgs e)
        {
            FormStock auxStock = new FormStock();

            auxStock.Show();
            this.Limpiar();
        }

        /// <summary>
        /// Cierra el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Limpia los textbox
        /// </summary>
        private void Limpiar()
        {
            this.txtDescripcion.Clear();
            this.txtPrecio.Clear();
            this.txtStock.Clear();
            this.txtId.Clear();
        }

        /// <summary>
        /// Llama al metodo Limpiar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }
        #endregion
    }
}
