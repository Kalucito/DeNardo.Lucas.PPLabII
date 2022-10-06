using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class PlacaDeVideo : Producto
    {
        #region Atributos
        private string chipset;
        private int capacidadDeMemorioa;
        private int consumoDeEnergia;
        #endregion
        
        #region Constructores
        public PlacaDeVideo(string tipoDeProducto, string marcaProducto, string modelo, double precio, string categoria, int stock, string chipset, int capacidadDeMemoria, int consumoDeEnergia) : base(tipoDeProducto, marcaProducto, modelo, precio, categoria, stock)
        {
            this.chipset = chipset;
            this.capacidadDeMemorioa = capacidadDeMemoria;
            this.consumoDeEnergia = consumoDeEnergia;
        }
        #endregion 

    }
}
