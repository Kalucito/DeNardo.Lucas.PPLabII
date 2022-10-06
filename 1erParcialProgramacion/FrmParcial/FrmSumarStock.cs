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
    public partial class FrmSumarStock : Form
    {
        public FrmSumarStock()
        {
            InitializeComponent();
        }

        private void txtCantidadAAgregar_TextChanged(object sender, EventArgs e)
        {
            int auxCantidadAAgregar = 0;

            if(int.TryParse(txtCantidadAAgregar.Text, out auxCantidadAAgregar))
            {

            }
        }
    }
}
