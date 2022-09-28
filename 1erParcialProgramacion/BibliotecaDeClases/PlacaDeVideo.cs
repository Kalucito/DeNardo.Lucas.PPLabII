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
        public PlacaDeVideo(string modelo, string tipoDeProducto, string marcaProducto, float precio, List<eColores> colores, string chipset, int capacidadDeMemoria, int consumoDeEnergia) : base(modelo, tipoDeProducto, marcaProducto, precio, colores)
        {
            this.chipset = chipset;
            this.capacidadDeMemorioa = capacidadDeMemoria;
            this.consumoDeEnergia = consumoDeEnergia;
        }
        #endregion 

    }
}
