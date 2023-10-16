using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Stock
    {
        public static Dictionary<string, int> stock;

        static Stock()
        {
            stock = new Dictionary<string, int>();
            CargarInventario();
        }

        /// <summary>
        /// Carga el inventario de stock con cantidades aleatorias de materias primas dentro de un rango específico (entre 5 y 10 unidades) para cada materia prima.
        /// </summary>
        public static void CargarInventario()
        {
            Random random = new Random();
            foreach(MateriasPrimas materiaPrima in Enum.GetValues(typeof(MateriasPrimas)))
            {
                Personal.supervisor1.AgregarProductoStock(materiaPrima.ToString(), random.Next(5, 10));
            }
        }

        /// <summary>
        /// Utiliza la cantidad especificada de un producto del inventario de stock. Si hay suficientes existencias, reduce la cantidad disponible y devuelve true. Si no hay suficientes existencias, devuelve false.
        /// </summary>
        /// <param name="nombreProducto">Nombre del producto a utilizar del inventario.</param>
        /// <param name="cantidad">Cantidad del producto a utilizar del inventario.</param>
        /// <returns>True si se utilizó el producto correctamente, false si no hay suficientes existencias.</returns>
        public static bool UsarProductoStock(string nombreProducto, int cantidad)
        {
            nombreProducto = nombreProducto.ToLower();            

            if (stock.ContainsKey(nombreProducto))
            {
                if (stock[nombreProducto] >= cantidad)
                {
                    stock[nombreProducto] -= cantidad;

                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Genera y devuelve una cadena que muestra el inventario de stock, incluyendo el nombre del producto y la cantidad disponible en cada línea.
        /// </summary>
        /// <returns>Una cadena que muestra el inventario de stock con el nombre del producto y la cantidad disponible para cada producto.</returns>
        public static string MostrarStock()
        {
            StringBuilder sb = new StringBuilder();

            foreach (KeyValuePair<string, int> par in stock)
            {
                sb.Append($"{(par.Key).ToUpper()}: {par.Value}\n");
            }

   
            return sb.ToString();
        }
    }
}
