namespace parcial_Laboratorio_2
{
    partial class frmOperario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOperario));
            lblInventario = new Label();
            btnCerrarSesion = new Button();
            label1 = new Label();
            btnProducir = new Button();
            dgvStock = new DataGridView();
            producto = new DataGridViewTextBoxColumn();
            cantidadProducto = new DataGridViewTextBoxColumn();
            gpProducir = new GroupBox();
            lbProductos = new ListBox();
            lblNombre = new Label();
            lblFecha = new Label();
            lblFechaActual = new Label();
            pbFabricacion = new ProgressBar();
            tmrProducto = new System.Windows.Forms.Timer(components);
            lblProcesos = new Label();
            lklblUsuario = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)dgvStock).BeginInit();
            gpProducir.SuspendLayout();
            SuspendLayout();
            // 
            // lblInventario
            // 
            lblInventario.AutoSize = true;
            lblInventario.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblInventario.Location = new Point(378, 10);
            lblInventario.Name = "lblInventario";
            lblInventario.Size = new Size(219, 37);
            lblInventario.TabIndex = 0;
            lblInventario.Text = "INVENTARIO";
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Location = new Point(12, 330);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(102, 40);
            btnCerrarSesion.TabIndex = 2;
            btnCerrarSesion.Text = "CERRAR SESION";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 3;
            label1.Text = "USUARIO: ";
            // 
            // btnProducir
            // 
            btnProducir.Location = new Point(6, 152);
            btnProducir.Name = "btnProducir";
            btnProducir.Size = new Size(188, 41);
            btnProducir.TabIndex = 4;
            btnProducir.Text = "PRODUCIR";
            btnProducir.UseVisualStyleBackColor = true;
            btnProducir.Click += btnProducir_Click;
            // 
            // dgvStock
            // 
            dgvStock.AllowUserToAddRows = false;
            dgvStock.AllowUserToDeleteRows = false;
            dgvStock.AllowUserToOrderColumns = true;
            dgvStock.AllowUserToResizeColumns = false;
            dgvStock.AllowUserToResizeRows = false;
            dgvStock.BackgroundColor = SystemColors.ControlDarkDark;
            dgvStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvStock.Columns.AddRange(new DataGridViewColumn[] { producto, cantidadProducto });
            dgvStock.GridColor = SystemColors.InfoText;
            dgvStock.Location = new Point(368, 50);
            dgvStock.Name = "dgvStock";
            dgvStock.ReadOnly = true;
            dgvStock.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvStock.RowTemplate.Height = 25;
            dgvStock.Size = new Size(244, 320);
            dgvStock.TabIndex = 5;
            dgvStock.CellFormatting += dgvStock_CellFormatting;
            // 
            // producto
            // 
            producto.HeaderText = "Productos";
            producto.Name = "producto";
            producto.ReadOnly = true;
            // 
            // cantidadProducto
            // 
            cantidadProducto.HeaderText = "Cantidad";
            cantidadProducto.Name = "cantidadProducto";
            cantidadProducto.ReadOnly = true;
            // 
            // gpProducir
            // 
            gpProducir.Controls.Add(lbProductos);
            gpProducir.Controls.Add(lblNombre);
            gpProducir.Controls.Add(btnProducir);
            gpProducir.Location = new Point(12, 50);
            gpProducir.Name = "gpProducir";
            gpProducir.Size = new Size(200, 203);
            gpProducir.TabIndex = 6;
            gpProducir.TabStop = false;
            gpProducir.Text = "PRODUCCION";
            // 
            // lbProductos
            // 
            lbProductos.FormattingEnabled = true;
            lbProductos.ItemHeight = 15;
            lbProductos.Location = new Point(6, 52);
            lbProductos.Name = "lbProductos";
            lbProductos.Size = new Size(188, 94);
            lbProductos.TabIndex = 6;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(6, 34);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(147, 15);
            lblNombre.TabIndex = 5;
            lblNombre.Text = "Seleccione Item a Producir";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(215, 9);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(50, 15);
            lblFecha.TabIndex = 7;
            lblFecha.Text = "FECHA: ";
            // 
            // lblFechaActual
            // 
            lblFechaActual.AutoSize = true;
            lblFechaActual.Location = new Point(262, 9);
            lblFechaActual.Name = "lblFechaActual";
            lblFechaActual.Size = new Size(38, 15);
            lblFechaActual.TabIndex = 8;
            lblFechaActual.Text = "label2";
            // 
            // pbFabricacion
            // 
            pbFabricacion.Location = new Point(12, 406);
            pbFabricacion.Name = "pbFabricacion";
            pbFabricacion.Size = new Size(597, 23);
            pbFabricacion.Style = ProgressBarStyle.Continuous;
            pbFabricacion.TabIndex = 9;
            pbFabricacion.Visible = false;
            // 
            // tmrProducto
            // 
            tmrProducto.Tick += tmrProducto_Tick;
            // 
            // lblProcesos
            // 
            lblProcesos.AutoSize = true;
            lblProcesos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblProcesos.Location = new Point(18, 382);
            lblProcesos.Name = "lblProcesos";
            lblProcesos.Size = new Size(0, 21);
            lblProcesos.TabIndex = 10;
            // 
            // lklblUsuario
            // 
            lklblUsuario.AutoSize = true;
            lklblUsuario.Location = new Point(71, 9);
            lklblUsuario.Name = "lklblUsuario";
            lklblUsuario.Size = new Size(60, 15);
            lklblUsuario.TabIndex = 11;
            lklblUsuario.TabStop = true;
            lklblUsuario.Text = "linkLabel1";
            lklblUsuario.LinkClicked += lklblUsuario_LinkClicked;
            // 
            // frmOperario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(621, 373);
            Controls.Add(lklblUsuario);
            Controls.Add(lblProcesos);
            Controls.Add(pbFabricacion);
            Controls.Add(lblFechaActual);
            Controls.Add(lblFecha);
            Controls.Add(gpProducir);
            Controls.Add(dgvStock);
            Controls.Add(label1);
            Controls.Add(btnCerrarSesion);
            Controls.Add(lblInventario);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmOperario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OPERARIO";
            //Load += frmOperario_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStock).EndInit();
            gpProducir.ResumeLayout(false);
            gpProducir.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCerrarSesion;
        private Label lblInventario;
        private Label label1;
        private Button btnProducir;
        protected DataGridView dgvStock;
        private DataGridViewTextBoxColumn producto;
        private DataGridViewTextBoxColumn cantidadProducto;
        private GroupBox gpProducir;
        private Label lblFecha;
        private Label lblNombre;
        private ListBox lbProductos;
        private Label lblFechaActual;
        private ProgressBar pbFabricacion;
        private System.Windows.Forms.Timer tmrProducto;
        private Label lblProcesos;
        private LinkLabel lklblUsuario;
    }
}