namespace Gonzalez.Castello.Thiago.Parcial
{
    partial class frmMenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            gbInicioSesion = new GroupBox();
            cbMostrarContraseña = new CheckBox();
            lblPassword = new Label();
            lblUsuario = new Label();
            tbPassword = new TextBox();
            tbNombreUsuario = new TextBox();
            btnSupervisor = new Button();
            btnIngresar = new Button();
            btnSalir = new Button();
            btnOperario = new Button();
            lblNombre = new Label();
            pb2 = new PictureBox();
            pb1 = new PictureBox();
            pictureBox1 = new PictureBox();
            pbPixar = new PictureBox();
            gbInicioSesion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPixar).BeginInit();
            SuspendLayout();
            // 
            // gbInicioSesion
            // 
            gbInicioSesion.Controls.Add(cbMostrarContraseña);
            gbInicioSesion.Controls.Add(lblPassword);
            gbInicioSesion.Controls.Add(lblUsuario);
            gbInicioSesion.Controls.Add(tbPassword);
            gbInicioSesion.Controls.Add(tbNombreUsuario);
            gbInicioSesion.Location = new Point(133, 86);
            gbInicioSesion.Name = "gbInicioSesion";
            gbInicioSesion.Size = new Size(303, 143);
            gbInicioSesion.TabIndex = 0;
            gbInicioSesion.TabStop = false;
            //gbInicioSesion.Enter += groupBox1_Enter;
            // 
            // cbMostrarContraseña
            // 
            cbMostrarContraseña.AutoSize = true;
            cbMostrarContraseña.Location = new Point(6, 110);
            cbMostrarContraseña.Name = "cbMostrarContraseña";
            cbMostrarContraseña.Size = new Size(130, 19);
            cbMostrarContraseña.TabIndex = 7;
            cbMostrarContraseña.Text = "Mostrar Contraseña";
            cbMostrarContraseña.UseVisualStyleBackColor = true;
            cbMostrarContraseña.CheckedChanged += cbMostrarContraseña_CheckedChanged;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(6, 57);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(83, 15);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "CONTRASEÑA";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.FlatStyle = FlatStyle.System;
            lblUsuario.Location = new Point(6, 4);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(56, 15);
            lblUsuario.TabIndex = 4;
            lblUsuario.Text = "USUARIO";
            // 
            // tbPassword
            // 
            tbPassword.BackColor = Color.Linen;
            tbPassword.Cursor = Cursors.IBeam;
            tbPassword.Location = new Point(6, 75);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(291, 23);
            tbPassword.TabIndex = 3;
            tbPassword.UseSystemPasswordChar = true;
            //tbPassword.TextChanged += tbPassword_TextChanged;
            // 
            // tbNombreUsuario
            // 
            tbNombreUsuario.BackColor = Color.Linen;
            tbNombreUsuario.Cursor = Cursors.IBeam;
            tbNombreUsuario.ForeColor = SystemColors.ActiveCaptionText;
            tbNombreUsuario.Location = new Point(6, 22);
            tbNombreUsuario.Name = "tbNombreUsuario";
            tbNombreUsuario.Size = new Size(291, 23);
            tbNombreUsuario.TabIndex = 2;
            // 
            // btnSupervisor
            // 
            btnSupervisor.FlatAppearance.BorderSize = 3;
            btnSupervisor.FlatStyle = FlatStyle.Flat;
            btnSupervisor.Font = new Font("Maiandra GD", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSupervisor.ForeColor = Color.SaddleBrown;
            btnSupervisor.ImageAlign = ContentAlignment.MiddleLeft;
            btnSupervisor.Location = new Point(442, 164);
            btnSupervisor.Name = "btnSupervisor";
            btnSupervisor.Size = new Size(98, 65);
            btnSupervisor.TabIndex = 1;
            btnSupervisor.Text = "SUPERVISOR";
            btnSupervisor.UseVisualStyleBackColor = true;
            btnSupervisor.Click += btnhardcodeo_Click;
            // 
            // btnIngresar
            // 
            btnIngresar.AccessibleRole = AccessibleRole.None;
            btnIngresar.BackColor = Color.Gold;
            btnIngresar.BackgroundImageLayout = ImageLayout.Stretch;
            btnIngresar.FlatAppearance.BorderSize = 0;
            btnIngresar.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Maiandra GD", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnIngresar.Location = new Point(139, 235);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.RightToLeft = RightToLeft.No;
            btnIngresar.Size = new Size(130, 56);
            btnIngresar.TabIndex = 3;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Gold;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Maiandra GD", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalir.ForeColor = SystemColors.ControlText;
            btnSalir.Location = new Point(300, 235);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(130, 56);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnOperario
            // 
            btnOperario.FlatAppearance.BorderColor = Color.SaddleBrown;
            btnOperario.FlatAppearance.BorderSize = 3;
            btnOperario.FlatStyle = FlatStyle.Flat;
            btnOperario.Font = new Font("Maiandra GD", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnOperario.ForeColor = Color.SaddleBrown;
            btnOperario.Location = new Point(442, 90);
            btnOperario.Name = "btnOperario";
            btnOperario.Size = new Size(98, 68);
            btnOperario.TabIndex = 5;
            btnOperario.Text = "OPERARIO";
            btnOperario.UseVisualStyleBackColor = true;
            btnOperario.Click += btnOperario_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("SimSun-ExtB", 48F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.ForeColor = SystemColors.WindowText;
            lblNombre.Location = new Point(12, 9);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(555, 64);
            lblNombre.TabIndex = 6;
            lblNombre.Text = "ToyPixar Factory";
            // 
            // pb2
            // 
            pb2.BackColor = Color.Transparent;
            pb2.Image = Properties.Resources.pngwing_com__2_;
            pb2.Location = new Point(436, 235);
            pb2.Name = "pb2";
            pb2.Size = new Size(104, 56);
            pb2.SizeMode = PictureBoxSizeMode.StretchImage;
            pb2.TabIndex = 8;
            pb2.TabStop = false;
            //pb2.Click += pb2_Click;
            // 
            // pb1
            // 
            pb1.BackColor = Color.Transparent;
            pb1.Image = Properties.Resources.pngwing_com__1_;
            pb1.Location = new Point(12, 86);
            pb1.Name = "pb1";
            pb1.Size = new Size(115, 219);
            pb1.SizeMode = PictureBoxSizeMode.StretchImage;
            pb1.TabIndex = 7;
            pb1.TabStop = false;
            //pb1.Click += pb1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(159, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(23, 61);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // pbPixar
            // 
            pbPixar.Image = Properties.Resources.pngwing1;
            pbPixar.Location = new Point(159, 12);
            pbPixar.Name = "pbPixar";
            pbPixar.Size = new Size(23, 61);
            pbPixar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPixar.TabIndex = 10;
            pbPixar.TabStop = false;
            //pbPixar.Click += pictureBox2_Click;
            // 
            // frmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(552, 300);
            Controls.Add(pbPixar);
            Controls.Add(pictureBox1);
            Controls.Add(pb2);
            Controls.Add(pb1);
            Controls.Add(lblNombre);
            Controls.Add(btnOperario);
            Controls.Add(btnSalir);
            Controls.Add(btnIngresar);
            Controls.Add(btnSupervisor);
            Controls.Add(gbInicioSesion);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmMenuPrincipal";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ToyPixar Factory Pro";
            Load += Form1_Load;
            gbInicioSesion.ResumeLayout(false);
            gbInicioSesion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPixar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbInicioSesion;
        private Label lblPassword;
        private Label lblUsuario;
        private TextBox tbPassword;
        private TextBox tbNombreUsuario;
        private Button btnSupervisor;
        private CheckBox cbMostrarContraseña;
        private Button btnIngresar;
        private Button btnSalir;
        private Button btnOperario;
        private Label lblNombre;
        private PictureBox pb2;
        private PictureBox pb1;
        private PictureBox pictureBox1;
        private PictureBox pbPixar;
    }
}