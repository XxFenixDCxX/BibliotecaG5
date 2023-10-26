namespace CapaPresentacion
{
    partial class FrmGestionarLibro
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblUnidadesDisponibles = new System.Windows.Forms.Label();
            this.lblPrestable = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numUnidadesDisponiles = new System.Windows.Forms.NumericUpDown();
            this.lblTituloAnadirLibro = new System.Windows.Forms.Label();
            this.chckPrestable = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUnidadesDisponiles)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIsbn
            // 
            this.txtIsbn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIsbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIsbn.Location = new System.Drawing.Point(215, 142);
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(113, 30);
            this.txtIsbn.TabIndex = 0;
            this.txtIsbn.TextChanged += new System.EventHandler(this.txtIsbn_TextChanged);
            // 
            // lblIsbn
            // 
            this.lblIsbn.AutoSize = true;
            this.lblIsbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsbn.Location = new System.Drawing.Point(208, 103);
            this.lblIsbn.Name = "lblIsbn";
            this.lblIsbn.Size = new System.Drawing.Size(77, 37);
            this.lblIsbn.TabIndex = 1;
            this.lblIsbn.Text = "Isbn";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lblTitulo.Location = new System.Drawing.Point(389, 103);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(96, 37);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Titulo";
            // 
            // txtTitulo
            // 
            this.txtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold);
            this.txtTitulo.Location = new System.Drawing.Point(396, 142);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(148, 30);
            this.txtTitulo.TabIndex = 2;
            // 
            // lblEditorial
            // 
            this.lblEditorial.AutoSize = true;
            this.lblEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lblEditorial.Location = new System.Drawing.Point(209, 182);
            this.lblEditorial.Name = "lblEditorial";
            this.lblEditorial.Size = new System.Drawing.Size(133, 37);
            this.lblEditorial.TabIndex = 5;
            this.lblEditorial.Text = "Editorial";
            // 
            // txtEditorial
            // 
            this.txtEditorial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold);
            this.txtEditorial.Location = new System.Drawing.Point(215, 221);
            this.txtEditorial.Name = "txtEditorial";
            this.txtEditorial.Size = new System.Drawing.Size(134, 30);
            this.txtEditorial.TabIndex = 4;
            // 
            // lblSinopsis
            // 
            this.lblSinopsis.AutoSize = true;
            this.lblSinopsis.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lblSinopsis.Location = new System.Drawing.Point(390, 182);
            this.lblSinopsis.Name = "lblSinopsis";
            this.lblSinopsis.Size = new System.Drawing.Size(138, 37);
            this.lblSinopsis.TabIndex = 7;
            this.lblSinopsis.Text = "Sinopsis";
            // 
            // txtSinopsis
            // 
            this.txtSinopsis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSinopsis.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold);
            this.txtSinopsis.Location = new System.Drawing.Point(396, 221);
            this.txtSinopsis.Name = "txtSinopsis";
            this.txtSinopsis.Size = new System.Drawing.Size(133, 30);
            this.txtSinopsis.TabIndex = 6;
            // 
            // lblCaratula
            // 
            this.lblCaratula.AutoSize = true;
            this.lblCaratula.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lblCaratula.Location = new System.Drawing.Point(208, 260);
            this.lblCaratula.Name = "lblCaratula";
            this.lblCaratula.Size = new System.Drawing.Size(139, 37);
            this.lblCaratula.TabIndex = 9;
            this.lblCaratula.Text = "Caratula";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(214, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Seleccionar Imagen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblUnidadesDisponibles
            // 
            this.lblUnidadesDisponibles.AutoSize = true;
            this.lblUnidadesDisponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidadesDisponibles.Location = new System.Drawing.Point(243, 338);
            this.lblUnidadesDisponibles.Name = "lblUnidadesDisponibles";
            this.lblUnidadesDisponibles.Size = new System.Drawing.Size(250, 29);
            this.lblUnidadesDisponibles.TabIndex = 14;
            this.lblUnidadesDisponibles.Text = "Unidades Disponibles";
            // 
            // lblPrestable
            // 
            this.lblPrestable.AutoSize = true;
            this.lblPrestable.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lblPrestable.Location = new System.Drawing.Point(390, 260);
            this.lblPrestable.Name = "lblPrestable";
            this.lblPrestable.Size = new System.Drawing.Size(151, 37);
            this.lblPrestable.TabIndex = 16;
            this.lblPrestable.Text = "Prestable";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnAgregar
            // 
            this.btnAgregar.AutoSize = true;
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.Location = new System.Drawing.Point(282, 421);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(160, 44);
            this.btnAgregar.TabIndex = 17;
            this.btnAgregar.Text = "➕Aplicar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 123);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "(Ej: 123A)";
            // 
            // numUnidadesDisponiles
            // 
            this.numUnidadesDisponiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numUnidadesDisponiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold);
            this.numUnidadesDisponiles.Location = new System.Drawing.Point(323, 379);
            this.numUnidadesDisponiles.Margin = new System.Windows.Forms.Padding(2);
            this.numUnidadesDisponiles.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numUnidadesDisponiles.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUnidadesDisponiles.Name = "numUnidadesDisponiles";
            this.numUnidadesDisponiles.Size = new System.Drawing.Size(90, 33);
            this.numUnidadesDisponiles.TabIndex = 21;
            this.numUnidadesDisponiles.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblTituloAnadirLibro
            // 
            this.lblTituloAnadirLibro.AutoSize = true;
            this.lblTituloAnadirLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloAnadirLibro.Location = new System.Drawing.Point(217, 9);
            this.lblTituloAnadirLibro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTituloAnadirLibro.Name = "lblTituloAnadirLibro";
            this.lblTituloAnadirLibro.Size = new System.Drawing.Size(295, 44);
            this.lblTituloAnadirLibro.TabIndex = 22;
            this.lblTituloAnadirLibro.Text = "Gestionar Libro";
            // 
            // chckPrestable
            // 
            this.chckPrestable.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chckPrestable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckPrestable.Location = new System.Drawing.Point(453, 302);
            this.chckPrestable.Margin = new System.Windows.Forms.Padding(2);
            this.chckPrestable.Name = "chckPrestable";
            this.chckPrestable.Size = new System.Drawing.Size(15, 20);
            this.chckPrestable.TabIndex = 24;
            this.chckPrestable.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(355, 93);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 25;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label2.Location = new System.Drawing.Point(241, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 37);
            this.label2.TabIndex = 26;
            this.label2.Text = "¿Desea eliminar?";
            // 
            // FrmGestionarLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 467);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.chckPrestable);
            this.Controls.Add(this.lblTituloAnadirLibro);
            this.Controls.Add(this.numUnidadesDisponiles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblPrestable);
            this.Controls.Add(this.lblUnidadesDisponibles);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblCaratula);
            this.Controls.Add(this.lblSinopsis);
            this.Controls.Add(this.txtSinopsis);
            this.Controls.Add(this.lblEditorial);
            this.Controls.Add(this.txtEditorial);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblIsbn);
            this.Controls.Add(this.txtIsbn);
            this.Name = "FrmGestionarLibro";
            this.Text = "AñadirLibro";
            this.Load += new System.EventHandler(this.anadirLibro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUnidadesDisponiles)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblUnidadesDisponibles;
        private System.Windows.Forms.Label lblPrestable;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numUnidadesDisponiles;
        private System.Windows.Forms.Label lblTituloAnadirLibro;
        private System.Windows.Forms.CheckBox chckPrestable;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
    }
}