namespace ProyectoFinalAvance
{
    partial class ActualizarEliminarP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActualizarEliminarP));
            this.btAceptar = new System.Windows.Forms.Button();
            this.btAtras = new System.Windows.Forms.Button();
            this.rbActualizar = new System.Windows.Forms.RadioButton();
            this.rbEliminar = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NumPro = new System.Windows.Forms.TextBox();
            this.cantidadNUD = new System.Windows.Forms.NumericUpDown();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btAceptar
            // 
            this.btAceptar.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAceptar.Location = new System.Drawing.Point(89, 200);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(110, 36);
            this.btAceptar.TabIndex = 0;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // btAtras
            // 
            this.btAtras.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAtras.Location = new System.Drawing.Point(301, 200);
            this.btAtras.Name = "btAtras";
            this.btAtras.Size = new System.Drawing.Size(110, 36);
            this.btAtras.TabIndex = 1;
            this.btAtras.Text = "Atras";
            this.btAtras.UseVisualStyleBackColor = true;
            this.btAtras.Click += new System.EventHandler(this.btAtras_Click);
            // 
            // rbActualizar
            // 
            this.rbActualizar.AutoSize = true;
            this.rbActualizar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.rbActualizar.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbActualizar.Location = new System.Drawing.Point(65, 64);
            this.rbActualizar.Name = "rbActualizar";
            this.rbActualizar.Size = new System.Drawing.Size(155, 22);
            this.rbActualizar.TabIndex = 2;
            this.rbActualizar.TabStop = true;
            this.rbActualizar.Text = "Actualizar cantidad";
            this.rbActualizar.UseVisualStyleBackColor = false;
            this.rbActualizar.CheckedChanged += new System.EventHandler(this.rbActualizar_CheckedChanged);
            // 
            // rbEliminar
            // 
            this.rbEliminar.AutoSize = true;
            this.rbEliminar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.rbEliminar.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEliminar.Location = new System.Drawing.Point(276, 64);
            this.rbEliminar.Name = "rbEliminar";
            this.rbEliminar.Size = new System.Drawing.Size(149, 22);
            this.rbEliminar.TabIndex = 3;
            this.rbEliminar.TabStop = true;
            this.rbEliminar.Text = "Eliminar Producto";
            this.rbEliminar.UseVisualStyleBackColor = false;
            this.rbEliminar.CheckedChanged += new System.EventHandler(this.rbEliminar_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Número de producto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(126, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cantidad:\r\n";
            // 
            // NumPro
            // 
            this.NumPro.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumPro.Location = new System.Drawing.Point(225, 107);
            this.NumPro.Name = "NumPro";
            this.NumPro.Size = new System.Drawing.Size(218, 25);
            this.NumPro.TabIndex = 6;
            this.NumPro.Validating += new System.ComponentModel.CancelEventHandler(this.NumPro_Validating);
            // 
            // cantidadNUD
            // 
            this.cantidadNUD.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidadNUD.Location = new System.Drawing.Point(225, 153);
            this.cantidadNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cantidadNUD.Name = "cantidadNUD";
            this.cantidadNUD.Size = new System.Drawing.Size(100, 25);
            this.cantidadNUD.TabIndex = 7;
            this.cantidadNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(492, 298);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // ActualizarEliminarP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 279);
            this.Controls.Add(this.cantidadNUD);
            this.Controls.Add(this.NumPro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbEliminar);
            this.Controls.Add(this.rbActualizar);
            this.Controls.Add(this.btAtras);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ActualizarEliminarP";
            this.Text = "ActualizarEliminarP";
            this.Load += new System.EventHandler(this.ActualizarEliminarP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cantidadNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Button btAtras;
        private System.Windows.Forms.RadioButton rbActualizar;
        private System.Windows.Forms.RadioButton rbEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NumPro;
        private System.Windows.Forms.NumericUpDown cantidadNUD;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}