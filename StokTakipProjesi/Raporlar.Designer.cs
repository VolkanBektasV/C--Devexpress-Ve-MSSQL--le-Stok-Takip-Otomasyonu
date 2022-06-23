
namespace StokTakipProjesi
{
    partial class Raporlar
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.UrunlerRaporBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TeknolojiMagazaDbDataSet = new StokTakipProjesi.TeknolojiMagazaDbDataSet();
            this.StokTablosuRaporBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SatilanUrunlerRaporBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PersonellerRaporBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            this.reportViewer4 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.UrunlerRaporTableAdapter = new StokTakipProjesi.TeknolojiMagazaDbDataSetTableAdapters.UrunlerRaporTableAdapter();
            this.StokTablosuRaporTableAdapter = new StokTakipProjesi.TeknolojiMagazaDbDataSetTableAdapters.StokTablosuRaporTableAdapter();
            this.SatilanUrunlerRaporTableAdapter = new StokTakipProjesi.TeknolojiMagazaDbDataSetTableAdapters.SatilanUrunlerRaporTableAdapter();
            this.PersonellerRaporTableAdapter = new StokTakipProjesi.TeknolojiMagazaDbDataSetTableAdapters.PersonellerRaporTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.UrunlerRaporBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeknolojiMagazaDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StokTablosuRaporBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SatilanUrunlerRaporBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonellerRaporBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            this.xtraTabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // UrunlerRaporBindingSource
            // 
            this.UrunlerRaporBindingSource.DataMember = "UrunlerRapor";
            this.UrunlerRaporBindingSource.DataSource = this.TeknolojiMagazaDbDataSet;
            // 
            // TeknolojiMagazaDbDataSet
            // 
            this.TeknolojiMagazaDbDataSet.DataSetName = "TeknolojiMagazaDbDataSet";
            this.TeknolojiMagazaDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // StokTablosuRaporBindingSource
            // 
            this.StokTablosuRaporBindingSource.DataMember = "StokTablosuRapor";
            this.StokTablosuRaporBindingSource.DataSource = this.TeknolojiMagazaDbDataSet;
            // 
            // SatilanUrunlerRaporBindingSource
            // 
            this.SatilanUrunlerRaporBindingSource.DataMember = "SatilanUrunlerRapor";
            this.SatilanUrunlerRaporBindingSource.DataSource = this.TeknolojiMagazaDbDataSet;
            // 
            // PersonellerRaporBindingSource
            // 
            this.PersonellerRaporBindingSource.DataMember = "PersonellerRapor";
            this.PersonellerRaporBindingSource.DataSource = this.TeknolojiMagazaDbDataSet;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1934, 868);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3,
            this.xtraTabPage4});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.reportViewer1);
            this.xtraTabPage1.ImageOptions.SvgImage = global::StokTakipProjesi.Properties.Resources.bo_product_group5;
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1929, 824);
            this.xtraTabPage1.Text = "ÜRÜNLER RAPOR";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.UrunlerRaporBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "StokTakipProjesi.UrunlerRapor.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1929, 824);
            this.reportViewer1.TabIndex = 0;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.reportViewer2);
            this.xtraTabPage2.ImageOptions.SvgImage = global::StokTakipProjesi.Properties.Resources.charttype_pie3d2;
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1929, 824);
            this.xtraTabPage2.Text = "STOK RAPOR";
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.StokTablosuRaporBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "StokTakipProjesi.StokRapor.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(1929, 824);
            this.reportViewer2.TabIndex = 0;
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.reportViewer3);
            this.xtraTabPage3.ImageOptions.SvgImage = global::StokTakipProjesi.Properties.Resources.bo_sale6;
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(1929, 824);
            this.xtraTabPage3.Text = "SATILAN ÜRÜN RAPOR";
            // 
            // reportViewer3
            // 
            this.reportViewer3.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "SatilanUrunlerDs";
            reportDataSource3.Value = this.SatilanUrunlerRaporBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "StokTakipProjesi.SatilanUrunRapor.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(0, 0);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.ServerReport.BearerToken = null;
            this.reportViewer3.Size = new System.Drawing.Size(1929, 824);
            this.reportViewer3.TabIndex = 0;
            // 
            // xtraTabPage4
            // 
            this.xtraTabPage4.Controls.Add(this.reportViewer4);
            this.xtraTabPage4.ImageOptions.SvgImage = global::StokTakipProjesi.Properties.Resources.bo_position3;
            this.xtraTabPage4.Name = "xtraTabPage4";
            this.xtraTabPage4.Size = new System.Drawing.Size(1929, 824);
            this.xtraTabPage4.Text = "PERSONELLER RAPOR";
            // 
            // reportViewer4
            // 
            this.reportViewer4.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource4.Name = "PersonelRaporDs";
            reportDataSource4.Value = this.PersonellerRaporBindingSource;
            this.reportViewer4.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer4.LocalReport.ReportEmbeddedResource = "StokTakipProjesi.PersonellerRapor.rdlc";
            this.reportViewer4.Location = new System.Drawing.Point(0, 0);
            this.reportViewer4.Name = "reportViewer4";
            this.reportViewer4.ServerReport.BearerToken = null;
            this.reportViewer4.Size = new System.Drawing.Size(1929, 824);
            this.reportViewer4.TabIndex = 0;
            // 
            // UrunlerRaporTableAdapter
            // 
            this.UrunlerRaporTableAdapter.ClearBeforeFill = true;
            // 
            // StokTablosuRaporTableAdapter
            // 
            this.StokTablosuRaporTableAdapter.ClearBeforeFill = true;
            // 
            // SatilanUrunlerRaporTableAdapter
            // 
            this.SatilanUrunlerRaporTableAdapter.ClearBeforeFill = true;
            // 
            // PersonellerRaporTableAdapter
            // 
            this.PersonellerRaporTableAdapter.ClearBeforeFill = true;
            // 
            // Raporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1934, 868);
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "Raporlar";
            this.Text = "RAPORLAR";
            this.Load += new System.EventHandler(this.Raporlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UrunlerRaporBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeknolojiMagazaDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StokTablosuRaporBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SatilanUrunlerRaporBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonellerRaporBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage3.ResumeLayout(false);
            this.xtraTabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer4;
        private System.Windows.Forms.BindingSource UrunlerRaporBindingSource;
        private TeknolojiMagazaDbDataSet TeknolojiMagazaDbDataSet;
        private TeknolojiMagazaDbDataSetTableAdapters.UrunlerRaporTableAdapter UrunlerRaporTableAdapter;
        private System.Windows.Forms.BindingSource StokTablosuRaporBindingSource;
        private TeknolojiMagazaDbDataSetTableAdapters.StokTablosuRaporTableAdapter StokTablosuRaporTableAdapter;
        private System.Windows.Forms.BindingSource SatilanUrunlerRaporBindingSource;
        private TeknolojiMagazaDbDataSetTableAdapters.SatilanUrunlerRaporTableAdapter SatilanUrunlerRaporTableAdapter;
        private System.Windows.Forms.BindingSource PersonellerRaporBindingSource;
        private TeknolojiMagazaDbDataSetTableAdapters.PersonellerRaporTableAdapter PersonellerRaporTableAdapter;
    }
}