using ProyectoABCEmpleados.Estructuras;
using ProyectoABCEmpleados.Forms;

namespace ProyectoABCEmpleados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            AgregarEmpleado agregarEmpleado = new AgregarEmpleado();
            agregarEmpleado.Show();
        }

        private void btnGuardarDatos_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultarEmpleado_Click(object sender, EventArgs e)
        {
            ConsultarEmpleado consulta = new ConsultarEmpleado();
            consulta.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TablaHash tabla = new TablaHash(5);
        }
    }
}
    