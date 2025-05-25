namespace ProyectoFinalAvance
{
    partial class PaginaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaginaPrincipal));
            this.Seleccione = new System.Windows.Forms.Label();
            this.BInfoServicios = new System.Windows.Forms.Button();
            this.BRegisServicios = new System.Windows.Forms.Button();
            this.BInventario = new System.Windows.Forms.Button();
            this.BNuevoCliente = new System.Windows.Forms.Button();
            this.BCerrarS = new System.Windows.Forms.Button();
            this.BInfoT = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Seleccione
            // 
            this.Seleccione.AutoSize = true;
            this.Seleccione.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Seleccione.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seleccione.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Seleccione.Location = new System.Drawing.Point(308, 150);
            this.Seleccione.Name = "Seleccione";
            this.Seleccione.Size = new System.Drawing.Size(109, 23);
            this.Seleccione.TabIndex = 0;
            this.Seleccione.Text = "Seleccione: ";
            // 
            // BInfoServicios
            // 
            this.BInfoServicios.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BInfoServicios.Location = new System.Drawing.Point(162, 219);
            this.BInfoServicios.Name = "BInfoServicios";
            this.BInfoServicios.Size = new System.Drawing.Size(132, 72);
            this.BInfoServicios.TabIndex = 1;
            this.BInfoServicios.Text = "Informacion de Servicios";
            this.BInfoServicios.UseVisualStyleBackColor = true;
            this.BInfoServicios.Click += new System.EventHandler(this.BInfoServicios_Click);
            // 
            // BRegisServicios
            // 
            this.BRegisServicios.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BRegisServicios.Location = new System.Drawing.Point(312, 219);
            this.BRegisServicios.Name = "BRegisServicios";
            this.BRegisServicios.Size = new System.Drawing.Size(121, 72);
            this.BRegisServicios.TabIndex = 2;
            this.BRegisServicios.Text = "Registro de Servicios";
            this.BRegisServicios.UseVisualStyleBackColor = true;
            this.BRegisServicios.Click += new System.EventHandler(this.BRegisServicios_Click);
            // 
            // BInventario
            // 
            this.BInventario.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BInventario.Location = new System.Drawing.Point(162, 320);
            this.BInventario.Name = "BInventario";
            this.BInventario.Size = new System.Drawing.Size(132, 63);
            this.BInventario.TabIndex = 4;
            this.BInventario.Text = "Inventario";
            this.BInventario.UseVisualStyleBackColor = true;
            this.BInventario.Click += new System.EventHandler(this.BInventario_Click);
            // 
            // BNuevoCliente
            // 
            this.BNuevoCliente.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BNuevoCliente.Location = new System.Drawing.Point(312, 320);
            this.BNuevoCliente.Name = "BNuevoCliente";
            this.BNuevoCliente.Size = new System.Drawing.Size(121, 63);
            this.BNuevoCliente.TabIndex = 5;
            this.BNuevoCliente.Text = "Nuevo Cliente";
            this.BNuevoCliente.UseVisualStyleBackColor = true;
            this.BNuevoCliente.Click += new System.EventHandler(this.BNuevoCliente_Click);
            // 
            // BCerrarS
            // 
            this.BCerrarS.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCerrarS.Location = new System.Drawing.Point(454, 320);
            this.BCerrarS.Name = "BCerrarS";
            this.BCerrarS.Size = new System.Drawing.Size(128, 63);
            this.BCerrarS.TabIndex = 6;
            this.BCerrarS.Text = "Cerrar Sesion ";
            this.BCerrarS.UseVisualStyleBackColor = true;
            this.BCerrarS.Click += new System.EventHandler(this.BCerrarS_Click);
            // 
            // BInfoT
            // 
            this.BInfoT.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BInfoT.Location = new System.Drawing.Point(454, 219);
            this.BInfoT.Name = "BInfoT";
            this.BInfoT.Size = new System.Drawing.Size(128, 72);
            this.BInfoT.TabIndex = 7;
            this.BInfoT.Text = "Información de los trabajadores";
            this.BInfoT.UseVisualStyleBackColor = true;
            this.BInfoT.Click += new System.EventHandler(this.BInfoT_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(741, 477);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PaginaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 475);
            this.Controls.Add(this.BInfoT);
            this.Controls.Add(this.BCerrarS);
            this.Controls.Add(this.BNuevoCliente);
            this.Controls.Add(this.BInventario);
            this.Controls.Add(this.BRegisServicios);
            this.Controls.Add(this.BInfoServicios);
            this.Controls.Add(this.Seleccione);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PaginaPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Seleccione;
        private System.Windows.Forms.Button BInfoServicios;
        private System.Windows.Forms.Button BRegisServicios;
        private System.Windows.Forms.Button BInventario;
        private System.Windows.Forms.Button BNuevoCliente;
        private System.Windows.Forms.Button BCerrarS;
        private System.Windows.Forms.Button BInfoT;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}