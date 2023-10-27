using CapaEntidades;
using System;
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
    public partial class FrmListaDeMorosos : Form
    {
        public FrmListaDeMorosos()
        {
            InitializeComponent();
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            List<Lector> lectores = Program.gestor.devolverListaDeMorosos(out string error);
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            dgvMorosos.DataSource = null;
            if (lectores.Count == 0)
            {
                MessageBox.Show("No hay ninguno", "Atenció ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            dgvMorosos.DataSource = lectores;
        }

        private void btnComienzo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtComienzo.Text))
            {
                MessageBox.Show("El comienzo no puede estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            List<Lector> lectores = Program.gestor.devolverListaDeMorososPorComienzo(txtComienzo.Text, out string errores);
            if (!string.IsNullOrEmpty(errores))
            {
                MessageBox.Show(errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            dgvMorosos.DataSource = null;
            if (lectores.Count == 0)
            {
                MessageBox.Show("No hay ninguno", "Atenció ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            dgvMorosos.DataSource = lectores;
        }
    }
}
