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
    public partial class ControlCabezera : UserControl
    {
        public ControlCabezera()
        {
            InitializeComponent();

            try
            {
                lblLocalizado.Text += Program.gestor.biblioteca.Lugar;
                lblBiblioteca.Text += Program.gestor.biblioteca.Nombre;
                pbLogo.ImageLocation = Program.gestor.biblioteca.Imagen;
            }
            catch (NullReferenceException ex)
            {
            }
        }
    }
}
