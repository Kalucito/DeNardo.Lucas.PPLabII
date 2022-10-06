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
        public Notebook(string tipoDeProducto, string marcaProducto, string modelo, double precio, string categoria, int stock, int memoriaRam, int almacenamiento, string procesador) : base (tipoDeProducto, marcaProducto, modelo, precio, categoria, stock)
        {
            this.memoriaRam = memoriaRam;
            this.almacenamiento = almacenamiento;
            this.procesador = procesador;
        }
        #endregion
        
    }
}
