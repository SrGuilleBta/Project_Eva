namespace ProyectoFinalAvance
{
    partial class InfoTrabajadores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoTrabajadores));
            this.BPaginaPrincipal = new System.Windows.Forms.Button();
            this.BInfoServicios = new System.Windows.Forms.Button();
            this.ListaDServicios = new System.Windows.Forms.ComboBox();
            this.TrabajadoresDG = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.nombretxt = new System.Windows.Forms.TextBox();
            this.Nombrelb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BTAgregar = new System.Windows.Forms.Button();
            this.ActualizarOEliminar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.TrabajadoresDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BPaginaPrincipal
            // 
            this.BPaginaPrincipal.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BPaginaPrincipal.Location = new System.Drawing.Point(455, 475);
            this.BPaginaPrincipal.Name = "BPaginaPrincipal";
            this.BPaginaPrincipal.Size = new System.Drawing.Size(147, 32);
            this.BPaginaPrincipal.TabIndex = 16;
            this.BPaginaPrincipal.Text = "Pagina Principal";
            this.BPaginaPrincipal.UseVisualStyleBackColor = true;
            this.BPaginaPrincipal.Click += new System.EventHandler(this.BPaginaPrincipal_Click);
            // 
            // BInfoServicios
            // 
            this.BInfoServicios.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BInfoServicios.Location = new System.Drawing.Point(149, 475);
            this.BInfoServicios.Name = "BInfoServicios";
            this.BInfoServicios.Size = new System.Drawing.Size(187, 32);
            this.BInfoServicios.TabIndex = 15;
            this.BInfoServicios.Text = "Informacion de Servicios";
            this.BInfoServicios.UseVisualStyleBackColor = true;
            this.BInfoServicios.Click += new System.EventHandler(this.BInfoServicios_Click);
            // 
            // ListaDServicios
            // 
            this.ListaDServicios.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaDServicios.FormattingEnabled = true;
            this.ListaDServicios.Items.AddRange(new object[] {
            "Todo",
            "Ingenieria",
            "Cableado",
            "Audio",
            "Video",
            "Control de Iluminación",
            "Red De Datos",
            "Telefonia Y Control De Accesos",
            "Circuito Cerrado",
            "Control"});
            this.ListaDServicios.Location = new System.Drawing.Point(177, 108);
            this.ListaDServicios.Name = "ListaDServicios";
            this.ListaDServicios.Size = new System.Drawing.Size(282, 24);
            this.ListaDServicios.TabIndex = 14;
            this.ListaDServicios.SelectedIndexChanged += new System.EventHandler(this.ListaDServicios_SelectedIndexChanged);
            // 
            // TrabajadoresDG
            // 
            this.TrabajadoresDG.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TrabajadoresDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TrabajadoresDG.Location = new System.Drawing.Point(47, 149);
            this.TrabajadoresDG.Name = "TrabajadoresDG";
            this.TrabajadoresDG.Size = new System.Drawing.Size(916, 310);
            this.TrabajadoresDG.TabIndex = 13;
            this.TrabajadoresDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TrabajadoresDG_CellContentClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(714, 475);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 32);
            this.button1.TabIndex = 17;
            this.button1.Text = "Generar Nomina";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nombretxt
            // 
            this.nombretxt.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombretxt.Location = new System.Drawing.Point(607, 108);
            this.nombretxt.Name = "nombretxt";
            this.nombretxt.Size = new System.Drawing.Size(304, 22);
            this.nombretxt.TabIndex = 19;
            this.nombretxt.TextChanged += new System.EventHandler(this.nombretxt_TextChanged);
            // 
            // Nombrelb
            // 
            this.Nombrelb.AutoSize = true;
            this.Nombrelb.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Nombrelb.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombrelb.Location = new System.Drawing.Point(529, 111);
            this.Nombrelb.Name = "Nombrelb";
            this.Nombrelb.Size = new System.Drawing.Size(63, 16);
            this.Nombrelb.TabIndex = 20;
            this.Nombrelb.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Servicio:";
            // 
            // BTAgregar
            // 
            this.BTAgregar.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTAgregar.Location = new System.Drawing.Point(616, 29);
            this.BTAgregar.Name = "BTAgregar";
            this.BTAgregar.Size = new System.Drawing.Size(113, 36);
            this.BTAgregar.TabIndex = 22;
            this.BTAgregar.Text = "Agregar";
            this.BTAgregar.UseVisualStyleBackColor = true;
            this.BTAgregar.Click += new System.EventHandler(this.BTAgregar_Click);
            // 
            // ActualizarOEliminar
            // 
            this.ActualizarOEliminar.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActualizarOEliminar.Location = new System.Drawing.Point(794, 29);
            this.ActualizarOEliminar.Name = "ActualizarOEliminar";
            this.ActualizarOEliminar.Size = new System.Drawing.Size(152, 36);
            this.ActualizarOEliminar.TabIndex = 23;
            this.ActualizarOEliminar.Text = "Actualizar o Eliminar";
            this.ActualizarOEliminar.UseVisualStyleBackColor = true;
            this.ActualizarOEliminar.Click += new System.EventHandler(this.ActualizarOEliminar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1013, 550);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // InfoTrabajadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 547);
            this.Controls.Add(this.ActualizarOEliminar);
            this.Controls.Add(this.BTAgregar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nombrelb);
            this.Controls.Add(this.nombretxt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BPaginaPrincipal);
            this.Controls.Add(this.BInfoServicios);
            this.Controls.Add(this.ListaDServicios);
            this.Controls.Add(this.TrabajadoresDG);
            this.Controls.Add(this.pictureBox1);
            this.Name = "InfoTrabajadores";
            this.Text = "InfoTrabajadores";
            this.Load += new System.EventHandler(this.InfoTrabajadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TrabajadoresDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BPaginaPrincipal;
        private System.Windows.Forms.Button BInfoServicios;
        private System.Windows.Forms.ComboBox ListaDServicios;
        private System.Windows.Forms.DataGridView TrabajadoresDG;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox nombretxt;
        private System.Windows.Forms.Label Nombrelb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTAgregar;
        private System.Windows.Forms.Button ActualizarOEliminar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}