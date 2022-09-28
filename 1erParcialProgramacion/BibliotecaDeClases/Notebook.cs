using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Notebook : Producto
    {
        #region Atributos
        private int memoriaRam;
        private int almacenamiento;
        private string procesador;
        #endregion

        #region Contructores
        public Notebook(string modelo, string tipoDeProducto, string marcaProducto, float precio, List<eColores> colores, int memoriaRam, int almacenamiento, string procesador) : base (modelo, tipoDeProducto, marcaProducto, precio, colores)
        {
            this.memoriaRam = memoriaRam;
            this.almacenamiento = almacenamiento;
            this.procesador = procesador;
        }
        #endregion
        
    }
}
