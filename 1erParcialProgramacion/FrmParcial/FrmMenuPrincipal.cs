﻿using BibliotecaDeClases;
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

    public partial class FrmMenuPrincipal : Form
    {
        public int m, mx, my; //Variables para mover la ventana sin bordes.

        Usuario usuario;
        public FrmMenuPrincipal(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            FrmInventario frmInventario = new FrmInventario();
            frmInventario.Show();
            this.Hide();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            FrmVentas frmVentas = new FrmVentas(usuario);
            frmVentas.Show();
            this.Hide();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
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
    }
}
