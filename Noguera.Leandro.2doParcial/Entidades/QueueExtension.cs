using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace System.Collections.Generic
{
    public static class QueueExtension
    {
        /// <summary>
        /// Cuenta la cantidad de pedidos generados de un tipo pasado por parametro
        /// </summary>
        /// <param name="pedidos"></param>
        /// <param name="tipo"></param>
        /// <returns>la cantidad de pedidos consultada</returns>
        public static int CantidadPedidos(this Queue<Pedido> pedidos, Pedido.EPizza tipo)
        {
            int acumulador = 0;

            foreach (Pedido item in pedidos)
            {
                if (item.Tipo == tipo)
                {
                    acumulador++;
                }
            }

            return acumulador;
        }

    }
}
