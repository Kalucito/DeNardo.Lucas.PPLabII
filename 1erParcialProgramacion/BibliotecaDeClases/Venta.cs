using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Venta
    {
        private Producto productoVendido;

        public Venta(Producto productoVendido)
        {
            this.productoVendido = productoVendido;
        }


        public Producto ProductoVendido
        {
            get { return productoVendido; }
        }



    }
}
