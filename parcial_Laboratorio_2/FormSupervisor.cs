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

namespace parcial_Laboratorio_2
{
    public partial class frmSupervisor : frmOperario
    {
        public frmSupervisor()
        {

        }
        public frmSupervisor(string tbNombreUsuario) : base(tbNombreUsuario)
        {
            InitializeComponent();
            CargarListaCboxMp();
        }

        /// <summary>
        /// Maneja el evento de clic en el botón 'btnRestock'. Agrega materias primas seleccionadas al inventario de stock en la cantidad especificada.
        /// Muestra un mensaje de confirmación con las materias primas a cargar y solicita la confirmación del usuario antes de realizar la operación.
        /// </summary>
        /// <param name="sender">El objeto que desencadenó el evento (Button).</param>
        /// <param name="e">Argumentos del evento.</param>
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
                        Personal.supervisor1.AgregarProductoStock(materiaPrima, cantidadMatPrima);
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

        /// <summary>
        /// Carga los elementos de enumeración 'MateriasPrimas' en el CheckedListBox 'clbMateriasPrimas' para permitir al usuario seleccionar las materias primas a reabastecer en el inventario de stock.
        /// </summary>
        private void CargarListaCboxMp()
        {
            foreach (MateriasPrimas materiaPrima in Enum.GetValues(typeof(MateriasPrimas)))
            {
                clbMateriasPrimas.Items.Add(materiaPrima.ToString());
            }
        }

        /// <summary>
        /// Desmarca las selecciones en el CheckedListBox 'clbMateriasPrimas' y restablece el valor del control NumericUpDown 'nudCantStock' a cero.
        /// </summary>
        private void LimpiarCheckedListBox()
        {
            for (int i = 0; i < clbMateriasPrimas.CheckedItems.Count; i++)
            {
                clbMateriasPrimas.SetItemChecked(clbMateriasPrimas.CheckedIndices[i], false);
                nudCantStock.Value = 0;
            }
        }

        /// <summary>
        /// Crea y devuelve una cadena que representa las materias primas seleccionadas para cargar en el inventario de stock junto con la cantidad especificada.
        /// </summary>
        /// <returns>Una cadena que muestra las materias primas a cargar y sus respectivas cantidades en mayúsculas.</returns>
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
