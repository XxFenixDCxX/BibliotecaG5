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
        private void FrmDevoluciones_Load(object sender, EventArgs e)
        {
            dgvLibros.Rows.Clear();
            cboLectores.Items.Clear();

            List<Lector> lectores = new List<Lector>();

            lectores.AddRange(gestor.devolverListaDeMorosos(out string err));

            foreach (Lector l in lectores)
            {
                cboLectores.Items.Add(l);
            }
        }

        private void cboLectores_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lector lector = cboLectores.SelectedItem as Lector;

            if (lector != null)
            {
                cargarLibrosPrestados(lector);
            }
        }

        private void btnDevuelto_Click(object sender, EventArgs e)
        {
            Lector lector = cboLectores.SelectedItem as Lector;
            gestor.EliminarLibrosPrestados(lector.NumeroCarnet, out string err);

            cargarLibrosPrestados(lector);
        }

        private void cargarLibrosPrestados(Lector lector)
        {
            dgvLibros.DataSource = null;
            dgvLibros.DataSource = gestor.devolverLibrosPrestados(lector.NumeroCarnet, out string err);
        }
    }
}
