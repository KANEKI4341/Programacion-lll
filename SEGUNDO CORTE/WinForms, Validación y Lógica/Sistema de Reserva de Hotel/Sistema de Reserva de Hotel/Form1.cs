using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Reserva_de_Hotel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularReserva_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            if (txtCliente.Text == "")
            {
                lblNombre.Visible = true;
                isValid = false;
            }
            else
            {
                lblNombre.Visible = false;
            }

            if (dtpEntrada.Value.Date < DateTime.Today)
            {
                LblEntrada.Visible = true;
                isValid = false;
            }
            else
            {
                LblEntrada.Visible = false;
            }

            if (dtpSalida.Value.Date <= dtpEntrada.Value)
            {
                LbLSalida.Visible = true;
                isValid = false;
            }
            else
            {
                LbLSalida.Visible = false;
            }

            DateTime entrada = dtpEntrada.Value.Date;
            DateTime salida = dtpSalida.Value.Date;

            TimeSpan diff = salida - entrada;
            int dias = diff.Days;

            if (true)
            {
                decimal costoNoches = 50 * dias;

                decimal costoPersona = 0;

                if (numPersonas.Value > 1)
                {
                    costoPersona = 15 * (numPersonas.Value - 1)*dias;
                }

                string servicios = "";
                int cantidadServicios = 0;

                foreach (var item in clbServicios.CheckedItems)
                {
                    servicios += item.ToString() + ",";
                    cantidadServicios++;
                }

                if (servicios == "")
                    servicios = "Ninguno";

                decimal costoServicios = 10 * cantidadServicios * dias;

                decimal total = costoNoches + costoPersona + costoServicios;

                rtbResumen.Text =
                    "===== RESUMEN DE RESERVA =====\n\n" +
                    "Cliente: " + txtCliente.Text + "\n" +
                    "Estancia: " + dias + " noches\n" +
                    "Personas: " + numPersonas.Value + "\n" +
                    "Servicios: " + servicios + "\n\n" +
                    "-----------------------------\n" +
                    "TOTAL A PAGAR: $" + total.ToString("0.00");
            }
        }
        



        private void txtCliente_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
