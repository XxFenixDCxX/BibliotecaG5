namespace CapaPresentacion
{
    partial class Principal
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gotham XLight", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(693, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido/a a la Biblioteca\r\nde                       ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Gotham", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(393, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(383, 56);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cuatrovientos";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Info;
            this.button3.Font = new System.Drawing.Font("Gotham", 18F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(14, 103);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(280, 50);
            this.button3.TabIndex = 4;
            this.button3.Text = "Prestámos";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Gotham", 18F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(10, 174);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(280, 50);
            this.button4.TabIndex = 5;
            this.button4.Text = "Devoluciones";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Gotham", 18F, System.Drawing.FontStyle.Bold);
            this.button5.Location = new System.Drawing.Point(14, 230);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(280, 80);
            this.button5.TabIndex = 6;
            this.button5.Text = "Lista de Morosos";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Font = new System.Drawing.Font("Gotham", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(193, 214);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 250);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Libros";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Gotham", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(10, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(280, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "Gestionar libros";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Font = new System.Drawing.Font("Gotham", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(573, 211);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 330);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Usuarios";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gotham", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(424, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 33);
            this.label3.TabIndex = 9;
            this.label3.Text = "Gestiones con";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button6.Font = new System.Drawing.Font("Gotham", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(10, 47);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(280, 50);
            this.button6.TabIndex = 6;
            this.button6.Text = "Buscar";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Gotham", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(14, 174);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(280, 50);
            this.button2.TabIndex = 7;
            this.button2.Text = "Gestionar lector";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button7.Font = new System.Drawing.Font("Gotham", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(14, 47);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(280, 50);
            this.button7.TabIndex = 7;
            this.button7.Text = "Buscar";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 553);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Principal";
            this.Text = "Biblioteca";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button7;
    }
}

