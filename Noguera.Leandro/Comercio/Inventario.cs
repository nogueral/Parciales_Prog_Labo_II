using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comercio
{
    public static class Inventario
    {
        static List<Producto> listaProductos;
        static List<Venta> listaVentas;
        static List<Persona> listaPersonas;
        static Dictionary<string, string> listaUsuarios;
        static string nombreComercio;
        static Empleado empleadoLogueado;

        #region Constructor estatico
        /// <summary>
        /// Constructor estatico
        /// </summary>
        static Inventario()
        {
            nombreComercio = "Kwik E Mart";
            listaProductos = new List<Producto>();
            listaVentas = new List<Venta>();
            listaPersonas = new List<Persona>();
            listaUsuarios = new Dictionary<string, string>();
        }
        #endregion

        #region Properties
        /// <summary>
        /// Getter lista de productos
        /// </summary>
        public static List<Producto> ListaProductos
        {
            get { return listaProductos; }
        }

        /// <summary>
        /// Getter del empleado logueado
        /// </summary>
        public static Empleado EmpleadoLogueado
        {
            get { return empleadoLogueado; }
        }

        /// <summary>
        ///  Getter nombre del comercio
        /// </summary>
        public static string NombreComercio
        {
            get { return nombreComercio; }
        }

        /// <summary>
        ///  Getter lista de ventas
        /// </summary>
        public static List<Venta> ListaVentas
        {
            get { return listaVentas; }
        }

        /// <summary>
        ///  Getter lista de personas
        /// </summary>
        public static List<Persona> ListaPersonas
        {
            get { return listaPersonas; }
        }

        /// <summary>
        /// Getter del Dictionary con los usuarios y sus claves
        /// </summary>
        public static Dictionary<string, string> ListaUsuarios
        {
            get { return listaUsuarios; }
        }

        #endregion

        #region Metodos
        /// <summary>
        /// Devuelve el stock total de los productos cargados
        /// </summary>
        /// <returns></returns>
        public static int StockTotal()
        {
            int acumulador = 0;

            for (int i = 0; i < listaProductos.Count; i++)
            {
                acumulador += listaProductos[i].Stock;
            }

            return acumulador;
        }

        /// <summary>
        /// Devuelve una lista de productos con stock menor a 10 unidades
        /// </summary>
        /// <returns>List<> de tipo Producto</returns>
        public static List<Producto> StockParcial()
        {
            List<Producto> auxProductos = new List<Producto>();

            for (int i = 0; i < listaProductos.Count; i++)
            {
                if (listaProductos[i].Stock < 10)
                {
                    auxProductos.Add(listaProductos[i]);
                }
            }

            return auxProductos;
        }

        
        /// <summary>
        /// Valida si el elemento recibido contiene el apellido "Simpson"
        /// </summary>
        /// <param name="auxCliente"></param>
        /// <returns>True si es el apellido indicado, false caso contrario</returns>
        public static bool ValidarCliente(Cliente auxCliente)
        {

            if (auxCliente.Apellido == "Simpson")
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Valida si el valor de stock solicitado es menor al disponible
        /// </summary>
        /// <param name="idProducto"></param>
        /// <param name="auxCantidad"></param>
        /// <returns>Si hay stock disponible devuelve true. Caso contrario, false</returns>
        public static bool ValidarCantidad(int idProducto, int auxCantidad)
        {
            for (int i = 0; i < listaProductos.Count; i++)
            {
                if(listaProductos[i].Id == idProducto && listaProductos[i].Stock >= auxCantidad)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Hardcodeo de usuarios para login de empleados
        /// </summary>
        public static void HardcodeoUsuarios()
        {
            listaUsuarios.Add("lrodriguez", "rodriguez1");
            listaUsuarios.Add("eoggioni", "oggioni1");
            listaUsuarios.Add("fdavila", "davila1");

        }

        /// <summary>
        /// Hace una carga instantanea de 3 empleados
        /// </summary>
        public static void HardcodeoEmpleados()
        {
            string[] nombre = new string[3] { "Lucas", "Ezequiel", "Federico" };
            string[] apellido = new string[3] { "Rodriguez", "Oggioni", "Davila" };
            int[] id = new int[3] { 1, 2, 3 };
            string[] usuario = new string[3] { "lrodriguez", "eoggioni", "fdavila" };

            for (int i = 0; i < 3; i++)
            {
                listaPersonas.Add(new Empleado(nombre[i], apellido[i], id[i], usuario[i]));
            }
        }

        /// <summary>
        /// Hace una carga instantanea de 30 productos
        /// </summary>
        public static void HardcodeoProductos()
        {
            string[] descripcion = new string[30] { "Azucar", "Leche", "Yerba", "Chocolate", "Galletitas", "Pan lactal", "Queso",
            "Jabon", "Shampoo", "Acondicionador", "Miel", "Cereales", "Yogurt", "Fideos", "Gaseosa", "Jabon liquido",
            "Dulce de leche", "Crema", "Queso untable", "Te", "Arroz", "Jabon en polvo", "Mate cocido", "Salsa de tomate",
            "Arvejas", "Choclo", "Atun", "Jugo de naranja", "Jugo de manzana", "Caldo" };

            double[] precio = new double[30] { 79, 54, 66, 140, 68, 130, 235, 43, 135, 138, 150, 197, 110, 88, 120, 78, 132,
            123, 115, 51, 63, 177, 48, 55, 68, 88, 91, 145, 141, 30 };

            int[] idProducto = new int[30] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22,
                23, 24, 25, 26, 27, 28, 29, 30 };

            int[] stock = new int[30] { 8, 7, 9, 3, 15, 23, 44, 18, 2, 4, 5, 6, 48, 63, 84, 91, 110, 50, 78, 69, 78, 89, 108,
            97, 99, 9, 9, 15, 27, 32, };

            for (int i = 0; i < 30; i++)
            {
                listaProductos.Add(new Producto(descripcion[i], idProducto[i], precio[i], stock[i]));
            }
        }

        /// <summary>
        /// Hace una carga instantanea de 5 clientes
        /// </summary>
        public static void HardcodeoClientes()
        {

            string[] nombreClientes = new string[5] { "Homero", "Barney", "Montgomery", "Ned", "Waylon"};
            string[] apellidoClientes = new string[5] { "Simpson", "Gomez", "Burns", "Flanders", "Smithers"};
            double[] dni = new double[5] { 123456, 7891011, 2222222, 333333, 4444 };

            for (int i = 0; i < 5; i++)
            {
                listaPersonas.Add(new Cliente(nombreClientes[i], apellidoClientes[i], dni[i]));
            }

        }

        /// <summary>
        /// Hace una carga instantanea de 50 compras
        /// </summary>
        public static void HardcodeoCompras()
        {
            Empleado[] auxEmpleado = new Empleado[50] {new Empleado("Lucas", "Rodriguez",1, "rodriguez1"), new Empleado("Lucas", "Rodriguez", 1, "rodriguez1"),
            new Empleado("Lucas", "Rodriguez", 1, "rodriguez1"),new Empleado("Lucas", "Rodriguez",1, "rodriguez1"),new Empleado("Lucas", "Rodriguez",1, "rodriguez1"),
            new Empleado("Lucas", "Rodriguez", 1, "rodriguez1"),new Empleado("Lucas", "Rodriguez",1, "rodriguez1"),new Empleado("Lucas", "Rodriguez",1, "rodriguez1"),
            new Empleado("Lucas", "Rodriguez", 1, "rodriguez1"),new Empleado("Lucas", "Rodriguez",1, "rodriguez1"),new Empleado("Lucas", "Rodriguez",1, "rodriguez1"),
            new Empleado("Lucas", "Rodriguez", 1, "rodriguez1"),new Empleado("Lucas", "Rodriguez",1, "rodriguez1"),new Empleado("Lucas", "Rodriguez",1, "rodriguez1"),
            new Empleado("Lucas", "Rodriguez", 1, "rodriguez1"),new Empleado("Lucas", "Rodriguez",1, "rodriguez1"),new Empleado("Lucas", "Rodriguez",1, "rodriguez1"),
            new Empleado("Lucas", "Rodriguez", 1, "rodriguez1"),new Empleado("Lucas", "Rodriguez",1, "rodriguez1"),new Empleado("Lucas", "Rodriguez",1, "rodriguez1"),
            new Empleado("Ezequiel", "Oggioni",2, "oggioni1"), new Empleado("Ezequiel", "Oggioni",2, "oggioni1"),new Empleado("Ezequiel", "Oggioni",2, "oggioni1"),
            new Empleado("Ezequiel", "Oggioni",2, "oggioni1"),new Empleado("Ezequiel", "Oggioni", 2, "oggioni1"),new Empleado("Ezequiel", "Oggioni",2, "oggioni1"),
            new Empleado("Ezequiel", "Oggioni",2, "oggioni1"),new Empleado("Ezequiel", "Oggioni", 2, "oggioni1"),new Empleado("Ezequiel", "Oggioni",2, "oggioni1"),
            new Empleado("Ezequiel", "Oggioni",2, "oggioni1"),new Empleado("Ezequiel", "Oggioni", 2, "oggioni1"),new Empleado("Ezequiel", "Oggioni",2, "oggioni1"),
            new Empleado("Ezequiel", "Oggioni",2, "oggioni1"),new Empleado("Ezequiel", "Oggioni", 2, "oggioni1"),new Empleado("Ezequiel", "Oggioni",2, "oggioni1"),
            new Empleado("Ezequiel", "Oggioni",2, "oggioni1"),new Empleado("Ezequiel", "Oggioni", 2, "oggioni1"),new Empleado("Ezequiel", "Oggioni",2, "oggioni1"),
            new Empleado("Ezequiel", "Oggioni",2, "oggioni1"),new Empleado("Ezequiel", "Oggioni", 2, "oggioni1"),new Empleado("Ezequiel", "Oggioni",2, "oggioni1"),
            new Empleado("Federico", "Davila", 3, "davila1"),new Empleado("Federico", "Davila", 3, "davila1"),new Empleado("Federico", "Davila", 3, "davila1"),
            new Empleado("Federico", "Davila", 3, "davila1"),new Empleado("Federico", "Davila", 3, "davila1"),new Empleado("Federico", "Davila", 3, "davila1"),
            new Empleado("Federico", "Davila", 3, "davila1"),new Empleado("Federico", "Davila", 3, "davila1"),new Empleado("Federico", "Davila", 3, "davila1")};

            Cliente[] auxCliente = new Cliente[50] {new Cliente("Ned","Flanders",333333), new Cliente("Ned","Flanders",333333),
            new Cliente("Ned","Flanders",333333),new Cliente("Homero","Simpson",123456),new Cliente("Ned","Flanders",333333),
            new Cliente("Homero","Simpson",123456),new Cliente("Ned","Flanders",333333),new Cliente("Homero","Simpson",123456),
            new Cliente("Homero","Simpson",123456), new Cliente("Homero","Simpson",123456),new Cliente("Homero","Simpson",123456),new Cliente("Homero","Simpson",123456),
            new Cliente("Homero","Simpson",123456),new Cliente("Ned","Flanders",333333),new Cliente("Ned","Flanders",333333),
            new Cliente("Homero","Simpson",123456),new Cliente("Homero","Simpson",123456),new Cliente("Homero","Simpson",123456),
            new Cliente("Ned","Flanders",333333),new Cliente("Ned","Flanders",333333), new Cliente("Barney","Gomez",7891011),
            new Cliente("Waylon","Smithers",4444),new Cliente("Waylon","Smithers",4444),new Cliente("Waylon","Smithers",4444),
            new Cliente("Waylon","Smithers",4444),new Cliente("Waylon","Smithers",4444),new Cliente("Waylon","Smithers",4444),
            new Cliente("Waylon","Smithers",4444),new Cliente("Barney","Gomez",7891011),new Cliente("Barney","Gomez",7891011),
            new Cliente("Waylon","Smithers",4444),new Cliente("Barney","Gomez",7891011),new Cliente("Barney","Gomez",7891011),
            new Cliente("Waylon","Smithers",4444),new Cliente("Barney","Gomez",7891011),new Cliente("Barney","Gomez",7891011),
            new Cliente("Waylon","Smithers",4444),new Cliente("Barney","Gomez",7891011),new Cliente("Barney","Gomez",7891011),
            new Cliente("Montgomery","Burns",2222222), new Cliente("Montgomery","Burns",2222222),new Cliente("Montgomery","Burns",2222222),
            new Cliente("Montgomery","Burns",2222222),new Cliente("Montgomery","Burns",2222222),new Cliente("Montgomery","Burns",2222222),
            new Cliente("Montgomery","Burns",2222222),new Cliente("Montgomery","Burns",2222222),new Cliente("Montgomery","Burns",2222222),
            new Cliente("Montgomery","Burns",2222222), new Cliente("Montgomery","Burns",2222222)};

            string[] descripcion = new string[50] { "Azucar", "Leche", "Yerba", "Chocolate", "Galletitas", "Pan lactal", "Queso",
            "Jabon", "Shampoo", "Acondicionador", "Miel", "Cereales", "Yogurt", "Fideos", "Gaseosa", "Jabon liquido",
            "Dulce de leche", "Crema", "Queso untable", "Te", "Arroz", "Jabon en polvo", "Mate cocido", "Salsa de tomate",
            "Arvejas", "Choclo", "Atun", "Jugo de naranja", "Jugo de manzana", "Caldo",  "Azucar", "Leche", "Yerba", "Chocolate", "Galletitas", "Pan lactal", "Queso",
            "Jabon", "Shampoo", "Acondicionador", "Miel", "Cereales", "Yogurt", "Fideos", "Gaseosa", "Jabon liquido",
            "Dulce de leche", "Crema", "Queso untable", "Te" };

            double[] precio = new double[50] { 79, 54, 66, 140, 68, 130, 235, 43, 135, 138, 150, 197, 110, 88, 120, 78, 132,
            123, 115, 51, 63, 177, 48, 55, 68, 88, 91, 145, 141, 30, 79, 54, 66, 140, 68, 130, 235, 43, 135, 138, 150, 197, 110, 88, 120, 78, 132,
            123, 115, 51 };

            int[] idProducto = new int[50] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22,
                23, 24, 25, 26, 27, 28, 29, 30, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            for (int i = 0; i < 50; i++)
            {
                List<Compra> auxLista = new List<Compra>();
                Compra auxCompra = new Compra(descripcion[i], precio[i], idProducto[i]);
                auxLista.Add(auxCompra);
                listaVentas.Add(new Venta(auxEmpleado[i], auxCliente[i], auxLista, precio[i]));
            }
        }

        /// <summary>
        /// Filtra las ventas generadas por el empleado ID ingresado por parametro
        /// </summary>
        /// <param name="idEmpleado"></param>
        /// <returns>una List<> de tipo Venta</returns>
        public static List<Venta> VentasPorEmpleado(int idEmpleado)
        {
            List<Venta> auxListaVentas = new List<Venta>();

            foreach (Venta item in listaVentas)
            {
                if (item.Id == idEmpleado)
                {
                    auxListaVentas.Add(item);
                }
            }

            return auxListaVentas;
        }

        /// <summary>
        /// Verifica si en una lista de tipo Persona existen objetos de tipo Empleado y crea una sublista
        /// </summary>
        /// <returns>List<> de tipo Empleado</returns>
        public static List<Empleado> GetListaEmpleados()
        {
            List<Empleado> auxListaEmpleados = new List<Empleado>();

            foreach (Persona item in listaPersonas)
            {
                if(item is Empleado)
                {
                    auxListaEmpleados.Add((Empleado)item);
                }
            }

            return auxListaEmpleados;
        }

        /// <summary>
        /// Verifica si en una lista de tipo Persona existen objetos de tipo Cliente y crea una sublista
        /// </summary>
        /// <returns>List<> de tipo Cliente</returns>
        public static List<Cliente> GetListaClientes()
        {
            List<Cliente> auxListaClientes = new List<Cliente>();

            foreach (Persona item in listaPersonas)
            {
                if (item is Cliente)
                {
                    auxListaClientes.Add((Cliente)item);
                }
            }

            return auxListaClientes;
        }

        /// <summary>
        /// Crea un objeto de tipo Empleado referente al empleado logueado
        /// </summary>
        /// <param name="usuarioActivo"></param>
        public static void AuxEmpleadoLogueado(string usuarioActivo)
        {
            List<Empleado> auxListaEmpleados;

            auxListaEmpleados = GetListaEmpleados();

            for (int i = 0; i < auxListaEmpleados.Count; i++)
            {
                if (auxListaEmpleados[i].Usuario == usuarioActivo)
                { 
                    empleadoLogueado = auxListaEmpleados[i];
                    break;
                }
            }
        }

        #endregion
    }
}
