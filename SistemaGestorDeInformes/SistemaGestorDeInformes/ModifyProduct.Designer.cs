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
            this.Registrar_Button = new System.Windows.Forms.Button();
            this.atrasButton = new System.Windows.Forms.Button();
            this.Unit_TextBox = new System.Windows.Forms.TextBox();
            this.Provider_TextBox = new System.Windows.Forms.TextBox();
            this.Product_TextBox = new System.Windows.Forms.TextBox();
            this.FreshRadioButton = new System.Windows.Forms.RadioButton();
            this.DryRadioButton = new System.Windows.Forms.RadioButton();
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
            // Registrar_Button
            // 
            this.Registrar_Button.BackColor = System.Drawing.Color.Black;
            this.Registrar_Button.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.Registrar_Button.ForeColor = System.Drawing.Color.Yellow;
            this.Registrar_Button.Location = new System.Drawing.Point(238, 276);
            this.Registrar_Button.Name = "Registrar_Button";
            this.Registrar_Button.Size = new System.Drawing.Size(120, 30);
            this.Registrar_Button.TabIndex = 21;
            this.Registrar_Button.Text = "Guardar";
            this.Registrar_Button.UseVisualStyleBackColor = false;
            this.Registrar_Button.Click += new System.EventHandler(this.Registrar_Button_Click);
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
            // Unit_TextBox
            // 
            this.Unit_TextBox.Location = new System.Drawing.Point(197, 175);
            this.Unit_TextBox.Name = "Unit_TextBox";
            this.Unit_TextBox.Size = new System.Drawing.Size(250, 20);
            this.Unit_TextBox.TabIndex = 19;
            // 
            // Provider_TextBox
            // 
            this.Provider_TextBox.Location = new System.Drawing.Point(197, 136);
            this.Provider_TextBox.Name = "Provider_TextBox";
            this.Provider_TextBox.Size = new System.Drawing.Size(250, 20);
            this.Provider_TextBox.TabIndex = 18;
            // 
            // Product_TextBox
            // 
            this.Product_TextBox.Location = new System.Drawing.Point(197, 94);
            this.Product_TextBox.Name = "Product_TextBox";
            this.Product_TextBox.Size = new System.Drawing.Size(250, 20);
            this.Product_TextBox.TabIndex = 17;
            // 
            // FreshRadioButton
            // 
            this.FreshRadioButton.AutoSize = true;
            this.FreshRadioButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FreshRadioButton.Location = new System.Drawing.Point(197, 229);
            this.FreshRadioButton.Name = "FreshRadioButton";
            this.FreshRadioButton.Size = new System.Drawing.Size(68, 17);
            this.FreshRadioButton.TabIndex = 26;
            this.FreshRadioButton.TabStop = true;
            this.FreshRadioButton.Text = "FRESCO";
            this.FreshRadioButton.UseVisualStyleBackColor = true;
            this.FreshRadioButton.CheckedChanged += new System.EventHandler(this.FreshRadioButton_CheckedChanged);
            // 
            // DryRadioButton
            // 
            this.DryRadioButton.AutoSize = true;
            this.DryRadioButton.ForeColor = System.Drawing.SystemColors.Control;
            this.DryRadioButton.Location = new System.Drawing.Point(288, 229);
            this.DryRadioButton.Name = "DryRadioButton";
            this.DryRadioButton.Size = new System.Drawing.Size(54, 17);
            this.DryRadioButton.TabIndex = 27;
            this.DryRadioButton.TabStop = true;
            this.DryRadioButton.Text = "SECO";
            this.DryRadioButton.UseVisualStyleBackColor = true;
            this.DryRadioButton.CheckedChanged += new System.EventHandler(this.DryRadioButton_CheckedChanged);
            // 
            // ModifyProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(815, 508);
            this.Controls.Add(this.DryRadioButton);
            this.Controls.Add(this.FreshRadioButton);
            this.Controls.Add(this.labelInformaciónBásica);
            this.Controls.Add(this.ProductoLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProveedorLabel);
            this.Controls.Add(this.Registrar_Button);
            this.Controls.Add(this.atrasButton);
            this.Controls.Add(this.Unit_TextBox);
            this.Controls.Add(this.Provider_TextBox);
            this.Controls.Add(this.Product_TextBox);
            this.Name = "ModifyProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Producto";
            this.Load += new System.EventHandler(this.ModifyProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelInformaciónBásica;
        private System.Windows.Forms.Label ProductoLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ProveedorLabel;
        public System.Windows.Forms.Button Registrar_Button;
        private System.Windows.Forms.Button atrasButton;
        public System.Windows.Forms.TextBox Unit_TextBox;
        public System.Windows.Forms.TextBox Provider_TextBox;
        public System.Windows.Forms.TextBox Product_TextBox;
        public System.Windows.Forms.RadioButton FreshRadioButton;
        public System.Windows.Forms.RadioButton DryRadioButton;
    }
}