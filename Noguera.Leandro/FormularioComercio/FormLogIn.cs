using System;
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
    public partial class FormLogIn : Form
    {
        string auxUser;
        int contador = 0;

        #region Properties
        /// <summary>
        /// Getter del usuario logueado
        /// </summary>
        public string AuxUser
        {
            get { return auxUser; }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        public FormLogIn()
        {
            InitializeComponent();
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Carga inicial de usuarios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormLogIn_Load(object sender, EventArgs e)
        {
            Inventario.HardcodeoUsuarios();
        }

        /// <summary>
        /// Loguea al usuario, previa validacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool validarUsuario = false;
            

            if(!Validar.ValidarString(this.txtUsuario.Text) && !Validar.ValidarString(this.txtClave.Text))
            {
                contador++;

                foreach (var item in Inventario.ListaUsuarios)
                {

                    if(item.Key == this.txtUsuario.Text)
                    {
                        if(item.Value == this.txtClave.Text)
                        {
                            validarUsuario = true;

                            auxUser = item.Key;

                            DialogResult = DialogResult.Yes;
                        }
                    }
                }

                if (!validarUsuario)
                {

                    MessageBox.Show("Verifique clave o contraseña", Inventario.NombreComercio);
                }

                if (contador == 3)
                {
                    MessageBox.Show("Ha alcanzado el limite maximo de ingresos erroneos", Inventario.NombreComercio);
                    this.Close();
                }

                this.txtUsuario.Clear();
                this.txtClave.Clear();
               
            }
        }

        /// <summary>
        /// Boton de cierre
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
