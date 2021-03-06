﻿using Comercio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace FormularioComercio
{
    public partial class FormCompra : Form
    {
        List<Compra> listaCompras;
        double auxMontoTotal;
        SoundPlayer auxSonido;
        string directorio = Directory.GetCurrentDirectory();
        bool compraEfectuada = false;

        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        public FormCompra()
        {
            InitializeComponent();
            listaCompras = new List<Compra>();
            auxSonido = new SoundPlayer();
            auxMontoTotal = 0;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Carga inicial del formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCompraClienteExistente_Load(object sender, EventArgs e)
        {
            this.dgvProductos.DataSource = Inventario.ListaProductos;
            auxSonido.SoundLocation = String.Concat(directorio, "/deskbell.wav");
        }

        /// <summary>
        /// Carga actualizada de los datagridviews
        /// </summary>
        private void CargarDatagrid()
        {
            this.dgvProductos.DataSource = null;
            this.dgvProductos.DataSource = Inventario.ListaProductos;
            this.dgvCompra.DataSource = null;
            this.dgvCompra.DataSource = this.listaCompras;
        }

        /// <summary>
        /// Al hacer doble click sobre una fila, elimina el elemento de la lista de compras
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvCompra_DoubleClick(object sender, EventArgs e)
        {
            if (listaCompras.Count > 0)
            {
                double auxPrecio = (double)dgvCompra.CurrentRow.Cells["Precio"].Value;
                double auxId = (double)dgvCompra.CurrentRow.Cells["IdCompra"].Value;

                // recorre la lista y elimina el objeto

                for (int i = 0; i < listaCompras.Count; i++)
                {
                    if (listaCompras[i].IdCompra == auxId)
                    {
                        listaCompras.Remove(listaCompras[i]);
                        break;
                    }
                }

                // elimina el valor del monto total

                auxMontoTotal -= auxPrecio;

                // recorre el listado de productos, y aumenta el stock del objeto eliminado

                for (int i = 0; i < Inventario.ListaProductos.Count; i++)
                {
                    if (Inventario.ListaProductos[i].Id == auxId)
                    {
                        Inventario.ListaProductos[i].Stock += 1;
                    }
                }

                // actualiza los datagridviews y el label que muestra el valor total

                CargarDatagrid();
                lblMontoTotal.Text = auxMontoTotal.ToString();
            }
        }

        /// <summary>
        /// Al hacer doble click, agrega un producto a la lista de compras
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvProductos_DoubleClick(object sender, EventArgs e)
        {
            string auxDescripcion;
            double auxPrecio;
            int idProducto;
            int auxCantidad;


            if (int.TryParse(this.txtCantidad.Text, out auxCantidad))
            {
                auxDescripcion = (string)dgvProductos.CurrentRow.Cells["Descripcion"].Value;
                auxPrecio = (double)dgvProductos.CurrentRow.Cells["Precio"].Value;
                idProducto = (int)dgvProductos.CurrentRow.Cells["Id"].Value;

                if (!Validar.CerosYnegativos(auxCantidad))
                {
                    if (Inventario.ValidarCantidad(idProducto, auxCantidad))
                    {
                        //Carga la cantidad solicitada de productos a la lista

                        for (int i = 0; i < auxCantidad; i++)
                        {
                            listaCompras.Add(new Compra(auxDescripcion, auxPrecio, idProducto));
                        }

                        // Recorre la lista de productos y cuando la encuentra, reduce el stock 

                        for (int i = 0; i < Inventario.ListaProductos.Count; i++)
                        {
                            if (idProducto == Inventario.ListaProductos[i].Id)
                            {
                                Inventario.ListaProductos[i].Stock -= auxCantidad;
                            }
                        }

                        // actualiza el monto total, los datagridviews y el monto mostrado a traves del label

                        auxMontoTotal += (auxPrecio * auxCantidad);
                        lblMontoTotal.Text = auxMontoTotal.ToString();
                        CargarDatagrid();

                    }
                    else
                    {
                        MessageBox.Show("No hay suficiente stock del producto solicitados", Inventario.NombreComercio);
                    }

                } else
                {
                    MessageBox.Show("La cantidad no puede ser 0 ni un numero negativo", Inventario.NombreComercio);
                }

            } else
            {
                MessageBox.Show("Por favor, agregue cantidad antes de continuar", Inventario.NombreComercio);
            }

            this.txtCantidad.Clear();
        }

        /// <summary>
        /// Genera una nueva compra, con un cliente nuevo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCargarCliente_Click(object sender, EventArgs e)
        {
            

            if (listaCompras.Count > 0)
            {
                FormClienteNuevo auxClienteNuevo = new FormClienteNuevo();
                

                if (auxClienteNuevo.ShowDialog() == DialogResult.OK)
                {
                    if (Inventario.ValidarCliente(auxClienteNuevo.AuxCliente))
                    {
                        //Agrega venta, a la lista de ventas 

                        Inventario.ListaVentas.Add(new Venta(Inventario.EmpleadoLogueado, auxClienteNuevo.AuxCliente,
                        this.listaCompras, this.auxMontoTotal));

                        compraEfectuada = true;

                        // Si el cliente es miembro de la familia Simpson, aplica descuento.

                        MessageBox.Show("Por ser miembros de la familia Simpson tiene un descuentos del 13%", Inventario.NombreComercio);
                        double descuento = (auxMontoTotal * 13) / 100;
                        double montoOriginal = auxMontoTotal;
                        auxMontoTotal = montoOriginal - descuento;
                        MessageBox.Show(String.Format("Total compras: ${0:#,###.00}\n Descuentos (13%): S{1:#,###.00}\n Montos abonados: ${2:#,###.00}",
                       montoOriginal, descuento, auxMontoTotal), Inventario.NombreComercio);

                        // genera comprobante de compra

                        PrintTicket(auxClienteNuevo.AuxCliente, montoOriginal, descuento);
                    }
                    else
                    {
                        MessageBox.Show(String.Format("Montos abonados: ${0:#,###.00}", auxMontoTotal), Inventario.NombreComercio);

                        //Agrega venta, a la lista de ventas 

                        Inventario.ListaVentas.Add(new Venta(Inventario.EmpleadoLogueado, auxClienteNuevo.AuxCliente,
                        this.listaCompras, this.auxMontoTotal));

                        compraEfectuada = true;

                        // genera comprobante de compra

                        PrintTicket(auxClienteNuevo.AuxCliente);

                    }

                    // reproduce un sonido al finalizar la compra

                    auxSonido.Play();

                    DialogResult = DialogResult.OK;
                }

            }
            else
            {
                MessageBox.Show("Debe seleccionar algun articulos para continuar con la compras!", Inventario.NombreComercio);
            }


        }

        /// <summary>
        /// Imprime ticket de compra
        /// </summary>
        /// <param name="auxCliente"></param>
        private void PrintTicket(Cliente auxCliente)
        {
            StreamWriter auxComprobante = new StreamWriter(String.Concat(directorio, "/ticketCompra"));
            auxComprobante.WriteLine(Inventario.NombreComercio);
            auxComprobante.WriteLine($"Ticket Nro: {Inventario.ListaVentas[Inventario.ListaVentas.Count - 1].Ticket}");
            auxComprobante.WriteLine(DateTime.Now.ToLongDateString());
            auxComprobante.WriteLine(DateTime.Now.ToString("hh:mm:ss"));
            auxComprobante.WriteLine(String.Format($"Cliente: {auxCliente.Nombre} {auxCliente.Apellido}"));
            foreach (var item in this.listaCompras)
            {
                auxComprobante.WriteLine("Item: {0: -10} Precio: ${1:###,##.00}", item.Descripcion, item.Precio);
            }
            auxComprobante.WriteLine("Total a abonar: ${0:###,##.00}", auxMontoTotal);
            auxComprobante.WriteLine(String.Format($"Empleado: {Inventario.EmpleadoLogueado.Nombre} {Inventario.EmpleadoLogueado.Apellido}"));
            auxComprobante.WriteLine("Gracias! Vuelva prontosss");
            auxComprobante.Close();
        }

        /// <summary>
        /// Imprime ticket de compra (con descuento Simpson 13%)
        /// </summary>
        /// <param name="auxCliente"></param>
        /// <param name="montoOriginal"></param>
        /// <param name="descuento"></param>
        private void PrintTicket(Cliente auxCliente, double montoOriginal, double descuento)
        {
            StreamWriter auxComprobante = new StreamWriter(String.Concat(directorio, "/ticketCompra"));
            auxComprobante.WriteLine(Inventario.NombreComercio);
            auxComprobante.WriteLine($"Ticket Nro: {Inventario.ListaVentas[Inventario.ListaVentas.Count - 1].Ticket}");
            auxComprobante.WriteLine(DateTime.Now.ToLongDateString());
            auxComprobante.WriteLine(DateTime.Now.ToString("hh:mm:ss"));
            auxComprobante.WriteLine(String.Format($"Cliente: {auxCliente.Nombre} {auxCliente.Apellido}"));
            foreach (var item in this.listaCompras)
            {
                auxComprobante.WriteLine("Item: {0: -10} Precio: ${1:###,##.00}", item.Descripcion, item.Precio);
            }
            auxComprobante.WriteLine("Monto: ${0:###,##.00}", montoOriginal);
            auxComprobante.WriteLine("Descuento SIMPSON: ${0:###,##.00}", descuento);
            auxComprobante.WriteLine("Total a abonar: ${0:###,##.00}", auxMontoTotal);
            auxComprobante.WriteLine(String.Format($"Empleado: {Inventario.EmpleadoLogueado.Nombre} {Inventario.EmpleadoLogueado.Apellido}"));
            auxComprobante.WriteLine("Gracias! Vuelva prontosss");
            auxComprobante.Close();
        }

        /// <summary>
        /// Crea una nueva compra de un cliente existente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClienteExistente_Click(object sender, EventArgs e)
        {
            if (listaCompras.Count > 0)
            {
                FormClienteExistente auxClienteExistente = new FormClienteExistente();

                if (auxClienteExistente.ShowDialog() == DialogResult.OK)
                {
                    if (Inventario.ValidarCliente(auxClienteExistente.AuxCliente))
                    {
                        // si es miembro de la familia Simpson aplica descuento

                        MessageBox.Show("Por ser miembros de la familia Simpson tiene un descuentos del 13%", Inventario.NombreComercio);
                        double descuento = (auxMontoTotal) * 13 / 100;
                        double montoOriginal = auxMontoTotal;
                        auxMontoTotal = montoOriginal - descuento;
                        MessageBox.Show(String.Format("Total compras: ${0:#,###.00}\n Descuentos (13%): S{1:#,###.00}\n Montos abonados: ${2:#,###.00}",
                        montoOriginal, descuento, auxMontoTotal), Inventario.NombreComercio);

                        // Agrega venta a la lista de ventas 

                        Inventario.ListaVentas.Add(new Venta(Inventario.EmpleadoLogueado, auxClienteExistente.AuxCliente,
                        this.listaCompras, this.auxMontoTotal));

                        compraEfectuada = true;

                        // genera comprobante de compra

                        PrintTicket(auxClienteExistente.AuxCliente, montoOriginal, descuento);
                    }
                    else
                    {
                        MessageBox.Show(String.Format("Montos abonados: ${0:#,###.00}", auxMontoTotal), Inventario.NombreComercio);

                        // Agrega venta a la lista de ventas 

                        Inventario.ListaVentas.Add(new Venta(Inventario.EmpleadoLogueado, auxClienteExistente.AuxCliente,
                        this.listaCompras, this.auxMontoTotal));

                        compraEfectuada = true;

                        // genera comprobante de compra

                        PrintTicket(auxClienteExistente.AuxCliente);
                    }


                    // reproduce un sonido al finalizar la compra

                    auxSonido.Play();

                    DialogResult = DialogResult.OK;
                }

            }
            else
            {
                MessageBox.Show("Debe seleccionar algun articulos para continuar con la compras!", Inventario.NombreComercio);
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

        /// <summary>
        /// Si la compra no se efectua, se resstablece el stock inicial
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCompra_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!compraEfectuada)
            {
                for (int i = 0; i < listaCompras.Count; i++)
                {
                    for (int j = 0; j < Inventario.ListaProductos.Count; j++)
                    {
                        if(listaCompras[i].IdCompra == Inventario.ListaProductos[j].Id)
                        {
                            Inventario.ListaProductos[j].Stock++;
                            break;
                        }
                    }
                }
            }
        }


        #endregion


    }
}
