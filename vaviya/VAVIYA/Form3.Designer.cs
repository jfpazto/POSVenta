namespace VAVIYA
{
    partial class Form3
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Vaviya12DataSet1 = new VAVIYA.Vaviya12DataSet1();
            this.otro_facturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otro_facturaTableAdapter = new VAVIYA.Vaviya12DataSet1TableAdapters.otro_facturaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Vaviya12DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otro_facturaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.otro_facturaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "VAVIYA.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(801, 449);
            this.reportViewer1.TabIndex = 0;
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
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Vaviya12DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otro_facturaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource otro_facturaBindingSource;
        private Vaviya12DataSet1 Vaviya12DataSet1;
        private Vaviya12DataSet1TableAdapters.otro_facturaTableAdapter otro_facturaTableAdapter;
    }
}