using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Registro_de_Empleados
{
    public partial class Form1 : Form
    {
        private object txtApellido;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtNombres_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            bool isValid = true;

            if (txtNombres.Text == "")
            {
                lblNombre.Visible = true;
                isValid = false;
            }
            else
            {
                lblNombre.Visible = false;
            }

            if (txtApellidos.Text == "")
            {
                lblApellido.Visible = true;
                isValid = false;

            }
            else
            {
                lblApellido.Visible = false;
            }

            if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
            {
                lblEmail.Visible = true;
                isValid = false;
            }
            else
            {
                lblEmail.Visible = false;
            }

            if (txtIdentificacion.Text.Length != 10)
            {
                lblIdentificacion.Visible = true;
                isValid = false;
            }
            else
            {
                lblIdentificacion.Visible = false;
            }

            if (cmbDepartamento.Text == "")
            {
                lblDepartamento.Visible = true;
                isValid = false;
            }
            else
            {
                lblDepartamento.Visible = false;
            }

            if (isValid)
            {
                decimal sueldo = numSueldoBase.Value;
                decimal neto = sueldo - (sueldo * 0.1m);

                lblSueldoNeto.Text = neto.ToString("c");
                lblSueldoNeto.Visible = true;
            }
        }

        private void lablResultadoSueldo_Click(object sender, EventArgs e)
        {

        }

        private void numSueldoBase_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtEmail.Text = "";
            txtIdentificacion.Text = "";

            cmbDepartamento.Text = "";

            numSueldoBase.Value = 1000;

            lblNombre.Visible = false;
            lblApellido.Visible = false;
            lblEmail.Visible = false;
            lblIdentificacion.Visible = false;
            lblDepartamento.Visible = false;

            lblResultadoSueldo.Text = "";
            lblResultadoSueldo.Visible = false;
        }

        private void txtApellidos_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
