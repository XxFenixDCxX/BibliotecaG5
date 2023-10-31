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
            this.cboLectores = new System.Windows.Forms.ComboBox();
            this.lblLector = new System.Windows.Forms.Label();
            this.dgvLibros = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // controlCabezera1
            // 
            this.controlCabezera1.Location = new System.Drawing.Point(83, 15);
            this.controlCabezera1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.controlCabezera1.Name = "controlCabezera1";
            this.controlCabezera1.Size = new System.Drawing.Size(920, 201);
            this.controlCabezera1.TabIndex = 0;
            // 
            // cboLectores
            // 
            this.cboLectores.FormattingEnabled = true;
            this.cboLectores.Location = new System.Drawing.Point(147, 279);
            this.cboLectores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboLectores.Name = "cboLectores";
            this.cboLectores.Size = new System.Drawing.Size(160, 24);
            this.cboLectores.TabIndex = 1;
            this.cboLectores.SelectedIndexChanged += new System.EventHandler(this.cboLectores_SelectedIndexChanged);
            // 
            // lblLector
            // 
            this.lblLector.AutoSize = true;
            this.lblLector.Location = new System.Drawing.Point(143, 260);
            this.lblLector.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLector.Name = "lblLector";
            this.lblLector.Size = new System.Drawing.Size(44, 16);
            this.lblLector.TabIndex = 2;
            this.lblLector.Text = "Lector";
            // 
            // dgvLibros
            // 
            this.dgvLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibros.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvLibros.Location = new System.Drawing.Point(83, 336);
            this.dgvLibros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvLibros.Name = "dgvLibros";
            this.dgvLibros.RowHeadersWidth = 51;
            this.dgvLibros.Size = new System.Drawing.Size(948, 229);
            this.dgvLibros.TabIndex = 25;
            // 
            // FrmDevoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 662);
            this.Controls.Add(this.dgvLibros);
            this.Controls.Add(this.lblLector);
            this.Controls.Add(this.cboLectores);
            this.Controls.Add(this.controlCabezera1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmDevoluciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDevoluciones";
            this.Load += new System.EventHandler(this.FrmDevoluciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlCabezera controlCabezera1;
        private System.Windows.Forms.ComboBox cboLectores;
        private System.Windows.Forms.Label lblLector;
        private System.Windows.Forms.DataGridView dgvLibros;
    }
}