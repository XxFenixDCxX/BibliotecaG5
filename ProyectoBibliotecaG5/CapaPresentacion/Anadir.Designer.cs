namespace CapaPresentacion
{
    partial class Anadir
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
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.lblIsbn = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblEditorial = new System.Windows.Forms.Label();
            this.txtEditorial = new System.Windows.Forms.TextBox();
            this.lblSinopsis = new System.Windows.Forms.Label();
            this.txtSinopsis = new System.Windows.Forms.TextBox();
            this.lblCaratula = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ofdAbrirFichero = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.lblUnidadesDisponibles = new System.Windows.Forms.Label();
            this.txtUnidadesDisponiles = new System.Windows.Forms.TextBox();
            this.lblPrestable = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtIsbn
            // 
            this.txtIsbn.Location = new System.Drawing.Point(260, 75);
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(100, 20);
            this.txtIsbn.TabIndex = 0;
            // 
            // lblIsbn
            // 
            this.lblIsbn.AutoSize = true;
            this.lblIsbn.Location = new System.Drawing.Point(257, 59);
            this.lblIsbn.Name = "lblIsbn";
            this.lblIsbn.Size = new System.Drawing.Size(27, 13);
            this.lblIsbn.TabIndex = 1;
            this.lblIsbn.Text = "Isbn";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(406, 59);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(33, 13);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Titulo";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(409, 75);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(100, 20);
            this.txtTitulo.TabIndex = 2;
            // 
            // lblEditorial
            // 
            this.lblEditorial.AutoSize = true;
            this.lblEditorial.Location = new System.Drawing.Point(257, 122);
            this.lblEditorial.Name = "lblEditorial";
            this.lblEditorial.Size = new System.Drawing.Size(44, 13);
            this.lblEditorial.TabIndex = 5;
            this.lblEditorial.Text = "Editorial";
            // 
            // txtEditorial
            // 
            this.txtEditorial.Location = new System.Drawing.Point(260, 138);
            this.txtEditorial.Name = "txtEditorial";
            this.txtEditorial.Size = new System.Drawing.Size(100, 20);
            this.txtEditorial.TabIndex = 4;
            // 
            // lblSinopsis
            // 
            this.lblSinopsis.AutoSize = true;
            this.lblSinopsis.Location = new System.Drawing.Point(406, 122);
            this.lblSinopsis.Name = "lblSinopsis";
            this.lblSinopsis.Size = new System.Drawing.Size(46, 13);
            this.lblSinopsis.TabIndex = 7;
            this.lblSinopsis.Text = "Sinopsis";
            // 
            // txtSinopsis
            // 
            this.txtSinopsis.Location = new System.Drawing.Point(409, 138);
            this.txtSinopsis.Name = "txtSinopsis";
            this.txtSinopsis.Size = new System.Drawing.Size(100, 20);
            this.txtSinopsis.TabIndex = 6;
            // 
            // lblCaratula
            // 
            this.lblCaratula.AutoSize = true;
            this.lblCaratula.Location = new System.Drawing.Point(257, 175);
            this.lblCaratula.Name = "lblCaratula";
            this.lblCaratula.Size = new System.Drawing.Size(46, 13);
            this.lblCaratula.TabIndex = 9;
            this.lblCaratula.Text = "Caratula";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(406, 177);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(46, 13);
            this.lbl.TabIndex = 11;
            this.lbl.Text = "Sinopsis";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(409, 193);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            // 
            // ofdAbrirFichero
            // 
            this.ofdAbrirFichero.FileName = "AbrirFichero";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(260, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblUnidadesDisponibles
            // 
            this.lblUnidadesDisponibles.AutoSize = true;
            this.lblUnidadesDisponibles.Location = new System.Drawing.Point(257, 227);
            this.lblUnidadesDisponibles.Name = "lblUnidadesDisponibles";
            this.lblUnidadesDisponibles.Size = new System.Drawing.Size(109, 13);
            this.lblUnidadesDisponibles.TabIndex = 14;
            this.lblUnidadesDisponibles.Text = "Unidades Disponibles";
            // 
            // txtUnidadesDisponiles
            // 
            this.txtUnidadesDisponiles.Location = new System.Drawing.Point(260, 243);
            this.txtUnidadesDisponiles.Name = "txtUnidadesDisponiles";
            this.txtUnidadesDisponiles.Size = new System.Drawing.Size(100, 20);
            this.txtUnidadesDisponiles.TabIndex = 13;
            // 
            // lblPrestable
            // 
            this.lblPrestable.AutoSize = true;
            this.lblPrestable.Location = new System.Drawing.Point(406, 227);
            this.lblPrestable.Name = "lblPrestable";
            this.lblPrestable.Size = new System.Drawing.Size(51, 13);
            this.lblPrestable.TabIndex = 16;
            this.lblPrestable.Text = "Prestable";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(409, 243);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 15;
            // 
            // Anadir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPrestable);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lblUnidadesDisponibles);
            this.Controls.Add(this.txtUnidadesDisponiles);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblCaratula);
            this.Controls.Add(this.lblSinopsis);
            this.Controls.Add(this.txtSinopsis);
            this.Controls.Add(this.lblEditorial);
            this.Controls.Add(this.txtEditorial);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblIsbn);
            this.Controls.Add(this.txtIsbn);
            this.Name = "Anadir";
            this.Text = "AñadirLibro";
            this.Load += new System.EventHandler(this.anadirLibro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIsbn;
        private System.Windows.Forms.Label lblIsbn;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblEditorial;
        private System.Windows.Forms.TextBox txtEditorial;
        private System.Windows.Forms.Label lblSinopsis;
        private System.Windows.Forms.TextBox txtSinopsis;
        private System.Windows.Forms.Label lblCaratula;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog ofdAbrirFichero;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblUnidadesDisponibles;
        private System.Windows.Forms.TextBox txtUnidadesDisponiles;
        private System.Windows.Forms.Label lblPrestable;
        private System.Windows.Forms.TextBox textBox3;
    }
}