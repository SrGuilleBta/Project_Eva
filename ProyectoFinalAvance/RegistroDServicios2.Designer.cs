namespace ProyectoFinalAvance
{
    partial class RegistroDServicios2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroDServicios2));
            this.BPaginaPrincipal = new System.Windows.Forms.Button();
            this.BInfoServicios = new System.Windows.Forms.Button();
            this.ListaDServicios = new System.Windows.Forms.ComboBox();
            this.RegistroSDG = new System.Windows.Forms.DataGridView();
            this.ListaDFechas = new System.Windows.Forms.ComboBox();
            this.btBuscar = new System.Windows.Forms.Button();
            this.btAgregar = new System.Windows.Forms.Button();
            this.ClientesDt = new System.Windows.Forms.DataGridView();
            this.nombretxtx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbNombre = new System.Windows.Forms.RadioButton();
            this.rbResidencia = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.RegistroSDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesDt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BPaginaPrincipal
            // 
            this.BPaginaPrincipal.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BPaginaPrincipal.Location = new System.Drawing.Point(289, 774);
            this.BPaginaPrincipal.Name = "BPaginaPrincipal";
            this.BPaginaPrincipal.Size = new System.Drawing.Size(153, 38);
            this.BPaginaPrincipal.TabIndex = 16;
            this.BPaginaPrincipal.Text = "Pagina Principal";
            this.BPaginaPrincipal.UseVisualStyleBackColor = true;
            this.BPaginaPrincipal.Click += new System.EventHandler(this.BPaginaPrincipal_Click);
            // 
            // BInfoServicios
            // 
            this.BInfoServicios.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BInfoServicios.Location = new System.Drawing.Point(35, 774);
            this.BInfoServicios.Name = "BInfoServicios";
            this.BInfoServicios.Size = new System.Drawing.Size(196, 38);
            this.BInfoServicios.TabIndex = 15;
            this.BInfoServicios.Text = "Informacion de Servicios";
            this.BInfoServicios.UseVisualStyleBackColor = true;
            this.BInfoServicios.Click += new System.EventHandler(this.BInfoServicios_Click);
            // 
            // ListaDServicios
            // 
            this.ListaDServicios.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaDServicios.FormattingEnabled = true;
            this.ListaDServicios.Items.AddRange(new object[] {
            "Todo",
            "Ingenieria ",
            "Cableado",
            "Audio",
            "Video",
            "Control de Iluminación",
            "Red De Datos",
            "Telefonia Y Control De Accesos",
            "Circuito Cerrado",
            "Control"});
            this.ListaDServicios.Location = new System.Drawing.Point(31, 83);
            this.ListaDServicios.Name = "ListaDServicios";
            this.ListaDServicios.Size = new System.Drawing.Size(260, 22);
            this.ListaDServicios.TabIndex = 14;
            this.ListaDServicios.SelectedIndexChanged += new System.EventHandler(this.ListaDServicios_SelectedIndexChanged);
            // 
            // RegistroSDG
            // 
            this.RegistroSDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RegistroSDG.Location = new System.Drawing.Point(31, 121);
            this.RegistroSDG.Name = "RegistroSDG";
            this.RegistroSDG.Size = new System.Drawing.Size(534, 293);
            this.RegistroSDG.TabIndex = 13;
            // 
            // ListaDFechas
            // 
            this.ListaDFechas.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaDFechas.FormattingEnabled = true;
            this.ListaDFechas.Items.AddRange(new object[] {
            "Todo",
            "Hace un día",
            "Desde la semana pasada",
            "Desde el mes pasado",
            "Desde los ultimos tres meses",
            "Desde los ultimos seis meses",
            "Desde eñ ultimo  año"});
            this.ListaDFechas.Location = new System.Drawing.Point(306, 83);
            this.ListaDFechas.Name = "ListaDFechas";
            this.ListaDFechas.Size = new System.Drawing.Size(260, 22);
            this.ListaDFechas.TabIndex = 17;
            this.ListaDFechas.SelectedIndexChanged += new System.EventHandler(this.ListaDFechas_SelectedIndexChanged);
            // 
            // btBuscar
            // 
            this.btBuscar.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscar.Location = new System.Drawing.Point(477, 36);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(75, 23);
            this.btBuscar.TabIndex = 18;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // btAgregar
            // 
            this.btAgregar.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAgregar.Location = new System.Drawing.Point(343, 36);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(75, 23);
            this.btAgregar.TabIndex = 19;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // ClientesDt
            // 
            this.ClientesDt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientesDt.Location = new System.Drawing.Point(32, 464);
            this.ClientesDt.Name = "ClientesDt";
            this.ClientesDt.Size = new System.Drawing.Size(534, 293);
            this.ClientesDt.TabIndex = 20;
            // 
            // nombretxtx
            // 
            this.nombretxtx.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombretxtx.Location = new System.Drawing.Point(317, 431);
            this.nombretxtx.Name = "nombretxtx";
            this.nombretxtx.Size = new System.Drawing.Size(248, 20);
            this.nombretxtx.TabIndex = 21;
            this.nombretxtx.TextChanged += new System.EventHandler(this.nombretxtx_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 434);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 14);
            this.label1.TabIndex = 22;
            this.label1.Text = "Busqueda por: ";
            // 
            // rbNombre
            // 
            this.rbNombre.AutoSize = true;
            this.rbNombre.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNombre.Location = new System.Drawing.Point(137, 432);
            this.rbNombre.Name = "rbNombre";
            this.rbNombre.Size = new System.Drawing.Size(71, 18);
            this.rbNombre.TabIndex = 23;
            this.rbNombre.TabStop = true;
            this.rbNombre.Text = "Nombre";
            this.rbNombre.UseVisualStyleBackColor = true;
            // 
            // rbResidencia
            // 
            this.rbResidencia.AutoSize = true;
            this.rbResidencia.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbResidencia.Location = new System.Drawing.Point(214, 432);
            this.rbResidencia.Name = "rbResidencia";
            this.rbResidencia.Size = new System.Drawing.Size(86, 18);
            this.rbResidencia.TabIndex = 24;
            this.rbResidencia.TabStop = true;
            this.rbResidencia.Text = "Residencia";
            this.rbResidencia.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(664, 823);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // RegistroDServicios2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 824);
            this.Controls.Add(this.rbResidencia);
            this.Controls.Add(this.rbNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nombretxtx);
            this.Controls.Add(this.ClientesDt);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.ListaDFechas);
            this.Controls.Add(this.BPaginaPrincipal);
            this.Controls.Add(this.BInfoServicios);
            this.Controls.Add(this.ListaDServicios);
            this.Controls.Add(this.RegistroSDG);
            this.Controls.Add(this.pictureBox1);
            this.Name = "RegistroDServicios2";
            this.Text = "RegistroDServicios2";
            this.Load += new System.EventHandler(this.RegistroDServicios2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RegistroSDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesDt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BPaginaPrincipal;
        private System.Windows.Forms.Button BInfoServicios;
        private System.Windows.Forms.ComboBox ListaDServicios;
        private System.Windows.Forms.DataGridView RegistroSDG;
        private System.Windows.Forms.ComboBox ListaDFechas;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.DataGridView ClientesDt;
        private System.Windows.Forms.TextBox nombretxtx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbNombre;
        private System.Windows.Forms.RadioButton rbResidencia;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}