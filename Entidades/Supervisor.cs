using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Supervisor : Trabajador
    {
        
        public Supervisor(string nombre, ulong dni, TipoEmpleado tipoEmpleado) :base(nombre, dni, tipoEmpleado)
        {
            
        }

        /// <summary>
        /// Genera y devuelve una cadena que representa la información del trabajador, incluyendo la información base de la clase base y el tipo de empleado.
        /// </summary>
        /// <returns>Una cadena que muestra la información del trabajador, incluyendo el tipo de empleado.</returns>
        public override string MostrarInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.MostrarInfo());
            sb.AppendLine($"Tipo Empleado: {this.TipoTrabajador}");

            return sb.ToString();            
        }

        public override void CrearCuentaEmpleado()
        {
            this.Legajo = $"S-{this.Dni}";
                

            this.NombreUsuario = this.Legajo;
            this.Password = this.Dni.ToString();            
        }

        public void AgregarProductoStock(string nombreProducto, int cantidad)
        {
            nombreProducto = nombreProducto.ToLower();

            if (Stock.stock.ContainsKey(nombreProducto))
            {
                Stock.stock[nombreProducto] += cantidad;
            }
            else
            {
                Stock.stock.Add(nombreProducto, cantidad);
            }
        }
    }
}
