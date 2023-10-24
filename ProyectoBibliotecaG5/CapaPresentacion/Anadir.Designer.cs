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
            this.button1 = new System.Windows.Forms.Button();
            this.lblUnidadesDisponibles = new System.Windows.Forms.Label();
            this.lblPrestable = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numUnidadesDisponiles = new System.Windows.Forms.NumericUpDown();
            this.lblTituloAnadirLibro = new System.Windows.Forms.Label();
            this.lstlibros = new System.Windows.Forms.ListBox();
            this.chckPrestable = new System.Windows.Forms.CheckBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnDeseleccionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numUnidadesDisponiles)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIsbn
            // 
            this.txtIsbn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIsbn.Font = new System.Drawing.Font("Gotham", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIsbn.Location = new System.Drawing.Point(141, 115);
            this.txtIsbn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(151, 37);
            this.txtIsbn.TabIndex = 0;
            // 
            // lblIsbn
            // 
            this.lblIsbn.AutoSize = true;
            this.lblIsbn.Font = new System.Drawing.Font("Gotham", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsbn.Location = new System.Drawing.Point(132, 67);
            this.lblIsbn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIsbn.Name = "lblIsbn";
            this.lblIsbn.Size = new System.Drawing.Size(103, 44);
            this.lblIsbn.TabIndex = 1;
            this.lblIsbn.Text = "Isbn";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Gotham", 24F);
            this.lblTitulo.Location = new System.Drawing.Point(374, 67);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(134, 44);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Titulo";
            // 
            // txtTitulo
            // 
            this.txtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitulo.Font = new System.Drawing.Font("Gotham", 19.8F, System.Drawing.FontStyle.Bold);
            this.txtTitulo.Location = new System.Drawing.Point(383, 115);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(197, 37);
            this.txtTitulo.TabIndex = 2;
            // 
            // lblEditorial
            // 
            this.lblEditorial.AutoSize = true;
            this.lblEditorial.Font = new System.Drawing.Font("Gotham", 24F);
            this.lblEditorial.Location = new System.Drawing.Point(133, 164);
            this.lblEditorial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEditorial.Name = "lblEditorial";
            this.lblEditorial.Size = new System.Drawing.Size(187, 44);
            this.lblEditorial.TabIndex = 5;
            this.lblEditorial.Text = "Editorial";
            // 
            // txtEditorial
            // 
            this.txtEditorial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEditorial.Font = new System.Drawing.Font("Gotham", 19.8F, System.Drawing.FontStyle.Bold);
            this.txtEditorial.Location = new System.Drawing.Point(141, 212);
            this.txtEditorial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEditorial.Name = "txtEditorial";
            this.txtEditorial.Size = new System.Drawing.Size(179, 37);
            this.txtEditorial.TabIndex = 4;
            // 
            // lblSinopsis
            // 
            this.lblSinopsis.AutoSize = true;
            this.lblSinopsis.Font = new System.Drawing.Font("Gotham", 24F);
            this.lblSinopsis.Location = new System.Drawing.Point(375, 164);
            this.lblSinopsis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSinopsis.Name = "lblSinopsis";
            this.lblSinopsis.Size = new System.Drawing.Size(185, 44);
            this.lblSinopsis.TabIndex = 7;
            this.lblSinopsis.Text = "Sinopsis";
            // 
            // txtSinopsis
            // 
            this.txtSinopsis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSinopsis.Font = new System.Drawing.Font("Gotham", 19.8F, System.Drawing.FontStyle.Bold);
            this.txtSinopsis.Location = new System.Drawing.Point(383, 212);
            this.txtSinopsis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSinopsis.Name = "txtSinopsis";
            this.txtSinopsis.Size = new System.Drawing.Size(177, 37);
            this.txtSinopsis.TabIndex = 6;
            // 
            // lblCaratula
            // 
            this.lblCaratula.AutoSize = true;
            this.lblCaratula.Font = new System.Drawing.Font("Gotham", 24F);
            this.lblCaratula.Location = new System.Drawing.Point(132, 277);
            this.lblCaratula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCaratula.Name = "lblCaratula";
            this.lblCaratula.Size = new System.Drawing.Size(186, 44);
            this.lblCaratula.TabIndex = 9;
            this.lblCaratula.Text = "Caratula";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Gotham", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(140, 329);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 28);
            this.button1.TabIndex = 12;
            this.button1.Text = "Seleccionar Imagen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblUnidadesDisponibles
            // 
            this.lblUnidadesDisponibles.AutoSize = true;
            this.lblUnidadesDisponibles.Font = new System.Drawing.Font("Gotham", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidadesDisponibles.Location = new System.Drawing.Point(179, 373);
            this.lblUnidadesDisponibles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnidadesDisponibles.Name = "lblUnidadesDisponibles";
            this.lblUnidadesDisponibles.Size = new System.Drawing.Size(335, 33);
            this.lblUnidadesDisponibles.TabIndex = 14;
            this.lblUnidadesDisponibles.Text = "Unidades Disponibles";
            // 
            // lblPrestable
            // 
            this.lblPrestable.AutoSize = true;
            this.lblPrestable.Font = new System.Drawing.Font("Gotham", 24F);
            this.lblPrestable.Location = new System.Drawing.Point(375, 277);
            this.lblPrestable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrestable.Name = "lblPrestable";
            this.lblPrestable.Size = new System.Drawing.Size(207, 44);
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
            this.btnAgregar.Font = new System.Drawing.Font("Gotham", 19.8F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.Location = new System.Drawing.Point(152, 487);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(213, 54);
            this.btnAgregar.TabIndex = 17;
            this.btnAgregar.Text = "➕Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "(Ej: 123A)";
            // 
            // numUnidadesDisponiles
            // 
            this.numUnidadesDisponiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numUnidadesDisponiles.Font = new System.Drawing.Font("Gotham", 19.8F, System.Drawing.FontStyle.Bold);
            this.numUnidadesDisponiles.Location = new System.Drawing.Point(286, 423);
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
            this.numUnidadesDisponiles.Size = new System.Drawing.Size(120, 40);
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
            this.lblTituloAnadirLibro.Font = new System.Drawing.Font("Gotham", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloAnadirLibro.Location = new System.Drawing.Point(312, 9);
            this.lblTituloAnadirLibro.Name = "lblTituloAnadirLibro";
            this.lblTituloAnadirLibro.Size = new System.Drawing.Size(395, 53);
            this.lblTituloAnadirLibro.TabIndex = 22;
            this.lblTituloAnadirLibro.Text = "Gestionar Libro";
            // 
            // lstlibros
            // 
            this.lstlibros.Font = new System.Drawing.Font("Gotham", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstlibros.FormattingEnabled = true;
            this.lstlibros.ItemHeight = 30;
            this.lstlibros.Location = new System.Drawing.Point(665, 115);
            this.lstlibros.Name = "lstlibros";
            this.lstlibros.Size = new System.Drawing.Size(280, 394);
            this.lstlibros.TabIndex = 23;
            // 
            // chckPrestable
            // 
            this.chckPrestable.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chckPrestable.Font = new System.Drawing.Font("Gotham", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckPrestable.Location = new System.Drawing.Point(458, 329);
            this.chckPrestable.Name = "chckPrestable";
            this.chckPrestable.Size = new System.Drawing.Size(20, 24);
            this.chckPrestable.TabIndex = 24;
            this.chckPrestable.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoSize = true;
            this.btnEliminar.BackColor = System.Drawing.Color.Tomato;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.Font = new System.Drawing.Font("Gotham", 19.8F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.Location = new System.Drawing.Point(383, 487);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(203, 54);
            this.btnEliminar.TabIndex = 25;
            this.btnEliminar.Text = "❌Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnDeseleccionar
            // 
            this.btnDeseleccionar.AutoSize = true;
            this.btnDeseleccionar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeseleccionar.FlatAppearance.BorderSize = 0;
            this.btnDeseleccionar.Font = new System.Drawing.Font("Gotham", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeseleccionar.Location = new System.Drawing.Point(793, 516);
            this.btnDeseleccionar.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeseleccionar.Name = "btnDeseleccionar";
            this.btnDeseleccionar.Size = new System.Drawing.Size(152, 29);
            this.btnDeseleccionar.TabIndex = 26;
            this.btnDeseleccionar.Text = "Deseleccionar";
            this.btnDeseleccionar.UseVisualStyleBackColor = false;
            // 
            // Anadir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 554);
            this.Controls.Add(this.btnDeseleccionar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.chckPrestable);
            this.Controls.Add(this.lstlibros);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Anadir";
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
        private System.Windows.Forms.ListBox lstlibros;
        private System.Windows.Forms.CheckBox chckPrestable;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnDeseleccionar;
    }
}