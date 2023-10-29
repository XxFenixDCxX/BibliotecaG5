namespace CapaPresentacion
{
    partial class FrmDevoluciones
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
            this.controlCabezera1 = new CapaPresentacion.ControlCabezera();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblLector = new System.Windows.Forms.Label();
            this.dgvLibros = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // controlCabezera1
            // 
            this.controlCabezera1.Location = new System.Drawing.Point(62, 12);
            this.controlCabezera1.Name = "controlCabezera1";
            this.controlCabezera1.Size = new System.Drawing.Size(690, 163);
            this.controlCabezera1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(110, 227);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // lblLector
            // 
            this.lblLector.AutoSize = true;
            this.lblLector.Location = new System.Drawing.Point(107, 211);
            this.lblLector.Name = "lblLector";
            this.lblLector.Size = new System.Drawing.Size(37, 13);
            this.lblLector.TabIndex = 2;
            this.lblLector.Text = "Lector";
            // 
            // dgvLibros
            // 
            this.dgvLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibros.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvLibros.Location = new System.Drawing.Point(62, 273);
            this.dgvLibros.Name = "dgvLibros";
            this.dgvLibros.Size = new System.Drawing.Size(711, 186);
            this.dgvLibros.TabIndex = 25;
            // 
            // FrmDevoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 538);
            this.Controls.Add(this.dgvLibros);
            this.Controls.Add(this.lblLector);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.controlCabezera1);
            this.Name = "FrmDevoluciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDevoluciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlCabezera controlCabezera1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblLector;
        private System.Windows.Forms.DataGridView dgvLibros;
    }
}