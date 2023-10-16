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
        public static bool Elaborar(Producto producto)
        {
            Dictionary<string, int> auxStock = new Dictionary<string, int>(Stock.stock);
            bool disponible = false;
            
            foreach(KeyValuePair <string,int> par in producto.Materiales)
            {
                disponible = Stock.UsarProductoStock(par.Key, par.Value);
                if(!disponible)
                {
                    Console.WriteLine("Error, no hay suficientes materiales para crear el producto.");
                    Stock.stock = new Dictionary<string, int>(auxStock);
                    return false;
                }
            }

            Stock.AgregarProductoStock(producto.Nombre, 1);
            return true;
        }
    }
}
