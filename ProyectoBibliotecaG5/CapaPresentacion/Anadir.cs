﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Anadir : Form
    {
        public Anadir()
        {
            InitializeComponent();
        }

        private void anadirLibro_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ofdAbrirFichero.ShowDialog();
            MessageBox.Show(ofdAbrirFichero.);
        }
    }
}
