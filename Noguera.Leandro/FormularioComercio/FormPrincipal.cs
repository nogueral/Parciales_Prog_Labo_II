﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Comercio;

namespace FormularioComercio
{
    public partial class FormPrincipal : Form
    {
        bool login = false;

        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        public FormPrincipal()
        {
            InitializeComponent();
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Llama al metodo cargar producto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnProducto_Click(object sender, EventArgs e)
        {
            CargarProducto();
        }

        /// <summary>
        /// Llama al metodo cargar producto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cargarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CargarProducto();
        }


        /// <summary>
        /// Crea un formulario de tipo producto
        /// </summary>
        private void CargarProducto()
        {
            formProducto auxProducto = new formProducto();

            auxProducto.Show();
        }

        /// <summary>
        /// Realiza el login. Carga inicial de clientes, empleados, productos y compras.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormularioComercio_Load(object sender, EventArgs e)
        {
            Inventario.HardcodeoClientes();
            Inventario.HardcodeoEmpleados();
            Inventario.HardcodeoProductosNoPerecederos();
            Inventario.HardcodeoProductosPerecederos();
            Inventario.HardcodeoCompras();

            FormLogIn auxLogin = new FormLogIn();

            if (auxLogin.ShowDialog() == DialogResult.Yes)
            {
                MessageBox.Show("Login exitoso", Inventario.NombreComercio);

                Inventario.AuxEmpleadoLogueado(auxLogin.AuxUser);

                login = true;

            } else
            {
                this.Close();
            }


        }

        /// <summary>
        /// Crea un formulario que muestra el stock
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStock_Click(object sender, EventArgs e)
        {
            VerStock();
        }

        /// <summary>
        /// Crea un formulario que muestra el stock
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void verStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerStock();
        }

        /// <summary>
        /// Crea un formulario que muestra el stock
        /// </summary>
        private void VerStock()
        {
            FormStock auxStock = new FormStock();

            auxStock.Show();
        }


        /// <summary>
        /// Llama al metodo ListaVentas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVenta_Click(object sender, EventArgs e)
        {
            ListaVentas();
        }

        /// <summary>
        /// Llama al metodo ListaVentas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listadoVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaVentas();
        }

        /// <summary>
        /// Crea un formulario que muestra el listado de ventas
        /// </summary>
        private void ListaVentas()
        {
            FormVentas auxFormVentas = new FormVentas();

            auxFormVentas.Show();
        }

        /// <summary>
        /// Llama al metodo NuevaCompra
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCompra_Click(object sender, EventArgs e)
        {
            NuevaCompra();
        }

        /// <summary>
        /// Llama al metodo NuevaCompra
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nuevaCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevaCompra();
        }

        /// <summary>
        /// Crea un formulario de compra
        /// </summary>
        private void NuevaCompra()
        {
            FormCompra auxFormClienteExistente = new FormCompra();

            if (auxFormClienteExistente.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Gracias!! Vuelva prontosss", "Kwik E Mart");
            }
        }

        /// <summary>
        /// Confirma si el usuario quiere abandonar la aplicacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (login)
            {
                if (MessageBox.Show("Esta seguro que desea salir?", Inventario.NombreComercio, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            } 

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

        #endregion

    }
}
