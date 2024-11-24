using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cliente.Model;
using Cliente.Service;

namespace Cliente
{
    public partial class GUIActualizarAutor : Form
    {
        private ServicioAutor servicioAutor;
        private Autor autorEncontrado;
        private string nombreOriginal;

        public GUIActualizarAutor()
        {
            servicioAutor = new ServicioAutor();
            autorEncontrado = null;
            InitializeComponent();
        }

        private void lblAgregarAutor_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarAutor_Click(object sender, EventArgs e)
        {
            string nombreBuscar = txtNombreBuscado.Text.Trim();
            if (string.IsNullOrEmpty(nombreBuscar))
            {
                MessageBox.Show("Por favor, ingrese un nombre para buscar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            autorEncontrado = servicioAutor.BuscarAutor(nombreBuscar);

            if (autorEncontrado != null)
            {
                nombreOriginal = nombreBuscar;
                txtNombre.Text = autorEncontrado.Nombre;
                txtEdad.Text = autorEncontrado.Edad.ToString();
                txtNacionalidad.Text = autorEncontrado.Nacionalidad;
                txtRegalias.Text = autorEncontrado.PorcentajeRegalias.ToString();

                MessageBox.Show("Autor encontrado. Puede modificar los campos y luego presionar 'Actualizar'.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                LimpiarCampos();
                MessageBox.Show("No se encontró ningún autor con el nombre especificado.", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LimpiarCampos()
        {
            txtNombreBuscado.Text = "";
            txtNombre.Text = "";
            txtEdad.Text = "";
            txtNacionalidad.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNacionalidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNacionalidad_Click(object sender, EventArgs e)
        {

        }

        private void lblEdad_Click(object sender, EventArgs e)
        {

        }

        private void txtNombreBuscado_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizarAutor_Click(object sender, EventArgs e)
        {
            if (autorEncontrado == null)
            {
                MessageBox.Show("Por favor, primero busque un libro para actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidarCampos())
            {
                return;
            }

            try
            {
                string nombre = txtNombre.Text;
                int edad = int.Parse(txtEdad.Text);
                string nacionalidad = txtNacionalidad.Text;

                bool actualizado = servicioAutor.ActualizarAutor(nombreOriginal, txtNombre.Text, int.Parse(txtEdad.Text), txtNacionalidad.Text, double.Parse(txtRegalias.Text), dpFecha.Value);

                if (actualizado)
                {
                    MessageBox.Show("El autor ha sido actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    autorEncontrado = null;
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el autor. Por favor, inténtelo de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, asegúrese de que los campos 'Edad' y 'Porcentaje de regalías' contenga un valor numérico válido.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al actualizar el libro: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtEdad.Text) ||
                string.IsNullOrWhiteSpace(txtNacionalidad.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios. Por favor, complete todos los campos.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}
