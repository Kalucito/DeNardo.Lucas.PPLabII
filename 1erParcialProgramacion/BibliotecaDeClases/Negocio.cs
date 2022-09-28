using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public static class Negocio
    {
        #region Atributos
        static List<Usuario> usuariosRegistrados;
        static List<Producto> listaDeProductos;
        #endregion

        #region Constructores
        static Negocio()
        {
            usuariosRegistrados = new List<Usuario>();
            listaDeProductos = new List<Producto>();

            CargarUsuarios();
        }
        #endregion

        #region Metodos
        private static void CargarUsuarios()
        {
            usuariosRegistrados.Add(new Usuario("Ignacio Fadon", "fadon@vendedor.com", "contraseña", Usuario.eTipoDeUsuario.Vendedor));
            usuariosRegistrados.Add(new Usuario("Valentin Peralta", "peralta@peralta.com", "contraseña", Usuario.eTipoDeUsuario.Dueño));
        }


        public static bool ValidarCamposIngresados(string email, string contraseña)
        {

            if(string.IsNullOrEmpty(email.Trim()) || string.IsNullOrEmpty(contraseña)) 
            {
                return false;
            }

            return true;
        }

        public static Usuario LogearUsuario(string email, string contraseña)
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

        #endregion


    }

}
