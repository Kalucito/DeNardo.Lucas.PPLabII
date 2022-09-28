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
        private float frecuencia;
        private string socket;
        #endregion

        #region Constructores
        public Procesador(string modelo, string tipoDeProducto, string marcaProducto, float precio, List<eColores> colores, int nucleos, float frecuencia, string socket) : base (modelo, tipoDeProducto, marcaProducto, precio, colores)
        {
            this.nucleos = nucleos;
            this.frecuencia = frecuencia;
            this.socket = socket;
        }
        #endregion
    }
}
