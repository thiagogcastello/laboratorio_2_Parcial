using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Catalogo
    {
        private static Dictionary<string, int> materialesWoody = new Dictionary<string, int>();
        private static Dictionary<string, int> materialesYoda = new Dictionary<string, int>();
        private static List<string> procesosWoody = new List<string>();
        private static List<string> procesosBabyYoda = new List<string>();
        public static Producto producto1 = new Producto("Sheriff Woody", 27, materialesWoody, procesosWoody, "Disney Pixar", "30-63984459-1");
        public static Producto producto2 = new Producto("Peluche Baby Yoda",23, materialesYoda, procesosBabyYoda, "Disney Pixar", "30-63984459-1");
        public static List<Producto> productos = new List<Producto>();

        static Catalogo()
        {
            LLenarDiccionarios();
            CrearListasProcesos();
            productos.Add(producto1);
            productos.Add(producto2);
        }

        /// <summary>
        /// Llena los diccionarios 'materialesWoody' y 'materialesYoda' con las materias primas necesarias para producir los productos de Woody y Baby Yoda respectivamente.
        /// Establece las cantidades necesarias de cada materia prima en los diccionarios.
        /// </summary>
        private static void LLenarDiccionarios()
        {
            materialesWoody.Add((MateriasPrimas.pantalones).ToString(), 1);
            materialesWoody.Add((MateriasPrimas.camisas).ToString(), 1);
            materialesWoody.Add((MateriasPrimas.botas).ToString(), 2);
            materialesWoody.Add((MateriasPrimas.sombreros).ToString(), 1);
            materialesWoody.Add((MateriasPrimas.muñecos).ToString(), 1);
            materialesWoody.Add((MateriasPrimas.ojos).ToString(), 2);
            materialesWoody.Add((MateriasPrimas.cajas).ToString(), 1);

            materialesYoda.Add((MateriasPrimas.algodon).ToString(), 1);
            materialesYoda.Add((MateriasPrimas.tela).ToString(), 1);
            materialesYoda.Add((MateriasPrimas.ojos).ToString(), 2);
            materialesYoda.Add((MateriasPrimas.cajas).ToString(), 1);
        }

        /// <summary>
        /// Crea listas de procesos de producción para Woody y Baby Yoda y las almacena en las listas 'procesosWoody' y 'procesosBabyYoda' respectivamente.
        /// </summary>
        private static void CrearListasProcesos()
        {
            foreach (ProcesosProduccionWoody proceso in Enum.GetValues(typeof(ProcesosProduccionWoody)))
            {
                procesosWoody.Add(proceso.ToString());
            }
            foreach (ProcesoBabyYoda proceso in Enum.GetValues(typeof(ProcesoBabyYoda)))
            {
                procesosBabyYoda.Add(proceso.ToString());
            }
        }
    }
}
