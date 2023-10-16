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
            components = new System.ComponentModel.Container();
            gbInicioSesion = new GroupBox();
            cbMostrarContraseña = new CheckBox();
            lblPassword = new Label();
            lblUsuario = new Label();
            tbPassword = new TextBox();
            tbNombreUsuario = new TextBox();
            btnSupervisor = new Button();
            notifyIcon1 = new NotifyIcon(components);
            btnIngresar = new Button();
            btnSalir = new Button();
            btnOperario = new Button();
            lblNombre = new Label();
            pictureBox1 = new PictureBox();
            gbInicioSesion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            gbInicioSesion.Enter += groupBox1_Enter;
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
            lblUsuario.Location = new Point(6, 4);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(56, 15);
            lblUsuario.TabIndex = 4;
            lblUsuario.Text = "USUARIO";
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(6, 75);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(291, 23);
            tbPassword.TabIndex = 3;
            tbPassword.UseSystemPasswordChar = true;
            tbPassword.UseWaitCursor = true;
            tbPassword.TextChanged += tbPassword_TextChanged;
            // 
            // tbNombreUsuario
            // 
            tbNombreUsuario.Location = new Point(6, 22);
            tbNombreUsuario.Name = "tbNombreUsuario";
            tbNombreUsuario.Size = new Size(291, 23);
            tbNombreUsuario.TabIndex = 2;
            // 
            // btnSupervisor
            // 
            btnSupervisor.Location = new Point(452, 164);
            btnSupervisor.Name = "btnSupervisor";
            btnSupervisor.Size = new Size(81, 65);
            btnSupervisor.TabIndex = 1;
            btnSupervisor.Text = "SUPERVISOR";
            btnSupervisor.UseVisualStyleBackColor = true;
            btnSupervisor.Click += btnhardcodeo_Click;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(139, 235);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(130, 56);
            btnIngresar.TabIndex = 3;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(300, 235);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(130, 56);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnOperario
            // 
            btnOperario.Location = new Point(452, 90);
            btnOperario.Name = "btnOperario";
            btnOperario.Size = new Size(81, 68);
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
            lblNombre.Click += lblNombre_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 90);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 198);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // frmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(552, 300);
            Controls.Add(pictureBox1);
            Controls.Add(lblNombre);
            Controls.Add(btnOperario);
            Controls.Add(btnSalir);
            Controls.Add(btnIngresar);
            Controls.Add(btnSupervisor);
            Controls.Add(gbInicioSesion);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmMenuPrincipal";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ToyPixar Factory Pro";
            Load += Form1_Load;
            gbInicioSesion.ResumeLayout(false);
            gbInicioSesion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private NotifyIcon notifyIcon1;
        private CheckBox cbMostrarContraseña;
        private Button btnIngresar;
        private Button btnSalir;
        private Button btnOperario;
        private Label lblNombre;
        private PictureBox pictureBox1;
    }
}