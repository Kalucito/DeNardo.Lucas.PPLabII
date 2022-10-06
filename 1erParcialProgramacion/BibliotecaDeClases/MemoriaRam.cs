using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class MemoriaRam : Producto
    {
        #region Atributos
        private int cantidadDeMemoria;
        private string tecnologia;
        private int velocidad;
        #endregion

        #region Constructores
        public MemoriaRam(string tipoDeProducto, string marcaProducto, string modelo, double precio, string categoria, int stock, int cantidadDeMemoria, string tecnologia, int velocidad) : base(tipoDeProducto, marcaProducto, modelo, precio, categoria, stock)
        {
            this.cantidadDeMemoria = cantidadDeMemoria;
            this.tecnologia = tecnologia;
            this.velocidad = velocidad;
        }
        #endregion

    }
}
