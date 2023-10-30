using System.Text;

namespace Entidades
{
    public abstract class Trabajador
    {
        private string nombreUsuario = "";
        private string password = "";
        private string nombre = "";
        private ulong dni;
        private string legajo = "";
        private TipoEmpleado tipoTrabajador;

        protected Trabajador(string nombre, ulong dni, TipoEmpleado tipoTrabajador)
        {
            this.nombre = nombre;
            this.dni = dni;
            this.tipoTrabajador = tipoTrabajador;   
            CrearCuentaEmpleado();
        }

        public string NombreUsuario
        {
            get 
            { 
                return nombreUsuario; 
            }
            set 
            { 
                nombreUsuario = value;  
            }
        }
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
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

        public ulong Dni
        {
            get
            {
                return dni;
            }
            set
            {
                dni = value;
            }
        }
        public string Legajo
        {
            get
            {
                return legajo;
            }
            set
            {
                legajo = value;
            }
        }

        public TipoEmpleado TipoTrabajador
        {
            get
            {
                return tipoTrabajador;
            }
            set
            {
                tipoTrabajador = value;
            }
        }

        public abstract void CrearCuentaEmpleado();
        

        public virtual string MostrarInfo()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {this.Nombre}");
            sb.AppendLine($"Dni: {this.Dni}");
            sb.AppendLine($"Legajo: {this.legajo}");

            return sb.ToString();
        }

        public bool ProducirProducto()
        {
            return true;
        }

        public static bool operator == (Trabajador laburante, string nombre)
        {
            return nombre == laburante.nombre;
        }

        public static bool operator !=(Trabajador laburante, string nombre)
        {
            return !(nombre == laburante.nombre);
        }
    }
}