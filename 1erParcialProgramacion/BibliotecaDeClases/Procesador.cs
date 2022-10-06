using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BibliotecaDeClases.Producto;

namespace BibliotecaDeClases
{
    internal class Procesador : Producto
    {
        #region Atributos
        private int nucleos;
        private double frecuencia;
        private string socket;
        #endregion

        #region Constructores
        public Procesador(string tipoDeProducto, string marcaProducto, string modelo, double precio, string categoria, int stock, int nucleos, double frecuencia, string socket) : base (tipoDeProducto, marcaProducto, modelo, precio, categoria, stock)
        {
            this.nucleos = nucleos;
            this.frecuencia = frecuencia;
            this.socket = socket;
        }
        #endregion
    }
}
