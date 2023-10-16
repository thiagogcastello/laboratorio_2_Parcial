namespace Gonzalez.Castello.Thiago.Parcial
{
    partial class frmSupervisor
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
            btnRestock = new Button();
            clbMateriasPrimas = new CheckedListBox();
            label2 = new Label();
            nudCantStock = new NumericUpDown();
            gbRestock = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)nudCantStock).BeginInit();
            gbRestock.SuspendLayout();
            SuspendLayout();
            // 
            // btnRestock
            // 
            btnRestock.Location = new Point(7, 237);
            btnRestock.Name = "btnRestock";
            btnRestock.Size = new Size(120, 57);
            btnRestock.TabIndex = 8;
            btnRestock.Text = "RESTOCK";
            btnRestock.UseVisualStyleBackColor = true;
            btnRestock.Click += btnRestock_Click;
            // 
            // clbMateriasPrimas
            // 
            clbMateriasPrimas.CausesValidation = false;
            clbMateriasPrimas.CheckOnClick = true;
            clbMateriasPrimas.FormattingEnabled = true;
            clbMateriasPrimas.Location = new Point(7, 22);
            clbMateriasPrimas.Name = "clbMateriasPrimas";
            clbMateriasPrimas.Size = new Size(120, 166);
            clbMateriasPrimas.TabIndex = 9;
            clbMateriasPrimas.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 202);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 10;
            label2.Text = "CANTIDAD";
            // 
            // nudCantStock
            // 
            nudCantStock.ForeColor = SystemColors.WindowText;
            nudCantStock.Location = new Point(78, 200);
            nudCantStock.Name = "nudCantStock";
            nudCantStock.Size = new Size(49, 23);
            nudCantStock.TabIndex = 11;
            // 
            // gbRestock
            // 
            gbRestock.Controls.Add(clbMateriasPrimas);
            gbRestock.Controls.Add(nudCantStock);
            gbRestock.Controls.Add(btnRestock);
            gbRestock.Controls.Add(label2);
            gbRestock.Location = new Point(218, 50);
            gbRestock.Name = "gbRestock";
            gbRestock.Size = new Size(133, 310);
            gbRestock.TabIndex = 13;
            gbRestock.TabStop = false;
            gbRestock.Text = "Re-Stock";
            // 
            // frmSupervisor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 379);
            Controls.Add(gbRestock);
            Name = "frmSupervisor";
            Text = "FormSupervisor";
            Load += FormSupervisor_Load;
            ((System.ComponentModel.ISupportInitialize)nudCantStock).EndInit();
            gbRestock.ResumeLayout(false);
            gbRestock.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnRestock;
        private CheckedListBox clbMateriasPrimas;
        private Label label2;
        private NumericUpDown nudCantStock;
        private GroupBox gbRestock;
    }
}