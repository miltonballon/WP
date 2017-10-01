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
            this.informesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.buttonAtrás = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pantallaPrincipalToolStripMenuItem,
            this.facturasToolStripMenuItem,
            this.informesToolStripMenuItem,
            this.inventarioToolStripMenuItem,
            this.configuraciónToolStripMenuItem});
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
            // 
            // facturasToolStripMenuItem
            // 
            this.facturasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarFacturaToolStripMenuItem});
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
            // informesToolStripMenuItem
            // 
            this.informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            this.informesToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.informesToolStripMenuItem.Text = "Informes";
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.configuraciónToolStripMenuItem.Text = "Configuración";
            // 
            // labelProveedor
            // 
            this.labelProveedor.AutoSize = true;
            this.labelProveedor.Location = new System.Drawing.Point(30, 40);
            this.labelProveedor.Name = "labelProveedor";
            this.labelProveedor.Size = new System.Drawing.Size(78, 13);
            this.labelProveedor.TabIndex = 1;
            this.labelProveedor.Text = "PROVEEDOR:";
            // 
            // labelNit
            // 
            this.labelNit.AutoSize = true;
            this.labelNit.Location = new System.Drawing.Point(30, 80);
            this.labelNit.Name = "labelNit";
            this.labelNit.Size = new System.Drawing.Size(28, 13);
            this.labelNit.TabIndex = 2;
            this.labelNit.Text = "NIT:";
            // 
            // labelNFactura
            // 
            this.labelNFactura.AutoSize = true;
            this.labelNFactura.Location = new System.Drawing.Point(30, 120);
            this.labelNFactura.Name = "labelNFactura";
            this.labelNFactura.Size = new System.Drawing.Size(74, 13);
            this.labelNFactura.TabIndex = 3;
            this.labelNFactura.Text = "N. FACTURA:";
            // 
            // labelNAutorizacion
            // 
            this.labelNAutorizacion.AutoSize = true;
            this.labelNAutorizacion.Location = new System.Drawing.Point(30, 160);
            this.labelNAutorizacion.Name = "labelNAutorizacion";
            this.labelNAutorizacion.Size = new System.Drawing.Size(105, 13);
            this.labelNAutorizacion.TabIndex = 4;
            this.labelNAutorizacion.Text = "N. AUTORIZACION:";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Location = new System.Drawing.Point(30, 200);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(45, 13);
            this.labelFecha.TabIndex = 5;
            this.labelFecha.Text = "FECHA:";
            // 
            // labelProductos
            // 
            this.labelProductos.AutoSize = true;
            this.labelProductos.Location = new System.Drawing.Point(30, 240);
            this.labelProductos.Name = "labelProductos";
            this.labelProductos.Size = new System.Drawing.Size(75, 13);
            this.labelProductos.TabIndex = 6;
            this.labelProductos.Text = "PRODUCTOS";
            // 
            // textBoxProveedor
            // 
            this.textBoxProveedor.Location = new System.Drawing.Point(140, 40);
            this.textBoxProveedor.Name = "textBoxProveedor";
            this.textBoxProveedor.Size = new System.Drawing.Size(200, 20);
            this.textBoxProveedor.TabIndex = 7;
            this.textBoxProveedor.TextChanged += new System.EventHandler(this.textBoxProveedor_TextChanged);
            // 
            // textBoxNit
            // 
            this.textBoxNit.Location = new System.Drawing.Point(140, 80);
            this.textBoxNit.Name = "textBoxNit";
            this.textBoxNit.Size = new System.Drawing.Size(200, 20);
            this.textBoxNit.TabIndex = 8;
            // 
            // textBoxNFactura
            // 
            this.textBoxNFactura.Location = new System.Drawing.Point(140, 120);
            this.textBoxNFactura.Name = "textBoxNFactura";
            this.textBoxNFactura.Size = new System.Drawing.Size(200, 20);
            this.textBoxNFactura.TabIndex = 9;
            // 
            // textBoxNAutorizacion
            // 
            this.textBoxNAutorizacion.Location = new System.Drawing.Point(140, 160);
            this.textBoxNAutorizacion.Name = "textBoxNAutorizacion";
            this.textBoxNAutorizacion.Size = new System.Drawing.Size(200, 20);
            this.textBoxNAutorizacion.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(140, 200);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(30, 260);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(541, 150);
            this.dataGridView1.TabIndex = 12;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Unidad";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cantidad";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Precio Unitario";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Precio Total";
            this.Column5.Name = "Column5";
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(265, 430);
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
            this.buttonAtrás.Click += new System.EventHandler(this.buttonAtrás_Click);
            // 
            // InterfazRegistrarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 508);
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
        private System.Windows.Forms.ToolStripMenuItem facturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarFacturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informesToolStripMenuItem;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button buttonAtrás;
    }
}