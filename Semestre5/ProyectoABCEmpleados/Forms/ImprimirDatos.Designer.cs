namespace ProyectoABCEmpleados.Forms
{
    partial class ImprimirDatos
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
            label3 = new Label();
            txtIngreseEmpleado = new TextBox();
            button1 = new Button();
            cmbIdEmpleado = new ComboBox();
            pnlInformacionEmpleado = new Panel();
            label4 = new Label();
            lblDPI = new Label();
            label6 = new Label();
            lblNombre = new Label();
            label8 = new Label();
            lblDireccion = new Label();
            label10 = new Label();
            lblEmail = new Label();
            label12 = new Label();
            lblCelular = new Label();
            label14 = new Label();
            lblEdad = new Label();
            label16 = new Label();
            lblSalario = new Label();
            label18 = new Label();
            lblDescuentos = new Label();
            label20 = new Label();
            lblFechaInicio = new Label();
            label22 = new Label();
            lblProfesion = new Label();
            btnImprimir = new Button();
            btnVistaPrevia = new Button();
            btnLimpiar = new Button();
            btnRegresar = new Button();
            pnlVistaPrevia = new Panel();
            label5 = new Label();
            label7 = new Label();
            panel1 = new Panel();
            label9 = new Label();
            label11 = new Label();
            lblPreDPI = new Label();
            lblPreNombre = new Label();
            label17 = new Label();
            label19 = new Label();
            lblPreDireccion = new Label();
            label23 = new Label();
            lblPreEmail = new Label();
            label25 = new Label();
            lblPreCelular = new Label();
            label27 = new Label();
            lblPreEdad = new Label();
            label29 = new Label();
            lblPreSalario = new Label();
            label31 = new Label();
            label32 = new Label();
            lblPreDescuentos = new Label();
            lblPreInicioLaboral = new Label();
            label35 = new Label();
            lblPreProfesion = new Label();
            label37 = new Label();
            lblPreFechaImpresion = new Label();
            pnlInformacionEmpleado.SuspendLayout();
            pnlVistaPrevia.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(269, 22);
            label1.Name = "label1";
            label1.Size = new Size(185, 15);
            label1.TabIndex = 0;
            label1.Text = "IMPRIMIR DATOS DEL EMPLEADO";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 46);
            label2.Name = "label2";
            label2.Size = new Size(315, 15);
            label2.TabIndex = 1;
            label2.Text = "Seleccione un empleado y genere el reporte para imprimir ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 96);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 2;
            label3.Text = "Buscar por:";
            // 
            // txtIngreseEmpleado
            // 
            txtIngreseEmpleado.ForeColor = SystemColors.ScrollBar;
            txtIngreseEmpleado.Location = new Point(319, 93);
            txtIngreseEmpleado.Name = "txtIngreseEmpleado";
            txtIngreseEmpleado.Size = new Size(118, 23);
            txtIngreseEmpleado.TabIndex = 3;
            txtIngreseEmpleado.Text = "Ingrese el empleado";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(477, 92);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = false;
            // 
            // cmbIdEmpleado
            // 
            cmbIdEmpleado.ForeColor = SystemColors.ScrollBar;
            cmbIdEmpleado.FormattingEnabled = true;
            cmbIdEmpleado.Items.AddRange(new object[] { "DPI", "Nombre", "E - mail" });
            cmbIdEmpleado.Location = new Point(150, 93);
            cmbIdEmpleado.Name = "cmbIdEmpleado";
            cmbIdEmpleado.Size = new Size(121, 23);
            cmbIdEmpleado.TabIndex = 6;
            cmbIdEmpleado.Text = "ID Empleado";
            // 
            // pnlInformacionEmpleado
            // 
            pnlInformacionEmpleado.Controls.Add(lblProfesion);
            pnlInformacionEmpleado.Controls.Add(label22);
            pnlInformacionEmpleado.Controls.Add(lblFechaInicio);
            pnlInformacionEmpleado.Controls.Add(label20);
            pnlInformacionEmpleado.Controls.Add(lblDescuentos);
            pnlInformacionEmpleado.Controls.Add(label18);
            pnlInformacionEmpleado.Controls.Add(lblSalario);
            pnlInformacionEmpleado.Controls.Add(label16);
            pnlInformacionEmpleado.Controls.Add(lblEdad);
            pnlInformacionEmpleado.Controls.Add(label14);
            pnlInformacionEmpleado.Controls.Add(lblCelular);
            pnlInformacionEmpleado.Controls.Add(label12);
            pnlInformacionEmpleado.Controls.Add(lblEmail);
            pnlInformacionEmpleado.Controls.Add(label10);
            pnlInformacionEmpleado.Controls.Add(lblDireccion);
            pnlInformacionEmpleado.Controls.Add(label8);
            pnlInformacionEmpleado.Controls.Add(lblNombre);
            pnlInformacionEmpleado.Controls.Add(label6);
            pnlInformacionEmpleado.Controls.Add(lblDPI);
            pnlInformacionEmpleado.Controls.Add(label4);
            pnlInformacionEmpleado.Location = new Point(26, 153);
            pnlInformacionEmpleado.Name = "pnlInformacionEmpleado";
            pnlInformacionEmpleado.Size = new Size(726, 234);
            pnlInformacionEmpleado.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 26);
            label4.Name = "label4";
            label4.Size = new Size(25, 15);
            label4.TabIndex = 0;
            label4.Text = "DPI";
            // 
            // lblDPI
            // 
            lblDPI.AutoSize = true;
            lblDPI.Location = new Point(141, 26);
            lblDPI.Name = "lblDPI";
            lblDPI.Size = new Size(17, 15);
            lblDPI.TabIndex = 1;
            lblDPI.Text = "--";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 66);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 2;
            label6.Text = "Nombre";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(141, 66);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(17, 15);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "--";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(35, 109);
            label8.Name = "label8";
            label8.Size = new Size(57, 15);
            label8.TabIndex = 4;
            label8.Text = "Direccion";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(141, 109);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(17, 15);
            lblDireccion.TabIndex = 5;
            lblDireccion.Text = "--";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(35, 157);
            label10.Name = "label10";
            label10.Size = new Size(47, 15);
            label10.TabIndex = 6;
            label10.Text = "E - mail";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(141, 145);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(17, 15);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "--";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(35, 198);
            label12.Name = "label12";
            label12.Size = new Size(44, 15);
            label12.TabIndex = 8;
            label12.Text = "Celular";
            // 
            // lblCelular
            // 
            lblCelular.AutoSize = true;
            lblCelular.Location = new Point(141, 187);
            lblCelular.Name = "lblCelular";
            lblCelular.Size = new Size(17, 15);
            lblCelular.TabIndex = 9;
            lblCelular.Text = "--";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(395, 26);
            label14.Name = "label14";
            label14.Size = new Size(33, 15);
            label14.TabIndex = 10;
            label14.Text = "Edad";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(578, 26);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(17, 15);
            lblEdad.TabIndex = 11;
            lblEdad.Text = "--";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(395, 66);
            label16.Name = "label16";
            label16.Size = new Size(42, 15);
            label16.TabIndex = 12;
            label16.Text = "Salario";
            // 
            // lblSalario
            // 
            lblSalario.AutoSize = true;
            lblSalario.Location = new Point(578, 66);
            lblSalario.Name = "lblSalario";
            lblSalario.Size = new Size(17, 15);
            lblSalario.TabIndex = 13;
            lblSalario.Text = "--";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(395, 109);
            label18.Name = "label18";
            label18.Size = new Size(68, 15);
            label18.TabIndex = 14;
            label18.Text = "Descuentos";
            // 
            // lblDescuentos
            // 
            lblDescuentos.AutoSize = true;
            lblDescuentos.Location = new Point(578, 109);
            lblDescuentos.Name = "lblDescuentos";
            lblDescuentos.Size = new Size(17, 15);
            lblDescuentos.TabIndex = 15;
            lblDescuentos.Text = "--";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(395, 157);
            label20.Name = "label20";
            label20.Size = new Size(125, 15);
            label20.TabIndex = 16;
            label20.Text = "Fecha de inicio laboral";
            // 
            // lblFechaInicio
            // 
            lblFechaInicio.AutoSize = true;
            lblFechaInicio.Location = new Point(578, 157);
            lblFechaInicio.Name = "lblFechaInicio";
            lblFechaInicio.Size = new Size(17, 15);
            lblFechaInicio.TabIndex = 17;
            lblFechaInicio.Text = "--";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(395, 198);
            label22.Name = "label22";
            label22.Size = new Size(57, 15);
            label22.TabIndex = 18;
            label22.Text = "Profesion";
            // 
            // lblProfesion
            // 
            lblProfesion.AutoSize = true;
            lblProfesion.Location = new Point(578, 198);
            lblProfesion.Name = "lblProfesion";
            lblProfesion.Size = new Size(17, 15);
            lblProfesion.TabIndex = 19;
            lblProfesion.Text = "--";
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(86, 561);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(75, 23);
            btnImprimir.TabIndex = 8;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnVistaPrevia
            // 
            btnVistaPrevia.Location = new Point(298, 563);
            btnVistaPrevia.Name = "btnVistaPrevia";
            btnVistaPrevia.Size = new Size(75, 23);
            btnVistaPrevia.TabIndex = 9;
            btnVistaPrevia.Text = "Vista Previa";
            btnVistaPrevia.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(450, 561);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 10;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(619, 561);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(75, 23);
            btnRegresar.TabIndex = 11;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            // 
            // pnlVistaPrevia
            // 
            pnlVistaPrevia.Controls.Add(panel1);
            pnlVistaPrevia.Controls.Add(label5);
            pnlVistaPrevia.Location = new Point(784, 96);
            pnlVistaPrevia.Name = "pnlVistaPrevia";
            pnlVistaPrevia.Size = new Size(453, 620);
            pnlVistaPrevia.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 19);
            label5.Name = "label5";
            label5.Size = new Size(127, 15);
            label5.TabIndex = 0;
            label5.Text = "Vista previa del reporte";
            label5.Click += label5_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(159, 9);
            label7.Name = "label7";
            label7.Size = new Size(78, 15);
            label7.TabIndex = 1;
            label7.Text = "EMPRESA S.A";
            // 
            // panel1
            // 
            panel1.Controls.Add(lblPreFechaImpresion);
            panel1.Controls.Add(label37);
            panel1.Controls.Add(lblPreProfesion);
            panel1.Controls.Add(label35);
            panel1.Controls.Add(lblPreInicioLaboral);
            panel1.Controls.Add(lblPreDescuentos);
            panel1.Controls.Add(label32);
            panel1.Controls.Add(label31);
            panel1.Controls.Add(lblPreSalario);
            panel1.Controls.Add(label29);
            panel1.Controls.Add(lblPreEdad);
            panel1.Controls.Add(label27);
            panel1.Controls.Add(lblPreCelular);
            panel1.Controls.Add(label25);
            panel1.Controls.Add(lblPreEmail);
            panel1.Controls.Add(label23);
            panel1.Controls.Add(lblPreDireccion);
            panel1.Controls.Add(label19);
            panel1.Controls.Add(label17);
            panel1.Controls.Add(lblPreNombre);
            panel1.Controls.Add(lblPreDPI);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(14, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(427, 565);
            panel1.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(136, 24);
            label9.Name = "label9";
            label9.Size = new Size(120, 15);
            label9.TabIndex = 2;
            label9.Text = "Reporte de empleado";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(15, 72);
            label11.Name = "label11";
            label11.Size = new Size(25, 15);
            label11.TabIndex = 3;
            label11.Text = "DPI";
            // 
            // lblPreDPI
            // 
            lblPreDPI.AutoSize = true;
            lblPreDPI.Location = new Point(95, 72);
            lblPreDPI.Name = "lblPreDPI";
            lblPreDPI.Size = new Size(17, 15);
            lblPreDPI.TabIndex = 4;
            lblPreDPI.Text = "--";
            // 
            // lblPreNombre
            // 
            lblPreNombre.AutoSize = true;
            lblPreNombre.Location = new Point(15, 120);
            lblPreNombre.Name = "lblPreNombre";
            lblPreNombre.Size = new Size(51, 15);
            lblPreNombre.TabIndex = 5;
            lblPreNombre.Text = "Nombre";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(95, 120);
            label17.Name = "label17";
            label17.Size = new Size(17, 15);
            label17.TabIndex = 6;
            label17.Text = "--";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(15, 165);
            label19.Name = "label19";
            label19.Size = new Size(57, 15);
            label19.TabIndex = 7;
            label19.Text = "Direccion";
            // 
            // lblPreDireccion
            // 
            lblPreDireccion.AutoSize = true;
            lblPreDireccion.Location = new Point(95, 165);
            lblPreDireccion.Name = "lblPreDireccion";
            lblPreDireccion.Size = new Size(17, 15);
            lblPreDireccion.TabIndex = 8;
            lblPreDireccion.Text = "--";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(15, 207);
            label23.Name = "label23";
            label23.Size = new Size(47, 15);
            label23.TabIndex = 9;
            label23.Text = "E - mail";
            // 
            // lblPreEmail
            // 
            lblPreEmail.AutoSize = true;
            lblPreEmail.Location = new Point(95, 207);
            lblPreEmail.Name = "lblPreEmail";
            lblPreEmail.Size = new Size(17, 15);
            lblPreEmail.TabIndex = 10;
            lblPreEmail.Text = "--";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(15, 250);
            label25.Name = "label25";
            label25.Size = new Size(44, 15);
            label25.TabIndex = 11;
            label25.Text = "Celular";
            // 
            // lblPreCelular
            // 
            lblPreCelular.AutoSize = true;
            lblPreCelular.Location = new Point(95, 250);
            lblPreCelular.Name = "lblPreCelular";
            lblPreCelular.Size = new Size(17, 15);
            lblPreCelular.TabIndex = 12;
            lblPreCelular.Text = "--";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(15, 299);
            label27.Name = "label27";
            label27.Size = new Size(33, 15);
            label27.TabIndex = 13;
            label27.Text = "Edad";
            // 
            // lblPreEdad
            // 
            lblPreEdad.AutoSize = true;
            lblPreEdad.Location = new Point(95, 299);
            lblPreEdad.Name = "lblPreEdad";
            lblPreEdad.RightToLeft = RightToLeft.Yes;
            lblPreEdad.Size = new Size(17, 15);
            lblPreEdad.TabIndex = 14;
            lblPreEdad.Text = "--";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(15, 346);
            label29.Name = "label29";
            label29.Size = new Size(42, 15);
            label29.TabIndex = 15;
            label29.Text = "Salario";
            // 
            // lblPreSalario
            // 
            lblPreSalario.AutoSize = true;
            lblPreSalario.Location = new Point(95, 346);
            lblPreSalario.Name = "lblPreSalario";
            lblPreSalario.Size = new Size(17, 15);
            lblPreSalario.TabIndex = 16;
            lblPreSalario.Text = "--";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(15, 392);
            label31.Name = "label31";
            label31.Size = new Size(68, 15);
            label31.TabIndex = 17;
            label31.Text = "Descuentos";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Location = new Point(15, 438);
            label32.Name = "label32";
            label32.Size = new Size(125, 15);
            label32.TabIndex = 18;
            label32.Text = "Fecha de inicio laboral";
            // 
            // lblPreDescuentos
            // 
            lblPreDescuentos.AutoSize = true;
            lblPreDescuentos.Location = new Point(95, 392);
            lblPreDescuentos.Name = "lblPreDescuentos";
            lblPreDescuentos.Size = new Size(17, 15);
            lblPreDescuentos.TabIndex = 19;
            lblPreDescuentos.Text = "--";
            // 
            // lblPreInicioLaboral
            // 
            lblPreInicioLaboral.AutoSize = true;
            lblPreInicioLaboral.Location = new Point(145, 436);
            lblPreInicioLaboral.Name = "lblPreInicioLaboral";
            lblPreInicioLaboral.Size = new Size(17, 15);
            lblPreInicioLaboral.TabIndex = 20;
            lblPreInicioLaboral.Text = "--";
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Location = new Point(15, 491);
            label35.Name = "label35";
            label35.Size = new Size(57, 15);
            label35.TabIndex = 21;
            label35.Text = "Profesion";
            // 
            // lblPreProfesion
            // 
            lblPreProfesion.AutoSize = true;
            lblPreProfesion.Location = new Point(95, 491);
            lblPreProfesion.Name = "lblPreProfesion";
            lblPreProfesion.Size = new Size(17, 15);
            lblPreProfesion.TabIndex = 22;
            lblPreProfesion.Text = "--";
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Location = new Point(78, 535);
            label37.Name = "label37";
            label37.Size = new Size(110, 15);
            label37.TabIndex = 23;
            label37.Text = "Fecha de impresion";
            // 
            // lblPreFechaImpresion
            // 
            lblPreFechaImpresion.AutoSize = true;
            lblPreFechaImpresion.Location = new Point(219, 535);
            lblPreFechaImpresion.Name = "lblPreFechaImpresion";
            lblPreFechaImpresion.Size = new Size(17, 15);
            lblPreFechaImpresion.TabIndex = 24;
            lblPreFechaImpresion.Text = "--";
            // 
            // ImprimirDatos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1265, 746);
            Controls.Add(pnlVistaPrevia);
            Controls.Add(btnRegresar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnVistaPrevia);
            Controls.Add(btnImprimir);
            Controls.Add(pnlInformacionEmpleado);
            Controls.Add(cmbIdEmpleado);
            Controls.Add(button1);
            Controls.Add(txtIngreseEmpleado);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ImprimirDatos";
            Text = "ImprimirDatos";
            pnlInformacionEmpleado.ResumeLayout(false);
            pnlInformacionEmpleado.PerformLayout();
            pnlVistaPrevia.ResumeLayout(false);
            pnlVistaPrevia.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtIngreseEmpleado;
        private Button button1;
        private ComboBox cmbIdEmpleado;
        private Panel pnlInformacionEmpleado;
        private Label lblProfesion;
        private Label label22;
        private Label lblFechaInicio;
        private Label label20;
        private Label lblDescuentos;
        private Label label18;
        private Label lblSalario;
        private Label label16;
        private Label lblEdad;
        private Label label14;
        private Label lblCelular;
        private Label label12;
        private Label lblEmail;
        private Label label10;
        private Label lblDireccion;
        private Label label8;
        private Label lblNombre;
        private Label label6;
        private Label lblDPI;
        private Label label4;
        private Button btnImprimir;
        private Button btnVistaPrevia;
        private Button btnLimpiar;
        private Button btnRegresar;
        private Panel pnlVistaPrevia;
        private Panel panel1;
        private Label label7;
        private Label label5;
        private Label label11;
        private Label label9;
        private Label lblPreFechaImpresion;
        private Label label37;
        private Label lblPreProfesion;
        private Label label35;
        private Label lblPreInicioLaboral;
        private Label lblPreDescuentos;
        private Label label32;
        private Label label31;
        private Label lblPreSalario;
        private Label label29;
        private Label lblPreEdad;
        private Label label27;
        private Label lblPreCelular;
        private Label label25;
        private Label lblPreEmail;
        private Label label23;
        private Label lblPreDireccion;
        private Label label19;
        private Label label17;
        private Label lblPreNombre;
        private Label lblPreDPI;
    }
}