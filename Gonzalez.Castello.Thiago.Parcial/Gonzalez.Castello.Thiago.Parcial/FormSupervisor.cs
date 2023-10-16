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

namespace Gonzalez.Castello.Thiago.Parcial
{
    public partial class frmSupervisor : frmOperario
    {
        public frmSupervisor()
        {

        }
        public frmSupervisor(string tbNombreUsuario) : base(tbNombreUsuario)
        {
            InitializeComponent();
        }

        private void FormSupervisor_Load(object sender, EventArgs e)
        {
            CargarListaCboxMp();
        }

        private void btnRestock_Click(object sender, EventArgs e)
        {
            int cantidadMatPrima = (int)nudCantStock.Value;

            if (clbMateriasPrimas.CheckedItems.Count > 0 && nudCantStock.Value > 0)
            {
                DialogResult resultado = MessageBox.Show(MostrarMateriasPrimasaCargar(), "RE-STOCK", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    foreach (string materiaPrima in clbMateriasPrimas.CheckedItems)
                    {
                        Stock.AgregarProductoStock(materiaPrima, cantidadMatPrima);
                    }
                    MessageBox.Show("Stock cargado con exito.");
                    LimpiarCheckedListBox();
                }
                else
                {
                    MessageBox.Show("Carga de stock cancelada.");
                }
            }
            dgvStock.Rows.Clear();
            base.CargarDataGridStock();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btnRegistro_Click(object sender, EventArgs e)
        {

        }


        private void CargarListaCboxMp()
        {
            foreach (MateriasPrimas materiaPrima in Enum.GetValues(typeof(MateriasPrimas)))
            {
                clbMateriasPrimas.Items.Add(materiaPrima.ToString());
            }
        }
        private void LimpiarCheckedListBox()
        {
            for (int i = 0; i < clbMateriasPrimas.CheckedItems.Count; i++)
            {
                clbMateriasPrimas.SetItemChecked(clbMateriasPrimas.CheckedIndices[i], false);
                nudCantStock.Value = 0;
            }
        }
        private string MostrarMateriasPrimasaCargar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Desea cargar: ");
            foreach (var item in clbMateriasPrimas.CheckedItems)
            {
                sb.AppendLine($"  - {item.ToString()} x {nudCantStock.Value}");
            }

            return sb.ToString().ToUpper();
        }
    }
}
