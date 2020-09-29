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
    public partial class FormClienteExistente : Form
    {
        Cliente auxCliente;
        bool clickCliente = false;


        #region Properties
        /// <summary>
        /// Getter del objeto de tipo Cliente utilizado como auxiliar
        /// </summary>
        public Cliente AuxCliente
        {
            get { return this.auxCliente; }
        }

        #endregion

        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        public FormClienteExistente()
        {
            InitializeComponent();
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Cuando el usuario hace doble click sobre una fila, crea un objeto de tipo Cliente (lista de clientes existentes)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvCliente_DoubleClick(object sender, EventArgs e)
        {
            string nombre = (string)dgvCliente.CurrentRow.Cells["Nombre"].Value;
            string apellido = (string)dgvCliente.CurrentRow.Cells["Apellido"].Value;
            double dni = (double)dgvCliente.CurrentRow.Cells["Dni"].Value;

            auxCliente = new Cliente(nombre, apellido, dni);
            this.lblCliente.Text = String.Concat("Cliente: ", apellido, ", ", nombre);
            clickCliente = true;


        }


        /// <summary>
        /// Carga inicial de los datagridviews
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormClienteExistente_Load(object sender, EventArgs e)
        {
            CargarDatagrid();
        }

        /// <summary>
        /// Carga de listado datagridview
        /// </summary>
        private void CargarDatagrid()
        {
            this.dgvCliente.DataSource = null;
            this.dgvCliente.DataSource = Inventario.GetListaClientes();

        }

        /// <summary>
        /// Si el objeto Cliente se cargo correctamente, finaliza la operacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (clickCliente == true)
            {
                MessageBox.Show("Se agrego correctamente cliente la compras", Inventario.NombreComercio);
                DialogResult = DialogResult.OK;

            }
            else
            {
                MessageBox.Show("Debe seleccionar todos los campos antes de continuar", Inventario.NombreComercio);
            }
        }
        #endregion

    }
}
