using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public static class Negocio
    {
        static public List<Usuario> usuariosRegistrados;
        
        static Negocio()
        {
            usuariosRegistrados = new List<Usuario>();

            CargarUsuarios();
        }

        private static void CargarUsuarios()
        {
            usuariosRegistrados.Add(new Usuario("Ignacio Fadon", "fadon@vendedor.com", "contraseña", Usuario.eTipoDeUsuario.Vendedor));
            usuariosRegistrados.Add(new Usuario("Valentin Peralta", "peralta@peralta.com", "contraseña", Usuario.eTipoDeUsuario.Dueño));
        }

        private static bool ValidarCamposIngresados(string email, string contraseña)
        {

            if(string.IsNullOrEmpty(email) || string.IsNullOrEmpty(contraseña))
            {
                return false;
            }

            return true;
        }

        private static Usuario LogearUsuario(string email, string contraseña)
        {
            if(ValidarCamposIngresados(email, contraseña))
            {
                foreach(Usuario item in usuariosRegistrados)
                {
                    if(item.Email.Trim().ToLower() == email.Trim().ToLower() 
                        && item.Contraseña == contraseña) //Dejo diferencia de mayus y espacios.
                    {
                        return item;
                    }
                }
            }
            return null;

        }


    }

}
