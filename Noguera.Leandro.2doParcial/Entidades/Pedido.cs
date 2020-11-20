using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivo;

namespace Entidades
{
    public class Pedido
    {
        public enum EPizza
        {
            Muzzarella,
            Roquefort,
            JamonYMorrones,
            JamonYAnana,
            CuatroQuesos,
            Champignones,
            Napolitana
        }

        public enum EDelivery
        {
            No,
            Si
        }

        EPizza tipo;
        string nroPedido;
        EDelivery tieneDelivery;
        string domicilio;
        string telefono;

        #region Constructores
        /// <summary>
        /// Constructor
        /// </summary>
        private Pedido()
        {
            this.nroPedido = DateTime.Now.ToString("HHmmss");
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="tipo"></param>
        public Pedido(EPizza tipo) : this()
        {
            this.tipo = tipo;
            this.tieneDelivery = EDelivery.No;
            this.domicilio = "Unknown";
            this.telefono = "Unknown";   
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="tipo"></param>
        /// <param name="tieneDelivery"></param>
        /// <param name="domicilio"></param>
        /// <param name="telefono"></param>
        public Pedido(EPizza tipo, EDelivery tieneDelivery, string domicilio, string telefono) :this()
        {
            this.tieneDelivery = tieneDelivery;
            this.domicilio = domicilio;
            this.telefono = telefono;
            this.tipo = tipo;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="tipo"></param>
        /// <param name="nroPedido"></param>
        /// <param name="tieneDelivery"></param>
        /// <param name="domicilio"></param>
        /// <param name="telefono"></param>
        public Pedido(EPizza tipo, string nroPedido, EDelivery tieneDelivery, string domicilio, string telefono) 
        {
            this.nroPedido = nroPedido;
            this.tieneDelivery = tieneDelivery;
            this.domicilio = domicilio;
            this.telefono = telefono;
        }
        #endregion

        #region Properties
        /// <summary>
        /// Setter / Getter tipo
        /// </summary>
        public EPizza Tipo
        {
            get { return this.tipo; }

            set { this.tipo = value; }

        }

        /// <summary>
        /// Setter / Getter numero pedido
        /// </summary>
        public string NroPedido
        {
            get { return this.nroPedido; }

            set { this.nroPedido = value; }

        }

        /// <summary>
        /// Setter / Getter delivery
        /// </summary>
        public EDelivery TieneDelivery
        {
            get { return this.tieneDelivery; }

            set { this.tieneDelivery = value; }
        }

        /// <summary>
        /// Setter / Getter domicilio
        /// </summary>
        public string Domicilio
        {
            get { return this.domicilio; }

            set { this.domicilio = value; }
        }

        /// <summary>
        /// Setter / Getter telefono
        /// </summary>
        public string Telefono
        {
            get { return this.telefono; }

            set { this.telefono = value; }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Sobrecarga ToString()
        /// </summary>
        /// <returns>retorna todos los datos del objetos</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Pedido Nro.: {this.nroPedido}");
            sb.AppendLine($"Item: Pizza de {this.tipo.ToString()}");
            sb.AppendLine($"Direccion: {this.domicilio}");
            sb.AppendLine($"Telefono: {this.telefono}");

            return sb.ToString();
        }

        /// <summary>
        /// Impime ticket con los datos del pedido
        /// </summary>
        /// <param name="pedido"></param>
        /// <returns>true si se imprimio, false caso contrario</returns>
        public static bool PrintTicket(Pedido pedido)
        {
            bool retorno = false;
            string path;

            if (pedido != null)
            {
                path = String.Concat(AppDomain.CurrentDomain.BaseDirectory, pedido.nroPedido.ToString());

                Texto texto = new Texto();

                texto.Guardar(path, pedido.ToString());
                retorno = true;
            }

            return retorno;
        }
        #endregion
    }
}
