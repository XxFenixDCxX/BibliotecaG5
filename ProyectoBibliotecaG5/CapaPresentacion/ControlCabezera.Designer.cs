namespace CapaPresentacion
{
    partial class ControlCabezera
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblBiblioteca = new System.Windows.Forms.Label();
            this.lblLocalizado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.ImageLocation = "";
            this.pbLogo.Location = new System.Drawing.Point(11, 32);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(96, 88);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 12;
            this.pbLogo.TabStop = false;
            // 
            // lblBiblioteca
            // 
            this.lblBiblioteca.AutoSize = true;
            this.lblBiblioteca.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBiblioteca.Location = new System.Drawing.Point(112, 32);
            this.lblBiblioteca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBiblioteca.Name = "lblBiblioteca";
            this.lblBiblioteca.Size = new System.Drawing.Size(565, 88);
            this.lblBiblioteca.TabIndex = 11;
            this.lblBiblioteca.Text = "Administrador de la Biblioteca \r\nde ";
            this.lblBiblioteca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLocalizado
            // 
            this.lblLocalizado.AutoSize = true;
            this.lblLocalizado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalizado.Location = new System.Drawing.Point(507, 138);
            this.lblLocalizado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLocalizado.Name = "lblLocalizado";
            this.lblLocalizado.Size = new System.Drawing.Size(100, 16);
            this.lblLocalizado.TabIndex = 13;
            this.lblLocalizado.Text = "Localizado en:  ";
            // 
            // ControlCabezera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblLocalizado);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.lblBiblioteca);
            this.Name = "ControlCabezera";
            this.Size = new System.Drawing.Size(690, 163);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblBiblioteca;
        private System.Windows.Forms.Label lblLocalizado;
    }
}
