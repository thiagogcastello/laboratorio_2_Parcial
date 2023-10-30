using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Producto : Empresa
    {
        private string nombre;
        private int id;
        private string marca;
        private Dictionary<string,int> materiales;
        private List<string> procesosProduccion;

        public Producto(string nombre,int id, Dictionary<string, int> materiales, List<string> procesosProduccion, string razonSocial, string cuil) : base (razonSocial, cuil)
        {
            this.nombre = nombre;
            this.marca = base.RazonSocial;
            this.materiales = materiales;
            this.id = id;
            this.procesosProduccion = procesosProduccion;
        }
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string Marca
        {
            get
            {
                return marca;
            }
            set
            {
                marca = value;
            }
        }
        public Dictionary<string, int> Materiales
        {
            get
            {
                return materiales;
            }
        }

        public List<string> ProcesosProduccion
        {
            get
            {
                return procesosProduccion;
            }
        }

        /// <summary>
        /// Genera y devuelve una cadena que representa la información detallada del producto, incluyendo su nombre, ID y la información del fabricante.
        /// </summary>
        /// <returns>Una cadena que muestra el nombre del producto, su ID y la información del fabricante en un formato específico.</returns>
        public string InfoProducto()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre Producto: {Nombre}");
            sb.AppendLine($"Id: {Id}");
            sb.AppendLine($"Informacion fabricante:\n\t {base.InfoEmpresa(1)}");

            return sb.ToString();
        }

        /// <summary>
        /// Genera y devuelve una cadena que muestra los materiales utilizados para fabricar el producto.
        /// </summary>
        /// <returns>Una cadena que lista los materiales utilizados para fabricar el producto.</returns>
        public string MaterialesUtiliados()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var materia in Materiales) 
            {
                sb.AppendLine( materia.ToString() );
            }
            return sb.ToString();
        }
    }
}
