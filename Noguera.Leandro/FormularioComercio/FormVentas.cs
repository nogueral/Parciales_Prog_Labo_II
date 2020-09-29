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
    public partial class FormVentas : Form
    {
        List<Venta> auxListaVentas;

        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        public FormVentas()
        {
            InitializeComponent();
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Carga inicial del datagridview de empleados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormVentas_Load(object sender, EventArgs e)
        {
            this.dgvListaEmpleados.DataSource = Inventario.GetListaEmpleados();
        }

        /// <summary>
        /// Utiliza el id del empleado seleccionado por el usuario para mostrar el listado de compras
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvListaEmpleados_DoubleClick(object sender, EventArgs e)
        {
            int idEmpleado = (int)this.dgvListaEmpleados.CurrentRow.Cells["IdEmpleado"].Value;
            string nombre = (string)this.dgvListaEmpleados.CurrentRow.Cells["Nombre"].Value;
            string apellido = (string)this.dgvListaEmpleados.CurrentRow.Cells["Apellido"].Value;

            auxListaVentas = Inventario.VentasPorEmpleado(idEmpleado);

            this.lblEmpleado.Text = String.Concat("Empleado: ", nombre, ", ", apellido);
            this.CargarDatagrid();

        }

        /// <summary>
        /// Carga del datagridview
        /// </summary>
        private void CargarDatagrid()
        {
            this.dgvListaVentas.DataSource = null;
            this.dgvListaVentas.DataSource = auxListaVentas;
        }
        #endregion
    }
}
