using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public static class Negocio
    {
        #region Atributos
        private static List<Usuario> usuariosRegistrados;
        private static List<Producto> listaDeProductos;
        #endregion

        #region Constructores
        static Negocio()
        {
            usuariosRegistrados = new List<Usuario>();
            listaDeProductos = new List<Producto>();

            CargarUsuarios();
            CargarProductos();
        }
        #endregion

        #region Metodos
        private static void CargarUsuarios()
        {
            usuariosRegistrados.Add(new Usuario("Ignacio Fadon", "fadon@vendedor.com", "contraseña", Usuario.eTipoDeUsuario.Vendedor));
            usuariosRegistrados.Add(new Usuario("Valentin Peralta", "peralta@peralta.com", "contraseña", Usuario.eTipoDeUsuario.Dueño));
        }
        private static void CargarProductos()
        {
            listaDeProductos.Add(new Procesador("Procesador", "AMD", "Ryzen 5 3600g", 35000, "Gamer", 3, 4, 3.6, "AM4"));
            listaDeProductos.Add(new Notebook("Notebook", "Asus", "X515EA", 105000, "Escritorio", 2, 8, 256, "Intel I3 1115g"));
            listaDeProductos.Add(new MemoriaRam("Memoria Ram", "Corsair","ValueSelect" , 18100, "Gamer", 1, 16, "DDR4", 2400));
            listaDeProductos.Add(new PlacaDeVideo("Placa De Video", "Asus", "GeForce GTX 1630", 95000, "Escritorio", 3, "GTX 1630", 4, 75));
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

        public static List<Producto> RetornarProductos()
        {
            return listaDeProductos;
        }

        public static List<Producto> BuscarPorPrecio(double precioMinimo, double precioMaximo)
        {
            List<Producto> lista = new List<Producto>();

            foreach (Producto item in listaDeProductos)
            {
                if(item.Precio > precioMinimo && item.Precio < precioMaximo)
                {
                    lista.Add(item);
                }
            }

            return lista;
        }

        public static List<Producto> BuscarPorCategoria(string categoria)
        {
            List<Producto> lista = new List<Producto>();

            foreach (Producto item in listaDeProductos)
            {
                if (item.Categoria == categoria || categoria == "Categorias")
                {
                    lista.Add(item);
                }
            }

            return lista;
        }




        #endregion



    }

}
