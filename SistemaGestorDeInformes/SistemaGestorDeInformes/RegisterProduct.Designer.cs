namespace SistemaGestorDeInformes
{
    partial class RegisterProduct
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
            this.ProductoTextBox = new System.Windows.Forms.TextBox();
            this.ProveedorTextBox = new System.Windows.Forms.TextBox();
            this.UnidadTextBox = new System.Windows.Forms.TextBox();
            this.atrasButton = new System.Windows.Forms.Button();
            this.RegistrarButton = new System.Windows.Forms.Button();
            this.ProveedorLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductoLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pantallaPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verFacturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.labelInformaciónBásica = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductoTextBox
            // 
            this.ProductoTextBox.Location = new System.Drawing.Point(197, 94);
            this.ProductoTextBox.Name = "ProductoTextBox";
            this.ProductoTextBox.Size = new System.Drawing.Size(250, 20);
            this.ProductoTextBox.TabIndex = 0;
            // 
            // ProveedorTextBox
            // 
            this.ProveedorTextBox.Location = new System.Drawing.Point(197, 136);
            this.ProveedorTextBox.Name = "ProveedorTextBox";
            this.ProveedorTextBox.Size = new System.Drawing.Size(250, 20);
            this.ProveedorTextBox.TabIndex = 1;
            // 
            // UnidadTextBox
            // 
            this.UnidadTextBox.Location = new System.Drawing.Point(197, 175);
            this.UnidadTextBox.Name = "UnidadTextBox";
            this.UnidadTextBox.Size = new System.Drawing.Size(250, 20);
            this.UnidadTextBox.TabIndex = 2;
            // 
            // atrasButton
            // 
            this.atrasButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.atrasButton.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.atrasButton.ForeColor = System.Drawing.Color.Yellow;
            this.atrasButton.Location = new System.Drawing.Point(3, 472);
            this.atrasButton.Name = "atrasButton";
            this.atrasButton.Size = new System.Drawing.Size(90, 32);
            this.atrasButton.TabIndex = 3;
            this.atrasButton.Text = "Atrás";
            this.atrasButton.UseVisualStyleBackColor = false;
            this.atrasButton.Click += new System.EventHandler(this.atrasButton_Click);
            // 
            // RegistrarButton
            // 
            this.RegistrarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.RegistrarButton.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.RegistrarButton.ForeColor = System.Drawing.Color.Yellow;
            this.RegistrarButton.Location = new System.Drawing.Point(250, 456);
            this.RegistrarButton.Name = "RegistrarButton";
            this.RegistrarButton.Size = new System.Drawing.Size(90, 32);
            this.RegistrarButton.TabIndex = 4;
            this.RegistrarButton.Text = "Registrar";
            this.RegistrarButton.UseVisualStyleBackColor = false;
            this.RegistrarButton.Click += new System.EventHandler(this.RegistrarButton_Click);
            // 
            // ProveedorLabel
            // 
            this.ProveedorLabel.AutoSize = true;
            this.ProveedorLabel.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProveedorLabel.ForeColor = System.Drawing.Color.White;
            this.ProveedorLabel.Location = new System.Drawing.Point(30, 135);
            this.ProveedorLabel.Name = "ProveedorLabel";
            this.ProveedorLabel.Size = new System.Drawing.Size(103, 19);
            this.ProveedorLabel.TabIndex = 8;
            this.ProveedorLabel.Text = "PROVEEDOR:";
            this.ProveedorLabel.Click += new System.EventHandler(this.labelProveedor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "UNIDAD:";
            // 
            // ProductoLabel
            // 
            this.ProductoLabel.AutoSize = true;
            this.ProductoLabel.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductoLabel.ForeColor = System.Drawing.Color.White;
            this.ProductoLabel.Location = new System.Drawing.Point(30, 93);
            this.ProductoLabel.Name = "ProductoLabel";
            this.ProductoLabel.Size = new System.Drawing.Size(76, 19);
            this.ProductoLabel.TabIndex = 10;
            this.ProductoLabel.Text = "NOMBRE:";
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
            this.abrirTrimestreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(815, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pantallaPrincipalToolStripMenuItem
            // 
            this.pantallaPrincipalToolStripMenuItem.Name = "pantallaPrincipalToolStripMenuItem";
            this.pantallaPrincipalToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.pantallaPrincipalToolStripMenuItem.Text = "Pantalla Principal";
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
            // 
            // verFacturasToolStripMenuItem
            // 
            this.verFacturasToolStripMenuItem.Name = "verFacturasToolStripMenuItem";
            this.verFacturasToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.verFacturasToolStripMenuItem.Text = "Ver  Facturas";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verProductosToolStripMenuItem});
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // verProductosToolStripMenuItem
            // 
            this.verProductosToolStripMenuItem.Name = "verProductosToolStripMenuItem";
            this.verProductosToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.verProductosToolStripMenuItem.Text = "Ver productos";
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
            // 
            // verInformeToolStripMenuItem
            // 
            this.verInformeToolStripMenuItem.Name = "verInformeToolStripMenuItem";
            this.verInformeToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.verInformeToolStripMenuItem.Text = "Ver Informe";
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarEntradaToolStripMenuItem,
            this.registrarSalidaToolStripMenuItem,
            this.verInventarioToolStripMenuItem});
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            // 
            // registrarEntradaToolStripMenuItem
            // 
            this.registrarEntradaToolStripMenuItem.Name = "registrarEntradaToolStripMenuItem";
            this.registrarEntradaToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.registrarEntradaToolStripMenuItem.Text = "Registrar Entrada";
            // 
            // registrarSalidaToolStripMenuItem
            // 
            this.registrarSalidaToolStripMenuItem.Name = "registrarSalidaToolStripMenuItem";
            this.registrarSalidaToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.registrarSalidaToolStripMenuItem.Text = "Registrar Salida";
            // 
            // verInventarioToolStripMenuItem
            // 
            this.verInventarioToolStripMenuItem.Name = "verInventarioToolStripMenuItem";
            this.verInventarioToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.verInventarioToolStripMenuItem.Text = "Ver Inventario";
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
            // 
            // abrirTrimestreToolStripMenuItem
            // 
            this.abrirTrimestreToolStripMenuItem.Name = "abrirTrimestreToolStripMenuItem";
            this.abrirTrimestreToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.abrirTrimestreToolStripMenuItem.Text = "Abrir Trimestre";
            // 
            // labelInformaciónBásica
            // 
            this.labelInformaciónBásica.AutoSize = true;
            this.labelInformaciónBásica.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInformaciónBásica.ForeColor = System.Drawing.Color.Yellow;
            this.labelInformaciónBásica.Location = new System.Drawing.Point(30, 40);
            this.labelInformaciónBásica.Name = "labelInformaciónBásica";
            this.labelInformaciónBásica.Size = new System.Drawing.Size(85, 19);
            this.labelInformaciónBásica.TabIndex = 16;
            this.labelInformaciónBásica.Text = "Producto";
            // 
            // RegisterProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(815, 508);
            this.Controls.Add(this.labelInformaciónBásica);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.ProductoLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProveedorLabel);
            this.Controls.Add(this.RegistrarButton);
            this.Controls.Add(this.atrasButton);
            this.Controls.Add(this.UnidadTextBox);
            this.Controls.Add(this.ProveedorTextBox);
            this.Controls.Add(this.ProductoTextBox);
            this.Name = "RegisterProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Producto";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ProductoTextBox;
        private System.Windows.Forms.TextBox ProveedorTextBox;
        private System.Windows.Forms.TextBox UnidadTextBox;
        private System.Windows.Forms.Button atrasButton;
        private System.Windows.Forms.Button RegistrarButton;
        private System.Windows.Forms.Label ProveedorLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ProductoLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pantallaPrincipalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarFacturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verFacturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
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
        private System.Windows.Forms.Label labelInformaciónBásica;
    }
}