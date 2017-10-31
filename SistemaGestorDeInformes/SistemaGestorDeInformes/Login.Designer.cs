namespace SistemaGestorDeInformes
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Contraseña_Textbox = new System.Windows.Forms.TextBox();
            this.Usuario_Textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Cancelar_Button = new System.Windows.Forms.Button();
            this.Entrar_Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Contrasena_linkLabel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(347, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // Contraseña_Textbox
            // 
            this.Contraseña_Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contraseña_Textbox.Location = new System.Drawing.Point(411, 266);
            this.Contraseña_Textbox.Name = "Contraseña_Textbox";
            this.Contraseña_Textbox.PasswordChar = '*';
            this.Contraseña_Textbox.Size = new System.Drawing.Size(250, 24);
            this.Contraseña_Textbox.TabIndex = 2;
            this.Contraseña_Textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContraseña_KeyPress);
            // 
            // Usuario_Textbox
            // 
            this.Usuario_Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuario_Textbox.Location = new System.Drawing.Point(411, 214);
            this.Usuario_Textbox.Name = "Usuario_Textbox";
            this.Usuario_Textbox.Size = new System.Drawing.Size(250, 24);
            this.Usuario_Textbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 10.2F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(274, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "USUARIO:";
            // 
            // Cancelar_Button
            // 
            this.Cancelar_Button.BackColor = System.Drawing.Color.Black;
            this.Cancelar_Button.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar_Button.ForeColor = System.Drawing.Color.Yellow;
            this.Cancelar_Button.Location = new System.Drawing.Point(411, 316);
            this.Cancelar_Button.Name = "Cancelar_Button";
            this.Cancelar_Button.Size = new System.Drawing.Size(120, 30);
            this.Cancelar_Button.TabIndex = 4;
            this.Cancelar_Button.Text = "Cancelar";
            this.Cancelar_Button.UseVisualStyleBackColor = false;
            this.Cancelar_Button.Click += new System.EventHandler(this.Cancelar_Button_Click);
            // 
            // Entrar_Button
            // 
            this.Entrar_Button.BackColor = System.Drawing.Color.Black;
            this.Entrar_Button.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Entrar_Button.ForeColor = System.Drawing.Color.Yellow;
            this.Entrar_Button.Location = new System.Drawing.Point(277, 316);
            this.Entrar_Button.Name = "Entrar_Button";
            this.Entrar_Button.Size = new System.Drawing.Size(120, 30);
            this.Entrar_Button.TabIndex = 3;
            this.Entrar_Button.Text = "Entrar";
            this.Entrar_Button.UseVisualStyleBackColor = false;
            this.Entrar_Button.Click += new System.EventHandler(this.Entrar_Button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 10.2F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(274, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "CONTRASEÑA:";
            // 
            // Contrasena_linkLabel
            // 
            this.Contrasena_linkLabel.AutoSize = true;
            this.Contrasena_linkLabel.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contrasena_linkLabel.LinkColor = System.Drawing.Color.Yellow;
            this.Contrasena_linkLabel.Location = new System.Drawing.Point(274, 367);
            this.Contrasena_linkLabel.Name = "Contrasena_linkLabel";
            this.Contrasena_linkLabel.Size = new System.Drawing.Size(187, 19);
            this.Contrasena_linkLabel.TabIndex = 5;
            this.Contrasena_linkLabel.TabStop = true;
            this.Contrasena_linkLabel.Text = "Olvide mi Contraseña";
            this.Contrasena_linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Contrasena_linkLabel_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(831, 547);
            this.Controls.Add(this.Contrasena_linkLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Contraseña_Textbox);
            this.Controls.Add(this.Usuario_Textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cancelar_Button);
            this.Controls.Add(this.Entrar_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Contraseña_Textbox;
        private System.Windows.Forms.TextBox Usuario_Textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Cancelar_Button;
        private System.Windows.Forms.Button Entrar_Button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel Contrasena_linkLabel;
    }
}