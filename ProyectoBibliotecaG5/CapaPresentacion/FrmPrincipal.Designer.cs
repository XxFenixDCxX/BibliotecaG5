namespace CapaPresentacion
{
    partial class FrmPrincipal
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lblListaMorosos = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.btnGestionarLibros = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscarLectores = new System.Windows.Forms.Button();
            this.btnGestionarLector = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.controlCabezera1 = new CapaPresentacion.ControlCabezera();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Info;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(17, 84);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(210, 41);
            this.button3.TabIndex = 4;
            this.button3.Text = "Prestámos";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(8, 141);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(210, 41);
            this.button4.TabIndex = 5;
            this.button4.Text = "Devoluciones";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // lblListaMorosos
            // 
            this.lblListaMorosos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblListaMorosos.Location = new System.Drawing.Point(10, 187);
            this.lblListaMorosos.Margin = new System.Windows.Forms.Padding(2);
            this.lblListaMorosos.Name = "lblListaMorosos";
            this.lblListaMorosos.Size = new System.Drawing.Size(230, 65);
            this.lblListaMorosos.TabIndex = 6;
            this.lblListaMorosos.Text = "Lista de Morosos";
            this.lblListaMorosos.UseVisualStyleBackColor = true;
            this.lblListaMorosos.Click += new System.EventHandler(this.lblListaMorosos_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.btnGestionarLibros);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(148, 231);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(225, 203);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Libros";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(8, 38);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(210, 41);
            this.button6.TabIndex = 6;
            this.button6.Text = "Buscar";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // btnGestionarLibros
            // 
            this.btnGestionarLibros.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionarLibros.Location = new System.Drawing.Point(8, 96);
            this.btnGestionarLibros.Margin = new System.Windows.Forms.Padding(2);
            this.btnGestionarLibros.Name = "btnGestionarLibros";
            this.btnGestionarLibros.Size = new System.Drawing.Size(210, 41);
            this.btnGestionarLibros.TabIndex = 2;
            this.btnGestionarLibros.Text = "Gestionar libros";
            this.btnGestionarLibros.UseVisualStyleBackColor = true;
            this.btnGestionarLibros.Click += new System.EventHandler(this.btnGestionarLibros_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBuscarLectores);
            this.groupBox2.Controls.Add(this.btnGestionarLector);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.lblListaMorosos);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(433, 228);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(244, 268);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lectores";
            // 
            // btnBuscarLectores
            // 
            this.btnBuscarLectores.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnBuscarLectores.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarLectores.Location = new System.Drawing.Point(17, 38);
            this.btnBuscarLectores.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarLectores.Name = "btnBuscarLectores";
            this.btnBuscarLectores.Size = new System.Drawing.Size(210, 41);
            this.btnBuscarLectores.TabIndex = 7;
            this.btnBuscarLectores.Text = "Buscar";
            this.btnBuscarLectores.UseVisualStyleBackColor = false;
            this.btnBuscarLectores.Click += new System.EventHandler(this.btnBuscarLectores_Click);
            // 
            // btnGestionarLector
            // 
            this.btnGestionarLector.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionarLector.Location = new System.Drawing.Point(17, 141);
            this.btnGestionarLector.Margin = new System.Windows.Forms.Padding(2);
            this.btnGestionarLector.Name = "btnGestionarLector";
            this.btnGestionarLector.Size = new System.Drawing.Size(210, 41);
            this.btnGestionarLector.TabIndex = 7;
            this.btnGestionarLector.Text = "Gestionar lector";
            this.btnGestionarLector.UseVisualStyleBackColor = true;
            this.btnGestionarLector.Click += new System.EventHandler(this.btnGestionarLector_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(321, 190);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Gestiones con";
            // 
            // controlCabezera1
            // 
            this.controlCabezera1.Location = new System.Drawing.Point(33, 24);
            this.controlCabezera1.Name = "controlCabezera1";
            this.controlCabezera1.Size = new System.Drawing.Size(690, 163);
            this.controlCabezera1.TabIndex = 10;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 507);
            this.Controls.Add(this.controlCabezera1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biblioteca";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button lblListaMorosos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGestionarLibros;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnGestionarLector;
        private System.Windows.Forms.Button btnBuscarLectores;
        private ControlCabezera controlCabezera;
        private ControlCabezera controlCabezera1;
    }
}

