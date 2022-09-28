using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public abstract class Producto
    {
        #region Atributos
        protected string tipoDeProducto;
        protected string marcaProducto;
        protected string modelo;
        protected float precio;
        protected List <eColores> colores;
        #endregion

        #region Constructores

        protected Producto(string modelo, string tipoDeProducto, string marcaProducto, float precio, List<eColores> colores) 
        {
            this.tipoDeProducto = tipoDeProducto;
            this.marcaProducto = marcaProducto;
            this.modelo = modelo;
            this.precio = precio;
            this.colores = colores;
        }

        #endregion

        #region Enumerados
        public enum eColores
        {
            Rosa,
            Negro,
            Rojo,
            Blanco,
            Amarillo,
            Marron,
            Verde,
            Violeta,
            Azul,
            Celeste
        }
        #endregion


    }
}
