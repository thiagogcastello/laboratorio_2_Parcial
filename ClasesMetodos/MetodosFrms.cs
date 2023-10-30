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

        /// <summary>
        /// Valida las credenciales ingresadas por el usuario al intentar iniciar sesión.
        /// Compara el nombre de usuario y la contraseña con los datos almacenados en el diccionario de usuarios.
        /// Devuelve un código de retorno que indica el tipo de usuario o si las credenciales son incorrectas.
        /// Códigos de retorno: 
        /// 1 - Ingreso exitoso como supervisor (usuario que comienza con 'S').
        /// 2 - Ingreso exitoso como operario (otros usuarios).
        /// 3 - Credenciales incorrectas.
        /// </summary>
        /// <param name="tbNombreUsuario">Nombre de usuario ingresado por el usuario.</param>
        /// <param name="tbPassword">Contraseña ingresada por el usuario.</param>
        /// <returns>Código de retorno que indica el resultado de la validación.</returns>

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
