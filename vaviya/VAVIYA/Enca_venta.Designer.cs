namespace VAVIYA
{
    partial class Enca_venta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Enca_venta));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataenca_venta = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IvaProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_vendedor = new System.Windows.Forms.ComboBox();
            this.cb_cliente = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cod_venta = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_descuento = new System.Windows.Forms.TextBox();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.lis_ape_em = new System.Windows.Forms.ListBox();
            this.lis_nom_em = new System.Windows.Forms.ListBox();
            this.list_apellidos = new System.Windows.Forms.ListBox();
            this.list_nombres = new System.Windows.Forms.ListBox();
            this.bt_home = new System.Windows.Forms.Button();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.bt_buscar = new System.Windows.Forms.Button();
            this.bt_eliminar = new System.Windows.Forms.Button();
            this.bt_el_data = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_recibido = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_cambio = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.checkPrestamo = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataenca_venta)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cod Venta";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(421, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vendedor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha";
            // 
            // dataenca_venta
            // 
            this.dataenca_venta.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataenca_venta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataenca_venta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column5,
            this.Column2,
            this.Column3,
            this.colum_descuento,
            this.Column4,
            this.IvaProd});
            this.dataenca_venta.Location = new System.Drawing.Point(86, 227);
            this.dataenca_venta.Name = "dataenca_venta";
            this.dataenca_venta.Size = new System.Drawing.Size(942, 253);
            this.dataenca_venta.TabIndex = 8;
            this.dataenca_venta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataenca_venta_CellContentClick);
            this.dataenca_venta.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataenca_venta_CellEndEdit);
            this.dataenca_venta.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataenca_venta_EditingControlShowing);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Nombre Producto";
            this.Column5.Name = "Column5";
            this.Column5.Width = 300;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Cantidad";
            this.Column2.Name = "Column2";
            this.Column2.Width = 120;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Valor Unitario";
            this.Column3.Name = "Column3";
            this.Column3.Width = 130;
            // 
            // colum_descuento
            // 
            this.colum_descuento.HeaderText = "Descuento";
            this.colum_descuento.Name = "colum_descuento";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Valor Total";
            this.Column4.Name = "Column4";
            // 
            // IvaProd
            // 
            this.IvaProd.HeaderText = "Iva";
            this.IvaProd.Name = "IvaProd";
            this.IvaProd.Width = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(269, 493);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Observaciones";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(258, 520);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(669, 52);
            this.textBox5.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(676, 595);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Sub Total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(676, 634);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Descuento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(676, 674);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Total";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // textBox6
            // 
            this.textBox6.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox6.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(741, 588);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(110, 26);
            this.textBox6.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(272, 592);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 59);
            this.button1.TabIndex = 17;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkPrestamo);
            this.groupBox1.Controls.Add(this.cb_vendedor);
            this.groupBox1.Controls.Add(this.cb_cliente);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.cod_venta);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(258, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(669, 178);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // cb_vendedor
            // 
            this.cb_vendedor.FormattingEnabled = true;
            this.cb_vendedor.Location = new System.Drawing.Point(480, 23);
            this.cb_vendedor.Name = "cb_vendedor";
            this.cb_vendedor.Size = new System.Drawing.Size(145, 21);
            this.cb_vendedor.TabIndex = 51;
            // 
            // cb_cliente
            // 
            this.cb_cliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_cliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_cliente.FormattingEnabled = true;
            this.cb_cliente.Location = new System.Drawing.Point(140, 74);
            this.cb_cliente.Name = "cb_cliente";
            this.cb_cliente.Size = new System.Drawing.Size(145, 21);
            this.cb_cliente.TabIndex = 50;
            this.cb_cliente.SelectedIndexChanged += new System.EventHandler(this.cb_cliente_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(140, 127);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(145, 20);
            this.dateTimePicker1.TabIndex = 49;
            this.dateTimePicker1.Value = new System.DateTime(2020, 8, 4, 0, 0, 0, 0);
            // 
            // cod_venta
            // 
            this.cod_venta.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cod_venta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cod_venta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cod_venta.Location = new System.Drawing.Point(140, 17);
            this.cod_venta.Multiline = true;
            this.cod_venta.Name = "cod_venta";
            this.cod_venta.Size = new System.Drawing.Size(236, 28);
            this.cod_venta.TabIndex = 48;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(382, 19);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 37);
            this.pictureBox3.TabIndex = 47;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(38, 19);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(33, 37);
            this.pictureBox4.TabIndex = 46;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(38, 120);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 37);
            this.pictureBox2.TabIndex = 45;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(38, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 37);
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // txt_descuento
            // 
            this.txt_descuento.Location = new System.Drawing.Point(741, 631);
            this.txt_descuento.Name = "txt_descuento";
            this.txt_descuento.Size = new System.Drawing.Size(79, 20);
            this.txt_descuento.TabIndex = 23;
            this.txt_descuento.TabIndexChanged += new System.EventHandler(this.Txt_descuento_TabIndexChanged);
            this.txt_descuento.TextChanged += new System.EventHandler(this.txt_descuento_TextChanged);
            this.txt_descuento.Enter += new System.EventHandler(this.Txt_descuento_Enter);
            // 
            // txt_total
            // 
            this.txt_total.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_total.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total.Location = new System.Drawing.Point(741, 666);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(110, 24);
            this.txt_total.TabIndex = 24;
            this.txt_total.TextChanged += new System.EventHandler(this.txt_total_TextChanged_1);
            this.txt_total.Enter += new System.EventHandler(this.txt_total_Enter);
            this.txt_total.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txt_total_MouseDown);
            this.txt_total.MouseLeave += new System.EventHandler(this.txt_total_MouseLeave);
            this.txt_total.MouseHover += new System.EventHandler(this.txt_total_MouseHover);
            // 
            // lis_ape_em
            // 
            this.lis_ape_em.FormattingEnabled = true;
            this.lis_ape_em.Location = new System.Drawing.Point(58, 227);
            this.lis_ape_em.Name = "lis_ape_em";
            this.lis_ape_em.Size = new System.Drawing.Size(120, 30);
            this.lis_ape_em.TabIndex = 48;
            this.lis_ape_em.Visible = false;
            // 
            // lis_nom_em
            // 
            this.lis_nom_em.FormattingEnabled = true;
            this.lis_nom_em.Location = new System.Drawing.Point(58, 182);
            this.lis_nom_em.Name = "lis_nom_em";
            this.lis_nom_em.Size = new System.Drawing.Size(120, 30);
            this.lis_nom_em.TabIndex = 47;
            this.lis_nom_em.Visible = false;
            // 
            // list_apellidos
            // 
            this.list_apellidos.FormattingEnabled = true;
            this.list_apellidos.Location = new System.Drawing.Point(58, 129);
            this.list_apellidos.Name = "list_apellidos";
            this.list_apellidos.Size = new System.Drawing.Size(120, 30);
            this.list_apellidos.TabIndex = 46;
            this.list_apellidos.Visible = false;
            // 
            // list_nombres
            // 
            this.list_nombres.FormattingEnabled = true;
            this.list_nombres.Location = new System.Drawing.Point(58, 81);
            this.list_nombres.Name = "list_nombres";
            this.list_nombres.Size = new System.Drawing.Size(120, 30);
            this.list_nombres.TabIndex = 45;
            this.list_nombres.Visible = false;
            // 
            // bt_home
            // 
            this.bt_home.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bt_home.FlatAppearance.BorderSize = 0;
            this.bt_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_home.Image = ((System.Drawing.Image)(resources.GetObject("bt_home.Image")));
            this.bt_home.Location = new System.Drawing.Point(398, 581);
            this.bt_home.Name = "bt_home";
            this.bt_home.Size = new System.Drawing.Size(75, 75);
            this.bt_home.TabIndex = 49;
            this.bt_home.TabStop = false;
            this.bt_home.UseVisualStyleBackColor = true;
            this.bt_home.Click += new System.EventHandler(this.bt_home_Click);
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(373, 664);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(100, 20);
            this.txt_buscar.TabIndex = 50;
            // 
            // bt_buscar
            // 
            this.bt_buscar.Location = new System.Drawing.Point(503, 664);
            this.bt_buscar.Name = "bt_buscar";
            this.bt_buscar.Size = new System.Drawing.Size(75, 23);
            this.bt_buscar.TabIndex = 51;
            this.bt_buscar.Text = "BUSCAR";
            this.bt_buscar.UseVisualStyleBackColor = true;
            this.bt_buscar.Click += new System.EventHandler(this.Bt_buscar_Click);
            // 
            // bt_eliminar
            // 
            this.bt_eliminar.FlatAppearance.BorderSize = 0;
            this.bt_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("bt_eliminar.Image")));
            this.bt_eliminar.Location = new System.Drawing.Point(1043, 289);
            this.bt_eliminar.Name = "bt_eliminar";
            this.bt_eliminar.Size = new System.Drawing.Size(56, 59);
            this.bt_eliminar.TabIndex = 52;
            this.bt_eliminar.UseVisualStyleBackColor = true;
            this.bt_eliminar.Click += new System.EventHandler(this.Bt_eliminar_Click);
            // 
            // bt_el_data
            // 
            this.bt_el_data.FlatAppearance.BorderSize = 0;
            this.bt_el_data.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_el_data.Image = ((System.Drawing.Image)(resources.GetObject("bt_el_data.Image")));
            this.bt_el_data.Location = new System.Drawing.Point(1043, 227);
            this.bt_el_data.Name = "bt_el_data";
            this.bt_el_data.Size = new System.Drawing.Size(55, 56);
            this.bt_el_data.TabIndex = 53;
            this.bt_el_data.UseVisualStyleBackColor = true;
            this.bt_el_data.Click += new System.EventHandler(this.Bt_el_data_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(820, 631);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 18);
            this.label9.TabIndex = 54;
            this.label9.Text = "%";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(503, 610);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 55;
            this.button2.Text = "IMPRIMIR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_recibido
            // 
            this.txt_recibido.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_recibido.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_recibido.Location = new System.Drawing.Point(918, 588);
            this.txt_recibido.Name = "txt_recibido";
            this.txt_recibido.Size = new System.Drawing.Size(110, 24);
            this.txt_recibido.TabIndex = 57;
            this.txt_recibido.TextChanged += new System.EventHandler(this.txt_recibido_TextChanged);
            this.txt_recibido.MouseLeave += new System.EventHandler(this.txt_recibido_MouseLeave);
            this.txt_recibido.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txt_recibido_MouseUp);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(866, 594);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 56;
            this.label10.Text = "Recibido";
            // 
            // txt_cambio
            // 
            this.txt_cambio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_cambio.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cambio.Location = new System.Drawing.Point(918, 634);
            this.txt_cambio.Name = "txt_cambio";
            this.txt_cambio.ReadOnly = true;
            this.txt_cambio.Size = new System.Drawing.Size(110, 24);
            this.txt_cambio.TabIndex = 59;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(873, 639);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 58;
            this.label11.Text = "Cambio";
            // 
            // checkPrestamo
            // 
            this.checkPrestamo.AutoSize = true;
            this.checkPrestamo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.checkPrestamo.Location = new System.Drawing.Point(382, 109);
            this.checkPrestamo.Name = "checkPrestamo";
            this.checkPrestamo.Size = new System.Drawing.Size(86, 17);
            this.checkPrestamo.TabIndex = 52;
            this.checkPrestamo.Text = "PRESTAMO";
            this.checkPrestamo.UseVisualStyleBackColor = false;
            // 
            // Enca_venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1141, 712);
            this.Controls.Add(this.txt_cambio);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_recibido);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.bt_el_data);
            this.Controls.Add(this.bt_eliminar);
            this.Controls.Add(this.bt_buscar);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.bt_home);
            this.Controls.Add(this.lis_ape_em);
            this.Controls.Add(this.lis_nom_em);
            this.Controls.Add(this.list_apellidos);
            this.Controls.Add(this.list_nombres);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.txt_descuento);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataenca_venta);
            this.Name = "Enca_venta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Enca_venta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Enca_venta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataenca_venta)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataenca_venta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox cod_venta;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txt_descuento;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.ComboBox cb_cliente;
        private System.Windows.Forms.ComboBox cb_vendedor;
        private System.Windows.Forms.ListBox lis_ape_em;
        private System.Windows.Forms.ListBox lis_nom_em;
        private System.Windows.Forms.ListBox list_apellidos;
        private System.Windows.Forms.ListBox list_nombres;
        private System.Windows.Forms.Button bt_home;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Button bt_buscar;
        private System.Windows.Forms.Button bt_eliminar;
        private System.Windows.Forms.Button bt_el_data;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn IvaProd;
        private System.Windows.Forms.TextBox txt_recibido;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_cambio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox checkPrestamo;
    }
}