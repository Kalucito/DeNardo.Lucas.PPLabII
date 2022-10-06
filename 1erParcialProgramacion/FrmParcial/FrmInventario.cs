using BibliotecaDeClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmParcial
{
    public partial class FrmInventario : Form
    {
        int n; //Cell selected.

        public FrmInventario()
        {
            InitializeComponent();
        }


        //private void CargarDataGridView() ESTABA AL PEDO
        //{
        //    List<Producto> listaDeProductos = Negocio.RetornarProductos();

        //    foreach (Producto producto in listaDeProductos)
        //    {
        //        dgvProductos.Rows.Add(producto.TipoDeProducto,producto.MarcaDeProducto, producto.Modelo, $"${producto.Precio}", producto.Categoria, producto.Stock);
        //    }
        //}

        private void CargarDataGridView(List<Producto> listaDeProductos)
        {
            foreach (Producto producto in listaDeProductos)
            {
                dgvProductos.Rows.Add(producto.TipoDeProducto, producto.MarcaDeProducto, producto.Modelo, $"${producto.Precio}", producto.Categoria, producto.Stock);
            }
        }

        private void FrmInventario_Load(object sender, EventArgs e)
        {
            CargarDataGridView(Negocio.RetornarProductos());
            cmbCategorias.SelectedIndex = 0;
        }

        //private void VerificarMinMaxYBuscarPorPrecio(string min, string max)
        //{
        //    double auxMin;
        //    double auxMax;

        //    if (double.TryParse(txtMin.Text, out auxMin) && double.TryParse(txtMax.Text, out auxMax))
        //    {
        //        List<Producto> listaDeProductos = Negocio.BuscarPorPrecio(auxMin, auxMax);
        //        dgvProductos.Rows.Clear();
        //        CargarDataGridView(listaDeProductos);
        //    }

        //}

        //private void txtMin_TextChanged(object sender, EventArgs e)
        //{
        //    VerificarMinMaxYBuscarPorPrecio(txtMin.Text, txtMax.Text);
        //}

        //private void txtMax_TextChanged(object sender, EventArgs e)
        //{
        //    VerificarMinMaxYBuscarPorPrecio(txtMin.Text, txtMax.Text);
        //}

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            double auxMin;
            double auxMax;

            if (double.TryParse(txtMin.Text, out auxMin) && double.TryParse(txtMax.Text, out auxMax))
            {
                List<Producto> listaDeProductos = Negocio.BuscarPorPrecio(auxMin, auxMax);
                dgvProductos.Rows.Clear();
                CargarDataGridView(listaDeProductos);
            }
        }

        private void cmbCategorias_SelectedValueChanged(object sender, EventArgs e)
        {
            dgvProductos.Rows.Clear();
            CargarDataGridView(Negocio.BuscarPorCategoria(cmbCategorias.Text));
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;

        }
    }
}
