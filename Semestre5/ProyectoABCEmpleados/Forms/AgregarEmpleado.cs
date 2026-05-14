using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoABCEmpleados.Forms
{
    public partial class AgregarEmpleado : Form
    {
        public AgregarEmpleado()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string dpi = txtDPI.Text;
            string nombre = txtNombre.Text;

            string mensaje = "El empleado " + nombre + " tiene el DPI " + dpi;
            MessageBox.Show(mensaje);
            this.Close();

        }
    }
}
