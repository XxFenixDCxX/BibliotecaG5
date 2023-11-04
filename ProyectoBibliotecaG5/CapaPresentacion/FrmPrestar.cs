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
    public partial class FrmPrestar : Form
    {
        public FrmPrestar()
        {
            InitializeComponent();
        }

        private void btnPrestarLibro_Click(object sender, EventArgs e)
        {


            string libroselecionado = lstListaISBN.SelectedItem.ToString();
            string lectorselecionado = lstCarnetLector.SelectedItem.ToString();
            gestorPrestamos.PrestarLibro(libroselecionado, lectorselecionado, out string errores);
            if (errores != "")
            {
                MessageBox.Show(errores);
            }
            else
            {
                MessageBox.Show("Prestamo realizado correctamente");
            }

        }

        private void controlCabezera1_Load(object sender, EventArgs e)
        {

        }
        Gestor gestorPrestamos = new Gestor();
        private void FrmPrestar_Load(object sender, EventArgs e)
        {
            //foreach (Libro libro in gestorPrestamos.devolverListaDeLibros(out string errores))
            //{
            //    lstListaISBN.Items.AddRange(new object[] { libro.Isbn });
            //}
            ////llenar la listbox2 con los lectores
            //foreach (Lector lector in gestorPrestamos.devolverListaLectores(out string errores))
            //{
            //    lstCarnetLector.Items.AddRange(new object[] { lector.NumeroCarnet });
            //}
            ////llenar la listbox3 con los nombres de los libros
            //foreach (Libro libro in gestorPrestamos.devolverListaDeLibros(out string errores))
            //{
            //    lstNombreLibro.Items.AddRange(new object[] { libro.Titulo });
            //}
            ////llenar la listbox4 con los nombres de los lectores
            //foreach (Lector lector in gestorPrestamos.devolverListaLectores(out string errores))
            //{
            //    lstNombreLector.Items.AddRange(new object[] { lector.Nombre });
            //}
        }
        //selecionar el nombre del libro y que se selecione el isbn
        private void lstNombreLibro_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstListaISBN.SelectedIndex = lstNombreLibro.SelectedIndex;
        }
        //selecionar el nombre del lector y que se selecione el carnet
        private void lstNombreLector_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstCarnetLector.SelectedIndex = lstNombreLector.SelectedIndex;
        }
        // que conforme valla actualizando los textbox se vall actualizando los listbox con los datos en el caso de textbox1 con el isbn en el lstListaISBN y el nombre del libro en el lstNombreLibro
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           // si esta vacio no muestra nada
           if (textBox1.Text == "")
            {
                lstListaISBN.Items.Clear();
                lstNombreLibro.Items.Clear();
                return;
            }
            lstListaISBN.Items.Clear();
            lstNombreLibro.Items.Clear();
            foreach (Libro libro in gestorPrestamos.devolverListaDeLibros(out string errores))
            {
                if (libro.Titulo.ToUpper().Contains(textBox1.Text.ToUpper()))
                {
                    lstListaISBN.Items.AddRange(new object[] { libro.Isbn });
                    lstNombreLibro.Items.AddRange(new object[] { libro.Titulo });
                }
            }
        }   
        // que conforme valla actualizando los textbox se valla actualizando los listbox con los datos en el caso de textbox2 con el carnet en el lstCarnetLector y el nombre del lector en el lstNombreLector
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // si esta vacio no muestra nada
            if (textBox2.Text == "")
            {
                lstCarnetLector.Items.Clear();
                lstNombreLector.Items.Clear();
                return;
            }
            lstCarnetLector.Items.Clear();
            lstNombreLector.Items.Clear();
            foreach (Lector lector in gestorPrestamos.devolverListaLectores(out string errores))
            {
                if (lector.Nombre.ToUpper().Contains(textBox2.Text.ToUpper()))
                {
                    lstCarnetLector.Items.AddRange(new object[] { lector.NumeroCarnet });
                    lstNombreLector.Items.AddRange(new object[] { lector.Nombre });
                }
            }
        }

        private void lstCarnetLector_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstNombreLibro_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //si se seleciona un libro que se selecione el isbn
            lstListaISBN.SelectedIndex = lstNombreLibro.SelectedIndex;
        }

        private void lstNombreLector_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //si se seleciona un lector que se selecione el carnet
            lstCarnetLector.SelectedIndex = lstNombreLector.SelectedIndex;
        }
    }
}
