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
    public partial class GUIBuscarAutor : Form
    {
        private ServicioAutor servicioAutor;

        public GUIBuscarAutor()
        {
            servicioAutor = new ServicioAutor();
            InitializeComponent();
        }

        private void lblAgregarAutor_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarAutor_Click(object sender, EventArgs e)
        {
            Autor autor = servicioAutor.BuscarAutor(txtNombreBuscado.Text);
            
            if(autor != null)
            {
                txtNombre.Text = autor.Nombre;
                txtEdad.Text = autor.Edad.ToString();
                txtNacionalidad.Text = autor.Nacionalidad;
                dpFecha.Value = autor.FechaNacimiento;
                txtRegalias.Text = autor.PorcentajeRegalias.ToString();
            }
            else
            {
                MessageBox.Show("Autor no encontrado");
            }
        }

        private void GUIBuscarAutor_Load(object sender, EventArgs e)
        {

        }

        private void txtNombreBuscado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
