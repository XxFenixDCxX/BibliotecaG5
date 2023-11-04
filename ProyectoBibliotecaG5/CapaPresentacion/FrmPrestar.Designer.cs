namespace CapaPresentacion
{
    partial class FrmPrestar
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstNombreLector = new System.Windows.Forms.ListBox();
            this.lstNombreLibro = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstCarnetLector = new System.Windows.Forms.ListBox();
            this.btnPrestarLibro = new System.Windows.Forms.Button();
            this.lstListaISBN = new System.Windows.Forms.ListBox();
            this.controlCabezera1 = new CapaPresentacion.ControlCabezera();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(503, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Nombre Lector";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Nombre Libro";
            // 
            // lstNombreLector
            // 
            this.lstNombreLector.FormattingEnabled = true;
            this.lstNombreLector.Location = new System.Drawing.Point(494, 258);
            this.lstNombreLector.Name = "lstNombreLector";
            this.lstNombreLector.Size = new System.Drawing.Size(103, 186);
            this.lstNombreLector.TabIndex = 16;
            this.lstNombreLector.SelectedIndexChanged += new System.EventHandler(this.lstNombreLector_SelectedIndexChanged_1);
            // 
            // lstNombreLibro
            // 
            this.lstNombreLibro.FormattingEnabled = true;
            this.lstNombreLibro.Location = new System.Drawing.Point(255, 258);
            this.lstNombreLibro.Name = "lstNombreLibro";
            this.lstNombreLibro.Size = new System.Drawing.Size(124, 186);
            this.lstNombreLibro.TabIndex = 15;
            this.lstNombreLibro.SelectedIndexChanged += new System.EventHandler(this.lstNombreLibro_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Isbn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(409, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "CarnetLector";
            // 
            // lstCarnetLector
            // 
            this.lstCarnetLector.FormattingEnabled = true;
            this.lstCarnetLector.Location = new System.Drawing.Point(412, 258);
            this.lstCarnetLector.Name = "lstCarnetLector";
            this.lstCarnetLector.Size = new System.Drawing.Size(85, 186);
            this.lstCarnetLector.TabIndex = 12;
            this.lstCarnetLector.SelectedIndexChanged += new System.EventHandler(this.lstCarnetLector_SelectedIndexChanged);
            // 
            // btnPrestarLibro
            // 
            this.btnPrestarLibro.Location = new System.Drawing.Point(330, 181);
            this.btnPrestarLibro.Name = "btnPrestarLibro";
            this.btnPrestarLibro.Size = new System.Drawing.Size(147, 49);
            this.btnPrestarLibro.TabIndex = 11;
            this.btnPrestarLibro.Text = "Prestar Libro";
            this.btnPrestarLibro.UseVisualStyleBackColor = true;
            this.btnPrestarLibro.Click += new System.EventHandler(this.btnPrestarLibro_Click);
            // 
            // lstListaISBN
            // 
            this.lstListaISBN.FormattingEnabled = true;
            this.lstListaISBN.Location = new System.Drawing.Point(166, 258);
            this.lstListaISBN.Name = "lstListaISBN";
            this.lstListaISBN.Size = new System.Drawing.Size(92, 186);
            this.lstListaISBN.TabIndex = 10;
            // 
            // controlCabezera1
            // 
            this.controlCabezera1.Location = new System.Drawing.Point(40, 12);
            this.controlCabezera1.Name = "controlCabezera1";
            this.controlCabezera1.Size = new System.Drawing.Size(690, 163);
            this.controlCabezera1.TabIndex = 19;
            this.controlCabezera1.Load += new System.EventHandler(this.controlCabezera1_Load);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(113, 196);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 20);
            this.textBox1.TabIndex = 20;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(586, 196);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(185, 20);
            this.textBox2.TabIndex = 21;
            // 
            // FrmPrestar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.controlCabezera1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstNombreLector);
            this.Controls.Add(this.lstNombreLibro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstCarnetLector);
            this.Controls.Add(this.btnPrestarLibro);
            this.Controls.Add(this.lstListaISBN);
            this.Name = "FrmPrestar";
            this.Text = "FrmPrestar";
            this.Load += new System.EventHandler(this.FrmPrestar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstNombreLector;
        private System.Windows.Forms.ListBox lstNombreLibro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstCarnetLector;
        private System.Windows.Forms.Button btnPrestarLibro;
        private System.Windows.Forms.ListBox lstListaISBN;
        private ControlCabezera controlCabezera1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}