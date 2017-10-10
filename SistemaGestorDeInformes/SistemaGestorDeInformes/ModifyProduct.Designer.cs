namespace SistemaGestorDeInformes
{
    partial class ModifyProduct
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
            this.ProductoLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ProveedorLabel = new System.Windows.Forms.Label();
            this.RegistrarButton = new System.Windows.Forms.Button();
            this.atrasButton = new System.Windows.Forms.Button();
            this.Unit = new System.Windows.Forms.TextBox();
            this.ProviderTextBox = new System.Windows.Forms.TextBox();
            this.ProductTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelInformaciónBásica
            // 
            this.labelInformaciónBásica.AutoSize = true;
            this.labelInformaciónBásica.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInformaciónBásica.ForeColor = System.Drawing.Color.Yellow;
            this.labelInformaciónBásica.Location = new System.Drawing.Point(30, 40);
            this.labelInformaciónBásica.Name = "labelInformaciónBásica";
            this.labelInformaciónBásica.Size = new System.Drawing.Size(85, 19);
            this.labelInformaciónBásica.TabIndex = 25;
            this.labelInformaciónBásica.Text = "Producto";
            // 
            // ProductoLabel
            // 
            this.ProductoLabel.AutoSize = true;
            this.ProductoLabel.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductoLabel.ForeColor = System.Drawing.Color.White;
            this.ProductoLabel.Location = new System.Drawing.Point(30, 93);
            this.ProductoLabel.Name = "ProductoLabel";
            this.ProductoLabel.Size = new System.Drawing.Size(76, 19);
            this.ProductoLabel.TabIndex = 24;
            this.ProductoLabel.Text = "NOMBRE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 23;
            this.label2.Text = "UNIDAD:";
            // 
            // ProveedorLabel
            // 
            this.ProveedorLabel.AutoSize = true;
            this.ProveedorLabel.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProveedorLabel.ForeColor = System.Drawing.Color.White;
            this.ProveedorLabel.Location = new System.Drawing.Point(30, 135);
            this.ProveedorLabel.Name = "ProveedorLabel";
            this.ProveedorLabel.Size = new System.Drawing.Size(103, 19);
            this.ProveedorLabel.TabIndex = 22;
            this.ProveedorLabel.Text = "PROVEEDOR:";
            // 
            // RegistrarButton
            // 
            this.RegistrarButton.BackColor = System.Drawing.Color.Black;
            this.RegistrarButton.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.RegistrarButton.ForeColor = System.Drawing.Color.Yellow;
            this.RegistrarButton.Location = new System.Drawing.Point(250, 456);
            this.RegistrarButton.Name = "RegistrarButton";
            this.RegistrarButton.Size = new System.Drawing.Size(120, 30);
            this.RegistrarButton.TabIndex = 21;
            this.RegistrarButton.Text = "Guardar";
            this.RegistrarButton.UseVisualStyleBackColor = false;
            this.RegistrarButton.Click += new System.EventHandler(this.RegistrarButton_Click);
            // 
            // atrasButton
            // 
            this.atrasButton.BackColor = System.Drawing.Color.Black;
            this.atrasButton.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.atrasButton.ForeColor = System.Drawing.Color.Yellow;
            this.atrasButton.Location = new System.Drawing.Point(3, 472);
            this.atrasButton.Name = "atrasButton";
            this.atrasButton.Size = new System.Drawing.Size(120, 30);
            this.atrasButton.TabIndex = 20;
            this.atrasButton.Text = "Atrás";
            this.atrasButton.UseVisualStyleBackColor = false;
            this.atrasButton.Click += new System.EventHandler(this.atrasButton_Click);
            // 
            // Unit
            // 
            this.Unit.Location = new System.Drawing.Point(197, 175);
            this.Unit.Name = "Unit";
            this.Unit.Size = new System.Drawing.Size(250, 20);
            this.Unit.TabIndex = 19;
            // 
            // ProviderTextBox
            // 
            this.ProviderTextBox.Location = new System.Drawing.Point(197, 136);
            this.ProviderTextBox.Name = "ProviderTextBox";
            this.ProviderTextBox.Size = new System.Drawing.Size(250, 20);
            this.ProviderTextBox.TabIndex = 18;
            // 
            // ProductTextBox
            // 
            this.ProductTextBox.Location = new System.Drawing.Point(197, 94);
            this.ProductTextBox.Name = "ProductTextBox";
            this.ProductTextBox.Size = new System.Drawing.Size(250, 20);
            this.ProductTextBox.TabIndex = 17;
            // 
            // ModifyProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(815, 508);
            this.Controls.Add(this.labelInformaciónBásica);
            this.Controls.Add(this.ProductoLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProveedorLabel);
            this.Controls.Add(this.RegistrarButton);
            this.Controls.Add(this.atrasButton);
            this.Controls.Add(this.Unit);
            this.Controls.Add(this.ProviderTextBox);
            this.Controls.Add(this.ProductTextBox);
            this.Name = "ModifyProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Producto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelInformaciónBásica;
        private System.Windows.Forms.Label ProductoLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ProveedorLabel;
        public System.Windows.Forms.Button RegistrarButton;
        private System.Windows.Forms.Button atrasButton;
        public System.Windows.Forms.TextBox Unit;
        public System.Windows.Forms.TextBox ProviderTextBox;
        public System.Windows.Forms.TextBox ProductTextBox;
    }
}