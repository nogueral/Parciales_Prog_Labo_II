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
            this.lblStockTotal.Text = Inventario.StockTotal().ToString();

            CargarDatagrid();
        }

        /// <summary>
        /// Carga del datagridview
        /// </summary>
        private void CargarDatagrid()
        {
            List<Producto> auxLista;

            auxLista = Inventario.StockParcial();

            this.dgvStockProductos.DataSource = null;

            this.dgvStockProductos.DataSource = auxLista;
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
        #endregion
    }
}
