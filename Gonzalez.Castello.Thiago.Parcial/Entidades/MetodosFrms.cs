using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class MetodosFrms
    {
        static MetodosFrms()
        {
            
        }
        public static int ValidarBotonIngresar(string tbNombreUsuario, string tbPassword)
        {
            string usuario = tbNombreUsuario.ToUpper();
            string contrasenia = tbPassword;
            bool acceso = false;
            int retorno = -1;

            if (contrasenia.Length > 0)
            {
                foreach (KeyValuePair<string, string> par in Personal.dictUsuarios)
                {
                    if (par.Key == usuario && par.Value == contrasenia)
                    {
                        usuario.ToCharArray();

                        if (usuario[0] == 'S')
                        {
                            acceso = true;
                            retorno = 1;
                        }
                        else
                        {
                            acceso = true;
                            retorno = 2;
                        }
                    }
                }
                if (!acceso)
                {
                    retorno = 3;
                }
            }
            return retorno;
        }
    }
}
