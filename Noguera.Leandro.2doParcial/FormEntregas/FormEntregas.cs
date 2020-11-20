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
using System.Threading;
using Excepciones;

namespace FormEntregas
{
    public delegate bool DelegadoDelivery(Pedido pedido);

    public partial class FormEntregas : Form
    {
        Thread hiloActualizar;
        public event DelegadoDelivery delivery;
        Random random;

        /// <summary>
        /// Constructor
        /// </summary>
        public FormEntregas()
        {
            InitializeComponent();
            hiloActualizar = new Thread(this.ActualizarPedidos);
            random = new Random();
        }

        /// <summary>
        /// Deserializa datos, inicializa la informacion de los datagridview, agrega metodos al evento, inicia el hilo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormEntregas_Load(object sender, EventArgs e)
        {

            try
            {
                //Inventario.Guardar();
                Inventario.Hardcodeo();

                this.ActualizarDatagridviewEnPreparacion();
                this.ActualizarDatagridviewEntregados();

                delivery += Pedido.PrintTicket;

                if (!hiloActualizar.IsAlive)
                {
                    hiloActualizar.Start();

                }
                else
                {
                    hiloActualizar.Abort();
                    hiloActualizar.Start();
                }


            }
            catch (ArchivosException exc)
            {
                MessageBox.Show(exc.Message);
                MessageBox.Show(exc.InnerException.Message);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }


        /// <summary>
        /// Actualiza los pedidos de la pantalla, desde "en preparacion" a "entregados"
        /// </summary>
        private void ActualizarPedidos()
        {
            try
            {
                while (true)
                {
                    //ActualizarEnPreparacion();
                    //Thread.Sleep(4000);

                    if (Inventario.EnPreparacion.Count > 0)
                    {
                        Pedido p1;
                        p1 = Inventario.EnPreparacion.Dequeue();
                        ManejadorSQL.InsertarPedido(p1);
                        Inventario.Entregados.Enqueue(p1);

                        if (p1.TieneDelivery == Pedido.EDelivery.Si)
                            delivery.Invoke(p1);

                        ActualizarEnPreparacion();
                        ActualizarEntregados();


                        if (this.lblPedidos.InvokeRequired)
                        {
                            this.lblPedidos.BeginInvoke((MethodInvoker)delegate ()
                            {
                                this.lblPedidos.Text = "Hay pedidos en preparacion";
                            });

                        }
                        else
                        {
                            this.lblPedidos.Text = "Hay pedidos en preparacion";
                        }

                        Thread.Sleep(random.Next(2000, 4000));

                    } else
                    {
                        if (this.lblPedidos.InvokeRequired)
                        {
                            this.lblPedidos.BeginInvoke((MethodInvoker)delegate ()
                            {
                                this.lblPedidos.Text = "No hay pedidos pendientes de entrega";
                            });

                        }
                        else
                        {
                            this.lblPedidos.Text = "No hay pedidos pendientes de entrega";
                        }
                    }

                    
                }

            }
            catch (ArchivosException exc)
            {
                MessageBox.Show(exc.Message);
                MessageBox.Show(exc.InnerException.Message);
            }
            catch (ThreadAbortException)
            {
                MessageBox.Show("Gracias, vuelva prontossss!");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }

        /// <summary>
        /// Verifica si es necesario llamar a un metodo de invocacion para actualizar los datos de pantalla
        /// </summary>
        private void ActualizarEnPreparacion()
        {
            if (this.dtvEnPreparacion.InvokeRequired)
            {
                this.dtvEnPreparacion.BeginInvoke((MethodInvoker)delegate ()
                {
                    ActualizarDatagridviewEnPreparacion();

                });
            }
            else
            {
                ActualizarDatagridviewEnPreparacion();
            }
        }

        /// <summary>
        /// Verifica si es necesario llamar a un metodo de invocacion para actualizar los datos de pantalla
        /// </summary>
        private void ActualizarEntregados()
        {
            if (this.dtvEntregados.InvokeRequired)
            {
                this.dtvEntregados.BeginInvoke((MethodInvoker)delegate ()
                {
                    ActualizarDatagridviewEntregados();
                });
            }
            else
            {
                ActualizarDatagridviewEntregados();
            }
        }

        /// <summary>
        /// Actualiza datagridview
        /// </summary>
        private void ActualizarDatagridviewEnPreparacion()
        {
            this.dtvEnPreparacion.DataSource = null;
            this.dtvEnPreparacion.DataSource = Inventario.EnPreparacion.ToArray();
        }

        /// <summary>
        /// Actualiza datagridview
        /// </summary>
        private void ActualizarDatagridviewEntregados()
        {
            this.dtvEntregados.DataSource = null;
            this.dtvEntregados.DataSource = Inventario.Entregados.ToArray();
        }

        /// <summary>
        /// Aborta el hilo al cerrar el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormEntregas_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (hiloActualizar.IsAlive)
                hiloActualizar.Abort();
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
        /// Crea una nueva instancia de formulario para armar pedidos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCargarPedido_Click(object sender, EventArgs e)
        {
            FormPedidos auxFormPedidos = new FormPedidos();
            auxFormPedidos.Show();
        }

        /// <summary>
        /// Crea una nueva instancia de formulario para verificar cantidad de productos vendidos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCantPedidos_Click(object sender, EventArgs e)
        {
            FormCantidad cantidad = new FormCantidad();
            cantidad.Show();
        }


    }
}
