using ProyectoABCEmpleados.Estructuras;
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
        TablaHash tabla = new TablaHash(5);
        public AgregarEmpleado()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string dpi = txtDPI.Text;
            string nombre = txtNombre.Text;
            string direccion = txtDireccion.Text;
            string email = txtEmail.Text;
            string celular = txtCelular.Text;
            string edad = txtEdad.Text;
            string salario = txtSalario.Text;
            string descuentos = txtDesceuntos.Text;
            string profesion = txtProfesion.Text;
            string fecha_inicio = new DateTime().Date.ToString();

            Empleado empleado = new Empleado();
            empleado.SetDpi(dpi);
            empleado.SetNombre(nombre);
            empleado.SetEmail(email);
            tabla.Insertar(empleado);
            string mensaje = "Empleado agregado";
            MessageBox.Show(mensaje);

            MessageBox.Show(tabla.ObtenerEmpleados());

        }
    }
}
