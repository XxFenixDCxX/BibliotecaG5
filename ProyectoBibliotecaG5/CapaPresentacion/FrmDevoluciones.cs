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

            lectores.AddRange(gestor.devolverListaLectores(out string err));

            foreach (Lector l in lectores)
            {
                cboLectores.Items.Add(l.Nombre);
            }
        }

        private void cboLectores_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lector lector = cboLectores.SelectedItem as Lector;

            if (lector != null)
            {

            }
        }
    }
}
