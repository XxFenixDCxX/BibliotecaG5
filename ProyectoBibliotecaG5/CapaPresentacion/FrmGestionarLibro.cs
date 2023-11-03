using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmGestionarLibro : Form
    {
        string rutaCaratula;
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
                var ficheroSplit = nombreFichero.Split('\\');
                rutaCaratula = "./imagenes/" + ficheroSplit[ficheroSplit.Length - 1];
                File.Copy(nombreFichero, rutaCaratula);
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
                    string isbn = txtIsbn.Text.Trim();
                    string titulo = txtTitulo.Text.Trim();
                    string editorial = txtEditorial.Text.Trim();
                    string sinopsis = txtSinopsis.Text.Trim();
                    string caratula = string.IsNullOrWhiteSpace(nombreFichero) ? null : nombreFichero;
                    int cantidadUnidadesDisponibles = (int)numUnidadesDisponiles.Value;
                    string nombreBiblioteca = Program.gestor.biblioteca.Nombre;


                    Libro nuevoLibro = new Libro(isbn, titulo, editorial, sinopsis, rutaCaratula, cantidadUnidadesDisponibles, esPrestable, nombreBiblioteca , categoriasSeleccionadas, autoresSeleccionados);


                    if (!Program.gestor.AgregarLibro(nuevoLibro, out string err))
                    {
                        MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("EL libro se ha agregado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtAutor.Clear();
                        txtCategoria.Clear();
                        txtIsbn.Clear();
                        txtSinopsis.Clear();
                        txtTitulo.Clear();
                        LblImagen.ResetText();
                        txtEditorial.Clear();

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
                        txtAutor.Clear();
                        txtCategoria.Clear();
                        txtIsbn.Clear();
                        txtSinopsis.Clear();
                        txtTitulo.Clear();
                        LblImagen.ResetText();
                        txtEditorial.Clear();
                    }
                }
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {

                txtTitulo.Visible = false;
                txtEditorial.Visible = false;
                txtSinopsis.Visible = false;
                numUnidadesDisponiles.Visible = false;
                button1.Visible = false;
                chckPrestable.Visible = false;
                groupBox2.Visible = false;
                groupBox3.Visible = false;
                lblUnidadesDisponibles.Visible = false;
                lblCaratula.Visible = false;
                lblEditorial.Visible = false;
                lblPrestable.Visible = false;
                lblSinopsis.Visible = false;
                lblTitulo.Visible = false;
                LblImagen.Visible = false;
                lblIsbn.Location = new Point(150, 120);
                lblIsbn.Visible = true;
                txtIsbn.Location = new Point(250,120);
                txtIsbn.Visible = true;
                label1.Visible = false;

            }
            else
            {
                txtTitulo.Visible = true;
                txtEditorial.Visible = true;
                txtSinopsis.Visible = true;
                numUnidadesDisponiles.Visible = true;
                button1.Visible = true;
                chckPrestable.Visible = true;
                groupBox2.Visible = true;
                groupBox3.Visible = true;
                lblUnidadesDisponibles.Visible = true;
                lblCaratula.Visible = true;
                lblEditorial.Visible = true;
                lblPrestable.Visible = true;
                lblSinopsis.Visible = true;
                lblTitulo.Visible = true;
                LblImagen.Visible = true;
                lblIsbn.Location = new Point(29, 16);
                lblIsbn.Visible = true;
                txtIsbn.Location = new Point(36, 56);
                txtIsbn.Visible = true;
                label1.Visible = true;

            }
        }


        private void BtnAnadir_Click(object sender, EventArgs e)
        {
            string nombreAutor = txtAutor.Text;
            if (nombreAutor.Length > 2)
            {
                string error;
                Autor autor = Program.gestor.ObtenerAutorPorNombre(nombreAutor, out error);
                if (autor == null)
                {
                    bool resultado = Program.gestor.AnadirAutor(nombreAutor, out error);
                    Autor autorN = Program.gestor.ObtenerAutorPorNombre(nombreAutor, out error);
                    if (!resultado)
                    {
                        MessageBox.Show("Error al añadir el autor a la base de datos: " + error);

                        return;
                    }
                    listBoxAutores.Items.Add(autorN);
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
                string error;
                Categoria categoria = Program.gestor.ObtenerCategoriaPorNombre(nombreCategoria, out error);
                if (categoria == null)
                {
                    bool resultado = Program.gestor.AnadirCategoria(nombreCategoria, out error);
                    Categoria categoriaN = Program.gestor.ObtenerCategoriaPorNombre(nombreCategoria, out error);

                    if (!resultado)
                    {
                        MessageBox.Show("Error al añadir la categoría a la base de datos: " + error);
                        return;
                    }
                    listBoxCategorias.Items.Add(categoriaN);

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

        private void LblImagen_Click(object sender, EventArgs e)
        {

        }
    }
}
