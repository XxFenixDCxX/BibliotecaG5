namespace CapaPresentacion
{
    partial class FrmBuscarLector
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
            this.dgvListaLectores = new System.Windows.Forms.DataGridView();
            this.lblTituloAnadirLibro = new System.Windows.Forms.Label();
            this.controlCabezera1 = new CapaPresentacion.ControlCabezera();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaLectores)).BeginInit();
            this.SuspendLayout();
            // 
            // btnComienzo
            // 
            this.btnComienzo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.btnComienzo.Location = new System.Drawing.Point(494, 465);
            this.btnComienzo.Margin = new System.Windows.Forms.Padding(2);
            this.btnComienzo.Name = "btnComienzo";
            this.btnComienzo.Size = new System.Drawing.Size(278, 41);
            this.btnComienzo.TabIndex = 33;
            this.btnComienzo.Text = "Mostrar por comienzo";
            this.btnComienzo.UseVisualStyleBackColor = true;
            this.btnComienzo.Click += new System.EventHandler(this.btnComienzo_Click);
            // 
            // txtComienzo
            // 
            this.txtComienzo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtComienzo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold);
            this.txtComienzo.Location = new System.Drawing.Point(494, 430);
            this.txtComienzo.Name = "txtComienzo";
            this.txtComienzo.Size = new System.Drawing.Size(277, 30);
            this.txtComienzo.TabIndex = 32;
            // 
            // btnTodos
            // 
            this.btnTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.btnTodos.Location = new System.Drawing.Point(29, 465);
            this.btnTodos.Margin = new System.Windows.Forms.Padding(2);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(210, 41);
            this.btnTodos.TabIndex = 31;
            this.btnTodos.Text = "Mostrar Tod@s";
            this.btnTodos.UseVisualStyleBackColor = true;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // dgvListaLectores
            // 
            this.dgvListaLectores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaLectores.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvListaLectores.Location = new System.Drawing.Point(42, 212);
            this.dgvListaLectores.Name = "dgvListaLectores";
            this.dgvListaLectores.Size = new System.Drawing.Size(711, 186);
            this.dgvListaLectores.TabIndex = 30;
            // 
            // lblTituloAnadirLibro
            // 
            this.lblTituloAnadirLibro.AutoSize = true;
            this.lblTituloAnadirLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloAnadirLibro.Location = new System.Drawing.Point(245, 155);
            this.lblTituloAnadirLibro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTituloAnadirLibro.Name = "lblTituloAnadirLibro";
            this.lblTituloAnadirLibro.Size = new System.Drawing.Size(325, 44);
            this.lblTituloAnadirLibro.TabIndex = 29;
            this.lblTituloAnadirLibro.Text = "Lista de Lectores";
            // 
            // controlCabezera1
            // 
            this.controlCabezera1.Location = new System.Drawing.Point(29, -5);
            this.controlCabezera1.Name = "controlCabezera1";
            this.controlCabezera1.Size = new System.Drawing.Size(690, 163);
            this.controlCabezera1.TabIndex = 28;
            // 
            // FrmBuscarLector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 536);
            this.Controls.Add(this.btnComienzo);
            this.Controls.Add(this.txtComienzo);
            this.Controls.Add(this.btnTodos);
            this.Controls.Add(this.dgvListaLectores);
            this.Controls.Add(this.lblTituloAnadirLibro);
            this.Controls.Add(this.controlCabezera1);
            this.Name = "FrmBuscarLector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBuscarLector";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaLectores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnComienzo;
        private System.Windows.Forms.TextBox txtComienzo;
        private System.Windows.Forms.Button btnTodos;
        private System.Windows.Forms.DataGridView dgvListaLectores;
        private System.Windows.Forms.Label lblTituloAnadirLibro;
        private ControlCabezera controlCabezera1;
    }
}