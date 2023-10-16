using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Empresa
    {
        private string razonSocial;
        private string cuil;

        public Empresa(string razonSocial, string cuil)
        {
            this.razonSocial = razonSocial;
            this.cuil = cuil;
        }
        public string RazonSocial
        {
            get
            {
                return razonSocial;
            }
        }
        public string Cuil
        {
            get
            {
                return cuil;
            }
        }

        /// <summary>
        /// Genera y devuelve una cadena que representa la información básica de la empresa, incluyendo la razón social y el número de CUIL.
        /// </summary>
        /// <returns>Una cadena que muestra la razón social y el CUIL de la empresa.</returns>

        public virtual string InfoEmpresa()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Razon Social: {RazonSocial}");
            sb.AppendLine($"Cuil: {Cuil}");

            return sb.ToString();
        }

        /// <summary>
        /// Genera y devuelve una cadena que representa la información básica de la empresa, con un formato especial indicado por el número proporcionado.
        /// </summary>
        /// <param name="numero">Número que indica el formato especial de la cadena de salida.</param>
        /// <returns>Una cadena con formato especial que muestra la razón social y el CUIL de la empresa.</returns>
        public virtual string InfoEmpresa(int numero)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"- Razon Social: {RazonSocial}");
            sb.AppendLine($"\t - Cuil: {Cuil}");

            return sb.ToString();
        }
    }
}
