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
        protected double precio;
        protected string categoria;
        protected int stock;
        #endregion

        #region Constructores

        protected Producto(string tipoDeProducto, string marcaProducto, string modelo, double precio, string categoria, int stock) 
        {
            this.tipoDeProducto = tipoDeProducto;
            this.marcaProducto = marcaProducto;
            this.modelo = modelo;
            this.precio = precio;
            this.categoria = categoria;
            this.stock = stock;
        }

        #endregion

        public string TipoDeProducto
        {
            get { return this.tipoDeProducto;}
        }
        public string MarcaDeProducto
        {
            get { return this.marcaProducto;}
        }
        public string Modelo
        {
            get { return this.modelo;}
        }
        public double Precio
        {
            get { return this.precio;}
        }
        public string Categoria
        {
            get { return this.categoria;}
        }
        public int Stock
        {
            get { return this.stock;}
        }



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
