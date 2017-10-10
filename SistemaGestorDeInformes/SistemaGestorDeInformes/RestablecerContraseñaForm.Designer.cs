namespace SistemaGestorDeInformes
{
    partial class RestablecerContraseñaForm
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
            this.button5 = new System.Windows.Forms.Button();
            this.confirmar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.contraseña = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.user = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ci = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(223, 166);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 17;
            this.button5.Text = "Cerrar";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // confirmar
            // 
            this.confirmar.Location = new System.Drawing.Point(235, 122);
            this.confirmar.Name = "confirmar";
            this.confirmar.PasswordChar = '*';
            this.confirmar.Size = new System.Drawing.Size(100, 20);
            this.confirmar.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Vuelva a escribir la nueva contraseña:";
            // 
            // contraseña
            // 
            this.contraseña.Location = new System.Drawing.Point(235, 90);
            this.contraseña.Name = "contraseña";
            this.contraseña.PasswordChar = '*';
            this.contraseña.Size = new System.Drawing.Size(100, 20);
            this.contraseña.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Ingrese su nueva contraseña;";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(116, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Siguiente";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(235, 58);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(100, 20);
            this.user.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Ingrese su nombre de usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ingrese su CI:";
            // 
            // ci
            // 
            this.ci.Location = new System.Drawing.Point(235, 23);
            this.ci.Name = "ci";
            this.ci.Size = new System.Drawing.Size(100, 20);
            this.ci.TabIndex = 10;
            // 
            // RestablecerContraseñaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 217);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.confirmar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.contraseña);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.user);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ci);
            this.Name = "RestablecerContraseñaForm";
            this.Text = "Recuperar contreseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox confirmar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox contraseña;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ci;
    }
}