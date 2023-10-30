using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Personal
    {
        public static Dictionary<string,string> dictUsuarios = new Dictionary<string,string>();
        //creo supervisor
        public static Supervisor supervisor1 = new Supervisor("Thiago Castello", 42343951, TipoEmpleado.Supervisor);
        public static Supervisor supervisor2 = new Supervisor("Hugo Basilotta", 29739267, TipoEmpleado.Supervisor);

        //creo operario
        public static Operario operario1 = new Operario("Bart Simpson", 34858321, TipoEmpleado.Operario);
        public static Operario operario2 = new Operario("Homero Simpson", 11111111, TipoEmpleado.Operario);

        public static List<Trabajador> listaTrabajadores = new List<Trabajador>();

        static Personal()
        {
            dictUsuarios.Add(supervisor1.NombreUsuario.ToString(),supervisor1.Password.ToString());
            dictUsuarios.Add(supervisor2.NombreUsuario.ToString(),supervisor2.Password.ToString());
            dictUsuarios.Add(operario1.NombreUsuario.ToString(), operario1.Password.ToString());
            dictUsuarios.Add(operario2.NombreUsuario.ToString(), operario2.Password.ToString());

            listaTrabajadores.Add(operario1);
            listaTrabajadores.Add(operario2);
            listaTrabajadores.Add(supervisor1);
            listaTrabajadores.Add(supervisor2);
        }
    }
}

