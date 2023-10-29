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
            this.BtnAplicar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numUnidadesDisponiles = new System.Windows.Forms.NumericUpDown();
            this.chckPrestable = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.BtnAnadir = new System.Windows.Forms.Button();
            this.listBoxAutores = new System.Windows.Forms.ListBox();
            this.btnCategoria = new System.Windows.Forms.Button();
            this.listBoxCategorias = new System.Windows.Forms.ListBox();
            this.LblImagen = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnBuscarAutor = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnBuscarCategoria = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.controlCabezera1 = new CapaPresentacion.ControlCabezera();
            ((System.ComponentModel.ISupportInitialize)(this.numUnidadesDisponiles)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIsbn
            // 
            this.txtIsbn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIsbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIsbn.Location = new System.Drawing.Point(36, 56);
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(336, 30);
            this.txtIsbn.TabIndex = 0;
            // 
            // lblIsbn
            // 
            this.lblIsbn.AutoSize = true;
            this.lblIsbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsbn.Location = new System.Drawing.Point(29, 16);
            this.lblIsbn.Name = "lblIsbn";
            this.lblIsbn.Size = new System.Drawing.Size(77, 37);
            this.lblIsbn.TabIndex = 1;
            this.lblIsbn.Text = "Isbn";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lblTitulo.Location = new System.Drawing.Point(410, 16);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(96, 37);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Titulo";
            // 
            // txtTitulo
            // 
            this.txtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold);
            this.txtTitulo.Location = new System.Drawing.Point(417, 55);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(343, 30);
            this.txtTitulo.TabIndex = 2;
            // 
            // lblEditorial
            // 
            this.lblEditorial.AutoSize = true;
            this.lblEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lblEditorial.Location = new System.Drawing.Point(29, 103);
            this.lblEditorial.Name = "lblEditorial";
            this.lblEditorial.Size = new System.Drawing.Size(133, 37);
            this.lblEditorial.TabIndex = 5;
            this.lblEditorial.Text = "Editorial";
            // 
            // txtEditorial
            // 
            this.txtEditorial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold);
            this.txtEditorial.Location = new System.Drawing.Point(36, 142);
            this.txtEditorial.Name = "txtEditorial";
            this.txtEditorial.Size = new System.Drawing.Size(336, 30);
            this.txtEditorial.TabIndex = 4;
            // 
            // lblSinopsis
            // 
            this.lblSinopsis.AutoSize = true;
            this.lblSinopsis.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lblSinopsis.Location = new System.Drawing.Point(411, 102);
            this.lblSinopsis.Name = "lblSinopsis";
            this.lblSinopsis.Size = new System.Drawing.Size(138, 37);
            this.lblSinopsis.TabIndex = 7;
            this.lblSinopsis.Text = "Sinopsis";
            // 
            // txtSinopsis
            // 
            this.txtSinopsis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSinopsis.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold);
            this.txtSinopsis.Location = new System.Drawing.Point(417, 141);
            this.txtSinopsis.Name = "txtSinopsis";
            this.txtSinopsis.Size = new System.Drawing.Size(343, 30);
            this.txtSinopsis.TabIndex = 6;
            // 
            // lblCaratula
            // 
            this.lblCaratula.AutoSize = true;
            this.lblCaratula.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lblCaratula.Location = new System.Drawing.Point(30, 181);
            this.lblCaratula.Name = "lblCaratula";
            this.lblCaratula.Size = new System.Drawing.Size(139, 37);
            this.lblCaratula.TabIndex = 9;
            this.lblCaratula.Text = "Caratula";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(175, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Seleccionar Imagen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblUnidadesDisponibles
            // 
            this.lblUnidadesDisponibles.AutoSize = true;
            this.lblUnidadesDisponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidadesDisponibles.Location = new System.Drawing.Point(249, 626);
            this.lblUnidadesDisponibles.Name = "lblUnidadesDisponibles";
            this.lblUnidadesDisponibles.Size = new System.Drawing.Size(250, 29);
            this.lblUnidadesDisponibles.TabIndex = 14;
            this.lblUnidadesDisponibles.Text = "Unidades Disponibles";
            // 
            // lblPrestable
            // 
            this.lblPrestable.AutoSize = true;
            this.lblPrestable.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lblPrestable.Location = new System.Drawing.Point(412, 181);
            this.lblPrestable.Name = "lblPrestable";
            this.lblPrestable.Size = new System.Drawing.Size(151, 37);
            this.lblPrestable.TabIndex = 16;
            this.lblPrestable.Text = "Prestable";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BtnAplicar
            // 
            this.BtnAplicar.AutoSize = true;
            this.BtnAplicar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnAplicar.FlatAppearance.BorderSize = 0;
            this.BtnAplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold);
            this.BtnAplicar.Location = new System.Drawing.Point(674, 634);
            this.BtnAplicar.Name = "BtnAplicar";
            this.BtnAplicar.Size = new System.Drawing.Size(181, 41);
            this.BtnAplicar.TabIndex = 17;
            this.BtnAplicar.Text = "➕Aplicar";
            this.BtnAplicar.UseVisualStyleBackColor = false;
            this.BtnAplicar.Click += new System.EventHandler(this.BtnAplicar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 36);
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
            this.numUnidadesDisponiles.Location = new System.Drawing.Point(504, 625);
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
            this.numUnidadesDisponiles.Size = new System.Drawing.Size(120, 33);
            this.numUnidadesDisponiles.TabIndex = 21;
            this.numUnidadesDisponiles.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // chckPrestable
            // 
            this.chckPrestable.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chckPrestable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckPrestable.Location = new System.Drawing.Point(578, 194);
            this.chckPrestable.Margin = new System.Windows.Forms.Padding(2);
            this.chckPrestable.Name = "chckPrestable";
            this.chckPrestable.Size = new System.Drawing.Size(88, 20);
            this.chckPrestable.TabIndex = 24;
            this.chckPrestable.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(420, 171);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 25;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label2.Location = new System.Drawing.Point(287, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 37);
            this.label2.TabIndex = 26;
            this.label2.Text = "¿Desea eliminar?";
            // 
            // txtCategoria
            // 
            this.txtCategoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold);
            this.txtCategoria.Location = new System.Drawing.Point(26, 19);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(270, 30);
            this.txtCategoria.TabIndex = 30;
            // 
            // txtAutor
            // 
            this.txtAutor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold);
            this.txtAutor.Location = new System.Drawing.Point(37, 19);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(271, 30);
            this.txtAutor.TabIndex = 28;
            // 
            // BtnAnadir
            // 
            this.BtnAnadir.Location = new System.Drawing.Point(315, 19);
            this.BtnAnadir.Name = "BtnAnadir";
            this.BtnAnadir.Size = new System.Drawing.Size(36, 30);
            this.BtnAnadir.TabIndex = 32;
            this.BtnAnadir.Text = "+";
            this.BtnAnadir.UseVisualStyleBackColor = true;
            this.BtnAnadir.Click += new System.EventHandler(this.BtnAnadir_Click);
            // 
            // listBoxAutores
            // 
            this.listBoxAutores.FormattingEnabled = true;
            this.listBoxAutores.Location = new System.Drawing.Point(38, 55);
            this.listBoxAutores.Name = "listBoxAutores";
            this.listBoxAutores.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxAutores.Size = new System.Drawing.Size(270, 82);
            this.listBoxAutores.TabIndex = 33;
            // 
            // btnCategoria
            // 
            this.btnCategoria.Location = new System.Drawing.Point(302, 19);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(36, 30);
            this.btnCategoria.TabIndex = 34;
            this.btnCategoria.Text = "+";
            this.btnCategoria.UseVisualStyleBackColor = true;
            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // listBoxCategorias
            // 
            this.listBoxCategorias.FormattingEnabled = true;
            this.listBoxCategorias.Location = new System.Drawing.Point(26, 55);
            this.listBoxCategorias.Name = "listBoxCategorias";
            this.listBoxCategorias.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxCategorias.Size = new System.Drawing.Size(270, 82);
            this.listBoxCategorias.TabIndex = 35;
            // 
            // LblImagen
            // 
            this.LblImagen.AutoSize = true;
            this.LblImagen.Location = new System.Drawing.Point(53, 248);
            this.LblImagen.Name = "LblImagen";
            this.LblImagen.Size = new System.Drawing.Size(99, 13);
            this.LblImagen.TabIndex = 36;
            this.LblImagen.Text = "Nombre del archivo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTitulo);
            this.groupBox1.Controls.Add(this.LblImagen);
            this.groupBox1.Controls.Add(this.txtIsbn);
            this.groupBox1.Controls.Add(this.lblIsbn);
            this.groupBox1.Controls.Add(this.txtTitulo);
            this.groupBox1.Controls.Add(this.txtEditorial);
            this.groupBox1.Controls.Add(this.lblEditorial);
            this.groupBox1.Controls.Add(this.txtSinopsis);
            this.groupBox1.Controls.Add(this.lblSinopsis);
            this.groupBox1.Controls.Add(this.lblCaratula);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.lblPrestable);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chckPrestable);
            this.groupBox1.Location = new System.Drawing.Point(59, 200);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(795, 231);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del libro";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnBuscarAutor);
            this.groupBox2.Controls.Add(this.txtAutor);
            this.groupBox2.Controls.Add(this.BtnAnadir);
            this.groupBox2.Controls.Add(this.listBoxAutores);
            this.groupBox2.Location = new System.Drawing.Point(59, 437);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(398, 174);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del Autor";
            // 
            // BtnBuscarAutor
            // 
            this.BtnBuscarAutor.Location = new System.Drawing.Point(357, 19);
            this.BtnBuscarAutor.Name = "BtnBuscarAutor";
            this.BtnBuscarAutor.Size = new System.Drawing.Size(36, 30);
            this.BtnBuscarAutor.TabIndex = 34;
            this.BtnBuscarAutor.Text = "B";
            this.BtnBuscarAutor.UseVisualStyleBackColor = true;
            this.BtnBuscarAutor.Click += new System.EventHandler(this.BtnBuscarAutor_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnBuscarCategoria);
            this.groupBox3.Controls.Add(this.txtCategoria);
            this.groupBox3.Controls.Add(this.btnCategoria);
            this.groupBox3.Controls.Add(this.listBoxCategorias);
            this.groupBox3.Location = new System.Drawing.Point(463, 437);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(392, 174);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos de la categoría";
            // 
            // BtnBuscarCategoria
            // 
            this.BtnBuscarCategoria.Location = new System.Drawing.Point(346, 19);
            this.BtnBuscarCategoria.Name = "BtnBuscarCategoria";
            this.BtnBuscarCategoria.Size = new System.Drawing.Size(36, 30);
            this.BtnBuscarCategoria.TabIndex = 36;
            this.BtnBuscarCategoria.Text = "B";
            this.BtnBuscarCategoria.UseVisualStyleBackColor = true;
            this.BtnBuscarCategoria.Click += new System.EventHandler(this.BtnBuscarCategoria_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(59, 631);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(190, 44);
            this.button2.TabIndex = 40;
            this.button2.Text = "- Borrar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // controlCabezera1
            // 
            this.controlCabezera1.Location = new System.Drawing.Point(36, -1);
            this.controlCabezera1.Name = "controlCabezera1";
            this.controlCabezera1.Size = new System.Drawing.Size(774, 129);
            this.controlCabezera1.TabIndex = 27;
            // 
            // FrmGestionarLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 700);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.controlCabezera1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.numUnidadesDisponiles);
            this.Controls.Add(this.BtnAplicar);
            this.Controls.Add(this.lblUnidadesDisponibles);
            this.Name = "FrmGestionarLibro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AñadirLibro";
            this.Load += new System.EventHandler(this.anadirLibro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUnidadesDisponiles)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.Button BtnAplicar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numUnidadesDisponiles;
        private System.Windows.Forms.CheckBox chckPrestable;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private ControlCabezera controlCabezera1;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Button BtnAnadir;
        private System.Windows.Forms.ListBox listBoxAutores;
        private System.Windows.Forms.Button btnCategoria;
        private System.Windows.Forms.ListBox listBoxCategorias;
        private System.Windows.Forms.Label LblImagen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnBuscarAutor;
        private System.Windows.Forms.Button BtnBuscarCategoria;
    }
}