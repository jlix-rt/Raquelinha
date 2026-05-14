namespace ProyectoABCEmpleados
{
    partial class ConsultarEmpleado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtBuscarDPI = new TextBox();
            btnBuscarEmpleado = new Button();
            btnRegresar = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(358, 34);
            label1.Name = "label1";
            label1.Size = new Size(134, 15);
            label1.TabIndex = 0;
            label1.Text = "Consulta de empleados ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(85, 80);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 1;
            label2.Text = "Buscar por DPI";
            // 
            // txtBuscarDPI
            // 
            txtBuscarDPI.ForeColor = SystemColors.ScrollBar;
            txtBuscarDPI.Location = new Point(214, 80);
            txtBuscarDPI.Name = "txtBuscarDPI";
            txtBuscarDPI.Size = new Size(190, 23);
            txtBuscarDPI.TabIndex = 2;
            txtBuscarDPI.Text = "Ingrese DPI";
            // 
            // btnBuscarEmpleado
            // 
            btnBuscarEmpleado.Location = new Point(550, 77);
            btnBuscarEmpleado.Name = "btnBuscarEmpleado";
            btnBuscarEmpleado.Size = new Size(75, 23);
            btnBuscarEmpleado.TabIndex = 3;
            btnBuscarEmpleado.Text = "Buscar Empleado ";
            btnBuscarEmpleado.UseVisualStyleBackColor = true;
            btnBuscarEmpleado.Click += btnBuscar_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(382, 386);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(75, 23);
            btnRegresar.TabIndex = 4;
            btnRegresar.Tag = "";
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(42, 124);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(757, 204);
            dataGridView1.TabIndex = 5;
            // 
            // ConsultarEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 425);
            Controls.Add(dataGridView1);
            Controls.Add(btnRegresar);
            Controls.Add(btnBuscarEmpleado);
            Controls.Add(txtBuscarDPI);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ConsultarEmpleado";
            Text = "ConsultarEmpleado";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtBuscarDPI;
        private Button btnBuscarEmpleado;
        private Button btnRegresar;
        private DataGridView dataGridView1;
    }
}