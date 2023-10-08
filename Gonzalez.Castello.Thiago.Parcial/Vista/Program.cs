using Entidades;

namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creo supervisor
            Supervisor supervisor1 = new Supervisor("Thiago Gonzalez Castello", 42343951, TipoEmpleado.Supervisor);

            //creo operario
            Operario operario1 = new Operario("Bart Simpson", 37656991, TipoEmpleado.Operario);

            Console.WriteLine(supervisor1.MostrarInfo());
            Console.WriteLine(operario1.MostrarInfo());

        }
    }
}