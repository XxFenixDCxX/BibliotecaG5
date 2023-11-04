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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnGestionarLibros_Click(object sender, EventArgs e)
        {
            FrmGestionarLibro form = new FrmGestionarLibro();
            form.ShowDialog();
        }

        private void btnGestionarLector_Click(object sender, EventArgs e)
        {
            FrmGestionarLector form = new FrmGestionarLector();
            form.ShowDialog();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.Text = Program.gestor.biblioteca.Nombre;
        }

        private void lblListaMorosos_Click(object sender, EventArgs e)
        {
            FrmListaDeMorosos form = new FrmListaDeMorosos();
            form.ShowDialog();
        }

        private void btnBuscarLectores_Click(object sender, EventArgs e)
        {
            FrmBuscarLector form = new FrmBuscarLector();
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmDevoluciones form = new FrmDevoluciones();
            form.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FrmBuscarLibros form = new FrmBuscarLibros();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmPrestar form = new FrmPrestar();
            form.ShowDialog();
        }
    }
}
