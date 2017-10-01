namespace SistemaGestorDeInformes
{
    partial class InterfazRegistrarFactura
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pantallaPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verFacturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.labelProveedor = new System.Windows.Forms.Label();
            this.labelNit = new System.Windows.Forms.Label();
            this.labelNFactura = new System.Windows.Forms.Label();
            this.labelNAutorizacion = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.labelProductos = new System.Windows.Forms.Label();
            this.textBoxProveedor = new System.Windows.Forms.TextBox();
            this.textBoxNit = new System.Windows.Forms.TextBox();
            this.textBoxNFactura = new System.Windows.Forms.TextBox();
            this.textBoxNAutorizacion = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.buttonAtrás = new System.Windows.Forms.Button();
            this.labelInformaciónBásica = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pantallaPrincipalToolStripMenuItem,
            this.facturasToolStripMenuItem,
            this.informeToolStripMenuItem1,
            this.inventarioToolStripMenuItem,
            this.configuraciónToolStripMenuItem,
            this.abrirTrimestreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(811, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pantallaPrincipalToolStripMenuItem
            // 
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
            // 
            // verFacturasToolStripMenuItem
            // 
            this.verFacturasToolStripMenuItem.Name = "verFacturasToolStripMenuItem";
            this.verFacturasToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.verFacturasToolStripMenuItem.Text = "Ver  Facturas";
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
            this.informeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.informeToolStripMenuItem.Text = "Informe";
            // 
            // abrirTrimestreToolStripMenuItem
            // 
            this.abrirTrimestreToolStripMenuItem.Name = "abrirTrimestreToolStripMenuItem";
            this.abrirTrimestreToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.abrirTrimestreToolStripMenuItem.Text = "Abrir Trimestre";
            // 
            // labelProveedor
            // 
            this.labelProveedor.AutoSize = true;
            this.labelProveedor.Location = new System.Drawing.Point(30, 70);
            this.labelProveedor.Name = "labelProveedor";
            this.labelProveedor.Size = new System.Drawing.Size(78, 13);
            this.labelProveedor.TabIndex = 1;
            this.labelProveedor.Text = "PROVEEDOR:";
            // 
            // labelNit
            // 
            this.labelNit.AutoSize = true;
            this.labelNit.Location = new System.Drawing.Point(30, 110);
            this.labelNit.Name = "labelNit";
            this.labelNit.Size = new System.Drawing.Size(28, 13);
            this.labelNit.TabIndex = 2;
            this.labelNit.Text = "NIT:";
            // 
            // labelNFactura
            // 
            this.labelNFactura.AutoSize = true;
            this.labelNFactura.Location = new System.Drawing.Point(30, 150);
            this.labelNFactura.Name = "labelNFactura";
            this.labelNFactura.Size = new System.Drawing.Size(74, 13);
            this.labelNFactura.TabIndex = 3;
            this.labelNFactura.Text = "N. FACTURA:";
            // 
            // labelNAutorizacion
            // 
            this.labelNAutorizacion.AutoSize = true;
            this.labelNAutorizacion.Location = new System.Drawing.Point(30, 190);
            this.labelNAutorizacion.Name = "labelNAutorizacion";
            this.labelNAutorizacion.Size = new System.Drawing.Size(105, 13);
            this.labelNAutorizacion.TabIndex = 4;
            this.labelNAutorizacion.Text = "N. AUTORIZACION:";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Location = new System.Drawing.Point(30, 230);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(45, 13);
            this.labelFecha.TabIndex = 5;
            this.labelFecha.Text = "FECHA:";
            // 
            // labelProductos
            // 
            this.labelProductos.AutoSize = true;
            this.labelProductos.Location = new System.Drawing.Point(30, 270);
            this.labelProductos.Name = "labelProductos";
            this.labelProductos.Size = new System.Drawing.Size(55, 13);
            this.labelProductos.TabIndex = 6;
            this.labelProductos.Text = "Productos";
            // 
            // textBoxProveedor
            // 
            this.textBoxProveedor.Location = new System.Drawing.Point(140, 70);
            this.textBoxProveedor.Name = "textBoxProveedor";
            this.textBoxProveedor.Size = new System.Drawing.Size(200, 20);
            this.textBoxProveedor.TabIndex = 7;
            this.textBoxProveedor.TextChanged += new System.EventHandler(this.textBoxProveedor_TextChanged);
            // 
            // textBoxNit
            // 
            this.textBoxNit.Location = new System.Drawing.Point(140, 110);
            this.textBoxNit.Name = "textBoxNit";
            this.textBoxNit.Size = new System.Drawing.Size(200, 20);
            this.textBoxNit.TabIndex = 8;
            // 
            // textBoxNFactura
            // 
            this.textBoxNFactura.Location = new System.Drawing.Point(140, 150);
            this.textBoxNFactura.Name = "textBoxNFactura";
            this.textBoxNFactura.Size = new System.Drawing.Size(200, 20);
            this.textBoxNFactura.TabIndex = 9;
            // 
            // textBoxNAutorizacion
            // 
            this.textBoxNAutorizacion.Location = new System.Drawing.Point(140, 190);
            this.textBoxNAutorizacion.Name = "textBoxNAutorizacion";
            this.textBoxNAutorizacion.Size = new System.Drawing.Size(200, 20);
            this.textBoxNAutorizacion.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(140, 230);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Unidad,
            this.Cantidad,
            this.PrecioUnitario,
            this.PrecioTotal});
            this.dataGridView1.Location = new System.Drawing.Point(30, 300);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(541, 150);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
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
            // PrecioUnitario
            // 
            this.PrecioUnitario.HeaderText = "Precio Unitario";
            this.PrecioUnitario.Name = "PrecioUnitario";
            // 
            // PrecioTotal
            // 
            this.PrecioTotal.HeaderText = "Precio Total";
            this.PrecioTotal.Name = "PrecioTotal";
            this.PrecioTotal.ReadOnly = true;
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(265, 460);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 13;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            // 
            // buttonAtrás
            // 
            this.buttonAtrás.Location = new System.Drawing.Point(0, 486);
            this.buttonAtrás.Name = "buttonAtrás";
            this.buttonAtrás.Size = new System.Drawing.Size(75, 23);
            this.buttonAtrás.TabIndex = 14;
            this.buttonAtrás.Text = "Atrás";
            this.buttonAtrás.UseVisualStyleBackColor = true;
            // 
            // labelInformaciónBásica
            // 
            this.labelInformaciónBásica.AutoSize = true;
            this.labelInformaciónBásica.Location = new System.Drawing.Point(30, 40);
            this.labelInformaciónBásica.Name = "labelInformaciónBásica";
            this.labelInformaciónBásica.Size = new System.Drawing.Size(97, 13);
            this.labelInformaciónBásica.TabIndex = 15;
            this.labelInformaciónBásica.Text = "Información Básica";
            // 
            // InterfazRegistrarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 508);
            this.Controls.Add(this.labelInformaciónBásica);
            this.Controls.Add(this.buttonAtrás);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxNAutorizacion);
            this.Controls.Add(this.textBoxNFactura);
            this.Controls.Add(this.textBoxNit);
            this.Controls.Add(this.textBoxProveedor);
            this.Controls.Add(this.labelProductos);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.labelNAutorizacion);
            this.Controls.Add(this.labelNFactura);
            this.Controls.Add(this.labelNit);
            this.Controls.Add(this.labelProveedor);
            this.Controls.Add(this.menuStrip1);
            this.Name = "InterfazRegistrarFactura";
            this.Text = "InterfazRegistrarFactura";
            this.Load += new System.EventHandler(this.InterfazRegistrarFactura_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pantallaPrincipalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
        private System.Windows.Forms.Label labelProveedor;
        private System.Windows.Forms.Label labelNit;
        private System.Windows.Forms.Label labelNFactura;
        private System.Windows.Forms.Label labelNAutorizacion;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label labelProductos;
        private System.Windows.Forms.TextBox textBoxProveedor;
        private System.Windows.Forms.TextBox textBoxNit;
        private System.Windows.Forms.TextBox textBoxNFactura;
        private System.Windows.Forms.TextBox textBoxNAutorizacion;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button buttonAtrás;
        private System.Windows.Forms.Label labelInformaciónBásica;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem facturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarFacturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verFacturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem generarInformeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verInformeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarEntradaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarSalidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verInventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirTrimestreToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioTotal;
    }
}