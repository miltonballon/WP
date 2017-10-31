namespace SistemaGestorDeInformes
{
    partial class ForgotPassword
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
            this.Enviar_button = new System.Windows.Forms.Button();
            this.Correo_textbox = new System.Windows.Forms.TextBox();
            this.labelInformaciónBásica = new System.Windows.Forms.Label();
            this.atrasButton = new System.Windows.Forms.Button();
            this.labelProveedor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Enviar_button
            // 
            this.Enviar_button.BackColor = System.Drawing.Color.Black;
            this.Enviar_button.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enviar_button.ForeColor = System.Drawing.Color.Yellow;
            this.Enviar_button.Location = new System.Drawing.Point(320, 234);
            this.Enviar_button.Name = "Enviar_button";
            this.Enviar_button.Size = new System.Drawing.Size(120, 30);
            this.Enviar_button.TabIndex = 17;
            this.Enviar_button.Text = "Enviar";
            this.Enviar_button.UseVisualStyleBackColor = false;
            this.Enviar_button.Click += new System.EventHandler(this.Enviar_button_Click);
            // 
            // Correo_textbox
            // 
            this.Correo_textbox.Location = new System.Drawing.Point(320, 186);
            this.Correo_textbox.Name = "Correo_textbox";
            this.Correo_textbox.Size = new System.Drawing.Size(250, 20);
            this.Correo_textbox.TabIndex = 19;
            this.Correo_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Correo_textbox_KeyPress);
            // 
            // labelInformaciónBásica
            // 
            this.labelInformaciónBásica.AutoSize = true;
            this.labelInformaciónBásica.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInformaciónBásica.ForeColor = System.Drawing.Color.Yellow;
            this.labelInformaciónBásica.Location = new System.Drawing.Point(30, 40);
            this.labelInformaciónBásica.Name = "labelInformaciónBásica";
            this.labelInformaciónBásica.Size = new System.Drawing.Size(390, 19);
            this.labelInformaciónBásica.TabIndex = 25;
            this.labelInformaciónBásica.Text = "Introduzca su Dirección de Correo Electrónico";
            // 
            // atrasButton
            // 
            this.atrasButton.BackColor = System.Drawing.Color.Black;
            this.atrasButton.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.atrasButton.ForeColor = System.Drawing.Color.Yellow;
            this.atrasButton.Location = new System.Drawing.Point(3, 472);
            this.atrasButton.Name = "atrasButton";
            this.atrasButton.Size = new System.Drawing.Size(120, 30);
            this.atrasButton.TabIndex = 26;
            this.atrasButton.Text = "Atrás";
            this.atrasButton.UseVisualStyleBackColor = false;
            this.atrasButton.Click += new System.EventHandler(this.atrasButton_Click);
            // 
            // labelProveedor
            // 
            this.labelProveedor.AutoSize = true;
            this.labelProveedor.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProveedor.ForeColor = System.Drawing.Color.White;
            this.labelProveedor.Location = new System.Drawing.Point(134, 187);
            this.labelProveedor.Name = "labelProveedor";
            this.labelProveedor.Size = new System.Drawing.Size(180, 19);
            this.labelProveedor.TabIndex = 27;
            this.labelProveedor.Text = "CORREO ELECTRÓNICO:";
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(815, 508);
            this.Controls.Add(this.labelProveedor);
            this.Controls.Add(this.atrasButton);
            this.Controls.Add(this.labelInformaciónBásica);
            this.Controls.Add(this.Correo_textbox);
            this.Controls.Add(this.Enviar_button);
            this.Name = "ForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recuperar Contreseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Enviar_button;
        private System.Windows.Forms.TextBox Correo_textbox;
        private System.Windows.Forms.Label labelInformaciónBásica;
        private System.Windows.Forms.Button atrasButton;
        private System.Windows.Forms.Label labelProveedor;
    }
}