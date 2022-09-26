using BibliotecaDeClases;

namespace FrmParcial
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if(Negocio.ValidarCamposIngresados(txtEmail.Text, txtClave.Text))
            {
                Negocio.LogearUsuario(txtEmail.Text, txtClave.Text);
            }
        }
    }
}