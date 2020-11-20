using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace Entidades
{
    public static class ManejadorSQL
    {
        private static SqlConnection conexion;
        private static SqlCommand comando;

        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        static ManejadorSQL()
        {
            conexion = new SqlConnection();
            conexion.ConnectionString = "Data Source=.\\sqlexpress; Initial Catalog=ParcialDelivery; Integrated Security=True;";
            comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;

        }

        #endregion

        #region Metodos

        /// <summary>
        /// Ejecuta ExecuteNonQuery() en una conexion SQL
        /// </summary>
        /// <param name="sql"></param>
        /// <returns>True si se ejecuto, false caso contrario</returns>
        public static bool EjecutarNonQuery(string sql)
        {
            bool ejecuto = false;
            try
            {
                comando.CommandText = sql;

                if(conexion.State!=ConnectionState.Open)
                conexion.Open();

                comando.ExecuteNonQuery();
                ejecuto = true;
            }
            catch (Exception e)
            {
                ejecuto = false;
                throw new ArchivosException("Falla al intentar trabajar sobre la base de datos", e);
            }
            finally
            {
                conexion.Close();
            }

            return ejecuto;
        }

        /// <summary>
        /// Inserta un pedido a la base de datos
        /// </summary>
        /// <param name="pedido"></param>
        /// <returns>True si se guardo, false caso contrario</returns>
        public static bool InsertarPedido(Pedido pedido)
        {
            string sql = "Insert into Pedido(tipo, nroPedido, tieneDelivery, domicilio, telefono) " +
                "values(@auxTipo, @auxPedido, @auxDelivery, @auxDomicilio, @auxTelefono)";

            comando.Parameters.Clear();
            comando.Parameters.Add(new SqlParameter("@auxTipo", pedido.Tipo.ToString()));
            comando.Parameters.Add(new SqlParameter("@auxPedido", pedido.NroPedido));
            comando.Parameters.Add(new SqlParameter("@auxDelivery", pedido.TieneDelivery.ToString()));
            comando.Parameters.Add(new SqlParameter("@auxDomicilio", pedido.Domicilio));
            comando.Parameters.Add(new SqlParameter("@auxTelefono", pedido.Telefono));

            return EjecutarNonQuery(sql);
        }

        #endregion
    }
}
