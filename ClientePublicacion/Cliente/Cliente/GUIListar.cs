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
using Cliente.Model;

namespace Cliente
{

        public partial class GUIListar : Form
        {
        private ServicioLibroCliente servicioLibro;
        private List<Libro> libros;
        public GUIListar()
        {
            servicioLibro = new ServicioLibroCliente();
            InitializeComponent();
        }

        private void lblCantidadPaginas_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnListar_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                libros = servicioLibro.ObtenerLibros();
                var librosVista = libros.Select(l => new LibroVista
                {
                    Titulo = l.Titulo,
                    Autores = string.Join(", ", l.Autores),
                    CantidadPaginas = l.CantidadPaginas,
                    FechaCreacion = l.FechaCreacion,
                    Precio = l.Precio,
                    TapaDura = l.TapaDura
                }).ToList();

                dataGridView1.DataSource = librosVista;
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No hay libros disponibles", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                libros = servicioLibro.ObtenerLibrosAutor(txtAutor.Text);

                var librosVista = libros.Select(l => new LibroVista
                {
                    Titulo = l.Titulo,
                    Autores = l.Autores.ToString(),
                    CantidadPaginas = l.CantidadPaginas,
                    FechaCreacion = l.FechaCreacion,
                    Precio = l.Precio,
                    TapaDura = l.TapaDura
                }).ToList();

                dataGridView1.DataSource = librosVista;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar libros: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                libros = servicioLibro.ObtenerLibrosTapaDura(chxTapaDura.Checked);

                var librosVista = libros.Select(l => new LibroVista
                {
                    Titulo = l.Titulo,
                    Autores = l.Autores.ToString(),
                    CantidadPaginas = l.CantidadPaginas,
                    FechaCreacion = l.FechaCreacion,
                    Precio = l.Precio,
                    TapaDura = l.TapaDura
                }).ToList();

                dataGridView1.DataSource = librosVista;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar libros: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
