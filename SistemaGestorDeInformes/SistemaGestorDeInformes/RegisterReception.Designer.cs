namespace SistemaGestorDeInformes
{
    partial class RegisterReception
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
            this.ProducTextBox = new System.Windows.Forms.TextBox();
            this.ProviderTextBox = new System.Windows.Forms.TextBox();
            this.UnitTextBox = new System.Windows.Forms.TextBox();
            this.ExpirationDate = new System.Windows.Forms.TextBox();
            this.ReceptionDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TotalReception = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProducTextBox
            // 
            this.ProducTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ProducTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.ProducTextBox.Location = new System.Drawing.Point(117, 50);
            this.ProducTextBox.Name = "ProducTextBox";
            this.ProducTextBox.Size = new System.Drawing.Size(100, 20);
            this.ProducTextBox.TabIndex = 0;
            this.ProducTextBox.TextChanged += new System.EventHandler(this.ProducTextBox_TextChanged);
            // 
            // ProviderTextBox
            // 
            this.ProviderTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ProviderTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.ProviderTextBox.Location = new System.Drawing.Point(117, 77);
            this.ProviderTextBox.Name = "ProviderTextBox";
            this.ProviderTextBox.Size = new System.Drawing.Size(100, 20);
            this.ProviderTextBox.TabIndex = 1;
            // 
            // UnitTextBox
            // 
            this.UnitTextBox.Location = new System.Drawing.Point(117, 106);
            this.UnitTextBox.Name = "UnitTextBox";
            this.UnitTextBox.Size = new System.Drawing.Size(100, 20);
            this.UnitTextBox.TabIndex = 2;
            // 
            // ExpirationDate
            // 
            this.ExpirationDate.Location = new System.Drawing.Point(117, 132);
            this.ExpirationDate.Name = "ExpirationDate";
            this.ExpirationDate.Size = new System.Drawing.Size(100, 20);
            this.ExpirationDate.TabIndex = 3;
            // 
            // ReceptionDate
            // 
            this.ReceptionDate.Location = new System.Drawing.Point(117, 158);
            this.ReceptionDate.Name = "ReceptionDate";
            this.ReceptionDate.Size = new System.Drawing.Size(100, 20);
            this.ReceptionDate.TabIndex = 4;
            this.ReceptionDate.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Producto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Proveedor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Unidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fecha Vencimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fecha Recepcion";
            // 
            // TotalReception
            // 
            this.TotalReception.Location = new System.Drawing.Point(117, 185);
            this.TotalReception.Name = "TotalReception";
            this.TotalReception.Size = new System.Drawing.Size(100, 20);
            this.TotalReception.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Cantidad Total";
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(61, 226);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(75, 23);
            this.RegisterButton.TabIndex = 12;
            this.RegisterButton.Text = "Registrar";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(160, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // RegisterReception
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TotalReception);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReceptionDate);
            this.Controls.Add(this.ExpirationDate);
            this.Controls.Add(this.UnitTextBox);
            this.Controls.Add(this.ProviderTextBox);
            this.Controls.Add(this.ProducTextBox);
            this.Name = "RegisterReception";
            this.Text = "RegisterReception";
            this.Load += new System.EventHandler(this.RegisterReception_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox ProducTextBox;
        public System.Windows.Forms.TextBox ProviderTextBox;
        public System.Windows.Forms.TextBox UnitTextBox;
        public System.Windows.Forms.TextBox ExpirationDate;
        public System.Windows.Forms.TextBox ReceptionDate;
        public System.Windows.Forms.TextBox TotalReception;
    }
}