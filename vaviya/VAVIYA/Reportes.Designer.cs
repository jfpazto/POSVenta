namespace VAVIYA
{
    partial class Reportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reportes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteValorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataVencer = new System.Windows.Forms.DataGridView();
            this.date_desde = new System.Windows.Forms.DateTimePicker();
            this.date_hasta = new System.Windows.Forms.DateTimePicker();
            this.busca_venta = new System.Windows.Forms.Button();
            this.data_fec_venta = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_tot_ventas = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_num_compras = new System.Windows.Forms.Label();
            this.but_busca_compra = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.fec_fin_compra = new System.Windows.Forms.DateTimePicker();
            this.label_total_compras = new System.Windows.Forms.Label();
            this.fec_ini_compra = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.data_fec_compra = new System.Windows.Forms.DataGridView();
            this.bt_home = new System.Windows.Forms.Button();
            this.contabilidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataVencer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_fec_venta)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_fec_compra)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem,
            this.reporteValorToolStripMenuItem,
            this.consultarCompraToolStripMenuItem,
            this.consultarVentaToolStripMenuItem,
            this.contabilidadToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("productosToolStripMenuItem.Image")));
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(138, 20);
            this.productosToolStripMenuItem.Text = "Productos A Vencer";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.ProductosToolStripMenuItem_Click);
            // 
            // reporteValorToolStripMenuItem
            // 
            this.reporteValorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventaToolStripMenuItem,
            this.comprasToolStripMenuItem});
            this.reporteValorToolStripMenuItem.Name = "reporteValorToolStripMenuItem";
            this.reporteValorToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.reporteValorToolStripMenuItem.Text = "Reporte valor";
            // 
            // ventaToolStripMenuItem
            // 
            this.ventaToolStripMenuItem.Name = "ventaToolStripMenuItem";
            this.ventaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ventaToolStripMenuItem.Text = "Ventas";
            this.ventaToolStripMenuItem.Click += new System.EventHandler(this.VentaToolStripMenuItem_Click);
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.comprasToolStripMenuItem.Text = "Compras";
            this.comprasToolStripMenuItem.Click += new System.EventHandler(this.ComprasToolStripMenuItem_Click);
            // 
            // consultarCompraToolStripMenuItem
            // 
            this.consultarCompraToolStripMenuItem.Name = "consultarCompraToolStripMenuItem";
            this.consultarCompraToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.consultarCompraToolStripMenuItem.Text = "Ver Productos";
            this.consultarCompraToolStripMenuItem.Click += new System.EventHandler(this.consultarCompraToolStripMenuItem_Click);
            // 
            // consultarVentaToolStripMenuItem
            // 
            this.consultarVentaToolStripMenuItem.Name = "consultarVentaToolStripMenuItem";
            this.consultarVentaToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.consultarVentaToolStripMenuItem.Text = "Consultar Facturas";
            this.consultarVentaToolStripMenuItem.Click += new System.EventHandler(this.consultarVentaToolStripMenuItem_Click);
            // 
            // dataVencer
            // 
            this.dataVencer.AllowUserToAddRows = false;
            this.dataVencer.AllowUserToDeleteRows = false;
            this.dataVencer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataVencer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataVencer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataVencer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataVencer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataVencer.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataVencer.Location = new System.Drawing.Point(30, 61);
            this.dataVencer.Name = "dataVencer";
            this.dataVencer.ReadOnly = true;
            this.dataVencer.Size = new System.Drawing.Size(968, 177);
            this.dataVencer.TabIndex = 5;
            // 
            // date_desde
            // 
            this.date_desde.Location = new System.Drawing.Point(16, 23);
            this.date_desde.Name = "date_desde";
            this.date_desde.Size = new System.Drawing.Size(200, 20);
            this.date_desde.TabIndex = 6;
            // 
            // date_hasta
            // 
            this.date_hasta.Location = new System.Drawing.Point(278, 23);
            this.date_hasta.Name = "date_hasta";
            this.date_hasta.Size = new System.Drawing.Size(200, 20);
            this.date_hasta.TabIndex = 7;
            // 
            // busca_venta
            // 
            this.busca_venta.Location = new System.Drawing.Point(501, 20);
            this.busca_venta.Name = "busca_venta";
            this.busca_venta.Size = new System.Drawing.Size(75, 23);
            this.busca_venta.TabIndex = 8;
            this.busca_venta.Text = "BUSCAR";
            this.busca_venta.UseVisualStyleBackColor = true;
            this.busca_venta.Click += new System.EventHandler(this.Busca_venta_Click);
            // 
            // data_fec_venta
            // 
            this.data_fec_venta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_fec_venta.Location = new System.Drawing.Point(16, 78);
            this.data_fec_venta.Name = "data_fec_venta";
            this.data_fec_venta.Size = new System.Drawing.Size(353, 203);
            this.data_fec_venta.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_tot_ventas);
            this.groupBox2.Controls.Add(this.busca_venta);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.date_hasta);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.date_desde);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.data_fec_venta);
            this.groupBox2.Location = new System.Drawing.Point(94, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(589, 307);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Valor Ventas";
            this.groupBox2.Enter += new System.EventHandler(this.GroupBox2_Enter);
            // 
            // label_tot_ventas
            // 
            this.label_tot_ventas.AutoSize = true;
            this.label_tot_ventas.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tot_ventas.Location = new System.Drawing.Point(465, 151);
            this.label_tot_ventas.Name = "label_tot_ventas";
            this.label_tot_ventas.Size = new System.Drawing.Size(0, 26);
            this.label_tot_ventas.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(386, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 36);
            this.label3.TabIndex = 13;
            this.label3.Text = "Numero \r\nVentas: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(465, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 26);
            this.label2.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(386, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Total: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_num_compras);
            this.groupBox1.Controls.Add(this.but_busca_compra);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.fec_fin_compra);
            this.groupBox1.Controls.Add(this.label_total_compras);
            this.groupBox1.Controls.Add(this.fec_ini_compra);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.data_fec_compra);
            this.groupBox1.Location = new System.Drawing.Point(94, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(589, 307);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Valor Compras";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // label_num_compras
            // 
            this.label_num_compras.AutoSize = true;
            this.label_num_compras.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_num_compras.Location = new System.Drawing.Point(478, 158);
            this.label_num_compras.Name = "label_num_compras";
            this.label_num_compras.Size = new System.Drawing.Size(0, 26);
            this.label_num_compras.TabIndex = 14;
            // 
            // but_busca_compra
            // 
            this.but_busca_compra.Location = new System.Drawing.Point(501, 20);
            this.but_busca_compra.Name = "but_busca_compra";
            this.but_busca_compra.Size = new System.Drawing.Size(75, 23);
            this.but_busca_compra.TabIndex = 8;
            this.but_busca_compra.Text = "BUSCAR";
            this.but_busca_compra.UseVisualStyleBackColor = true;
            this.but_busca_compra.Click += new System.EventHandler(this.But_busca_compra_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(383, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 36);
            this.label5.TabIndex = 13;
            this.label5.Text = "Numero \r\nCompras: ";
            // 
            // fec_fin_compra
            // 
            this.fec_fin_compra.Location = new System.Drawing.Point(278, 23);
            this.fec_fin_compra.Name = "fec_fin_compra";
            this.fec_fin_compra.Size = new System.Drawing.Size(200, 20);
            this.fec_fin_compra.TabIndex = 7;
            this.fec_fin_compra.ValueChanged += new System.EventHandler(this.fec_fin_compra_ValueChanged);
            // 
            // label_total_compras
            // 
            this.label_total_compras.AutoSize = true;
            this.label_total_compras.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_total_compras.Location = new System.Drawing.Point(472, 96);
            this.label_total_compras.Name = "label_total_compras";
            this.label_total_compras.Size = new System.Drawing.Size(0, 26);
            this.label_total_compras.TabIndex = 12;
            // 
            // fec_ini_compra
            // 
            this.fec_ini_compra.Location = new System.Drawing.Point(16, 23);
            this.fec_ini_compra.Name = "fec_ini_compra";
            this.fec_ini_compra.Size = new System.Drawing.Size(200, 20);
            this.fec_ini_compra.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(382, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "Total: ";
            // 
            // data_fec_compra
            // 
            this.data_fec_compra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_fec_compra.Location = new System.Drawing.Point(16, 78);
            this.data_fec_compra.Name = "data_fec_compra";
            this.data_fec_compra.Size = new System.Drawing.Size(353, 203);
            this.data_fec_compra.TabIndex = 9;
            // 
            // bt_home
            // 
            this.bt_home.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bt_home.FlatAppearance.BorderSize = 0;
            this.bt_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_home.Image = ((System.Drawing.Image)(resources.GetObject("bt_home.Image")));
            this.bt_home.Location = new System.Drawing.Point(94, 352);
            this.bt_home.Name = "bt_home";
            this.bt_home.Size = new System.Drawing.Size(75, 75);
            this.bt_home.TabIndex = 50;
            this.bt_home.TabStop = false;
            this.bt_home.UseVisualStyleBackColor = true;
            this.bt_home.Click += new System.EventHandler(this.Bt_home_Click);
            // 
            // contabilidadToolStripMenuItem
            // 
            this.contabilidadToolStripMenuItem.Name = "contabilidadToolStripMenuItem";
            this.contabilidadToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.contabilidadToolStripMenuItem.Text = "Contabilidad";
            this.contabilidadToolStripMenuItem.Click += new System.EventHandler(this.contabilidadToolStripMenuItem_Click);
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_home);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataVencer);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Reportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reportes Valor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Reportes_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataVencer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_fec_venta)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_fec_compra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteValorToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataVencer;
        private System.Windows.Forms.ToolStripMenuItem consultarCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarVentaToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker date_desde;
        private System.Windows.Forms.DateTimePicker date_hasta;
        private System.Windows.Forms.Button busca_venta;
        private System.Windows.Forms.DataGridView data_fec_venta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_tot_ventas;
        private System.Windows.Forms.ToolStripMenuItem ventaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_num_compras;
        private System.Windows.Forms.Button but_busca_compra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker fec_fin_compra;
        private System.Windows.Forms.Label label_total_compras;
        private System.Windows.Forms.DateTimePicker fec_ini_compra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView data_fec_compra;
        private System.Windows.Forms.Button bt_home;
        private System.Windows.Forms.ToolStripMenuItem contabilidadToolStripMenuItem;
    }
}