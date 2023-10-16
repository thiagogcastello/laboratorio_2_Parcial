using System;
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

        public override string MostrarInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.MostrarInfo());
            sb.AppendLine($"Tipo Empleado: {this.TipoTrabajador}");

            return sb.ToString();            
        }

        public void ReponerStock()
        {

        }
    }
}
