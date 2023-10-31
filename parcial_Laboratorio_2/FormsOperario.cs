using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace parcial_Laboratorio_2
{
    public partial class frmOperario : Form
    {
        protected string? nombreUsuario = "";
        protected Trabajador? usuario;

        public frmOperario()
        {

        }

        public frmOperario(string tbNombreUsuario)
        {
            InitializeComponent();
            CargarDataGridStock();
            CargarListadoProductos();
            SetearLblFecha();
            nombreUsuario = tbNombreUsuario;
            Usuario();
            lklblUsuario.Text = usuario?.Nombre.ToUpper();
        }

        /// <summary>
        /// Maneja el evento de clic en el botón 'btnProducir'. Activa un temporizador para simular la producción de productos seleccionados.
        /// Muestra una barra de progreso y ajusta el tamaño del formulario.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        protected void btnProducir_Click(object sender, EventArgs e)
        {
            if (lbProductos.SelectedItems.Count > 0)
            {
                tmrProducto.Enabled = true;
                pbFabricacion.Visible = true;
                this.Size = new System.Drawing.Size(637, 478);
            }
        }

        /// <summary>
        /// Maneja el evento de clic en el botón 'btnCerrarSesion'. Muestra un mensaje de confirmación y cierra la sesión del usuario.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Esta seguro de que desea salir?", "Confirmar Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                this.Close();
                frmMenuPrincipal frmInicio = new frmMenuPrincipal();
                frmInicio.Show();
            }
        }


        /// <summary>
        /// Maneja el evento de formato de celda en el DataGridView 'dgvStock'. Cambia el color del texto y el fondo de las celdas de la columna 'cantidadProducto'
        /// si la cantidad del producto es menor a 6 unidades, para indicar un nivel de stock bajo.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento (DataGridView).</param>
        /// <param name="e">Argumentos del evento que contienen información sobre la celda que se está formateando.</param>
        private void dgvStock_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgvStock.Columns[e.ColumnIndex].Name == "cantidadProducto")
            {
                foreach (var item in Catalogo.productos)
                {
                    if (Convert.ToInt32(e.Value) < 6)
                    {
                        e.CellStyle.ForeColor = Color.Red;
                        e.CellStyle.BackColor = Color.Orange;
                    }
                }
            }
        }


        /// <summary>
        /// Maneja el evento de clic en el enlace de etiqueta 'lklblUsuario'. Muestra la información del usuario actual en un cuadro de mensaje si el usuario no es nulo.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento (LinkLabel).</param>
        /// <param name="e">Argumentos del evento.</param>
        private void lklblUsuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (usuario != null)
            {
                MessageBox.Show(usuario.MostrarInfo());
            }
        }


        /// <summary>
        /// Maneja el evento de temporizador 'tmrProducto_Tick'. Simula el proceso de producción de productos seleccionados.
        /// Actualiza la barra de progreso y muestra información sobre el proceso de producción en un control de etiqueta.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento (Timer).</param>
        /// <param name="e">Argumentos del evento.</param>
        private void tmrProducto_Tick(object sender, EventArgs e)
        {
            if (pbFabricacion.Value < 100)
            {
                pbFabricacion.Value++;
                StringsProcesos stringsProcesos = new StringsProcesos();
                int i = 0;

                #region SetLblProduccion
                if (lbProductos.SelectedItem.ToString() == Catalogo.producto1.Nombre)
                {
                    if (pbFabricacion.Value < 20)
                    {
                        i = 0;
                    }
                    else if (pbFabricacion.Value < 50)
                    {
                        i = 1;
                    }
                    else if (pbFabricacion.Value < 65)
                    {
                        i = 2;
                    }
                    else if (pbFabricacion.Value < 85)
                    {
                        i = 3;
                    }
                    else
                    {
                        i = 4;
                    }
                }
                else
                {
                    if (pbFabricacion.Value < 20)
                    {
                        i = 5;
                    }
                    else if (pbFabricacion.Value < 50)
                    {
                        i = 6;
                    }
                    else if (pbFabricacion.Value < 65)
                    {
                        i = 7;
                    }
                    else if (pbFabricacion.Value < 85)
                    {
                        i = 8;
                    }
                    else
                    {
                        i = 4;
                    }
                }
                lblProcesos.Text = stringsProcesos[i];
                #endregion

                if (pbFabricacion.Value == pbFabricacion.Maximum)
                {
                    Producir();
                    tmrProducto.Enabled = false;
                    pbFabricacion.Value = 0;
                }
            }
            else
            {
                tmrProducto.Enabled = false;
                pbFabricacion.Value = 0;
            }
        }

        /// <summary>
        /// Carga en un listBox todos los productos disponibles para fabricar
        /// </summary>
        private void CargarListadoProductos()
        {
            foreach (Producto item in Catalogo.productos)
            {
                lbProductos.Items.Add(item.Nombre);
            }
        }

        /// <summary>
        /// Coloca la fecha actual en el label correspondiente
        /// </summary>
        private void SetearLblFecha()
        {
            DateTime dateTime = DateTime.Now;
            lblFechaActual.Text = dateTime.ToString("dd/MM/yy");
        }

        /// <summary>
        /// Recorre la lista de productos de Catalogo y cuando el elemento seleccionado cumpla la condicion, crea un
        /// objeto de tipo Producto.
        /// </summary>
        private void Producir()
        {
            Producto produccion = Catalogo.producto1;

            foreach (var item in Catalogo.productos)
            {
                if (lbProductos.SelectedItem.ToString() == item.Nombre.ToString())
                {
                    produccion = item;
                    break;
                }
            }

            if (LineaProduccion.Elaborar(produccion))
            {
                MessageBox.Show("Entra cuchillo, salen las tripas.\nProducto creado correctamente!");
            }
            else
            {
                tmrProducto.Enabled = false;
                pbFabricacion.Value = 90;
                MessageBox.Show("Error, no hay suficiente materia prima.\nComuniquese con un supervisor para hacer el restock.");
                pbFabricacion.Value = 0;
            }
            this.Size = new System.Drawing.Size(637, 418);
            pbFabricacion.Visible = false;
            dgvStock.Rows.Clear();
            CargarDataGridStock();
        }

        /// <summary>
        /// Carga el dataGridView para visualizar el stock actual
        /// </summary>
        protected void CargarDataGridStock()
        {
            int numColumna;

            foreach (KeyValuePair<string, int> par in Stock.stock)
            {
                numColumna = dgvStock.Rows.Add();
                dgvStock.Rows[numColumna].Cells[0].Value = par.Key;
                dgvStock.Rows[numColumna].Cells[1].Value = par.Value;
            }
        }

        /// <summary>
        /// Busca un trabajador en la lista de trabajadores por su nombre de usuario y
        /// asigna el trabajador correspondiente al miembro 'usuario' de la clase actual.
        /// </summary>
        private void Usuario()
        {
            foreach (Trabajador empleado in Personal.listaTrabajadores)
            {
                string nombreEmpleado = empleado.NombreUsuario;

                if (nombreEmpleado == nombreUsuario)
                {
                    if (nombreEmpleado[0] == 'S')
                    {
                        usuario = new Supervisor(empleado.Nombre, empleado.Dni, TipoEmpleado.Supervisor);
                    }
                    else
                    {
                        usuario = new Operario(empleado.Nombre, empleado.Dni, TipoEmpleado.Operario);
                    }
                    break;
                }
            }
        }
    }
}
