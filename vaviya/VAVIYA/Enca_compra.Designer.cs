namespace VAVIYA
{
    partial class Enca_compra
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Enca_compra));
            this.label6 = new System.Windows.Forms.Label();
            this.obrser_compra = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataenca_compra = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cod_compra = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_proveedor = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.list_nombres = new System.Windows.Forms.ListBox();
            this.list_apellidos = new System.Windows.Forms.ListBox();
            this.lis_nom_em = new System.Windows.Forms.ListBox();
            this.lis_ape_em = new System.Windows.Forms.ListBox();
            this.but_guardar = new System.Windows.Forms.Button();
            this.lb_total = new System.Windows.Forms.Label();
            this.bt_home = new System.Windows.Forms.Button();
            this.bt_imprimir = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.bt_buscar = new System.Windows.Forms.Button();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.bt_el_data = new System.Windows.Forms.Button();
            this.bt_eliminar = new System.Windows.Forms.Button();
            this.checkPrestamo = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataenca_compra)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoEllipsis = true;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(686, 565);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "Valor Total";
            // 
            // obrser_compra
            // 
            this.obrser_compra.Location = new System.Drawing.Point(227, 492);
            this.obrser_compra.Multiline = true;
            this.obrser_compra.Name = "obrser_compra";
            this.obrser_compra.Size = new System.Drawing.Size(713, 52);
            this.obrser_compra.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 468);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Observaciones";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // dataenca_compra
            // 
            this.dataenca_compra.AllowUserToDeleteRows = false;
            this.dataenca_compra.AllowUserToOrderColumns = true;
            this.dataenca_compra.AllowUserToResizeColumns = false;
            this.dataenca_compra.AllowUserToResizeRows = false;
            this.dataenca_compra.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataenca_compra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataenca_compra.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataenca_compra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataenca_compra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataenca_compra.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataenca_compra.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataenca_compra.Location = new System.Drawing.Point(185, 201);
            this.dataenca_compra.Name = "dataenca_compra";
            this.dataenca_compra.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataenca_compra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataenca_compra.Size = new System.Drawing.Size(794, 253);
            this.dataenca_compra.TabIndex = 28;
            this.dataenca_compra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataenca_compra_CellContentClick);
            this.dataenca_compra.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataenca_compra_CellEndEdit);
            this.dataenca_compra.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataenca_compra_CellLeave);
            this.dataenca_compra.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataenca_compra_EditingControlShowing);
            this.dataenca_compra.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataenca_compra_KeyDown);
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ID";
            this.Column2.Name = "Column2";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre Producto";
            this.Column1.Name = "Column1";
            this.Column1.Width = 260;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cantidad";
            this.Column3.Name = "Column3";
            this.Column3.Width = 130;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Vr Unitario";
            this.Column4.Name = "Column4";
            this.Column4.Width = 130;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Vr Total";
            this.Column5.Name = "Column5";
            this.Column5.Width = 130;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Proveedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(460, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Recibido Por";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Cod Compra #:";
            // 
            // cod_compra
            // 
            this.cod_compra.BackColor = System.Drawing.SystemColors.Info;
            this.cod_compra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cod_compra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cod_compra.Location = new System.Drawing.Point(178, 19);
            this.cod_compra.Multiline = true;
            this.cod_compra.Name = "cod_compra";
            this.cod_compra.Size = new System.Drawing.Size(63, 28);
            this.cod_compra.TabIndex = 20;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(178, 129);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(145, 20);
            this.dateTimePicker1.TabIndex = 39;
            this.dateTimePicker1.Value = new System.DateTime(2019, 7, 11, 21, 39, 23, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkPrestamo);
            this.groupBox1.Controls.Add(this.cb_proveedor);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cod_compra);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(227, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(713, 161);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cb_proveedor
            // 
            this.cb_proveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_proveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_proveedor.FormattingEnabled = true;
            this.cb_proveedor.Location = new System.Drawing.Point(178, 79);
            this.cb_proveedor.Name = "cb_proveedor";
            this.cb_proveedor.Size = new System.Drawing.Size(145, 21);
            this.cb_proveedor.TabIndex = 45;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(534, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(131, 21);
            this.comboBox1.TabIndex = 44;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(30, 16);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(33, 37);
            this.pictureBox4.TabIndex = 43;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(421, 16);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 37);
            this.pictureBox3.TabIndex = 42;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(30, 117);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 37);
            this.pictureBox2.TabIndex = 41;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 37);
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // list_nombres
            // 
            this.list_nombres.FormattingEnabled = true;
            this.list_nombres.Location = new System.Drawing.Point(32, 40);
            this.list_nombres.Name = "list_nombres";
            this.list_nombres.Size = new System.Drawing.Size(120, 30);
            this.list_nombres.TabIndex = 41;
            this.list_nombres.Visible = false;
            // 
            // list_apellidos
            // 
            this.list_apellidos.FormattingEnabled = true;
            this.list_apellidos.Location = new System.Drawing.Point(32, 88);
            this.list_apellidos.Name = "list_apellidos";
            this.list_apellidos.Size = new System.Drawing.Size(120, 30);
            this.list_apellidos.TabIndex = 42;
            this.list_apellidos.Visible = false;
            // 
            // lis_nom_em
            // 
            this.lis_nom_em.FormattingEnabled = true;
            this.lis_nom_em.Location = new System.Drawing.Point(32, 141);
            this.lis_nom_em.Name = "lis_nom_em";
            this.lis_nom_em.Size = new System.Drawing.Size(120, 30);
            this.lis_nom_em.TabIndex = 43;
            this.lis_nom_em.Visible = false;
            // 
            // lis_ape_em
            // 
            this.lis_ape_em.FormattingEnabled = true;
            this.lis_ape_em.Location = new System.Drawing.Point(32, 186);
            this.lis_ape_em.Name = "lis_ape_em";
            this.lis_ape_em.Size = new System.Drawing.Size(120, 30);
            this.lis_ape_em.TabIndex = 44;
            this.lis_ape_em.Visible = false;
            // 
            // but_guardar
            // 
            this.but_guardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.but_guardar.FlatAppearance.BorderSize = 0;
            this.but_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_guardar.Image = ((System.Drawing.Image)(resources.GetObject("but_guardar.Image")));
            this.but_guardar.Location = new System.Drawing.Point(227, 585);
            this.but_guardar.Name = "but_guardar";
            this.but_guardar.Size = new System.Drawing.Size(75, 53);
            this.but_guardar.TabIndex = 46;
            this.but_guardar.TabStop = false;
            this.but_guardar.UseVisualStyleBackColor = true;
            this.but_guardar.Click += new System.EventHandler(this.but_guardar_Click);
            // 
            // lb_total
            // 
            this.lb_total.AutoSize = true;
            this.lb_total.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_total.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lb_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_total.Location = new System.Drawing.Point(783, 565);
            this.lb_total.Name = "lb_total";
            this.lb_total.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lb_total.Size = new System.Drawing.Size(2, 27);
            this.lb_total.TabIndex = 47;
            // 
            // bt_home
            // 
            this.bt_home.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bt_home.FlatAppearance.BorderSize = 0;
            this.bt_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_home.Image = ((System.Drawing.Image)(resources.GetObject("bt_home.Image")));
            this.bt_home.Location = new System.Drawing.Point(348, 574);
            this.bt_home.Name = "bt_home";
            this.bt_home.Size = new System.Drawing.Size(75, 75);
            this.bt_home.TabIndex = 48;
            this.bt_home.TabStop = false;
            this.bt_home.UseVisualStyleBackColor = true;
            this.bt_home.Click += new System.EventHandler(this.bt_home_Click);
            // 
            // bt_imprimir
            // 
            this.bt_imprimir.Location = new System.Drawing.Point(464, 600);
            this.bt_imprimir.Name = "bt_imprimir";
            this.bt_imprimir.Size = new System.Drawing.Size(75, 23);
            this.bt_imprimir.TabIndex = 49;
            this.bt_imprimir.Text = "Imprimir";
            this.bt_imprimir.UseVisualStyleBackColor = true;
            this.bt_imprimir.Visible = false;
            this.bt_imprimir.Click += new System.EventHandler(this.Bt_imprimir_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage_1);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // bt_buscar
            // 
            this.bt_buscar.Location = new System.Drawing.Point(724, 600);
            this.bt_buscar.Name = "bt_buscar";
            this.bt_buscar.Size = new System.Drawing.Size(75, 23);
            this.bt_buscar.TabIndex = 50;
            this.bt_buscar.Text = "BUSCAR";
            this.bt_buscar.UseVisualStyleBackColor = true;
            this.bt_buscar.Click += new System.EventHandler(this.Bt_buscar_Click);
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(620, 600);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(100, 20);
            this.txt_buscar.TabIndex = 51;
            // 
            // bt_el_data
            // 
            this.bt_el_data.FlatAppearance.BorderSize = 0;
            this.bt_el_data.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_el_data.Image = ((System.Drawing.Image)(resources.GetObject("bt_el_data.Image")));
            this.bt_el_data.Location = new System.Drawing.Point(1012, 281);
            this.bt_el_data.Name = "bt_el_data";
            this.bt_el_data.Size = new System.Drawing.Size(55, 56);
            this.bt_el_data.TabIndex = 55;
            this.bt_el_data.UseVisualStyleBackColor = true;
            this.bt_el_data.Click += new System.EventHandler(this.Bt_el_data_Click);
            // 
            // bt_eliminar
            // 
            this.bt_eliminar.FlatAppearance.BorderSize = 0;
            this.bt_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("bt_eliminar.Image")));
            this.bt_eliminar.Location = new System.Drawing.Point(1011, 355);
            this.bt_eliminar.Name = "bt_eliminar";
            this.bt_eliminar.Size = new System.Drawing.Size(56, 59);
            this.bt_eliminar.TabIndex = 54;
            this.bt_eliminar.UseVisualStyleBackColor = true;
            this.bt_eliminar.Click += new System.EventHandler(this.Bt_eliminar_Click);
            // 
            // checkPrestamo
            // 
            this.checkPrestamo.AutoSize = true;
            this.checkPrestamo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.checkPrestamo.Location = new System.Drawing.Point(421, 100);
            this.checkPrestamo.Name = "checkPrestamo";
            this.checkPrestamo.Size = new System.Drawing.Size(86, 17);
            this.checkPrestamo.TabIndex = 46;
            this.checkPrestamo.Text = "PRESTAMO";
            this.checkPrestamo.UseVisualStyleBackColor = false;
            // 
            // Enca_compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1141, 712);
            this.Controls.Add(this.bt_el_data);
            this.Controls.Add(this.bt_eliminar);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.bt_buscar);
            this.Controls.Add(this.bt_imprimir);
            this.Controls.Add(this.bt_home);
            this.Controls.Add(this.lb_total);
            this.Controls.Add(this.but_guardar);
            this.Controls.Add(this.lis_ape_em);
            this.Controls.Add(this.lis_nom_em);
            this.Controls.Add(this.list_apellidos);
            this.Controls.Add(this.list_nombres);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.obrser_compra);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataenca_compra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Enca_compra";
            this.Text = "Enca_compra";
            this.Load += new System.EventHandler(this.Enca_compra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataenca_compra)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox obrser_compra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataenca_compra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cod_compra;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox cb_proveedor;
        private System.Windows.Forms.ListBox list_nombres;
        private System.Windows.Forms.ListBox list_apellidos;
        private System.Windows.Forms.ListBox lis_nom_em;
        private System.Windows.Forms.ListBox lis_ape_em;
        private System.Windows.Forms.Button but_guardar;
        private System.Windows.Forms.Label lb_total;
        private System.Windows.Forms.Button bt_home;
        private System.Windows.Forms.Button bt_imprimir;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button bt_buscar;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Button bt_el_data;
        private System.Windows.Forms.Button bt_eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.CheckBox checkPrestamo;
    }
}