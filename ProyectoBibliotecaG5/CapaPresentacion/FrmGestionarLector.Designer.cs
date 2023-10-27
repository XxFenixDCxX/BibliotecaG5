namespace CapaPresentacion
{
    partial class FrmGestionarLector
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
            this.lblEliminar = new System.Windows.Forms.Label();
            this.chcEliminar = new System.Windows.Forms.CheckBox();
            this.lblTituloGestionarLector = new System.Windows.Forms.Label();
            this.lblEjemploCarne = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblINumeroCarne = new System.Windows.Forms.Label();
            this.txtCarnet = new System.Windows.Forms.TextBox();
            this.lblCamposObligatorios = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.controlCabezera1 = new CapaPresentacion.ControlCabezera();
            this.SuspendLayout();
            // 
            // lblEliminar
            // 
            this.lblEliminar.AutoSize = true;
            this.lblEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lblEliminar.Location = new System.Drawing.Point(264, 252);
            this.lblEliminar.Name = "lblEliminar";
            this.lblEliminar.Size = new System.Drawing.Size(263, 37);
            this.lblEliminar.TabIndex = 9;
            this.lblEliminar.Text = "¿Desea eliminar?";
            // 
            // chcEliminar
            // 
            this.chcEliminar.AutoSize = true;
            this.chcEliminar.Location = new System.Drawing.Point(378, 292);
            this.chcEliminar.Name = "chcEliminar";
            this.chcEliminar.Size = new System.Drawing.Size(15, 14);
            this.chcEliminar.TabIndex = 1;
            this.chcEliminar.UseVisualStyleBackColor = true;
            this.chcEliminar.CheckedChanged += new System.EventHandler(this.chcEliminar_CheckedChanged);
            // 
            // lblTituloGestionarLector
            // 
            this.lblTituloGestionarLector.AutoSize = true;
            this.lblTituloGestionarLector.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloGestionarLector.Location = new System.Drawing.Point(240, 208);
            this.lblTituloGestionarLector.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTituloGestionarLector.Name = "lblTituloGestionarLector";
            this.lblTituloGestionarLector.Size = new System.Drawing.Size(317, 44);
            this.lblTituloGestionarLector.TabIndex = 8;
            this.lblTituloGestionarLector.Text = "Gestionar Lector";
            // 
            // lblEjemploCarne
            // 
            this.lblEjemploCarne.AutoSize = true;
            this.lblEjemploCarne.Location = new System.Drawing.Point(329, 340);
            this.lblEjemploCarne.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEjemploCarne.Name = "lblEjemploCarne";
            this.lblEjemploCarne.Size = new System.Drawing.Size(53, 13);
            this.lblEjemploCarne.TabIndex = 11;
            this.lblEjemploCarne.Text = "(Ej: 123A)";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lblTelefono.Location = new System.Drawing.Point(430, 395);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(141, 37);
            this.lblTelefono.TabIndex = 14;
            this.lblTelefono.Text = "Telefono";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold);
            this.txtTelefono.Location = new System.Drawing.Point(436, 434);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(148, 30);
            this.txtTelefono.TabIndex = 5;
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lblContrasena.Location = new System.Drawing.Point(228, 395);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(195, 37);
            this.lblContrasena.TabIndex = 13;
            this.lblContrasena.Text = "Contraseña*";
            // 
            // txtContrasena
            // 
            this.txtContrasena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold);
            this.txtContrasena.Location = new System.Drawing.Point(235, 434);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(154, 30);
            this.txtContrasena.TabIndex = 4;
            this.txtContrasena.UseSystemPasswordChar = true;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lblNombre.Location = new System.Drawing.Point(429, 316);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(144, 37);
            this.lblNombre.TabIndex = 12;
            this.lblNombre.Text = "Nombre*";
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold);
            this.txtNombre.Location = new System.Drawing.Point(436, 355);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(148, 30);
            this.txtNombre.TabIndex = 3;
            // 
            // lblINumeroCarne
            // 
            this.lblINumeroCarne.AutoSize = true;
            this.lblINumeroCarne.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblINumeroCarne.Location = new System.Drawing.Point(228, 315);
            this.lblINumeroCarne.Name = "lblINumeroCarne";
            this.lblINumeroCarne.Size = new System.Drawing.Size(125, 37);
            this.lblINumeroCarne.TabIndex = 10;
            this.lblINumeroCarne.Text = "Carnet*";
            // 
            // txtCarnet
            // 
            this.txtCarnet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCarnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarnet.Location = new System.Drawing.Point(235, 355);
            this.txtCarnet.Name = "txtCarnet";
            this.txtCarnet.Size = new System.Drawing.Size(133, 30);
            this.txtCarnet.TabIndex = 2;
            // 
            // lblCamposObligatorios
            // 
            this.lblCamposObligatorios.AutoSize = true;
            this.lblCamposObligatorios.Location = new System.Drawing.Point(325, 603);
            this.lblCamposObligatorios.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCamposObligatorios.Name = "lblCamposObligatorios";
            this.lblCamposObligatorios.Size = new System.Drawing.Size(168, 13);
            this.lblCamposObligatorios.TabIndex = 39;
            this.lblCamposObligatorios.Text = "Los campos con * son obligatorios";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lblEmail.Location = new System.Drawing.Point(264, 472);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(109, 37);
            this.lblEmail.TabIndex = 15;
            this.lblEmail.Text = "Email*";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold);
            this.txtEmail.Location = new System.Drawing.Point(271, 512);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(256, 30);
            this.txtEmail.TabIndex = 6;
            // 
            // btnAplicar
            // 
            this.btnAplicar.AutoSize = true;
            this.btnAplicar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAplicar.FlatAppearance.BorderSize = 0;
            this.btnAplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold);
            this.btnAplicar.Location = new System.Drawing.Point(329, 555);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(160, 44);
            this.btnAplicar.TabIndex = 7;
            this.btnAplicar.Text = "➕Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = false;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // controlCabezera1
            // 
            this.controlCabezera1.Location = new System.Drawing.Point(51, 32);
            this.controlCabezera1.Name = "controlCabezera1";
            this.controlCabezera1.Size = new System.Drawing.Size(690, 163);
            this.controlCabezera1.TabIndex = 40;
            // 
            // FrmGestionarLector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 635);
            this.Controls.Add(this.controlCabezera1);
            this.Controls.Add(this.btnAplicar);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblCamposObligatorios);
            this.Controls.Add(this.lblEjemploCarne);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblContrasena);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblINumeroCarne);
            this.Controls.Add(this.txtCarnet);
            this.Controls.Add(this.lblEliminar);
            this.Controls.Add(this.chcEliminar);
            this.Controls.Add(this.lblTituloGestionarLector);
            this.Name = "FrmGestionarLector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGestionarLector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEliminar;
        private System.Windows.Forms.CheckBox chcEliminar;
        private System.Windows.Forms.Label lblTituloGestionarLector;
        private System.Windows.Forms.Label lblEjemploCarne;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblINumeroCarne;
        private System.Windows.Forms.TextBox txtCarnet;
        private System.Windows.Forms.Label lblCamposObligatorios;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnAplicar;
        private ControlCabezera controlCabezera1;
    }
}