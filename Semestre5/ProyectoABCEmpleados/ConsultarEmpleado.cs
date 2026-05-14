using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoABCEmpleados
{
    public partial class ConsultarEmpleado : Form
    {
        public ConsultarEmpleado()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Buscando empleado...");
        }
    }
}
