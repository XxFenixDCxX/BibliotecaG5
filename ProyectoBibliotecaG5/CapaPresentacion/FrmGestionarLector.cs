using CapaEntidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CapaPresentacion
{
    public partial class FrmGestionarLector : Form
    {
        public FrmGestionarLector()
        {
            InitializeComponent();
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            string letras = "qwertyuiopasdfghjklñzxcvbnm";
            string formatoEmail = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";
            string errores = "";
           if (chcEliminar.Checked == false)
            {
                Lector lectorAñadir = new Lector();
                if (String.IsNullOrEmpty(txtCarnet.Text) || String.IsNullOrEmpty(txtContrasena.Text) || String.IsNullOrEmpty(txtNombre.Text) || String.IsNullOrEmpty(txtEmail.Text))
                {
                    MessageBox.Show("Los apartados de Carnet, Nombre, Contraseña y Email no pueden estar vacios", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txtCarnet.Text.Length != 4 || !int.TryParse(txtCarnet.Text.Substring(0, 3), out int carnet) || !letras.Contains(txtCarnet.Text.ToLower().Substring(3, 1)))
                {
                    MessageBox.Show("El campo de carnet tiene que tener este formato 123A", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCarnet.Text = "";
                    txtCarnet.Focus();
                    return;
                }
                if (Regex.IsMatch(txtEmail.Text, formatoEmail) == false)
                {
                    MessageBox.Show("El formato del Email es incorrecto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmail.Text = "";
                    txtEmail.Focus();
                    return;
                }
                if (String.IsNullOrEmpty(txtTelefono.Text))
                {
                    lectorAñadir = new Lector(txtCarnet.Text, txtNombre.Text, txtContrasena.Text, txtEmail.Text);
                }
                else
                {
                    if (int.TryParse(txtTelefono.Text, out int telefono) == false)
                    {
                        MessageBox.Show("El telefono tiene que ser un numero", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    lectorAñadir = new Lector(txtCarnet.Text, txtNombre.Text, txtContrasena.Text, txtTelefono.Text, txtEmail.Text);
                }
                Program.gestor.agregarLector(lectorAñadir, out errores);
            }
            else
            {
                if (String.IsNullOrEmpty(txtCarnet.Text))
                {
                    MessageBox.Show("El campo del carne no puede estar vacio", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCarnet.Focus();
                    return;
                }
                if (txtCarnet.Text.Length != 4 || !int.TryParse(txtCarnet.Text.Substring(0, 3), out int result) || !letras.Contains(txtCarnet.Text.ToLower().Substring(3, 1)))
                {
                    MessageBox.Show("El campo de carnet tiene que tener este formato 123A", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCarnet.Text = "";
                    txtCarnet.Focus();
                    return;
                }
                Program.gestor.eliminarLector(txtCarnet.Text, out errores);
            }
           if (string.IsNullOrEmpty(errores))
            {
                MessageBox.Show("Accion realizada correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                MessageBox.Show(errores, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void chcEliminar_CheckedChanged(object sender, EventArgs e)
        {
            txtCarnet.Text = "";
            txtContrasena.Text = "";
            txtEmail.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";
            if (chcEliminar.Checked == false)
            {
                txtCarnet.Visible = true;
                txtCarnet.Location = new Point(235, 355);
                lblEjemploCarne.Visible = true;
                lblEjemploCarne.Location = new Point(329,340);
                lblINumeroCarne.Visible = true;
                lblINumeroCarne.Location = new Point(228, 315);

                txtContrasena.Visible = true;
                lblContrasena.Visible = true;

                txtEmail.Visible = true;
                lblEmail.Visible = true;

                txtTelefono.Visible = true;
                lblTelefono.Visible = true;

                txtNombre.Visible = true;
                lblNombre.Visible = true;
            }
            else
            {
                txtCarnet.Visible = true;
                txtCarnet.Location = new Point(312, 408);
                lblEjemploCarne.Visible = true;
                lblEjemploCarne.Location = new Point(406, 393);
                lblINumeroCarne.Visible = true;
                lblINumeroCarne.Location = new Point(305, 368);

                txtContrasena.Visible = false;
                lblContrasena.Visible = false;

                txtEmail.Visible = false;
                lblEmail.Visible = false;

                txtTelefono.Visible = false;
                lblTelefono.Visible = false;

                txtNombre.Visible = false;
                lblNombre.Visible = false;
            }
        }
    }
}
