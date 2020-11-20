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
using Excepciones;

namespace FormEntregas
{
    public partial class FormPedidos : Form
    {
        Pedido auxPedido;

        /// <summary>
        /// Constructor
        /// </summary>
        public FormPedidos()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Asigna el origen de datos de los combobox utilizados en el form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormPedidos_Load(object sender, EventArgs e)
        {
            this.cmbTipo.DataSource = Enum.GetValues(typeof(Pedido.EPizza));
            this.cmbDelivery.DataSource = Enum.GetValues(typeof(Pedido.EDelivery));
        }

        /// <summary>
        /// Limpia la pantalla
        /// </summary>
        private void Limpiar()
        {
            this.txtDomicilio.Clear();
            this.txtTelefono.Clear();
        }

        /// <summary>
        /// Llamada al metodo Limpiar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        /// <summary>
        /// Cierra el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Carga un nuevo pedido a la lista de entregas pendientes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((Pedido.EDelivery)this.cmbDelivery.SelectedValue == Pedido.EDelivery.No)
                {
                    auxPedido = new Pedido((Pedido.EPizza)this.cmbTipo.SelectedItem);
                    Inventario.EnPreparacion.Enqueue(auxPedido);
                    MessageBox.Show("Cargado con exito");
 
                }
                else
                {
                    if (!String.IsNullOrEmpty(this.txtDomicilio.Text) && !String.IsNullOrEmpty(this.txtTelefono.Text))
                    {
                        auxPedido = new Pedido((Pedido.EPizza)this.cmbTipo.SelectedItem, Pedido.EDelivery.Si, this.txtDomicilio.Text, this.txtTelefono.Text);
                        Inventario.EnPreparacion.Enqueue(auxPedido);
                        MessageBox.Show("Cargado con exito");
                    }
                    else
                    {
                        throw new PedidosException("Por favor, completar todos los campos para confirmar delivery");
                    }

                }
            }
            catch (PedidosException exc)
            {

                MessageBox.Show(exc.Message, "Pedidos");
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message, "Pedidos");
            }
            finally
            {
                this.Limpiar();
            }
        }
    }
}
