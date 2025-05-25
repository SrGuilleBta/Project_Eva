namespace ProyectoFinalAvance
{
    partial class Configuracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configuracion));
            this.Contraseñatxt = new System.Windows.Forms.TextBox();
            this.Usuariotxt = new System.Windows.Forms.TextBox();
            this.Contraseña = new System.Windows.Forms.Label();
            this.Usuario = new System.Windows.Forms.Label();
            this.IngreseLosDatostxt = new System.Windows.Forms.Label();
            this.rbAgregar = new System.Windows.Forms.RadioButton();
            this.rbActualizar = new System.Windows.Forms.RadioButton();
            this.rbEliminar = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.BAceptar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Contraseñatxt
            // 
            this.Contraseñatxt.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contraseñatxt.Location = new System.Drawing.Point(209, 250);
            this.Contraseñatxt.Name = "Contraseñatxt";
            this.Contraseñatxt.Size = new System.Drawing.Size(252, 25);
            this.Contraseñatxt.TabIndex = 9;
            this.Contraseñatxt.TextChanged += new System.EventHandler(this.Contraseñatxt_TextChanged);
            this.Contraseñatxt.Validating += new System.ComponentModel.CancelEventHandler(this.Contraseñatxt_Validating);
            // 
            // Usuariotxt
            // 
            this.Usuariotxt.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuariotxt.Location = new System.Drawing.Point(213, 197);
            this.Usuariotxt.Name = "Usuariotxt";
            this.Usuariotxt.Size = new System.Drawing.Size(248, 25);
            this.Usuariotxt.TabIndex = 8;
            this.Usuariotxt.TextChanged += new System.EventHandler(this.Usuariotxt_TextChanged);
            this.Usuariotxt.Validating += new System.ComponentModel.CancelEventHandler(this.Usuariotxt_Validating);
            // 
            // Contraseña
            // 
            this.Contraseña.AutoSize = true;
            this.Contraseña.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Contraseña.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contraseña.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Contraseña.Location = new System.Drawing.Point(110, 253);
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.Size = new System.Drawing.Size(93, 18);
            this.Contraseña.TabIndex = 7;
            this.Contraseña.Text = "Contraseña: ";
            this.Contraseña.Click += new System.EventHandler(this.Contraseña_Click);
            // 
            // Usuario
            // 
            this.Usuario.AutoSize = true;
            this.Usuario.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Usuario.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Usuario.Location = new System.Drawing.Point(133, 200);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(70, 18);
            this.Usuario.TabIndex = 6;
            this.Usuario.Text = "Usuario: ";
            this.Usuario.Click += new System.EventHandler(this.Usuario_Click);
            // 
            // IngreseLosDatostxt
            // 
            this.IngreseLosDatostxt.AutoSize = true;
            this.IngreseLosDatostxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.IngreseLosDatostxt.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngreseLosDatostxt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.IngreseLosDatostxt.Location = new System.Drawing.Point(248, 81);
            this.IngreseLosDatostxt.Name = "IngreseLosDatostxt";
            this.IngreseLosDatostxt.Size = new System.Drawing.Size(134, 18);
            this.IngreseLosDatostxt.TabIndex = 5;
            this.IngreseLosDatostxt.Text = "Ingrese los Datos:";
            // 
            // rbAgregar
            // 
            this.rbAgregar.AutoSize = true;
            this.rbAgregar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.rbAgregar.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAgregar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbAgregar.Location = new System.Drawing.Point(102, 139);
            this.rbAgregar.Name = "rbAgregar";
            this.rbAgregar.Size = new System.Drawing.Size(79, 22);
            this.rbAgregar.TabIndex = 10;
            this.rbAgregar.TabStop = true;
            this.rbAgregar.Text = "Agregar";
            this.rbAgregar.UseVisualStyleBackColor = false;
            // 
            // rbActualizar
            // 
            this.rbActualizar.AutoSize = true;
            this.rbActualizar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.rbActualizar.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbActualizar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbActualizar.Location = new System.Drawing.Point(251, 139);
            this.rbActualizar.Name = "rbActualizar";
            this.rbActualizar.Size = new System.Drawing.Size(94, 22);
            this.rbActualizar.TabIndex = 11;
            this.rbActualizar.TabStop = true;
            this.rbActualizar.Text = "Actualizar";
            this.rbActualizar.UseVisualStyleBackColor = false;
            this.rbActualizar.CheckedChanged += new System.EventHandler(this.rbActualizar_CheckedChanged);
            // 
            // rbEliminar
            // 
            this.rbEliminar.AutoSize = true;
            this.rbEliminar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.rbEliminar.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEliminar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbEliminar.Location = new System.Drawing.Point(423, 139);
            this.rbEliminar.Name = "rbEliminar";
            this.rbEliminar.Size = new System.Drawing.Size(85, 22);
            this.rbEliminar.TabIndex = 12;
            this.rbEliminar.TabStop = true;
            this.rbEliminar.Text = "Eliminar";
            this.rbEliminar.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(370, 312);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 31);
            this.button2.TabIndex = 14;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BAceptar
            // 
            this.BAceptar.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAceptar.Location = new System.Drawing.Point(113, 312);
            this.BAceptar.Name = "BAceptar";
            this.BAceptar.Size = new System.Drawing.Size(115, 31);
            this.BAceptar.TabIndex = 13;
            this.BAceptar.Text = "Aceptar";
            this.BAceptar.UseVisualStyleBackColor = true;
            this.BAceptar.Click += new System.EventHandler(this.BAceptar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(618, 414);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 411);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BAceptar);
            this.Controls.Add(this.rbEliminar);
            this.Controls.Add(this.rbActualizar);
            this.Controls.Add(this.rbAgregar);
            this.Controls.Add(this.Contraseñatxt);
            this.Controls.Add(this.Usuariotxt);
            this.Controls.Add(this.Contraseña);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.IngreseLosDatostxt);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Configuracion";
            this.Text = "Configuracion";
            this.Load += new System.EventHandler(this.Configuracion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Contraseñatxt;
        private System.Windows.Forms.TextBox Usuariotxt;
        private System.Windows.Forms.Label Contraseña;
        private System.Windows.Forms.Label Usuario;
        private System.Windows.Forms.Label IngreseLosDatostxt;
        private System.Windows.Forms.RadioButton rbAgregar;
        private System.Windows.Forms.RadioButton rbActualizar;
        private System.Windows.Forms.RadioButton rbEliminar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BAceptar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}