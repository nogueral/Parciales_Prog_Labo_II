using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace FormEntregas
{
    public partial class FormCantidad : Form
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public FormCantidad()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Establece el origen de datos del combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCantidad_Load(object sender, EventArgs e)
        {
            this.cmbTipo.DataSource = Enum.GetValues(typeof(Pedido.EPizza));
        }

        /// <summary>
        /// Utiliza un metodo de extension para verificar la cantidad de pedidos entregados, del item seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int respuesta = Inventario.Entregados.CantidadPedidos((Pedido.EPizza)this.cmbTipo.SelectedItem);

            this.lblResultado.Text = String.Format($"Cantidad de pizzas de {this.cmbTipo.SelectedItem.ToString()} entregadas: {respuesta}");
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
    }
}
