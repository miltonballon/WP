namespace SistemaGestorDeInformes
{
    partial class RegisterConfiguration
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
            this.NumberOfScholarships_textBox = new System.Windows.Forms.TextBox();
            this.NumberOGames_textBox = new System.Windows.Forms.TextBox();
            this.DaysToBeat_textBox = new System.Windows.Forms.TextBox();
            this.MinimumNumberOfScholarships_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Save_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NumberOfScholarships_textBox
            // 
            this.NumberOfScholarships_textBox.Location = new System.Drawing.Point(361, 50);
            this.NumberOfScholarships_textBox.Name = "NumberOfScholarships_textBox";
            this.NumberOfScholarships_textBox.Size = new System.Drawing.Size(100, 20);
            this.NumberOfScholarships_textBox.TabIndex = 0;
            // 
            // NumberOGames_textBox
            // 
            this.NumberOGames_textBox.Location = new System.Drawing.Point(361, 108);
            this.NumberOGames_textBox.Name = "NumberOGames_textBox";
            this.NumberOGames_textBox.Size = new System.Drawing.Size(100, 20);
            this.NumberOGames_textBox.TabIndex = 0;
            // 
            // DaysToBeat_textBox
            // 
            this.DaysToBeat_textBox.Location = new System.Drawing.Point(361, 177);
            this.DaysToBeat_textBox.Name = "DaysToBeat_textBox";
            this.DaysToBeat_textBox.Size = new System.Drawing.Size(100, 20);
            this.DaysToBeat_textBox.TabIndex = 0;
            // 
            // MinimumNumberOfScholarships_textBox
            // 
            this.MinimumNumberOfScholarships_textBox.Location = new System.Drawing.Point(361, 241);
            this.MinimumNumberOfScholarships_textBox.Name = "MinimumNumberOfScholarships_textBox";
            this.MinimumNumberOfScholarships_textBox.Size = new System.Drawing.Size(100, 20);
            this.MinimumNumberOfScholarships_textBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(56, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "NÚMERO DE BECAS:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(56, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NÚMERO DE PARTIDA:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(56, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(279, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "DÍAS PADRA AVISAR QUE ALGO ESTÁ POR VENCER:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(56, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "NÚMERO MÍNIMO DE PRODUCTO";
            // 
            // Save_Button
            // 
            this.Save_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Save_Button.BackColor = System.Drawing.Color.Black;
            this.Save_Button.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.Save_Button.ForeColor = System.Drawing.Color.Yellow;
            this.Save_Button.Location = new System.Drawing.Point(224, 326);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(120, 30);
            this.Save_Button.TabIndex = 2;
            this.Save_Button.Text = "Guardar";
            this.Save_Button.UseVisualStyleBackColor = false;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // RegisterConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(557, 389);
            this.Controls.Add(this.Save_Button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MinimumNumberOfScholarships_textBox);
            this.Controls.Add(this.DaysToBeat_textBox);
            this.Controls.Add(this.NumberOGames_textBox);
            this.Controls.Add(this.NumberOfScholarships_textBox);
            this.Name = "RegisterConfiguration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Configuración";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NumberOfScholarships_textBox;
        private System.Windows.Forms.TextBox NumberOGames_textBox;
        private System.Windows.Forms.TextBox DaysToBeat_textBox;
        private System.Windows.Forms.TextBox MinimumNumberOfScholarships_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Save_Button;
    }
}