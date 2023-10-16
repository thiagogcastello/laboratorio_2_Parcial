using Entidades;

namespace Gonzalez.Castello.Thiago.Parcial
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cbMostrarContraseña_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMostrarContraseña.Checked)
            {
                tbPassword.UseSystemPasswordChar = false;
            }
            else
            {
                tbPassword.UseSystemPasswordChar = true;
            }
            tbPassword.Focus();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            int retorno;
            retorno = MetodosFrms.ValidarBotonIngresar(tbNombreUsuario.Text, tbPassword.Text);
            if (retorno == 1)
            {
                Form formSupervisor = new frmSupervisor(tbNombreUsuario.Text.ToUpper());
                formSupervisor.Show();
                this.Hide();
            }
            else if (retorno == 2)
            {
                Form formOperario = new frmOperario(tbNombreUsuario.Text.ToUpper());
                formOperario.Show();
                this.Hide();
            }
            else
            {
                tbPassword.Focus();
                MessageBox.Show("Contraseña o usuario incorrectos");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Esta seguro de que desea salir?", "Confirmar Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void btnhardcodeo_Click(object sender, EventArgs e)
        {
            tbNombreUsuario.Text = Personal.supervisor1.NombreUsuario;
            tbPassword.Text = Personal.supervisor1.Password;
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOperario_Click(object sender, EventArgs e)
        {
            tbNombreUsuario.Text = Personal.operario1.NombreUsuario;
            tbPassword.Text = Personal.operario1.Password;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }
    }
}