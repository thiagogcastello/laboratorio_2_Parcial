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

        public virtual string InfoEmpresa()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Razon Social: {RazonSocial}");
            sb.AppendLine($"Cuil: {Cuil}");

            return sb.ToString();
        }

        public virtual string InfoEmpresa(int numero)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"- Razon Social: {RazonSocial}");
            sb.AppendLine($"\t - Cuil: {Cuil}");

            return sb.ToString();
        }
    }
}
