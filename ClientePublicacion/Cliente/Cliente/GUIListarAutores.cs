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
    public partial class GUIListarAutores : Form
    {
        private ServicioAutor servicioAutor;
        private List<Autor> autores;

        public GUIListarAutores()
        {
            servicioAutor = new ServicioAutor();
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            try
            {
                autores = servicioAutor.ObtenerAutores();
                tablaAutores.DataSource = autores;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar libros: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void filtrarNacionalidad_Click(object sender, EventArgs e)
        {
            tablaAutores.DataSource = servicioAutor.ObtenerAutoresNacionalidad(txtNacionalidad.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tablaAutores.DataSource = servicioAutor.ObtenerAutoresEdad(int.Parse(txtEdad.Text));
        }
    }
}
