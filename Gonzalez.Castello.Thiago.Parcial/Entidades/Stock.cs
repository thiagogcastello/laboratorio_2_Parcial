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
        public static void CargarInventario()
        {
            Random random = new Random();
            foreach(MateriasPrimas materiaPrima in Enum.GetValues(typeof(MateriasPrimas)))
            {
                AgregarProductoStock(materiaPrima.ToString(), random.Next(5, 10));
            }
        }
        public static void AgregarProductoStock(string nombreProducto, int cantidad)
        {
            nombreProducto = nombreProducto.ToLower();

            if (stock.ContainsKey(nombreProducto))
            {
                stock[nombreProducto] += cantidad;
            }else
            {
                stock.Add(nombreProducto, cantidad);
            }
        }

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
