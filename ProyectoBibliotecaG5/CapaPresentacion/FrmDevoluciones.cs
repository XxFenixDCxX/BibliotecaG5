using CapaDatos;
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
    public partial class FrmDevoluciones : Form
    {
        Gestor gestor = new Gestor();
        public FrmDevoluciones()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Aquí puedes cargar datos de la tabla "Libro" en un DataGridView
            dgvLibros.Rows.Clear();
            List<Libro> libros = new List<Libro>();
            libros.AddRange(gestor.devolverListaDeLibros(out string err));
            // Ejemplo: dgvLibros.DataSource = ObtenerDatosLibros();
            dgvLibros.DataSource = libros;
        }

        private void btnAgregarLibro_Click(object sender, EventArgs e)
        {
            // Aquí puedes abrir un nuevo formulario o cuadro de diálogo para agregar un nuevo libro
            // Ejemplo: AgregarLibroForm agregarLibroForm = new AgregarLibroForm();
            // agregarLibroForm.ShowDialog();
        }

        // Puedes agregar otros eventos para editar o eliminar libros

        private void btnEditarLibro_Click(object sender, EventArgs e)
        {
            // Aquí puedes abrir un formulario para editar un libro seleccionado en el DataGridView
        }

        private void btnEliminarLibro_Click(object sender, EventArgs e)
        {
            // Aquí puedes eliminar un libro seleccionado en el DataGridView
        }

    }
}
