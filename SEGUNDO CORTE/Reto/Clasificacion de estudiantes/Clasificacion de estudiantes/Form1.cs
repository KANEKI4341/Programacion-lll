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

namespace Clasificacion_de_estudiantes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombreArchivo = "alumnos.csv";
            string rutaArchivo = Path.Combine(Application.StartupPath, nombreArchivo);
            string nombre = textNombre.Text;
            string nota = textNota.Text;

            if (!File.Exists(rutaArchivo))
            {
                File.WriteAllText(rutaArchivo, "Nombre,Nota" + Environment.NewLine);
            }

            string linea = $"{nombre},{nota}";
            File.AppendAllText(rutaArchivo, linea + Environment.NewLine);



            LimpiarCampos();
            listAprobados.Items.Clear();
            listDesaprovados.Items.Clear();

            string[] lineas = File.ReadAllLines(rutaArchivo, Encoding.UTF8);

            for (int i = 1; i < lineas.Length; i++)
            {
                if (!string.IsNullOrWhiteSpace(lineas[i]))
                {
                    string[] campos = lineas[i].Split(',');
                    if (campos.Length >= 2)
                    {
                        string nombres = campos[0].Trim();
                        string notas = campos[1].Trim();
                        double notas1 = Convert.ToDouble(campos[1]);

                        if (notas1 >= 3)
                        {
                            string estudiantes = $"Nombre: {nombres} Nota: {notas}";
                            listAprobados.Items.Add(estudiantes);

                        }
                        else
                        {
                            string estudiantes = $"Nombre: {nombres} Nota: {notas}";
                            listDesaprovados.Items.Add(estudiantes);
                        }


                    }
                }


            }
        }

        private void LimpiarCampos()
        {
            textNombre.Clear();
            textNota.Clear();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string nombreArchivo = "alumnos.csv";
            string rutaArchivo = Path.Combine(Application.StartupPath, nombreArchivo);
            string nombre = textNombre.Text;
            string nota = textNota.Text;

            if (!File.Exists(rutaArchivo))
            {
                File.WriteAllText(rutaArchivo, "Nombre,Nota" + Environment.NewLine);
            }

            string linea = $"{nombre},{nota}";
            File.AppendAllText(rutaArchivo, linea + Environment.NewLine);



            LimpiarCampos();
            listAprobados.Items.Clear();
            listDesaprovados.Items.Clear();

            string[] lineas = File.ReadAllLines(rutaArchivo, Encoding.UTF8);

            for (int i = 1; i < lineas.Length; i++)
            {
                if (!string.IsNullOrWhiteSpace(lineas[i]))
                {
                    string[] campos = lineas[i].Split(',');
                    if (campos.Length >= 2)
                    {
                        string nombres = campos[0].Trim();
                        string notas = campos[1].Trim();
                        double notas1 = Convert.ToDouble(campos[1]);

                        if (notas1 >= 3)
                        {
                            string estudiantes = $"Nombre: {nombres} Nota: {notas}";
                            listAprobados.Items.Add(estudiantes);

                        }
                        else
                        {
                            string estudiantes = $"Nombre: {nombres} Nota: {notas}";
                            listDesaprovados.Items.Add(estudiantes);
                        }


                    }
                }
            }
        }

        private void textNombre_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void listAprobados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listDesaprobados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textNota_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
