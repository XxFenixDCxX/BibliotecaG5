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
    public partial class FrmBuscarLibros : Form
    {
        public FrmBuscarLibros()
        {
            InitializeComponent();
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            List<Libro> libros = Program.gestor.devolverListaDeLibros(out string error);
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            dgvListaLibros.DataSource = null;
            if (libros.Count == 0)
            {
                MessageBox.Show("No hay ninguno", "Atenció ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            dgvListaLibros.DataSource = libros;
            //MessageBox.Show("kdjf");
            //dgvListaLibros.DataSource = (from l in libros
            //                             select new { l.Isbn, l.Titulo, Autor1 = (l.Autores!=null? l.Autores[0].Nombre : "NO tiene")}).ToList();

        }

        private void btnComienzo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtComienzo.Text))
            {
                MessageBox.Show("El comienzo no puede estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            List<Libro> libros = Program.gestor.devolverListaDeLibrosPorComienzo(txtComienzo.Text, out string errores);
            if (!string.IsNullOrEmpty(errores))
            {
                MessageBox.Show(errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            dgvListaLibros.DataSource = null;
            if (libros.Count == 0)
            {
                MessageBox.Show("No hay ninguno", "Atenció ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            dgvListaLibros.DataSource = libros;
        }

        private void dgvListaLibros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
