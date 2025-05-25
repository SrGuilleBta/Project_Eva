namespace ProyectoFinalAvance
{
    partial class PantallaDInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaDInicio));
            this.IngreseLosDatostxt = new System.Windows.Forms.Label();
            this.Usuario = new System.Windows.Forms.Label();
            this.Contraseña = new System.Windows.Forms.Label();
            this.Usuariotxt = new System.Windows.Forms.TextBox();
            this.Contraseñatxt = new System.Windows.Forms.TextBox();
            this.BAceptar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btConfiguracion = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // IngreseLosDatostxt
            // 
            this.IngreseLosDatostxt.AutoSize = true;
            this.IngreseLosDatostxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.IngreseLosDatostxt.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngreseLosDatostxt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.IngreseLosDatostxt.Location = new System.Drawing.Point(243, 86);
            this.IngreseLosDatostxt.Name = "IngreseLosDatostxt";
            this.IngreseLosDatostxt.Size = new System.Drawing.Size(140, 18);
            this.IngreseLosDatostxt.TabIndex = 0;
            this.IngreseLosDatostxt.Text = "Ingrese Los Datos:";
            // 
            // Usuario
            // 
            this.Usuario.AutoSize = true;
            this.Usuario.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Usuario.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuario.Location = new System.Drawing.Point(119, 151);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(72, 18);
            this.Usuario.TabIndex = 1;
            this.Usuario.Text = "Usuario: ";
            // 
            // Contraseña
            // 
            this.Contraseña.AutoSize = true;
            this.Contraseña.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Contraseña.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contraseña.Location = new System.Drawing.Point(94, 201);
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.Size = new System.Drawing.Size(97, 18);
            this.Contraseña.TabIndex = 2;
            this.Contraseña.Text = "Contraseña: ";
            // 
            // Usuariotxt
            // 
            this.Usuariotxt.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuariotxt.Location = new System.Drawing.Point(199, 148);
            this.Usuariotxt.Name = "Usuariotxt";
            this.Usuariotxt.Size = new System.Drawing.Size(311, 26);
            this.Usuariotxt.TabIndex = 3;
            this.Usuariotxt.Validating += new System.ComponentModel.CancelEventHandler(this.Usuariotxt_Validating);
            // 
            // Contraseñatxt
            // 
            this.Contraseñatxt.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contraseñatxt.Location = new System.Drawing.Point(199, 198);
            this.Contraseñatxt.Name = "Contraseñatxt";
            this.Contraseñatxt.Size = new System.Drawing.Size(311, 26);
            this.Contraseñatxt.TabIndex = 4;
            this.Contraseñatxt.Validating += new System.ComponentModel.CancelEventHandler(this.Contraseñatxt_Validating);
            // 
            // BAceptar
            // 
            this.BAceptar.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAceptar.Location = new System.Drawing.Point(144, 302);
            this.BAceptar.Name = "BAceptar";
            this.BAceptar.Size = new System.Drawing.Size(121, 42);
            this.BAceptar.TabIndex = 5;
            this.BAceptar.Text = "Aceptar";
            this.BAceptar.UseVisualStyleBackColor = true;
            this.BAceptar.Click += new System.EventHandler(this.BAceptar_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(333, 302);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 42);
            this.button2.TabIndex = 6;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btConfiguracion
            // 
            this.btConfiguracion.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConfiguracion.Location = new System.Drawing.Point(97, 257);
            this.btConfiguracion.Name = "btConfiguracion";
            this.btConfiguracion.Size = new System.Drawing.Size(413, 27);
            this.btConfiguracion.TabIndex = 7;
            this.btConfiguracion.Text = "Configuración de Usuario y Contraseña";
            this.btConfiguracion.UseVisualStyleBackColor = true;
            this.btConfiguracion.Click += new System.EventHandler(this.btConfiguracion_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(618, 414);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PantallaDInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 413);
            this.Controls.Add(this.btConfiguracion);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BAceptar);
            this.Controls.Add(this.Contraseñatxt);
            this.Controls.Add(this.Usuariotxt);
            this.Controls.Add(this.Contraseña);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.IngreseLosDatostxt);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PantallaDInicio";
            this.Load += new System.EventHandler(this.PantallaDInicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IngreseLosDatostxt;
        private System.Windows.Forms.Label Usuario;
        private System.Windows.Forms.Label Contraseña;
        private System.Windows.Forms.TextBox Usuariotxt;
        private System.Windows.Forms.TextBox Contraseñatxt;
        private System.Windows.Forms.Button BAceptar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btConfiguracion;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

