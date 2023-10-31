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
    public partial class FrmGestionarLibro : Form
    {
        string nombreFichero;
        Dictionary<string, Autor> diccionarioAutores;
        Dictionary<string, Categoria> diccionarioCategorias;
        public FrmGestionarLibro()
        {
            InitializeComponent();


            string error;
            List<Autor> autores = Program.gestor.ObtenerAutores(out error);
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (Autor autor in autores)
                {
                    listBoxAutores.Items.Add(autor);

                }
            }

            List<Categoria> categorias = Program.gestor.ObtenerCategorias(out error);
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (Categoria categoria in categorias)
                {
                    listBoxCategorias.Items.Add(categoria);

                }
            }


        }

        private void anadirLibro_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                nombreFichero = openFileDialog1.FileName;
                LblImagen.Text = nombreFichero;
            }
        }

        private void BtnAplicar_Click(object sender, EventArgs e)


        {
            if (!checkBox1.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtIsbn.Text) || string.IsNullOrWhiteSpace(txtTitulo.Text) || string.IsNullOrWhiteSpace(txtEditorial.Text) || string.IsNullOrWhiteSpace(txtSinopsis.Text) )
                {
                    MessageBox.Show("Por favor, completa todos los campos antes de continuar.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (listBoxAutores.SelectedItems.Count == 0 || listBoxCategorias.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Por favor, debe seleccionar al menos un autor y una categoría", "Listas vacías", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    List<Autor> autoresSeleccionados = new List<Autor>();
                    foreach (Autor autor in listBoxAutores.SelectedItems)
                    {

                        autoresSeleccionados.Add(autor);

                    }


                    List<Categoria> categoriasSeleccionadas = new List<Categoria>();
                    foreach (Categoria categoria in listBoxCategorias.SelectedItems)
                    {
                        categoriasSeleccionadas.Add(categoria);
                    }



                    bool esPrestable = chckPrestable.Checked;
                    string isbn = txtIsbn.Text;
                    string titulo = txtTitulo.Text;
                    string editorial = txtEditorial.Text;
                    string sinopsis = txtSinopsis.Text;
                    string caratula = string.IsNullOrWhiteSpace(nombreFichero) ? null : nombreFichero;
                    int cantidadUnidadesDisponibles = (int)numUnidadesDisponiles.Value;
                    string nombreBiblioteca = Program.gestor.biblioteca.Nombre;


                    Libro nuevoLibro = new Libro(isbn, titulo, editorial, sinopsis, caratula, cantidadUnidadesDisponibles, esPrestable, nombreBiblioteca , categoriasSeleccionadas, autoresSeleccionados);


                    if (!Program.gestor.AgregarLibro(nuevoLibro, out string err))
                    {
                        MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("EL libro se ha agregado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
            else
            {
                string isbn = txtIsbn.Text;
                if (string.IsNullOrWhiteSpace(isbn))
                {
                    MessageBox.Show("Por favor, completa el campo isbn.", "Campo obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (!Program.gestor.EliminarLibro(isbn, out string err))
                    {
                        MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("EL libro se ha borrado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {

                txtTitulo.Enabled = false;
                txtEditorial.Enabled = false;
                txtSinopsis.Enabled = false;
                numUnidadesDisponiles.Enabled = false;
                button1.Enabled = false;
                chckPrestable.Enabled = false;


            }
            else
            {
                txtTitulo.Enabled = true;
                txtEditorial.Enabled = true;
                txtSinopsis.Enabled = true;
                numUnidadesDisponiles.Enabled = true;
                button1.Enabled = true;
                chckPrestable.Enabled = true;


            }
        }


        private void BtnAnadir_Click(object sender, EventArgs e)
        {
            string nombreAutor = txtAutor.Text;
            if (nombreAutor.Length > 2)
            {
                if (!listBoxAutores.Items.Contains(nombreAutor))
                {

                    string error;
                    bool resultado = Program.gestor.AnadirAutor(nombreAutor, out error);

                    listBoxAutores.Items.Add(Program.gestor.ObtenerAutorPorNombre(nombreAutor, out error));
                    if (!resultado)
                    {
                        MessageBox.Show("Error al añadir el autor a la base de datos: " + error);
                        return;
                    }

                    
                }
                else
                {
                    MessageBox.Show("Este autor ya ha sido añadido.");
                }
            }
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            string nombreCategoria = txtCategoria.Text;
            if (nombreCategoria.Length > 2)
            {
                if (!listBoxCategorias.Items.Contains(nombreCategoria))
                {
                    // Añadir la categoría a la base de datos
                    string error;
                    bool resultado = Program.gestor.AnadirCategoria(nombreCategoria, out error);
                    if (!resultado)
                    {
                        MessageBox.Show("Error al añadir la categoría a la base de datos: " + error);
                        return;
                    }

                    listBoxCategorias.Items.Add(Program.gestor.ObtenerCategoriaPorNombre(nombreCategoria,out error));
                }
                else
                {
                    MessageBox.Show("Esta categoría ya ha sido añadida.");
                }
            }
        }

        private void BtnBuscarAutor_Click(object sender, EventArgs e)
        {
            List<Autor> autoresFiltrados = Program.gestor.ObtenerAutoresFiltrados(txtAutor.Text, out string error);

            if (!string.IsNullOrEmpty(error))
            {

                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                listBoxAutores.Items.Clear();
                foreach (Autor autor in autoresFiltrados)
                {
                    listBoxAutores.Items.Add(autor.Nombre);
                }
            }
        }

        private void BtnBuscarCategoria_Click(object sender, EventArgs e)
        {
            List<Categoria> categoriasFiltradas = Program.gestor.ObtenerCategoriasFiltradas(txtCategoria.Text, out string error);

            if (!string.IsNullOrEmpty(error))
            {

                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                listBoxCategorias.Items.Clear();
                foreach (Categoria categoria in categoriasFiltradas)
                {
                    listBoxCategorias.Items.Add(categoria.Descripcion);
                }
            }

        }

    }
}
