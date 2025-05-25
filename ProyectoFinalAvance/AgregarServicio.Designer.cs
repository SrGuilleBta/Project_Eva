namespace ProyectoFinalAvance
{
    partial class AgregarServicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarServicio));
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NumClientetxt = new System.Windows.Forms.TextBox();
            this.Fechatxt = new System.Windows.Forms.TextBox();
            this.Servciotxt = new System.Windows.Forms.TextBox();
            this.NumPedidotxt = new System.Windows.Forms.TextBox();
            this.btAtras = new System.Windows.Forms.Button();
            this.btAgregar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.NumServicio = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.rbClienteExistente = new System.Windows.Forms.RadioButton();
            this.rbClienteNuevo = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.residenciatxt = new System.Windows.Forms.TextBox();
            this.nombreclientetxt = new System.Windows.Forms.TextBox();
            this.telefonotxt = new System.Windows.Forms.TextBox();
            this.correotxt = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(252, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(235, 18);
            this.label6.TabIndex = 34;
            this.label6.Text = "Ingresa los datos correspondientes";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(99, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 16);
            this.label4.TabIndex = 33;
            this.label4.Text = "Número de cliente: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "Fecha (YYYY/MM/DD): ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(165, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "Servicio:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Número de Pedido: ";
            // 
            // NumClientetxt
            // 
            this.NumClientetxt.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumClientetxt.Location = new System.Drawing.Point(248, 243);
            this.NumClientetxt.Name = "NumClientetxt";
            this.NumClientetxt.Size = new System.Drawing.Size(207, 22);
            this.NumClientetxt.TabIndex = 29;
            this.NumClientetxt.TextChanged += new System.EventHandler(this.NumClientetxt_TextChanged);
            this.NumClientetxt.Validating += new System.ComponentModel.CancelEventHandler(this.NumClientetxt_Validating);
            // 
            // Fechatxt
            // 
            this.Fechatxt.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fechatxt.Location = new System.Drawing.Point(248, 207);
            this.Fechatxt.Name = "Fechatxt";
            this.Fechatxt.Size = new System.Drawing.Size(207, 22);
            this.Fechatxt.TabIndex = 28;
            this.Fechatxt.Validating += new System.ComponentModel.CancelEventHandler(this.Fechatxt_Validating);
            // 
            // Servciotxt
            // 
            this.Servciotxt.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Servciotxt.Location = new System.Drawing.Point(248, 169);
            this.Servciotxt.Name = "Servciotxt";
            this.Servciotxt.Size = new System.Drawing.Size(311, 22);
            this.Servciotxt.TabIndex = 27;
            this.Servciotxt.Validating += new System.ComponentModel.CancelEventHandler(this.Servciotxt_Validating);
            // 
            // NumPedidotxt
            // 
            this.NumPedidotxt.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumPedidotxt.Location = new System.Drawing.Point(248, 130);
            this.NumPedidotxt.Name = "NumPedidotxt";
            this.NumPedidotxt.Size = new System.Drawing.Size(207, 22);
            this.NumPedidotxt.TabIndex = 26;
            this.NumPedidotxt.Validating += new System.ComponentModel.CancelEventHandler(this.NumPedidotxt_Validating);
            // 
            // btAtras
            // 
            this.btAtras.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAtras.Location = new System.Drawing.Point(422, 479);
            this.btAtras.Name = "btAtras";
            this.btAtras.Size = new System.Drawing.Size(174, 41);
            this.btAtras.TabIndex = 36;
            this.btAtras.Text = "Atras";
            this.btAtras.UseVisualStyleBackColor = true;
            this.btAtras.Click += new System.EventHandler(this.btAtras_Click);
            // 
            // btAgregar
            // 
            this.btAgregar.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAgregar.Location = new System.Drawing.Point(123, 479);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(174, 41);
            this.btAgregar.TabIndex = 35;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(91, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 16);
            this.label5.TabIndex = 38;
            this.label5.Text = "Número de servicio: ";
            // 
            // NumServicio
            // 
            this.NumServicio.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumServicio.Location = new System.Drawing.Point(248, 280);
            this.NumServicio.Name = "NumServicio";
            this.NumServicio.Size = new System.Drawing.Size(207, 22);
            this.NumServicio.TabIndex = 37;
            this.NumServicio.Validating += new System.ComponentModel.CancelEventHandler(this.NumServicio_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // rbClienteExistente
            // 
            this.rbClienteExistente.AutoSize = true;
            this.rbClienteExistente.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.rbClienteExistente.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbClienteExistente.Location = new System.Drawing.Point(87, 95);
            this.rbClienteExistente.Name = "rbClienteExistente";
            this.rbClienteExistente.Size = new System.Drawing.Size(207, 20);
            this.rbClienteExistente.TabIndex = 39;
            this.rbClienteExistente.TabStop = true;
            this.rbClienteExistente.Text = "Agregar con cliente existente";
            this.rbClienteExistente.UseVisualStyleBackColor = false;
            this.rbClienteExistente.CheckedChanged += new System.EventHandler(this.rbClienteExistente_CheckedChanged);
            // 
            // rbClienteNuevo
            // 
            this.rbClienteNuevo.AutoSize = true;
            this.rbClienteNuevo.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.rbClienteNuevo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rbClienteNuevo.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbClienteNuevo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbClienteNuevo.Location = new System.Drawing.Point(440, 94);
            this.rbClienteNuevo.Name = "rbClienteNuevo";
            this.rbClienteNuevo.Size = new System.Drawing.Size(195, 21);
            this.rbClienteNuevo.TabIndex = 40;
            this.rbClienteNuevo.TabStop = true;
            this.rbClienteNuevo.Text = "Agregar con cliente nuevo";
            this.rbClienteNuevo.UseVisualStyleBackColor = false;
            this.rbClienteNuevo.CheckedChanged += new System.EventHandler(this.rbClienteNuevo_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label7.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(95, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 16);
            this.label7.TabIndex = 41;
            this.label7.Text = "Nombre residencia: ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label8.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(120, 357);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 16);
            this.label8.TabIndex = 42;
            this.label8.Text = "Nombre cliente:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label9.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(159, 393);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 16);
            this.label9.TabIndex = 43;
            this.label9.Text = "Telefono: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label10.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(170, 430);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 16);
            this.label10.TabIndex = 44;
            this.label10.Text = "Correo: ";
            // 
            // residenciatxt
            // 
            this.residenciatxt.Enabled = false;
            this.residenciatxt.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.residenciatxt.Location = new System.Drawing.Point(248, 317);
            this.residenciatxt.Name = "residenciatxt";
            this.residenciatxt.Size = new System.Drawing.Size(311, 22);
            this.residenciatxt.TabIndex = 45;
            this.residenciatxt.Validating += new System.ComponentModel.CancelEventHandler(this.residenciatxt_Validating);
            // 
            // nombreclientetxt
            // 
            this.nombreclientetxt.Enabled = false;
            this.nombreclientetxt.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreclientetxt.Location = new System.Drawing.Point(248, 354);
            this.nombreclientetxt.Name = "nombreclientetxt";
            this.nombreclientetxt.Size = new System.Drawing.Size(311, 22);
            this.nombreclientetxt.TabIndex = 46;
            this.nombreclientetxt.Validating += new System.ComponentModel.CancelEventHandler(this.nombreclientetxt_Validating);
            // 
            // telefonotxt
            // 
            this.telefonotxt.Enabled = false;
            this.telefonotxt.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefonotxt.Location = new System.Drawing.Point(248, 390);
            this.telefonotxt.Name = "telefonotxt";
            this.telefonotxt.Size = new System.Drawing.Size(207, 22);
            this.telefonotxt.TabIndex = 47;
            this.telefonotxt.Validating += new System.ComponentModel.CancelEventHandler(this.telefonotxt_Validating);
            // 
            // correotxt
            // 
            this.correotxt.Enabled = false;
            this.correotxt.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correotxt.Location = new System.Drawing.Point(248, 427);
            this.correotxt.Name = "correotxt";
            this.correotxt.Size = new System.Drawing.Size(311, 22);
            this.correotxt.TabIndex = 48;
            this.correotxt.Validating += new System.ComponentModel.CancelEventHandler(this.correotxt_Validating);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(721, 539);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // AgregarServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 538);
            this.Controls.Add(this.correotxt);
            this.Controls.Add(this.telefonotxt);
            this.Controls.Add(this.nombreclientetxt);
            this.Controls.Add(this.residenciatxt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rbClienteNuevo);
            this.Controls.Add(this.rbClienteExistente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NumServicio);
            this.Controls.Add(this.btAtras);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumClientetxt);
            this.Controls.Add(this.Fechatxt);
            this.Controls.Add(this.Servciotxt);
            this.Controls.Add(this.NumPedidotxt);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AgregarServicio";
            this.Text = "AgregarServicio";
            this.Load += new System.EventHandler(this.AgregarServicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NumClientetxt;
        private System.Windows.Forms.TextBox Fechatxt;
        private System.Windows.Forms.TextBox Servciotxt;
        private System.Windows.Forms.TextBox NumPedidotxt;
        private System.Windows.Forms.Button btAtras;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NumServicio;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.RadioButton rbClienteNuevo;
        private System.Windows.Forms.RadioButton rbClienteExistente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox correotxt;
        private System.Windows.Forms.TextBox telefonotxt;
        private System.Windows.Forms.TextBox nombreclientetxt;
        private System.Windows.Forms.TextBox residenciatxt;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}