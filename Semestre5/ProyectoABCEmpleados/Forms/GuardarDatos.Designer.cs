namespace ProyectoABCEmpleados.Forms
{
    partial class GuardarDatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuardarDatos));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            this.btnGuardar = new Button();
            btnRegresar = new Button();
            label2 = new Label();
            lblEstadoGuardado = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(315, 29);
            label1.Name = "label1";
            label1.Size = new Size(146, 15);
            label1.TabIndex = 0;
            label1.Text = "GUARDAR INFORMACION";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(287, 57);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(194, 191);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = Color.FromArgb(0, 192, 0);
            this.btnGuardar.Location = new Point(355, 281);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new Size(75, 23);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar Datos";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(355, 371);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(75, 23);
            btnRegresar.TabIndex = 4;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(218, 251);
            label2.Name = "label2";
            label2.Size = new Size(351, 15);
            label2.TabIndex = 6;
            label2.Text = "Presione el boton para guardar los datos registrados en el sistema";
            // 
            // lblEstadoGuardado
            // 
            lblEstadoGuardado.AutoSize = true;
            lblEstadoGuardado.Location = new Point(287, 332);
            lblEstadoGuardado.Name = "lblEstadoGuardado";
            lblEstadoGuardado.Size = new Size(217, 15);
            lblEstadoGuardado.TabIndex = 7;
            lblEstadoGuardado.Text = "DATOS GUARDADOS CORRECTAMENTE";
            lblEstadoGuardado.Click += lblEstadoGuardado_Click;
            // 
            // GuardarDatos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblEstadoGuardado);
            Controls.Add(label2);
            Controls.Add(btnRegresar);
            Controls.Add(this.btnGuardar);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "GuardarDatos";
            Text = "GuardarDatos";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Button btnGuardar;
        private Button button1;
        private Button btnRegresar;
        private Label label2;
        private Label lblEstadoGuardado;
    }
}