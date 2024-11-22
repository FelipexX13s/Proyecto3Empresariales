using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cliente.Service;

namespace Cliente
{
    public partial class GUIAgregarAutor : Form
    {
        private ServicioAutor servicioAutor;

        public GUIAgregarAutor()
        {
            servicioAutor = new ServicioAutor();
            InitializeComponent();
        }

        private void btnAgregarAutor_Click(object sender, EventArgs e)
        {
            var nombre = txtNombre.Text.Trim();

            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("El nombre no puede estar vacío.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtEdad.Text, out int edad))
            {
                MessageBox.Show("La edad debe debe ser un valor numérico entero.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(txtRegalias.Text, out double porcentaje))
            {
                MessageBox.Show("La edad debe debe ser un valor numérico entero.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var nacionalidad = txtNacionalidad.Text.Trim();

            if (string.IsNullOrEmpty(nacionalidad))
            {
                MessageBox.Show("La nacionalidad no puede estar vacío.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime fecha = dpFecha.Value;

            bool agregado = servicioAutor.AgregarAutor(nombre, edad, nacionalidad, porcentaje, fecha);

            if (agregado)
            {
                LimpiarCampos();
                MessageBox.Show("El autor fue agregado exitosamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Hubo un error al agregar el autor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtEdad.Text = "";
            txtNacionalidad.Text = "";
            txtRegalias.Text = "";
            dpFecha.Value = DateTime.Now;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
