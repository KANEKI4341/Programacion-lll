using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestión_de_Inventario_de_Productos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void chkEsPerecedero_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            bool isValid = true;

            if (!txtCodigo.Text.StartsWith("PROD-"))
            {
                lblCodigo.Visible = true;
                isValid = false;
            }
            else
            {
                lblCodigo.Visible = false;
            }

            if (cmbCategoria.Text == "")
            {
                lblCategoria.Visible = true;
                isValid = false;
            }
            else
            {
                lblCategoria.Visible = false;
            }

            if (numStockInicial.Value < numStockMinimo.Value)
            {
                lblStock.Visible = true;
                isValid = false;
            }
            else
            {
                lblStock.Visible = false;
            }

            if (chkEsPerecedero.Checked)
            {
                dtpFechaVencimiento.Enabled = true;
            }

            if (!rbExento.Checked && !rbGeneral.Checked && !rbReducido.Checked)
            {
                lblIVA.Visible = true;
                isValid = false;
            }
            else
            {
                lblIVA.Visible = false;
            }

            if (isValid)
            {
                lblValidar.Visible = true;
            }


        }

        private void txtCodigo_TextChanged(object sender, EventArgs e) { }
        private void numStockInicial_ValueChanged(object sender, EventArgs e) { }
        private void numStockMinimo_ValueChanged(object sender, EventArgs e) { }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e) { }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
