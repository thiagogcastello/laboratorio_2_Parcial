namespace Gonzalez.Castello.Thiago.Parcial
{
    partial class RegistroProduccion
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
            lblRegistro = new Label();
            SuspendLayout();
            // 
            // lblRegistro
            // 
            lblRegistro.AutoSize = true;
            lblRegistro.Location = new Point(12, 9);
            lblRegistro.Name = "lblRegistro";
            lblRegistro.Size = new Size(155, 15);
            lblRegistro.TabIndex = 0;
            lblRegistro.Text = "REGISTRO DE PRODUCCION";
            lblRegistro.Click += lblRegistro_Click;
            // 
            // RegistroProduccion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblRegistro);
            Name = "RegistroProduccion";
            Text = "RegistroProduccion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRegistro;
    }
}