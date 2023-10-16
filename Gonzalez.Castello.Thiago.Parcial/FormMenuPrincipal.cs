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

        /// <summary>
        /// Maneja el evento de cambio de estado del CheckBox 'cbMostrarContrase�a'. 
        /// Cambia la visibilidad del texto en el cuadro de contrase�a para mostrar u ocultar la contrase�a seg�n el estado del CheckBox.
        /// </summary>
        /// <param name="sender">El objeto que desencaden� el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void cbMostrarContrase�a_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMostrarContrase�a.Checked)
            {
                tbPassword.UseSystemPasswordChar = false;
            }
            else
            {
                tbPassword.UseSystemPasswordChar = true;
            }
            tbPassword.Focus();
        }

        /// <summary>
        /// Maneja el evento de clic en el bot�n 'btnIngresar'. Valida las credenciales ingresadas y abre el formulario correspondiente si son v�lidas.
        /// </summary>
        /// <param name="sender">El objeto que desencaden� el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
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
                MessageBox.Show("Contrase�a o usuario incorrectos");
            }
        }

        /// <summary>
        /// Maneja el evento de clic en el bot�n 'btnSalir'. Muestra un mensaje de confirmaci�n y cierra la aplicaci�n si el usuario confirma.
        /// </summary>
        /// <param name="sender">El objeto que desencaden� el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Esta seguro de que desea salir?", "Confirmar Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        /// <summary>
        /// Maneja el evento de clic en el bot�n 'btnhardcodeo'. Rellena los campos de nombre de usuario y contrase�a con valores predefinidos (hardcodeados) de un supervisor.
        /// </summary>
        /// <param name="sender">El objeto que desencaden� el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void btnhardcodeo_Click(object sender, EventArgs e)
        {
            tbNombreUsuario.Text = Personal.supervisor1.NombreUsuario;
            tbPassword.Text = Personal.supervisor1.Password;
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Maneja el evento de clic en el bot�n 'btnOperario'. Rellena los campos de nombre de usuario y contrase�a con valores predefinidos de un operario.
        /// </summary>
        /// <param name="sender">El objeto que desencaden� el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
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

        private void tbNombreUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void pb1_Click(object sender, EventArgs e)
        {

        }

        private void pb2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}