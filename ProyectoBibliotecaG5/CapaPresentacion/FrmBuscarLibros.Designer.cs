namespace CapaPresentacion
{
    partial class FrmBuscarLibros
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
            this.btnComienzo = new System.Windows.Forms.Button();
            this.txtComienzo = new System.Windows.Forms.TextBox();
            this.btnTodos = new System.Windows.Forms.Button();
            this.dgvListaLibros = new System.Windows.Forms.DataGridView();
            this.lblTituloListaLibros = new System.Windows.Forms.Label();
            this.controlCabezera1 = new CapaPresentacion.ControlCabezera();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // btnComienzo
            // 
            this.btnComienzo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.btnComienzo.Location = new System.Drawing.Point(494, 440);
            this.btnComienzo.Margin = new System.Windows.Forms.Padding(2);
            this.btnComienzo.Name = "btnComienzo";
            this.btnComienzo.Size = new System.Drawing.Size(278, 41);
            this.btnComienzo.TabIndex = 39;
            this.btnComienzo.Text = "Mostrar por comienzo";
            this.btnComienzo.UseVisualStyleBackColor = true;
            this.btnComienzo.Click += new System.EventHandler(this.btnComienzo_Click);
            // 
            // txtComienzo
            // 
            this.txtComienzo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtComienzo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold);
            this.txtComienzo.Location = new System.Drawing.Point(494, 405);
            this.txtComienzo.Name = "txtComienzo";
            this.txtComienzo.Size = new System.Drawing.Size(277, 30);
            this.txtComienzo.TabIndex = 38;
            // 
            // btnTodos
            // 
            this.btnTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.btnTodos.Location = new System.Drawing.Point(29, 440);
            this.btnTodos.Margin = new System.Windows.Forms.Padding(2);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(210, 41);
            this.btnTodos.TabIndex = 37;
            this.btnTodos.Text = "Mostrar Tod@s";
            this.btnTodos.UseVisualStyleBackColor = true;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // dgvListaLibros
            // 
            this.dgvListaLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaLibros.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvListaLibros.Location = new System.Drawing.Point(42, 187);
            this.dgvListaLibros.Name = "dgvListaLibros";
            this.dgvListaLibros.Size = new System.Drawing.Size(711, 186);
            this.dgvListaLibros.TabIndex = 36;
            // 
            // lblTituloListaLibros
            // 
            this.lblTituloListaLibros.AutoSize = true;
            this.lblTituloListaLibros.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloListaLibros.Location = new System.Drawing.Point(245, 130);
            this.lblTituloListaLibros.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTituloListaLibros.Name = "lblTituloListaLibros";
            this.lblTituloListaLibros.Size = new System.Drawing.Size(281, 44);
            this.lblTituloListaLibros.TabIndex = 35;
            this.lblTituloListaLibros.Text = "Lista de Libros";
            // 
            // controlCabezera1
            // 
            this.controlCabezera1.Location = new System.Drawing.Point(29, -30);
            this.controlCabezera1.Name = "controlCabezera1";
            this.controlCabezera1.Size = new System.Drawing.Size(690, 163);
            this.controlCabezera1.TabIndex = 34;
            // 
            // FrmBuscarLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 507);
            this.Controls.Add(this.btnComienzo);
            this.Controls.Add(this.txtComienzo);
            this.Controls.Add(this.btnTodos);
            this.Controls.Add(this.dgvListaLibros);
            this.Controls.Add(this.lblTituloListaLibros);
            this.Controls.Add(this.controlCabezera1);
            this.Name = "FrmBuscarLibros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBuscarLibros";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaLibros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnComienzo;
        private System.Windows.Forms.TextBox txtComienzo;
        private System.Windows.Forms.Button btnTodos;
        private System.Windows.Forms.DataGridView dgvListaLibros;
        private System.Windows.Forms.Label lblTituloListaLibros;
        private ControlCabezera controlCabezera1;
    }
}