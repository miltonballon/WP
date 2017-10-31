namespace SistemaGestorDeInformes
{
    partial class FirstSetup
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
            this.Ingresar_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Ingresar_button
            // 
            this.Ingresar_button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Ingresar_button.BackColor = System.Drawing.Color.Black;
            this.Ingresar_button.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.Ingresar_button.ForeColor = System.Drawing.Color.Yellow;
            this.Ingresar_button.Location = new System.Drawing.Point(289, 237);
            this.Ingresar_button.Name = "Ingresar_button";
            this.Ingresar_button.Size = new System.Drawing.Size(120, 30);
            this.Ingresar_button.TabIndex = 0;
            this.Ingresar_button.Text = "Ingresar";
            this.Ingresar_button.UseVisualStyleBackColor = false;
            this.Ingresar_button.Click += new System.EventHandler(this.Ingresar_button_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(166, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(376, 140);
            this.label2.TabIndex = 5;
            this.label2.Text = "HOLA,\r\n\r\nNo se detecto un usuario registrado en el sistema. \r\nPor favor presione " +
    "el boton \"Ingresar si desea crear \r\nuno  o  cierre  la  ventana para cancelar el" +
    " proceso\". \r\n\r\nGracias.";
            // 
            // FirstSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(718, 339);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Ingresar_button);
            this.Name = "FirstSetup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Presentación del Sistema";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FirtsSetup_FormClosing);
            this.Load += new System.EventHandler(this.FirtsSetup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ingresar_button;
        private System.Windows.Forms.Label label2;
    }
}