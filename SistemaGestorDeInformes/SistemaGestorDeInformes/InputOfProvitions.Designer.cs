namespace SistemaGestorDeInformes
{
    partial class InputOfProvitions
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
            this.RegisterButton = new System.Windows.Forms.Button();
            this.labelInformaciónBásica = new System.Windows.Forms.Label();
            this.buttonAtrás = new System.Windows.Forms.Button();
            this.labelNFactura = new System.Windows.Forms.Label();
            this.labelNit = new System.Windows.Forms.Label();
            this.labelProveedor = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ExpirationDate = new System.Windows.Forms.DateTimePicker();
            this.UnitTextBox = new System.Windows.Forms.TextBox();
            this.ProviderTextBox = new System.Windows.Forms.TextBox();
            this.ProducTextBox = new System.Windows.Forms.TextBox();
            this.ReceptionDate = new System.Windows.Forms.DateTimePicker();
            this.TotalReception = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pantallaPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verFacturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.generarInformeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verInformeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarEntradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarSalidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirTrimestreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RegisterButton
            // 
            this.RegisterButton.BackColor = System.Drawing.Color.Black;
            this.RegisterButton.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.RegisterButton.ForeColor = System.Drawing.Color.Yellow;
            this.RegisterButton.Location = new System.Drawing.Point(250, 456);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(120, 30);
            this.RegisterButton.TabIndex = 6;
            this.RegisterButton.Text = "Registrar";
            this.RegisterButton.UseVisualStyleBackColor = false;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // labelInformaciónBásica
            // 
            this.labelInformaciónBásica.AutoSize = true;
            this.labelInformaciónBásica.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInformaciónBásica.ForeColor = System.Drawing.Color.Yellow;
            this.labelInformaciónBásica.Location = new System.Drawing.Point(30, 40);
            this.labelInformaciónBásica.Name = "labelInformaciónBásica";
            this.labelInformaciónBásica.Size = new System.Drawing.Size(408, 19);
            this.labelInformaciónBásica.TabIndex = 19;
            this.labelInformaciónBásica.Text = "Registrar Recepción De Víveres En El Inventario";
            // 
            // buttonAtrás
            // 
            this.buttonAtrás.BackColor = System.Drawing.Color.Black;
            this.buttonAtrás.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAtrás.ForeColor = System.Drawing.Color.Yellow;
            this.buttonAtrás.Location = new System.Drawing.Point(3, 472);
            this.buttonAtrás.Name = "buttonAtrás";
            this.buttonAtrás.Size = new System.Drawing.Size(120, 30);
            this.buttonAtrás.TabIndex = 7;
            this.buttonAtrás.Text = "Atrás";
            this.buttonAtrás.UseVisualStyleBackColor = false;
            this.buttonAtrás.Click += new System.EventHandler(this.buttonAtrás_Click);
            // 
            // labelNFactura
            // 
            this.labelNFactura.AutoSize = true;
            this.labelNFactura.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNFactura.ForeColor = System.Drawing.Color.White;
            this.labelNFactura.Location = new System.Drawing.Point(30, 150);
            this.labelNFactura.Name = "labelNFactura";
            this.labelNFactura.Size = new System.Drawing.Size(70, 19);
            this.labelNFactura.TabIndex = 23;
            this.labelNFactura.Text = "UNIDAD:";
            // 
            // labelNit
            // 
            this.labelNit.AutoSize = true;
            this.labelNit.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNit.ForeColor = System.Drawing.Color.White;
            this.labelNit.Location = new System.Drawing.Point(30, 110);
            this.labelNit.Name = "labelNit";
            this.labelNit.Size = new System.Drawing.Size(103, 19);
            this.labelNit.TabIndex = 22;
            this.labelNit.Text = "PROVEEDOR:";
            // 
            // labelProveedor
            // 
            this.labelProveedor.AutoSize = true;
            this.labelProveedor.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProveedor.ForeColor = System.Drawing.Color.White;
            this.labelProveedor.Location = new System.Drawing.Point(30, 70);
            this.labelProveedor.Name = "labelProveedor";
            this.labelProveedor.Size = new System.Drawing.Size(94, 19);
            this.labelProveedor.TabIndex = 21;
            this.labelProveedor.Text = "PRODUCTO:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(30, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 19);
            this.label7.TabIndex = 25;
            this.label7.Text = "FECHA DE INGRESO:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(30, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(191, 19);
            this.label8.TabIndex = 24;
            this.label8.Text = "FECHA DE VENCIMIENTO:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(30, 270);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 19);
            this.label9.TabIndex = 26;
            this.label9.Text = "CANTIDAD TOTAL:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // ExpirationDate
            // 
            this.ExpirationDate.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpirationDate.Location = new System.Drawing.Point(230, 190);
            this.ExpirationDate.Name = "ExpirationDate";
            this.ExpirationDate.Size = new System.Drawing.Size(250, 23);
            this.ExpirationDate.TabIndex = 3;
            // 
            // UnitTextBox
            // 
            this.UnitTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.UnitTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.UnitTextBox.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitTextBox.Location = new System.Drawing.Point(230, 150);
            this.UnitTextBox.Name = "UnitTextBox";
            this.UnitTextBox.Size = new System.Drawing.Size(250, 23);
            this.UnitTextBox.TabIndex = 2;
            // 
            // ProviderTextBox
            // 
            this.ProviderTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ProviderTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.ProviderTextBox.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProviderTextBox.Location = new System.Drawing.Point(230, 110);
            this.ProviderTextBox.MaxLength = 64;
            this.ProviderTextBox.Name = "ProviderTextBox";
            this.ProviderTextBox.Size = new System.Drawing.Size(250, 23);
            this.ProviderTextBox.TabIndex = 1;
            // 
            // ProducTextBox
            // 
            this.ProducTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ProducTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.ProducTextBox.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProducTextBox.Location = new System.Drawing.Point(230, 70);
            this.ProducTextBox.MaxLength = 64;
            this.ProducTextBox.Name = "ProducTextBox";
            this.ProducTextBox.Size = new System.Drawing.Size(250, 23);
            this.ProducTextBox.TabIndex = 0;
            // 
            // ReceptionDate
            // 
            this.ReceptionDate.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReceptionDate.Location = new System.Drawing.Point(230, 230);
            this.ReceptionDate.Name = "ReceptionDate";
            this.ReceptionDate.Size = new System.Drawing.Size(250, 23);
            this.ReceptionDate.TabIndex = 4;
            // 
            // TotalReception
            // 
            this.TotalReception.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalReception.Location = new System.Drawing.Point(230, 270);
            this.TotalReception.Name = "TotalReception";
            this.TotalReception.Size = new System.Drawing.Size(250, 23);
            this.TotalReception.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pantallaPrincipalToolStripMenuItem,
            this.facturasToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.informeToolStripMenuItem1,
            this.inventarioToolStripMenuItem,
            this.configuraciónToolStripMenuItem,
            this.abrirTrimestreToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(815, 24);
            this.menuStrip1.TabIndex = 33;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pantallaPrincipalToolStripMenuItem
            // 
            this.pantallaPrincipalToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.pantallaPrincipalToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.pantallaPrincipalToolStripMenuItem.Name = "pantallaPrincipalToolStripMenuItem";
            this.pantallaPrincipalToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.pantallaPrincipalToolStripMenuItem.Text = "Pantalla Principal";
            this.pantallaPrincipalToolStripMenuItem.Click += new System.EventHandler(this.pantallaPrincipalToolStripMenuItem_Click);
            // 
            // facturasToolStripMenuItem
            // 
            this.facturasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarFacturaToolStripMenuItem,
            this.verFacturasToolStripMenuItem});
            this.facturasToolStripMenuItem.Name = "facturasToolStripMenuItem";
            this.facturasToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.facturasToolStripMenuItem.Text = "Facturas";
            // 
            // registrarFacturaToolStripMenuItem
            // 
            this.registrarFacturaToolStripMenuItem.Name = "registrarFacturaToolStripMenuItem";
            this.registrarFacturaToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.registrarFacturaToolStripMenuItem.Text = "Registrar Factura";
            this.registrarFacturaToolStripMenuItem.Click += new System.EventHandler(this.registrarFacturaToolStripMenuItem_Click);
            // 
            // verFacturasToolStripMenuItem
            // 
            this.verFacturasToolStripMenuItem.Name = "verFacturasToolStripMenuItem";
            this.verFacturasToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.verFacturasToolStripMenuItem.Text = "Ver  Facturas";
            this.verFacturasToolStripMenuItem.Click += new System.EventHandler(this.verFacturasToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarProductosToolStripMenuItem,
            this.verProductosToolStripMenuItem});
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // registrarProductosToolStripMenuItem
            // 
            this.registrarProductosToolStripMenuItem.Name = "registrarProductosToolStripMenuItem";
            this.registrarProductosToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.registrarProductosToolStripMenuItem.Text = "Registrar producto";
            this.registrarProductosToolStripMenuItem.Click += new System.EventHandler(this.registrarProductosToolStripMenuItem_Click);
            // 
            // verProductosToolStripMenuItem
            // 
            this.verProductosToolStripMenuItem.Name = "verProductosToolStripMenuItem";
            this.verProductosToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.verProductosToolStripMenuItem.Text = "Ver Productos";
            this.verProductosToolStripMenuItem.Click += new System.EventHandler(this.verProductosToolStripMenuItem_Click);
            // 
            // informeToolStripMenuItem1
            // 
            this.informeToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generarInformeToolStripMenuItem,
            this.verInformeToolStripMenuItem});
            this.informeToolStripMenuItem1.Name = "informeToolStripMenuItem1";
            this.informeToolStripMenuItem1.Size = new System.Drawing.Size(61, 20);
            this.informeToolStripMenuItem1.Text = "Informe";
            // 
            // generarInformeToolStripMenuItem
            // 
            this.generarInformeToolStripMenuItem.Name = "generarInformeToolStripMenuItem";
            this.generarInformeToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.generarInformeToolStripMenuItem.Text = "Generar Informe";
            this.generarInformeToolStripMenuItem.Click += new System.EventHandler(this.generarInformeToolStripMenuItem_Click);
            // 
            // verInformeToolStripMenuItem
            // 
            this.verInformeToolStripMenuItem.Name = "verInformeToolStripMenuItem";
            this.verInformeToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.verInformeToolStripMenuItem.Text = "Ver Informe";
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.inventarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarEntradaToolStripMenuItem,
            this.registrarSalidaToolStripMenuItem,
            this.verInventarioToolStripMenuItem});
            this.inventarioToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            // 
            // registrarEntradaToolStripMenuItem
            // 
            this.registrarEntradaToolStripMenuItem.ForeColor = System.Drawing.Color.Gray;
            this.registrarEntradaToolStripMenuItem.Name = "registrarEntradaToolStripMenuItem";
            this.registrarEntradaToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.registrarEntradaToolStripMenuItem.Text = "Registrar Entrada";
            // 
            // registrarSalidaToolStripMenuItem
            // 
            this.registrarSalidaToolStripMenuItem.Name = "registrarSalidaToolStripMenuItem";
            this.registrarSalidaToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.registrarSalidaToolStripMenuItem.Text = "Registrar Salida";
            this.registrarSalidaToolStripMenuItem.Click += new System.EventHandler(this.registrarSalidaToolStripMenuItem_Click);
            // 
            // verInventarioToolStripMenuItem
            // 
            this.verInventarioToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.verInventarioToolStripMenuItem.Name = "verInventarioToolStripMenuItem";
            this.verInventarioToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.verInventarioToolStripMenuItem.Text = "Ver Inventario";
            this.verInventarioToolStripMenuItem.Click += new System.EventHandler(this.verInventarioToolStripMenuItem_Click);
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informeToolStripMenuItem});
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.configuraciónToolStripMenuItem.Text = "Configuración";
            // 
            // informeToolStripMenuItem
            // 
            this.informeToolStripMenuItem.Name = "informeToolStripMenuItem";
            this.informeToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.informeToolStripMenuItem.Text = "Informe";
            this.informeToolStripMenuItem.Click += new System.EventHandler(this.informeToolStripMenuItem_Click);
            // 
            // abrirTrimestreToolStripMenuItem
            // 
            this.abrirTrimestreToolStripMenuItem.Name = "abrirTrimestreToolStripMenuItem";
            this.abrirTrimestreToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.abrirTrimestreToolStripMenuItem.Text = "Abrir Trimestre";
            this.abrirTrimestreToolStripMenuItem.Click += new System.EventHandler(this.abrirTrimestreToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.salirToolStripMenuItem.Text = "Cerrar Sesión";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // InputOfProvitions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(815, 508);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.TotalReception);
            this.Controls.Add(this.ReceptionDate);
            this.Controls.Add(this.ExpirationDate);
            this.Controls.Add(this.UnitTextBox);
            this.Controls.Add(this.ProviderTextBox);
            this.Controls.Add(this.ProducTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelNFactura);
            this.Controls.Add(this.labelNit);
            this.Controls.Add(this.labelProveedor);
            this.Controls.Add(this.buttonAtrás);
            this.Controls.Add(this.labelInformaciónBásica);
            this.Controls.Add(this.RegisterButton);
            this.Name = "InputOfProvitions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Entrada";
            this.Load += new System.EventHandler(this.RegisterReception_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Label labelInformaciónBásica;
        private System.Windows.Forms.Button buttonAtrás;
        private System.Windows.Forms.Label labelNFactura;
        private System.Windows.Forms.Label labelNit;
        private System.Windows.Forms.Label labelProveedor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker ExpirationDate;
        private System.Windows.Forms.TextBox UnitTextBox;
        private System.Windows.Forms.TextBox ProviderTextBox;
        private System.Windows.Forms.TextBox ProducTextBox;
        private System.Windows.Forms.DateTimePicker ReceptionDate;
        private System.Windows.Forms.TextBox TotalReception;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pantallaPrincipalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarFacturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verFacturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem generarInformeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verInformeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarEntradaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarSalidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verInventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirTrimestreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}