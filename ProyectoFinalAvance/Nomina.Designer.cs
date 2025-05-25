namespace ProyectoFinalAvance
{
    partial class Nomina
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nomina));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.NombreTxt = new System.Windows.Forms.TextBox();
            this.CantidadHtxt = new System.Windows.Forms.TextBox();
            this.SxHEtxt = new System.Windows.Forms.TextBox();
            this.Sueldotxt = new System.Windows.Forms.TextBox();
            this.HEtxt = new System.Windows.Forms.TextBox();
            this.RabajePoFtxt = new System.Windows.Forms.TextBox();
            this.CantRecibidatxt = new System.Windows.Forms.TextBox();
            this.SxHEFtxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BTvolver = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.TrabajadorNtxt = new System.Windows.Forms.TextBox();
            this.btGenerar = new System.Windows.Forms.Button();
            this.SxHtxt = new System.Windows.Forms.TextBox();
            this.GBDatos = new System.Windows.Forms.GroupBox();
            this.FechaHoy = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Generartxt = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GBDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Trabajador: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sueldo:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tiempo extra trabajado:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Horas trabajadas: ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sueldo hora extra: ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Rebaje de Prestamo/Falta: ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(111, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Neto recibido: ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // NombreTxt
            // 
            this.NombreTxt.Enabled = false;
            this.NombreTxt.Location = new System.Drawing.Point(229, 56);
            this.NombreTxt.Name = "NombreTxt";
            this.NombreTxt.Size = new System.Drawing.Size(259, 25);
            this.NombreTxt.TabIndex = 7;
            this.NombreTxt.TextChanged += new System.EventHandler(this.NombreTxt_TextChanged);
            // 
            // CantidadHtxt
            // 
            this.CantidadHtxt.Location = new System.Drawing.Point(229, 87);
            this.CantidadHtxt.Name = "CantidadHtxt";
            this.CantidadHtxt.Size = new System.Drawing.Size(111, 25);
            this.CantidadHtxt.TabIndex = 8;
            this.CantidadHtxt.TextChanged += new System.EventHandler(this.CantidadHtxt_TextChanged);
            this.CantidadHtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CantidadHtxt_KeyPress);
            // 
            // SxHEtxt
            // 
            this.SxHEtxt.Enabled = false;
            this.SxHEtxt.Location = new System.Drawing.Point(229, 149);
            this.SxHEtxt.Name = "SxHEtxt";
            this.SxHEtxt.Size = new System.Drawing.Size(132, 25);
            this.SxHEtxt.TabIndex = 9;
            this.SxHEtxt.TextChanged += new System.EventHandler(this.SxHEtxt_TextChanged);
            // 
            // Sueldotxt
            // 
            this.Sueldotxt.Enabled = false;
            this.Sueldotxt.Location = new System.Drawing.Point(229, 180);
            this.Sueldotxt.Name = "Sueldotxt";
            this.Sueldotxt.Size = new System.Drawing.Size(132, 25);
            this.Sueldotxt.TabIndex = 10;
            this.Sueldotxt.TextChanged += new System.EventHandler(this.Sueldotxt_TextChanged);
            // 
            // HEtxt
            // 
            this.HEtxt.Location = new System.Drawing.Point(229, 211);
            this.HEtxt.Name = "HEtxt";
            this.HEtxt.Size = new System.Drawing.Size(111, 25);
            this.HEtxt.TabIndex = 11;
            this.HEtxt.TextChanged += new System.EventHandler(this.HEtxt_TextChanged);
            this.HEtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HEtxt_KeyPress);
            // 
            // RabajePoFtxt
            // 
            this.RabajePoFtxt.Location = new System.Drawing.Point(229, 273);
            this.RabajePoFtxt.Name = "RabajePoFtxt";
            this.RabajePoFtxt.Size = new System.Drawing.Size(132, 25);
            this.RabajePoFtxt.TabIndex = 12;
            this.RabajePoFtxt.TextChanged += new System.EventHandler(this.RabajePoFtxt_TextChanged);
            this.RabajePoFtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RabajePoFtxt_KeyPress);
            // 
            // CantRecibidatxt
            // 
            this.CantRecibidatxt.Enabled = false;
            this.CantRecibidatxt.Location = new System.Drawing.Point(229, 304);
            this.CantRecibidatxt.Name = "CantRecibidatxt";
            this.CantRecibidatxt.Size = new System.Drawing.Size(132, 25);
            this.CantRecibidatxt.TabIndex = 13;
            this.CantRecibidatxt.TextChanged += new System.EventHandler(this.CantRecibidatxt_TextChanged);
            // 
            // SxHEFtxt
            // 
            this.SxHEFtxt.Enabled = false;
            this.SxHEFtxt.Location = new System.Drawing.Point(229, 242);
            this.SxHEFtxt.Name = "SxHEFtxt";
            this.SxHEFtxt.Size = new System.Drawing.Size(111, 25);
            this.SxHEFtxt.TabIndex = 14;
            this.SxHEFtxt.TextChanged += new System.EventHandler(this.SxHEFtxt_TextChanged);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(548, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 47);
            this.button1.TabIndex = 15;
            this.button1.Text = "Generar Nomina";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTvolver
            // 
            this.BTvolver.Location = new System.Drawing.Point(548, 262);
            this.BTvolver.Name = "BTvolver";
            this.BTvolver.Size = new System.Drawing.Size(115, 47);
            this.BTvolver.TabIndex = 16;
            this.BTvolver.Text = "Atras";
            this.BTvolver.UseVisualStyleBackColor = true;
            this.BTvolver.Click += new System.EventHandler(this.BTvolver_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label8.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(45, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Número del Tranbajador: ";
            // 
            // TrabajadorNtxt
            // 
            this.TrabajadorNtxt.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrabajadorNtxt.Location = new System.Drawing.Point(228, 101);
            this.TrabajadorNtxt.Name = "TrabajadorNtxt";
            this.TrabajadorNtxt.Size = new System.Drawing.Size(186, 22);
            this.TrabajadorNtxt.TabIndex = 18;
            this.TrabajadorNtxt.TextChanged += new System.EventHandler(this.TrabajadorNtxt_TextChanged);
            this.TrabajadorNtxt.Validating += new System.ComponentModel.CancelEventHandler(this.TrabajadorNtxt_Validating);
            // 
            // btGenerar
            // 
            this.btGenerar.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGenerar.Location = new System.Drawing.Point(545, 99);
            this.btGenerar.Name = "btGenerar";
            this.btGenerar.Size = new System.Drawing.Size(144, 27);
            this.btGenerar.TabIndex = 19;
            this.btGenerar.Text = "Llenar Automaticamente ";
            this.btGenerar.UseVisualStyleBackColor = true;
            this.btGenerar.Click += new System.EventHandler(this.btGenerar_Click);
            // 
            // SxHtxt
            // 
            this.SxHtxt.Enabled = false;
            this.SxHtxt.Location = new System.Drawing.Point(229, 118);
            this.SxHtxt.Name = "SxHtxt";
            this.SxHtxt.Size = new System.Drawing.Size(132, 25);
            this.SxHtxt.TabIndex = 20;
            this.SxHtxt.TextChanged += new System.EventHandler(this.SxHtxt_TextChanged);
            // 
            // GBDatos
            // 
            this.GBDatos.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.GBDatos.Controls.Add(this.FechaHoy);
            this.GBDatos.Controls.Add(this.label10);
            this.GBDatos.Controls.Add(this.label9);
            this.GBDatos.Controls.Add(this.Generartxt);
            this.GBDatos.Controls.Add(this.BTvolver);
            this.GBDatos.Controls.Add(this.SxHtxt);
            this.GBDatos.Controls.Add(this.label1);
            this.GBDatos.Controls.Add(this.label2);
            this.GBDatos.Controls.Add(this.label3);
            this.GBDatos.Controls.Add(this.label4);
            this.GBDatos.Controls.Add(this.button1);
            this.GBDatos.Controls.Add(this.label5);
            this.GBDatos.Controls.Add(this.SxHEFtxt);
            this.GBDatos.Controls.Add(this.label6);
            this.GBDatos.Controls.Add(this.CantRecibidatxt);
            this.GBDatos.Controls.Add(this.label7);
            this.GBDatos.Controls.Add(this.RabajePoFtxt);
            this.GBDatos.Controls.Add(this.NombreTxt);
            this.GBDatos.Controls.Add(this.HEtxt);
            this.GBDatos.Controls.Add(this.CantidadHtxt);
            this.GBDatos.Controls.Add(this.Sueldotxt);
            this.GBDatos.Controls.Add(this.SxHEtxt);
            this.GBDatos.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBDatos.Location = new System.Drawing.Point(40, 129);
            this.GBDatos.Name = "GBDatos";
            this.GBDatos.Size = new System.Drawing.Size(690, 351);
            this.GBDatos.TabIndex = 21;
            this.GBDatos.TabStop = false;
            this.GBDatos.Enter += new System.EventHandler(this.GBDatos_Enter);
            // 
            // FechaHoy
            // 
            this.FechaHoy.CalendarForeColor = System.Drawing.Color.Black;
            this.FechaHoy.CalendarMonthBackground = System.Drawing.SystemColors.AppWorkspace;
            this.FechaHoy.Location = new System.Drawing.Point(16, 22);
            this.FechaHoy.Name = "FechaHoy";
            this.FechaHoy.Size = new System.Drawing.Size(324, 25);
            this.FechaHoy.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(94, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 18);
            this.label10.TabIndex = 23;
            this.label10.Text = "Sueldo por hora: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 245);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(168, 18);
            this.label9.TabIndex = 22;
            this.label9.Text = "Sueldo por horas extras:";
            // 
            // Generartxt
            // 
            this.Generartxt.Enabled = false;
            this.Generartxt.Location = new System.Drawing.Point(548, 152);
            this.Generartxt.Name = "Generartxt";
            this.Generartxt.Size = new System.Drawing.Size(115, 49);
            this.Generartxt.TabIndex = 21;
            this.Generartxt.Text = "Generar";
            this.Generartxt.UseVisualStyleBackColor = true;
            this.Generartxt.Click += new System.EventHandler(this.Generartxt_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(777, 520);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Nomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 518);
            this.Controls.Add(this.btGenerar);
            this.Controls.Add(this.TrabajadorNtxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.GBDatos);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Nomina";
            this.Text = "Nomina";
            this.Load += new System.EventHandler(this.Nomina_Load);
            this.GBDatos.ResumeLayout(false);
            this.GBDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox NombreTxt;
        private System.Windows.Forms.TextBox CantidadHtxt;
        private System.Windows.Forms.TextBox SxHEtxt;
        private System.Windows.Forms.TextBox Sueldotxt;
        private System.Windows.Forms.TextBox HEtxt;
        private System.Windows.Forms.TextBox RabajePoFtxt;
        private System.Windows.Forms.TextBox CantRecibidatxt;
        private System.Windows.Forms.TextBox SxHEFtxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BTvolver;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TrabajadorNtxt;
        private System.Windows.Forms.Button btGenerar;
        private System.Windows.Forms.TextBox SxHtxt;
        private System.Windows.Forms.GroupBox GBDatos;
        private System.Windows.Forms.Button Generartxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DateTimePicker FechaHoy;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}