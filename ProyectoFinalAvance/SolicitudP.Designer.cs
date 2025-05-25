namespace ProyectoFinalAvance
{
    partial class SolicitudP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SolicitudP));
            this.BTSolicitar = new System.Windows.Forms.Button();
            this.Materialtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btAtras = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTSolicitar
            // 
            this.BTSolicitar.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTSolicitar.Location = new System.Drawing.Point(126, 366);
            this.BTSolicitar.Name = "BTSolicitar";
            this.BTSolicitar.Size = new System.Drawing.Size(131, 28);
            this.BTSolicitar.TabIndex = 0;
            this.BTSolicitar.Text = "Solicitar";
            this.BTSolicitar.UseVisualStyleBackColor = true;
            this.BTSolicitar.Click += new System.EventHandler(this.BTSolicitar_Click);
            // 
            // Materialtxt
            // 
            this.Materialtxt.Location = new System.Drawing.Point(28, 112);
            this.Materialtxt.Multiline = true;
            this.Materialtxt.Name = "Materialtxt";
            this.Materialtxt.Size = new System.Drawing.Size(556, 245);
            this.Materialtxt.TabIndex = 1;
            this.Materialtxt.TextChanged += new System.EventHandler(this.Materialtxt_TextChanged);
            this.Materialtxt.Validating += new System.ComponentModel.CancelEventHandler(this.Materialtxt_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Escribe los materials que desee solicitar:";
            // 
            // btAtras
            // 
            this.btAtras.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAtras.Location = new System.Drawing.Point(347, 366);
            this.btAtras.Name = "btAtras";
            this.btAtras.Size = new System.Drawing.Size(131, 28);
            this.btAtras.TabIndex = 3;
            this.btAtras.Text = "Atras";
            this.btAtras.UseVisualStyleBackColor = true;
            this.btAtras.Click += new System.EventHandler(this.btAtras_Click);
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
            this.pictureBox1.Size = new System.Drawing.Size(613, 429);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // SolicitudP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 427);
            this.Controls.Add(this.btAtras);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Materialtxt);
            this.Controls.Add(this.BTSolicitar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "SolicitudP";
            this.Text = "SolicitudP";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTSolicitar;
        private System.Windows.Forms.TextBox Materialtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAtras;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}