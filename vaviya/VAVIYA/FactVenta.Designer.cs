namespace VAVIYA
{
    partial class FactVenta
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DatosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Vaviya12DataSet1 = new VAVIYA.Vaviya12DataSet1();
            this.otro_facturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otro_facturaTableAdapter = new VAVIYA.Vaviya12DataSet1TableAdapters.otro_facturaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DatosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vaviya12DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otro_facturaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DatosBindingSource
            // 
            this.DatosBindingSource.DataSource = typeof(VAVIYA.Datos);
            // 
            // reportViewer2
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DatosBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "VAVIYA.factura_venta.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(-1, 0);
            this.reportViewer2.Margin = new System.Windows.Forms.Padding(0);
            this.reportViewer2.MaximumSize = new System.Drawing.Size(350, 600);
            this.reportViewer2.MinimumSize = new System.Drawing.Size(350, 600);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(350, 600);
            this.reportViewer2.TabIndex = 1;
            this.reportViewer2.Load += new System.EventHandler(this.reportViewer2_Load);
            // 
            // Vaviya12DataSet1
            // 
            this.Vaviya12DataSet1.DataSetName = "Vaviya12DataSet1";
            this.Vaviya12DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // otro_facturaBindingSource
            // 
            this.otro_facturaBindingSource.DataMember = "otro_factura";
            this.otro_facturaBindingSource.DataSource = this.Vaviya12DataSet1;
            // 
            // otro_facturaTableAdapter
            // 
            this.otro_facturaTableAdapter.ClearBeforeFill = true;
            // 
            // FactVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 510);
            this.Controls.Add(this.reportViewer2);
            this.Name = "FactVenta";
            this.Text = "FactVenta";
            this.Load += new System.EventHandler(this.FactVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vaviya12DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otro_facturaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource DatosBindingSource;
        private System.Windows.Forms.BindingSource otro_facturaBindingSource;
        private Vaviya12DataSet1 Vaviya12DataSet1;
        private Vaviya12DataSet1TableAdapters.otro_facturaTableAdapter otro_facturaTableAdapter;
    }
}