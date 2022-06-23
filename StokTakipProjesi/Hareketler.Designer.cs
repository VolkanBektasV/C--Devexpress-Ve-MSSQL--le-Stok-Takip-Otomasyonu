
namespace StokTakipProjesi
{
    partial class Hareketler
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
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.Grd_Hareket_Musteri = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.Grd_Hareket_Stok = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Hareket_Musteri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Hareket_Stok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.xtraTabControl1.Appearance.Options.UseFont = true;
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1934, 868);
            this.xtraTabControl1.TabIndex = 2;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Appearance.Header.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.xtraTabPage1.Appearance.Header.Options.UseFont = true;
            this.xtraTabPage1.Controls.Add(this.Grd_Hareket_Musteri);
            this.xtraTabPage1.ImageOptions.Padding = new System.Windows.Forms.Padding(-1);
            this.xtraTabPage1.ImageOptions.SvgImage = global::StokTakipProjesi.Properties.Resources.employeequickwelcome;
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1929, 824);
            this.xtraTabPage1.Text = "MÜŞTERİ HAREKETLERİ";
            // 
            // Grd_Hareket_Musteri
            // 
            this.Grd_Hareket_Musteri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grd_Hareket_Musteri.Location = new System.Drawing.Point(0, 0);
            this.Grd_Hareket_Musteri.MainView = this.gridView1;
            this.Grd_Hareket_Musteri.Name = "Grd_Hareket_Musteri";
            this.Grd_Hareket_Musteri.Size = new System.Drawing.Size(1929, 824);
            this.Grd_Hareket_Musteri.TabIndex = 0;
            this.Grd_Hareket_Musteri.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.Grd_Hareket_Musteri.DoubleClick += new System.EventHandler(this.Grd_Hareket_Musteri_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.Grd_Hareket_Musteri;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Appearance.Header.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.xtraTabPage2.Appearance.Header.Options.UseFont = true;
            this.xtraTabPage2.Controls.Add(this.Grd_Hareket_Stok);
            this.xtraTabPage2.ImageOptions.SvgImage = global::StokTakipProjesi.Properties.Resources.charttype_bar3d1;
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1929, 824);
            this.xtraTabPage2.Text = "STOK HAREKETLERİ";
            // 
            // Grd_Hareket_Stok
            // 
            this.Grd_Hareket_Stok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grd_Hareket_Stok.Location = new System.Drawing.Point(0, 0);
            this.Grd_Hareket_Stok.MainView = this.gridView2;
            this.Grd_Hareket_Stok.Name = "Grd_Hareket_Stok";
            this.Grd_Hareket_Stok.Size = new System.Drawing.Size(1929, 824);
            this.Grd_Hareket_Stok.TabIndex = 1;
            this.Grd_Hareket_Stok.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.Grd_Hareket_Stok;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsView.ShowFooter = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // Hareketler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1934, 868);
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "Hareketler";
            this.Text = "HAREKETLER";
            this.Load += new System.EventHandler(this.Hareketler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Hareket_Musteri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Hareket_Stok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraGrid.GridControl Grd_Hareket_Musteri;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraGrid.GridControl Grd_Hareket_Stok;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
    }
}