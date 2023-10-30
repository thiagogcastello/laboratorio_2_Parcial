using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class LineaProduccion
    {
        private static Dictionary<string, DateTime> fechasProduccion = new Dictionary<string, DateTime>();

        /// <summary>
        /// Elabora un producto utilizando los materiales especificados en el objeto Producto proporcionado.
        /// Verifica si hay suficientes materiales en el inventario de stock. Si los materiales están disponibles, reduce las cantidades en el inventario y agrega el producto elaborado al stock.
        /// </summary>
        /// <param name="producto">Objeto Producto que contiene los materiales necesarios y el nombre del producto a elaborar.</param>
        /// <returns>True si el producto se pudo elaborar correctamente y se agregó al inventario. False si no hay suficientes materiales en el inventario.</returns>
        public static bool Elaborar(Producto producto)
        {
            Dictionary<string, int> auxStock = new Dictionary<string, int>(Stock.stock);
            bool disponible = false;
            
            foreach(KeyValuePair <string,int> par in producto.Materiales)
            {
                disponible = Stock.UsarProductoStock(par.Key, par.Value);
                if(!disponible)
                {
                    Stock.stock = new Dictionary<string, int>(auxStock);
                    return false;
                }
            }

            Personal.supervisor1.AgregarProductoStock(producto.Nombre, 1);
            return true;
        }
    }
}
