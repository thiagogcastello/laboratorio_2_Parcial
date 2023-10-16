using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class StringsProcesos
    {
        private string[] proceso;

        public StringsProcesos()
        {
            proceso = new string[9];

            proceso[0] = new string("Planchando la ropa de vaquero...");
            proceso[1] = new string("Cociendole el brazo...");
            proceso[2] = new string("Lustrando sus botas...");
            proceso[3] = new string("Pintando su suela...");
            proceso[4] = new string("Empaquetando...");
            proceso[5] = new string("Cociendo el molde...");
            proceso[6] = new string("Rellenando...");
            proceso[7] = new string("Vistiendo como aprendiz mandaloriano...");
            proceso[8] = new string("Entrando su habilidad para manejar La Fuerza...");
        }

        public string this[int indice]
        {
            get { return proceso[indice]; }
        }
    }
}
