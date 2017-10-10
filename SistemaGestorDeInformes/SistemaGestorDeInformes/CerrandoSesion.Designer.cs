namespace SistemaGestorDeInformes
{
    partial class CerrandoSesion
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
            this.labelInformaciónBásica = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelInformaciónBásica
            // 
            this.labelInformaciónBásica.AutoSize = true;
            this.labelInformaciónBásica.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInformaciónBásica.ForeColor = System.Drawing.Color.Yellow;
            this.labelInformaciónBásica.Location = new System.Drawing.Point(323, 245);
            this.labelInformaciónBásica.Name = "labelInformaciónBásica";
            this.labelInformaciónBásica.Size = new System.Drawing.Size(221, 19);
            this.labelInformaciónBásica.TabIndex = 25;
            this.labelInformaciónBásica.Text = "Cerrando sesión. Espere...";
            // 
            // CerrandoSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(815, 508);
            this.Controls.Add(this.labelInformaciónBásica);
            this.Name = "CerrandoSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cerrando Sesion...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInformaciónBásica;
    }
}