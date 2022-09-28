using BibliotecaDeClases;
using FrmParcial;
using System.Windows.Forms.VisualStyles;

namespace FrmParcial
{
    public partial class FrmLogin : Form
    {
        public int m, mx, my; //Variables para mover la ventana sin bordes.

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Usuario aux;

            if (Negocio.ValidarCamposIngresados(txtEmail.Text, txtContrase�a.Text)) 
            {
                aux = Negocio.LogearUsuario(txtEmail.Text, txtContrase�a.Text); //Doble verificaci�n.

                if( aux != null)
                {
                    if(aux.TipoDeUsuario == Usuario.eTipoDeUsuario.Due�o)
                    { 
                        FrmMenuPrincipal menuPrincipal = new FrmMenuPrincipal();

                        this.Hide();
                        menuPrincipal.Show();
                    }
                    else
                    {
                        MessageBox.Show("jota");
                    }

                }
                else
                {
                    lblErrorIngreso.Text = "Email y/o contrase�a incorrectos. Reingrese.";
                }
            }
            else
            {
                lblErrorIngreso.Text = "Error. No puede haber campos vac�os.";
            }
        }

        #region Logica TextBox
        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if(txtEmail.Text == "EMAIL")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.LightGray;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if(txtEmail.Text == "")
            {
                txtEmail.Text = "EMAIL";
                txtEmail.ForeColor = Color.DimGray;
            }
        }              
   


        private void txtContrase�a_Enter(object sender, EventArgs e)
        {
            if(txtContrase�a.Text == "CONTRASE�A")
            {
                txtContrase�a.Text = "";
                txtContrase�a.ForeColor = Color.LightGray;
                txtContrase�a.UseSystemPasswordChar = true;
            }
        }

        private void txtContrase�a_Leave(object sender, EventArgs e)
        {
            if(txtContrase�a.Text == "")
            {
                txtContrase�a.Text = "CONTRASE�A";
                txtContrase�a.ForeColor = Color.DimGray;
                txtContrase�a.UseSystemPasswordChar = false;
            }
        }
        #endregion

        #region Funciones MinimizarCerrar

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        private void btnAutocompletarVendedor_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "fadon@vendedor.com";
            txtContrase�a.Text = "contrase�a";
            txtEmail.ForeColor = Color.LightGray;
            txtContrase�a.ForeColor = Color.LightGray;
            txtContrase�a.UseSystemPasswordChar = true;
        }











        #region Logica Mover Ventana
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }


        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if(m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0; 
        }
        #endregion
    }
}