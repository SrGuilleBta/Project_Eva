namespace ProyectoFinalAvance
{
    partial class PantallaInfoDServicios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaInfoDServicios));
            this.BNuevoCliente = new System.Windows.Forms.Button();
            this.BPaginaPrincipal = new System.Windows.Forms.Button();
            this.ListaDServicios = new System.Windows.Forms.ComboBox();
            this.InfoDeTrabajadoresTxt = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BNuevoCliente
            // 
            this.BNuevoCliente.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BNuevoCliente.Location = new System.Drawing.Point(138, 364);
            this.BNuevoCliente.Name = "BNuevoCliente";
            this.BNuevoCliente.Size = new System.Drawing.Size(129, 30);
            this.BNuevoCliente.TabIndex = 7;
            this.BNuevoCliente.Text = "Nuevo Cliente";
            this.BNuevoCliente.UseVisualStyleBackColor = true;
            this.BNuevoCliente.Click += new System.EventHandler(this.BNuevoCliente_Click);
            // 
            // BPaginaPrincipal
            // 
            this.BPaginaPrincipal.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BPaginaPrincipal.Location = new System.Drawing.Point(348, 364);
            this.BPaginaPrincipal.Name = "BPaginaPrincipal";
            this.BPaginaPrincipal.Size = new System.Drawing.Size(129, 30);
            this.BPaginaPrincipal.TabIndex = 8;
            this.BPaginaPrincipal.Text = "Pagina Principal";
            this.BPaginaPrincipal.UseVisualStyleBackColor = true;
            this.BPaginaPrincipal.Click += new System.EventHandler(this.BPaginaPrincipal_Click);
            // 
            // ListaDServicios
            // 
            this.ListaDServicios.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaDServicios.FormattingEnabled = true;
            this.ListaDServicios.Items.AddRange(new object[] {
            "Ingenieria",
            "Cableado",
            "Audio",
            "Video",
            "Control De Iluminacion",
            "Red De Datos",
            "Telefonia Y Control De Accesos",
            "Cicuito Cerrado",
            "Control"});
            this.ListaDServicios.Location = new System.Drawing.Point(159, 82);
            this.ListaDServicios.Name = "ListaDServicios";
            this.ListaDServicios.Size = new System.Drawing.Size(299, 23);
            this.ListaDServicios.TabIndex = 9;
            this.ListaDServicios.Text = "Ingenieria";
            this.ListaDServicios.SelectedIndexChanged += new System.EventHandler(this.ListaDServicios_SelectedIndexChanged);
            // 
            // InfoDeTrabajadoresTxt
            // 
            this.InfoDeTrabajadoresTxt.Enabled = false;
            this.InfoDeTrabajadoresTxt.Location = new System.Drawing.Point(28, 114);
            this.InfoDeTrabajadoresTxt.Multiline = true;
            this.InfoDeTrabajadoresTxt.Name = "InfoDeTrabajadoresTxt";
            this.InfoDeTrabajadoresTxt.Size = new System.Drawing.Size(557, 244);
            this.InfoDeTrabajadoresTxt.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(613, 429);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // PantallaInfoDServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 427);
            this.Controls.Add(this.InfoDeTrabajadoresTxt);
            this.Controls.Add(this.ListaDServicios);
            this.Controls.Add(this.BPaginaPrincipal);
            this.Controls.Add(this.BNuevoCliente);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PantallaInfoDServicios";
            this.Load += new System.EventHandler(this.PantallaInfoDServicios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BNuevoCliente;
        private System.Windows.Forms.Button BPaginaPrincipal;
        private System.Windows.Forms.ComboBox ListaDServicios;
        private System.Windows.Forms.TextBox InfoDeTrabajadoresTxt;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}