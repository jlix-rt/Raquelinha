namespace ProyectoABCEmpleados
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            panel1 = new Panel();
            btnSalir = new Button();
            btnVerEmpleados = new Button();
            btnGuardarDatos = new Button();
            btnEliminar = new Button();
            btnModificarEmpleado = new Button();
            btnConsultarEmpleado = new Button();
            btnAgregarEmpleado = new Button();
            label2 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 17);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 0;
            label1.Text = "Empleados";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSalir);
            panel1.Controls.Add(btnVerEmpleados);
            panel1.Controls.Add(btnGuardarDatos);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnModificarEmpleado);
            panel1.Controls.Add(btnConsultarEmpleado);
            panel1.Controls.Add(btnAgregarEmpleado);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(233, 426);
            panel1.TabIndex = 1;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(71, 377);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnVerEmpleados
            // 
            btnVerEmpleados.Location = new Point(71, 266);
            btnVerEmpleados.Name = "btnVerEmpleados";
            btnVerEmpleados.Size = new Size(100, 23);
            btnVerEmpleados.TabIndex = 7;
            btnVerEmpleados.Text = "Ver empleados";
            btnVerEmpleados.UseVisualStyleBackColor = true;
            // 
            // btnGuardarDatos
            // 
            btnGuardarDatos.Location = new Point(71, 226);
            btnGuardarDatos.Name = "btnGuardarDatos";
            btnGuardarDatos.Size = new Size(100, 23);
            btnGuardarDatos.TabIndex = 6;
            btnGuardarDatos.Text = "Guardar datos";
            btnGuardarDatos.UseVisualStyleBackColor = true;
            btnGuardarDatos.Click += btnGuardarDatos_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(71, 188);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 23);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar empleado";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificarEmpleado
            // 
            btnModificarEmpleado.Location = new Point(71, 148);
            btnModificarEmpleado.Name = "btnModificarEmpleado";
            btnModificarEmpleado.Size = new Size(100, 23);
            btnModificarEmpleado.TabIndex = 4;
            btnModificarEmpleado.Text = "Modificar empleado";
            btnModificarEmpleado.UseVisualStyleBackColor = true;
            // 
            // btnConsultarEmpleado
            // 
            btnConsultarEmpleado.Location = new Point(71, 106);
            btnConsultarEmpleado.Name = "btnConsultarEmpleado";
            btnConsultarEmpleado.Size = new Size(100, 23);
            btnConsultarEmpleado.TabIndex = 3;
            btnConsultarEmpleado.Text = "Consultar empleado";
            btnConsultarEmpleado.UseVisualStyleBackColor = true;
            btnConsultarEmpleado.Click += btnConsultarEmpleado_Click;
            // 
            // btnAgregarEmpleado
            // 
            btnAgregarEmpleado.Location = new Point(71, 66);
            btnAgregarEmpleado.Name = "btnAgregarEmpleado";
            btnAgregarEmpleado.Size = new Size(100, 23);
            btnAgregarEmpleado.TabIndex = 2;
            btnAgregarEmpleado.Text = "Agregar empleado";
            btnAgregarEmpleado.UseVisualStyleBackColor = true;
            btnAgregarEmpleado.Click += btnAgregarEmpleado_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 32);
            label2.Name = "label2";
            label2.Size = new Size(110, 15);
            label2.TabIndex = 1;
            label2.Text = "Sistema de Registro";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(376, 168);
            label3.Name = "label3";
            label3.Size = new Size(257, 15);
            label3.TabIndex = 2;
            label3.Text = "Bienvenido al sistema de registro de empleados";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "ABC Empleados";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private Button btnVerEmpleados;
        private Button btnGuardarDatos;
        private Button btnEliminar;
        private Button btnModificarEmpleado;
        private Button btnConsultarEmpleado;
        private Button btnAgregarEmpleado;
        private Button btnSalir;
        private Label label3;
    }
}
