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
    public partial class FormStock : Form
    {
        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        public FormStock()
        {
            InitializeComponent();
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Carga inicial de la pantalla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormStock_Load(object sender, EventArgs e)
        {  
            this.lblStockTotal.Text = Inventario.VerStock().ToString();

            CargarDatagridStockTotal();
        }

        /// <summary>
        /// Carga del datagridview
        /// </summary>
        private void CargarDatagridStockParcial()
        {
            List<Producto> auxLista;

            auxLista = Inventario.VerStock(10);

            this.lblEncabezadoDgv.Text = "Productos con menos de 10 unidades en stock:";

            this.dgvStockProductos.DataSource = null;

            this.dgvStockProductos.DataSource = auxLista;
        }

        /// <summary>
        /// Carga del datagridview
        /// </summary>
        private void CargarDatagridStockTotal()
        {
            this.lblEncabezadoDgv.Text = "Listado total de productos:";
            
            this.dgvStockProductos.DataSource = null;

            this.dgvStockProductos.DataSource = Inventario.ListaProductos;
        }

        /// <summary>
        /// Cerrar formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// Muestra el stock total de productos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStockTotal_Click(object sender, EventArgs e)
        {
            CargarDatagridStockTotal();
        }

        /// <summary>
        /// Muestra los productos con menos de 10 unidades en stock
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStockParcial_Click(object sender, EventArgs e)
        {
            CargarDatagridStockParcial();
        }

        #endregion

    }
}
