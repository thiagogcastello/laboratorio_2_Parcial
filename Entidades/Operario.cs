using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Operario : Trabajador
    {
        public Operario(string nombre, ulong dni, TipoEmpleado tipoEmpleado) : base(nombre, dni, tipoEmpleado)
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
            this.Legajo = $"O-{this.Dni}";


            this.NombreUsuario = this.Legajo;
            this.Password = this.Dni.ToString();
        }
    }
}
