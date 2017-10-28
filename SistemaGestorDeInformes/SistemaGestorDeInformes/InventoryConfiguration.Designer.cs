namespace SistemaGestorDeInformes
{
    partial class InventoryConfiguration
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
            this.button2 = new System.Windows.Forms.Button();
            this.RegistrarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.Yellow;
            this.button2.Location = new System.Drawing.Point(8, 1126);
            this.button2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(320, 72);
            this.button2.TabIndex = 38;
            this.button2.Text = "Atrás";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // RegistrarButton
            // 
            this.RegistrarButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RegistrarButton.BackColor = System.Drawing.Color.Black;
            this.RegistrarButton.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.RegistrarButton.ForeColor = System.Drawing.Color.Yellow;
            this.RegistrarButton.Location = new System.Drawing.Point(840, 885);
            this.RegistrarButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.RegistrarButton.Name = "RegistrarButton";
            this.RegistrarButton.Size = new System.Drawing.Size(320, 72);
            this.RegistrarButton.TabIndex = 39;
            this.RegistrarButton.Text = "Guardar";
            this.RegistrarButton.UseVisualStyleBackColor = false;
            // 
            // InventoryConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(2173, 1211);
            this.Controls.Add(this.RegistrarButton);
            this.Controls.Add(this.button2);
            this.Name = "InventoryConfiguration";
            this.Text = "InventoryConfiguration";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button RegistrarButton;
    }
}