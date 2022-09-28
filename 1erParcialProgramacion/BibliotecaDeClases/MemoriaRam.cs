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
        public MemoriaRam(string modelo, string tipoDeProducto, string marcaProducto, float precio, List<eColores> colores, int cantidadDeMemoria, string tecnologia, int velocidad) : base(modelo, tipoDeProducto, marcaProducto, precio, colores)
        {
            this.cantidadDeMemoria = cantidadDeMemoria;
            this.tecnologia = tecnologia;
            this.velocidad = velocidad;
        }
        #endregion

    }
}
