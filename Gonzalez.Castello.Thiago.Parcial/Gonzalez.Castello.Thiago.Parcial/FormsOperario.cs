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

namespace Gonzalez.Castello.Thiago.Parcial
{
    public partial class frmOperario : Form
    {
        private string? nombreUsuario;
        private Trabajador? usuario;

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
        }

        private void frmOperario_Load(object sender, EventArgs e)
        {

        }

        protected void label1_Click(object sender, EventArgs e)
        {

        }

        protected void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void label1_Click_1(object sender, EventArgs e)
        {
            //lblInventario = Personal.
        }

        protected void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        protected void btnProducir_Click(object sender, EventArgs e)
        {
            if (lbProductos.SelectedItems.Count > 0)
            {
                tmrProducto.Enabled = true;
                pbFabricacion.Visible = true;
                this.Size = new System.Drawing.Size(637, 478);
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Esta seguro de que desea salir?", "Confirmar Salida", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                this.Close();
                frmMenuPrincipal frmInicio = new frmMenuPrincipal();
                frmInicio.Show();
            }
        }
        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void lblFechaActual_Click(object sender, EventArgs e)
        {

        }

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

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        private void lblProcesosProduccion_Click(object sender, EventArgs e)
        {

        }

        private void lblProcesosProduccion_Click_1(object sender, EventArgs e)
        {

        }

        private void lklblUsuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(usuario != null)
            {
                MessageBox.Show(usuario.MostrarInfo());
            }
        }

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

        private void CargarListadoProductos()
        {
            foreach (Producto item in Catalogo.productos)
            {
                lbProductos.Items.Add(item.Nombre);
            }
        }

        private void SetearLblFecha()
        {
            DateTime dateTime = DateTime.Now;
            lblFechaActual.Text = dateTime.ToString("dd/MM/yy");
        }

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

        private void Usuario()
        {
            foreach(Trabajador empleado in Personal.listaTrabajadores)
            {
                if(nombreUsuario == empleado.NombreUsuario)
                {
                    this.usuario = empleado;
                    lklblUsuario.Text = usuario.Nombre.ToUpper();
                }
            }
        }
    }
}
