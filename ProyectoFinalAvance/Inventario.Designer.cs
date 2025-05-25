namespace ProyectoFinalAvance
{
    partial class Inventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventario));
            this.InventarioDG = new System.Windows.Forms.DataGridView();
            this.ListaDServicios = new System.Windows.Forms.ComboBox();
            this.BInfoServicios = new System.Windows.Forms.Button();
            this.BPaginaPrincipal = new System.Windows.Forms.Button();
            this.BTAgregar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ActualizarOEliminar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.InventarioDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // InventarioDG
            // 
            this.InventarioDG.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.InventarioDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InventarioDG.Location = new System.Drawing.Point(36, 134);
            this.InventarioDG.Name = "InventarioDG";
            this.InventarioDG.Size = new System.Drawing.Size(720, 283);
            this.InventarioDG.TabIndex = 0;
            // 
            // ListaDServicios
            // 
            this.ListaDServicios.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.ListaDServicios.Location = new System.Drawing.Point(215, 96);
            this.ListaDServicios.Name = "ListaDServicios";
            this.ListaDServicios.Size = new System.Drawing.Size(366, 23);
            this.ListaDServicios.TabIndex = 10;
            this.ListaDServicios.SelectedIndexChanged += new System.EventHandler(this.ListaDServicios_SelectedIndexChanged);
            // 
            // BInfoServicios
            // 
            this.BInfoServicios.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BInfoServicios.Location = new System.Drawing.Point(297, 425);
            this.BInfoServicios.Name = "BInfoServicios";
            this.BInfoServicios.Size = new System.Drawing.Size(163, 38);
            this.BInfoServicios.TabIndex = 11;
            this.BInfoServicios.Text = "Informacion de Servicios";
            this.BInfoServicios.UseVisualStyleBackColor = true;
            this.BInfoServicios.Click += new System.EventHandler(this.BInfoServicios_Click);
            // 
            // BPaginaPrincipal
            // 
            this.BPaginaPrincipal.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BPaginaPrincipal.Location = new System.Drawing.Point(532, 425);
            this.BPaginaPrincipal.Name = "BPaginaPrincipal";
            this.BPaginaPrincipal.Size = new System.Drawing.Size(138, 38);
            this.BPaginaPrincipal.TabIndex = 12;
            this.BPaginaPrincipal.Text = "Pagina Principal";
            this.BPaginaPrincipal.UseVisualStyleBackColor = true;
            this.BPaginaPrincipal.Click += new System.EventHandler(this.BPaginaPrincipal_Click);
            // 
            // BTAgregar
            // 
            this.BTAgregar.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTAgregar.Location = new System.Drawing.Point(103, 426);
            this.BTAgregar.Name = "BTAgregar";
            this.BTAgregar.Size = new System.Drawing.Size(122, 36);
            this.BTAgregar.TabIndex = 13;
            this.BTAgregar.Text = "Agregar";
            this.BTAgregar.UseVisualStyleBackColor = true;
            this.BTAgregar.Click += new System.EventHandler(this.BTAgregar_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(582, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 36);
            this.button1.TabIndex = 14;
            this.button1.Text = "Solicitar producto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ActualizarOEliminar
            // 
            this.ActualizarOEliminar.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActualizarOEliminar.Location = new System.Drawing.Point(377, 23);
            this.ActualizarOEliminar.Name = "ActualizarOEliminar";
            this.ActualizarOEliminar.Size = new System.Drawing.Size(162, 36);
            this.ActualizarOEliminar.TabIndex = 15;
            this.ActualizarOEliminar.Text = "Actualizar o Eliminar";
            this.ActualizarOEliminar.UseVisualStyleBackColor = true;
            this.ActualizarOEliminar.Click += new System.EventHandler(this.ActualizarOEliminar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(793, 502);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 500);
            this.Controls.Add(this.ActualizarOEliminar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BTAgregar);
            this.Controls.Add(this.BPaginaPrincipal);
            this.Controls.Add(this.BInfoServicios);
            this.Controls.Add(this.ListaDServicios);
            this.Controls.Add(this.InventarioDG);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Inventario";
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.Inventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InventarioDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView InventarioDG;
        private System.Windows.Forms.ComboBox ListaDServicios;
        private System.Windows.Forms.Button BInfoServicios;
        private System.Windows.Forms.Button BPaginaPrincipal;
        private System.Windows.Forms.Button BTAgregar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ActualizarOEliminar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}