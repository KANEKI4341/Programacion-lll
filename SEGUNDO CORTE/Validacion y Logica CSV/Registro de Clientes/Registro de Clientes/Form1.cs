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

namespace Registro_de_Clientes
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

        private void BtnResgistrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que los campos no estén vacíos
                if (string.IsNullOrWhiteSpace(txtCodigo.Text) || string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show("Por favor complete todos los campos de texto.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txtCiudad.Text == "")
                {
                    txtCiudad.Text = "No especificado";
                }

                // Nombre del archivo CSV
                string nombreArchivo = "Cliente.csv";
                string rutaArchivo = Path.Combine(Application.StartupPath, nombreArchivo);

                // Si el archivo no existe, crear el encabezado
                if (!File.Exists(rutaArchivo))
                {
                    File.WriteAllText(rutaArchivo, "Codigo,Ciudad,Nombre" + Environment.NewLine, Encoding.UTF8);
                }

                // Agregar la información del producto
                string linea = $"{txtCodigo.Text},{txtCiudad.Text},{txtNombre.Text}" + Environment.NewLine;
                File.AppendAllText(rutaArchivo, linea, Encoding.UTF8);

                MessageBox.Show($"Cliente guardado exitosamente en {nombreArchivo}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar los campos después de guardar
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimpiarCampos()
        {
            txtCodigo.Clear();
            txtCiudad.Clear();
            txtNombre.Clear();
        }

        private void btnCargarArchivo_Click(object sender, EventArgs e)
        {
            try
            {
                // Nombre del archivo CSV
                string nombreArchivo = "Cliente.csv";
                string rutaArchivo = Path.Combine(Application.StartupPath, nombreArchivo);

                // Verificar si el archivo existe
                if (!File.Exists(rutaArchivo))
                {
                    MessageBox.Show("No se encontró el cliente.", "Archivo no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Limpiar la lista antes de cargar
                listCliente.Items.Clear();

                // Leer todas las líneas del archivo
                string[] lineas = File.ReadAllLines(rutaArchivo, Encoding.UTF8);

                // Procesar cada línea (saltar la primera línea que son los encabezados)
                for (int i = 1; i < lineas.Length; i++)
                {
                    if (!string.IsNullOrWhiteSpace(lineas[i]))
                    {
                        string[] campos = lineas[i].Split(',');
                        if (campos.Length >= 3)
                        {
                            string codigo = campos[0].Trim();
                            string ciudad = campos[1].Trim();
                            string nombre = campos[2].Trim();

                            // Concatenar toda la información del producto
                            string productoCompleto = $"[{codigo}] {nombre} - Ciudad: {ciudad}";
                            listCliente.Items.Add(productoCompleto);
                        }
                    }
                }

                MessageBox.Show($"Se cargaron {listCliente.Items.Count} clientes.", "Carga exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los cliente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
