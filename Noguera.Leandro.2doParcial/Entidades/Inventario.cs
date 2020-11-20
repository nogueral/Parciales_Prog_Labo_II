using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Archivo;

namespace Entidades
{
    public static class Inventario
    {
        static Queue<Pedido> pedidosEnPreparacion;
        static Queue<Pedido> pedidosEntregados;

        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        static Inventario()
        {
            pedidosEnPreparacion = new Queue<Pedido>();
            pedidosEntregados = new Queue<Pedido>();
        }
        #endregion

        #region Properties
        /// <summary>
        /// Getter cola de pedidos en preparacion
        /// </summary>
        public static Queue<Pedido> EnPreparacion
        {
            get { return pedidosEnPreparacion; }
        }

        /// <summary>
        /// Getter cola de pedidos entregados
        /// </summary>
        public static Queue<Pedido> Entregados
        {
            get { return pedidosEntregados; }
        }
        #endregion


        #region Metodos
        /// <summary>
        /// Trae datos desde archivo y los agrega a la cola
        /// </summary>
        public static void Hardcodeo()
        {
            List<Pedido> pedidos = Leer();


            foreach (Pedido pedido in pedidos)
            {
                pedidosEnPreparacion.Enqueue(pedido);
            }


        }

        /// <summary>
        /// Serializa una lista de pedidos
        /// </summary>
        /// <returns>true si se guardo, false caso contrario</returns>
        public static bool Guardar()
        {
            string path = String.Concat(AppDomain.CurrentDomain.BaseDirectory, "inventario.xml");
            Xml<List<Pedido>> auxPedidos = new Xml<List<Pedido>>();

            List<Pedido> pedidos = new List<Pedido>();
            pedidos.Add(new Pedido(Pedido.EPizza.Champignones, Pedido.EDelivery.Si, "Maipu 907", "123456"));
            Thread.Sleep(1000);
            pedidos.Add(new Pedido(Pedido.EPizza.CuatroQuesos));
            Thread.Sleep(1000);
            pedidos.Add(new Pedido(Pedido.EPizza.JamonYAnana));
            Thread.Sleep(1000);
            pedidos.Add(new Pedido(Pedido.EPizza.JamonYMorrones, Pedido.EDelivery.Si, "Salta 103", "22222"));
            Thread.Sleep(1000);
            pedidos.Add(new Pedido(Pedido.EPizza.Muzzarella));
            Thread.Sleep(1000);
            pedidos.Add(new Pedido(Pedido.EPizza.Napolitana));
            Thread.Sleep(1000);
            pedidos.Add(new Pedido(Pedido.EPizza.Roquefort, Pedido.EDelivery.Si, "Paraguay 679", "333333"));
            Thread.Sleep(1000);
            pedidos.Add(new Pedido(Pedido.EPizza.Champignones));
            Thread.Sleep(1000);
            pedidos.Add(new Pedido(Pedido.EPizza.CuatroQuesos, Pedido.EDelivery.Si, "Lima 556", "555555"));
            Thread.Sleep(1000);
            pedidos.Add(new Pedido(Pedido.EPizza.JamonYAnana));
            Thread.Sleep(1000);
            pedidos.Add(new Pedido(Pedido.EPizza.JamonYMorrones));
            Thread.Sleep(1000);
            pedidos.Add(new Pedido(Pedido.EPizza.Muzzarella, Pedido.EDelivery.Si, "Independencia 333", "4444444"));
            Thread.Sleep(1000);
            pedidos.Add(new Pedido(Pedido.EPizza.Napolitana));
            Thread.Sleep(1000);
            pedidos.Add(new Pedido(Pedido.EPizza.Roquefort));

            return auxPedidos.Guardar(path, pedidos);
        }

        /// <summary>
        /// Deserializa un listado de pedidos
        /// </summary>
        /// <returns>una List<> de tipo Pedido</returns>
        public static List<Pedido> Leer()
        {
            List<Pedido> datos = new List<Pedido>();
            string path = String.Concat(AppDomain.CurrentDomain.BaseDirectory, "inventario.xml");
            Xml<List<Pedido>> auxPedidos = new Xml<List<Pedido>>();

            auxPedidos.Leer(path, out datos);

            return datos;

        }
        #endregion
    }
}
