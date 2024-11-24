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
    public partial class GUIEliminarAutor : Form
    {
        private ServicioAutor servicioAutor;
        private Autor autor;

        public GUIEliminarAutor()
        {
            autor = null;
            servicioAutor = new ServicioAutor();
            InitializeComponent();
        }

        private void btnBuscarAutor_Click(object sender, EventArgs e)
        {
            string nombreBuscar = txtNombreBuscado.Text.Trim();
            if (!string.IsNullOrEmpty(nombreBuscar))
            {
                autor = servicioAutor.BuscarAutor(nombreBuscar);
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un nombre para buscar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (autor != null)
            {
                txtNombre.Text = autor.Nombre;
                txtEdad.Text = autor.Edad.ToString();
                txtNacionalidad.Text = autor.Nacionalidad;
                dpFecha.Value = autor.FechaNacimiento;
                txtRegalias.Text = autor.PorcentajeRegalias.ToString();
                MessageBox.Show("Autor encontrado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                LimpiarCampos();
                MessageBox.Show("No se encontró ningún libro con el título especificado.", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LimpiarCampos()
        {
            txtNombreBuscado.Text = "";
            txtNombre.Text = "";
            txtEdad.Text = "";
            txtNacionalidad.Text = "";
        }

        private void btnEliminarAutor_Click(object sender, EventArgs e)
        {
            if (autor == null)
            {
                MessageBox.Show("Por favor, primero busque un nombre para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmResult = MessageBox.Show("¿Está seguro que desea eliminar este autor?", "Confirmar eliminación",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    bool eliminado = servicioAutor.EliminarAutor(txtNombre.Text);

                    if (eliminado)
                    {
                        MessageBox.Show("El autor ha sido eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                        autor = null;
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el autor. Por favor, inténtelo de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error al eliminar el autor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
