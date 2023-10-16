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
        private EstadoProducto estado;
        private Dictionary<string,int> materiales;

        public Producto(string nombre, EstadoProducto estado,int id, Dictionary<string, int> materiales, string razonSocial, string cuil) : base (razonSocial, cuil)
        {
            this.nombre = nombre;
            this.marca = base.RazonSocial;
            this.estado = estado;
            this.materiales = materiales;
            this.id = id;
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
        public EstadoProducto Estado
        {
            get
            {
                return estado;
            }
            set
            {
                estado = value;
            }
        }
        public Dictionary<string, int> Materiales
        {
            get
            {
                return materiales;
            }
        }

        public string InfoProducto()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre Producto: {Nombre}");
            sb.AppendLine($"Id: {Id}");
            sb.AppendLine($"Estado: {Estado}");
            sb.AppendLine($"Informacion fabricante:\n\t {base.InfoEmpresa(1)}");

            return sb.ToString();
        }

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
