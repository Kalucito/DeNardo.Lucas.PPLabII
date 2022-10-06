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
    public partial class FrmVentas : Form
    {
        Queue<Cliente> colaClientes;
        List<Producto> listaDeProductos;
        Producto productoSeleccioando;
        Usuario usuario;
        public int m, mx, my; //Variables para mover la ventana sin bordes.


        public FrmVentas(Usuario usuario)
        {
            InitializeComponent();
            this.listaDeProductos = Negocio.RetornarProductos();
            this.colaClientes = Negocio.RetornarClientes();
            this.usuario = usuario;
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;

            if (n != -1)
            {
                foreach (Producto item in listaDeProductos)
                {
                    if (item.TipoDeProducto == dgvProductos.Rows[n].Cells[0].Value.ToString() &&
                        item.MarcaDeProducto == dgvProductos.Rows[n].Cells[1].Value.ToString() &&
                        item.Modelo == dgvProductos.Rows[n].Cells[2].Value.ToString() &&
                        item.Precio == (double)dgvProductos.Rows[n].Cells[3].Value &&
                        item.Categoria == dgvProductos.Rows[n].Cells[4].Value.ToString() &&
                        item.Stock == (int)dgvProductos.Rows[n].Cells[5].Value)
                    {
                        productoSeleccioando = item;
                        break;
                    }
                }
            }
        }

        public void CargarDataGridView(List<Producto> listaDeProductos)
        {
            foreach (Producto producto in listaDeProductos)
            {
                dgvProductos.Rows.Add(producto.TipoDeProducto, producto.MarcaDeProducto, producto.Modelo, producto.Precio, producto.Categoria, producto.Stock);
            }
        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {
            CargarDataGridView(Negocio.RetornarProductos());

            lblNombreCliente.Text = colaClientes.Peek().NombreCompleto;
            lblDinero.Text = colaClientes.Peek().Dinero.ToString();
            lblMetodoDePago.Text = colaClientes.Peek().MetodoDePago.ToString();

            if(usuario.TipoDeUsuario == Usuario.eTipoDeUsuario.Dueño)
            {
                picHierro.Visible = false;
                picChallenger.Visible = true;
                btnVolver.Visible = true;
            }
            else
            {
                picHierro.Visible = true;
                picChallenger.Visible = false;
            }

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            DialogResult confirmarVenta;
            Cliente auxCliente = colaClientes.Peek();

            if(productoSeleccioando != null)
            {
                if(productoSeleccioando.Stock > 0)
                {
                    if((auxCliente.Dinero >= productoSeleccioando.Precio && auxCliente.MetodoDePago != Cliente.eMetodoPago.TarjetaDeCredito) ||
                        (auxCliente.MetodoDePago == Cliente.eMetodoPago.TarjetaDeCredito && auxCliente.Dinero >= productoSeleccioando.Precio*1.10))
                    {
                        confirmarVenta = MessageBox.Show("Desea confirmar la compra?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (confirmarVenta == DialogResult.Yes)
                        {
                            FrmFacturaDeVenta frmFacturaDeVenta = new FrmFacturaDeVenta(auxCliente, productoSeleccioando, usuario);

                            if (auxCliente.MetodoDePago == Cliente.eMetodoPago.TarjetaDeCredito)
                            {
                                auxCliente.Dinero = auxCliente.Dinero - (productoSeleccioando.Precio*1.10);
                                frmFacturaDeVenta.ShowDialog();
                            }
                            else
                            {
                                auxCliente.Dinero = auxCliente.Dinero - productoSeleccioando.Precio;
                            }

                            lblDinero.Text = auxCliente.Dinero.ToString();
                            productoSeleccioando--;
                            dgvProductos.Rows.Clear();
                            CargarDataGridView(Negocio.RetornarProductos());
                            frmFacturaDeVenta.ShowDialog();

                        }
                    }
                    else
                    {
                        MessageBox.Show("El cliente no tiene el dinero suficiente para comprar este producto.", "ERROR",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No hay stock disponible de este producto.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Primero seleccione un producto.");
            }
        }

        private void btnSiguienteCliente_Click(object sender, EventArgs e)
        {
            int clientesEnCola;

            clientesEnCola = colaClientes.Count;

            if(clientesEnCola > 1)
            {
                colaClientes.Dequeue();
                lblNombreCliente.Text = colaClientes.Peek().NombreCompleto;
                lblDinero.Text = colaClientes.Peek().Dinero.ToString();
                lblMetodoDePago.Text = colaClientes.Peek().MetodoDePago.ToString();
                clientesEnCola--;
            }
            else
            {
                clientesEnCola--;
                lblNombreCliente.Text = "No hay clientes...";

                if(clientesEnCola == 0)
                {
                    MessageBox.Show("No hay más clientes en la cola.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
