namespace SistemaGestorDeInformes
{
    partial class ShowInventory
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
            this.buttonAtrás = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.inventarioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirTrimestreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelInformaciónBásica = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.cleanButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAtrás
            // 
            this.buttonAtrás.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAtrás.BackColor = System.Drawing.Color.Black;
            this.buttonAtrás.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAtrás.ForeColor = System.Drawing.Color.Yellow;
            this.buttonAtrás.Location = new System.Drawing.Point(3, 472);
            this.buttonAtrás.Name = "buttonAtrás";
            this.buttonAtrás.Size = new System.Drawing.Size(120, 30);
            this.buttonAtrás.TabIndex = 16;
            this.buttonAtrás.Text = "Atrás";
            this.buttonAtrás.UseVisualStyleBackColor = false;
            this.buttonAtrás.Click += new System.EventHandler(this.buttonAtrás_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Unidad,
            this.Cantidad});
            this.dataGridView1.Location = new System.Drawing.Point(56, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(343, 370);
            this.dataGridView1.TabIndex = 15;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Unidad
            // 
            this.Unidad.HeaderText = "Unidad";
            this.Unidad.Name = "Unidad";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
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
            this.menuStrip1.TabIndex = 17;
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
            this.registrarEntradaToolStripMenuItem.Name = "registrarEntradaToolStripMenuItem";
            this.registrarEntradaToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.registrarEntradaToolStripMenuItem.Text = "Registrar Entrada";
            this.registrarEntradaToolStripMenuItem.Click += new System.EventHandler(this.registrarEntradaToolStripMenuItem_Click);
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
            this.verInventarioToolStripMenuItem.ForeColor = System.Drawing.Color.Gray;
            this.verInventarioToolStripMenuItem.Name = "verInventarioToolStripMenuItem";
            this.verInventarioToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.verInventarioToolStripMenuItem.Text = "Ver Inventario";
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informeToolStripMenuItem,
            this.inventarioToolStripMenuItem1});
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.configuraciónToolStripMenuItem.Text = "Configuración";
            // 
            // informeToolStripMenuItem
            // 
            this.informeToolStripMenuItem.Name = "informeToolStripMenuItem";
            this.informeToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.informeToolStripMenuItem.Text = "Informe";
            this.informeToolStripMenuItem.Click += new System.EventHandler(this.informeToolStripMenuItem_Click);
            // 
            // inventarioToolStripMenuItem1
            // 
            this.inventarioToolStripMenuItem1.Name = "inventarioToolStripMenuItem1";
            this.inventarioToolStripMenuItem1.Size = new System.Drawing.Size(127, 22);
            this.inventarioToolStripMenuItem1.Text = "Inventario";
            this.inventarioToolStripMenuItem1.Click += new System.EventHandler(this.inventarioToolStripMenuItem1_Click);
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
            // labelInformaciónBásica
            // 
            this.labelInformaciónBásica.AutoSize = true;
            this.labelInformaciónBásica.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInformaciónBásica.ForeColor = System.Drawing.Color.Yellow;
            this.labelInformaciónBásica.Location = new System.Drawing.Point(30, 44);
            this.labelInformaciónBásica.Name = "labelInformaciónBásica";
            this.labelInformaciónBásica.Size = new System.Drawing.Size(306, 19);
            this.labelInformaciónBásica.TabIndex = 18;
            this.labelInformaciónBásica.Text = "Lista De Productos En El Inventario";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchTextBox.Location = new System.Drawing.Point(406, 81);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(150, 20);
            this.searchTextBox.TabIndex = 19;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            this.searchTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchTextBox_KeyPress);
            // 
            // searchButton
            // 
            this.searchButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchButton.Location = new System.Drawing.Point(405, 107);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 20;
            this.searchButton.Text = "Buscar";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // cleanButton
            // 
            this.cleanButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cleanButton.Location = new System.Drawing.Point(406, 136);
            this.cleanButton.Name = "cleanButton";
            this.cleanButton.Size = new System.Drawing.Size(75, 23);
            this.cleanButton.TabIndex = 21;
            this.cleanButton.Text = "Limpiar";
            this.cleanButton.UseVisualStyleBackColor = true;
            this.cleanButton.Click += new System.EventHandler(this.cleanButton_Click);
            // 
            // ShowInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(815, 508);
            this.Controls.Add(this.cleanButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.labelInformaciónBásica);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.buttonAtrás);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ShowInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver Inventario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ShowInventory_FormClosing);
            this.Load += new System.EventHandler(this.ShowInventory_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ShowInventory_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAtrás;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
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
        private System.Windows.Forms.Label labelInformaciónBásica;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button cleanButton;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem1;
    }
}