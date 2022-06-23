
namespace StokTakipProjesi
{
    partial class AnaSayfa
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
            DevExpress.XtraCharts.SimpleDiagram3D simpleDiagram3D1 = new DevExpress.XtraCharts.SimpleDiagram3D();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.Pie3DSeriesLabel pie3DSeriesLabel1 = new DevExpress.XtraCharts.Pie3DSeriesLabel();
            DevExpress.XtraCharts.Pie3DSeriesView pie3DSeriesView1 = new DevExpress.XtraCharts.Pie3DSeriesView();
            this.groupControl12 = new DevExpress.XtraEditors.GroupControl();
            this.Grd_SonAlinanrunler = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Grd_StokCikisi = new DevExpress.XtraEditors.GroupControl();
            this.grd_StokCikis = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.grd_AzalanStok = new DevExpress.XtraGrid.GridControl();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl9 = new DevExpress.XtraEditors.GroupControl();
            this.chr_KategoriAdet = new DevExpress.XtraCharts.ChartControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lbl_EnKategori = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.lbl_Adet = new DevExpress.XtraEditors.LabelControl();
            this.lbl_BuAyMusteri = new DevExpress.XtraEditors.LabelControl();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.lbl_BuAyKar = new DevExpress.XtraEditors.LabelControl();
            this.grp_Kullanici = new DevExpress.XtraEditors.GroupControl();
            this.lbl_KullaniciAd = new DevExpress.XtraEditors.LabelControl();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl12)).BeginInit();
            this.groupControl12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_SonAlinanrunler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_StokCikisi)).BeginInit();
            this.Grd_StokCikisi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_StokCikis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_AzalanStok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl9)).BeginInit();
            this.groupControl9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chr_KategoriAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram3D1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grp_Kullanici)).BeginInit();
            this.grp_Kullanici.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl12
            // 
            this.groupControl12.AppearanceCaption.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupControl12.AppearanceCaption.Options.UseFont = true;
            this.groupControl12.CaptionImageOptions.SvgImage = global::StokTakipProjesi.Properties.Resources.bo_order_item;
            this.groupControl12.Controls.Add(this.Grd_SonAlinanrunler);
            this.groupControl12.Location = new System.Drawing.Point(3, 177);
            this.groupControl12.Name = "groupControl12";
            this.groupControl12.Size = new System.Drawing.Size(934, 306);
            this.groupControl12.TabIndex = 21;
            this.groupControl12.Text = "GÜNCEL STOK GİRİŞLERİ";
            // 
            // Grd_SonAlinanrunler
            // 
            this.Grd_SonAlinanrunler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grd_SonAlinanrunler.Location = new System.Drawing.Point(2, 39);
            this.Grd_SonAlinanrunler.MainView = this.gridView2;
            this.Grd_SonAlinanrunler.Name = "Grd_SonAlinanrunler";
            this.Grd_SonAlinanrunler.Size = new System.Drawing.Size(930, 265);
            this.Grd_SonAlinanrunler.TabIndex = 13;
            this.Grd_SonAlinanrunler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.DetailHeight = 349;
            this.gridView2.FixedLineWidth = 1;
            this.gridView2.GridControl = this.Grd_SonAlinanrunler;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsView.ShowFooter = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // Grd_StokCikisi
            // 
            this.Grd_StokCikisi.AppearanceCaption.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Grd_StokCikisi.AppearanceCaption.Options.UseFont = true;
            this.Grd_StokCikisi.CaptionImageOptions.SvgImage = global::StokTakipProjesi.Properties.Resources.bo_sale3;
            this.Grd_StokCikisi.Controls.Add(this.grd_StokCikis);
            this.Grd_StokCikisi.Location = new System.Drawing.Point(5, 485);
            this.Grd_StokCikisi.Name = "Grd_StokCikisi";
            this.Grd_StokCikisi.Size = new System.Drawing.Size(934, 383);
            this.Grd_StokCikisi.TabIndex = 22;
            this.Grd_StokCikisi.Text = "GÜNCEL STOK ÇIKIŞLARI";
            // 
            // grd_StokCikis
            // 
            this.grd_StokCikis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_StokCikis.Location = new System.Drawing.Point(2, 39);
            this.grd_StokCikis.MainView = this.gridView1;
            this.grd_StokCikis.Name = "grd_StokCikis";
            this.grd_StokCikis.Size = new System.Drawing.Size(930, 342);
            this.grd_StokCikis.TabIndex = 13;
            this.grd_StokCikis.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 349;
            this.gridView1.FixedLineWidth = 1;
            this.gridView1.GridControl = this.grd_StokCikis;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // groupControl3
            // 
            this.groupControl3.AppearanceCaption.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupControl3.AppearanceCaption.Options.UseFont = true;
            this.groupControl3.CaptionImageOptions.SvgImage = global::StokTakipProjesi.Properties.Resources.high1;
            this.groupControl3.Controls.Add(this.grd_AzalanStok);
            this.groupControl3.Location = new System.Drawing.Point(946, 177);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(962, 304);
            this.groupControl3.TabIndex = 23;
            this.groupControl3.Text = "STOKTA 20 ADETTEN AZ KALAN ÜRÜNLER";
            // 
            // grd_AzalanStok
            // 
            this.grd_AzalanStok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_AzalanStok.Location = new System.Drawing.Point(2, 39);
            this.grd_AzalanStok.MainView = this.gridView4;
            this.grd_AzalanStok.Name = "grd_AzalanStok";
            this.grd_AzalanStok.Size = new System.Drawing.Size(958, 263);
            this.grd_AzalanStok.TabIndex = 13;
            this.grd_AzalanStok.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            // 
            // gridView4
            // 
            this.gridView4.DetailHeight = 349;
            this.gridView4.FixedLineWidth = 1;
            this.gridView4.GridControl = this.grd_AzalanStok;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsBehavior.Editable = false;
            this.gridView4.OptionsView.ShowFooter = true;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // groupControl9
            // 
            this.groupControl9.AppearanceCaption.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupControl9.AppearanceCaption.Options.UseFont = true;
            this.groupControl9.CaptionImageOptions.SvgImage = global::StokTakipProjesi.Properties.Resources.charttype_pie3d;
            this.groupControl9.Controls.Add(this.chr_KategoriAdet);
            this.groupControl9.Location = new System.Drawing.Point(948, 485);
            this.groupControl9.Name = "groupControl9";
            this.groupControl9.Size = new System.Drawing.Size(960, 381);
            this.groupControl9.TabIndex = 24;
            this.groupControl9.Text = "SATILAN ÜRÜN KATEGORİ VE ADETİ";
            // 
            // chr_KategoriAdet
            // 
            simpleDiagram3D1.RotationMatrixSerializable = "1;0;0;0;0;0.5;-0.866025403784439;0;0;0.866025403784439;0.5;0;0;0;0;1";
            simpleDiagram3D1.ZoomPercent = 146;
            this.chr_KategoriAdet.Diagram = simpleDiagram3D1;
            this.chr_KategoriAdet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chr_KategoriAdet.Legend.Name = "Default Legend";
            this.chr_KategoriAdet.Location = new System.Drawing.Point(2, 39);
            this.chr_KategoriAdet.Name = "chr_KategoriAdet";
            pie3DSeriesLabel1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            pie3DSeriesLabel1.TextPattern = "{A}";
            series1.Label = pie3DSeriesLabel1;
            series1.Name = "ÜRÜNLER";
            series1.View = pie3DSeriesView1;
            this.chr_KategoriAdet.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chr_KategoriAdet.Size = new System.Drawing.Size(956, 340);
            this.chr_KategoriAdet.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupControl1.AppearanceCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.CaptionImageOptions.SvgImage = global::StokTakipProjesi.Properties.Resources.productquickshippments;
            this.groupControl1.Controls.Add(this.lbl_EnKategori);
            this.groupControl1.Location = new System.Drawing.Point(58, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(393, 141);
            this.groupControl1.TabIndex = 25;
            this.groupControl1.Text = "BU AY EN ÇOK TALEP GÖREN KATEGORİ";
            // 
            // lbl_EnKategori
            // 
            this.lbl_EnKategori.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_EnKategori.Appearance.Options.UseFont = true;
            this.lbl_EnKategori.Appearance.Options.UseTextOptions = true;
            this.lbl_EnKategori.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lbl_EnKategori.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_EnKategori.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.lbl_EnKategori.Location = new System.Drawing.Point(0, 41);
            this.lbl_EnKategori.Name = "lbl_EnKategori";
            this.lbl_EnKategori.Size = new System.Drawing.Size(388, 94);
            this.lbl_EnKategori.TabIndex = 0;
            this.lbl_EnKategori.Text = "Null";
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupControl2.AppearanceCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.CaptionImageOptions.SvgImage = global::StokTakipProjesi.Properties.Resources.employeequickwelcome2;
            this.groupControl2.Controls.Add(this.lbl_Adet);
            this.groupControl2.Controls.Add(this.lbl_BuAyMusteri);
            this.groupControl2.Location = new System.Drawing.Point(539, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(386, 141);
            this.groupControl2.TabIndex = 26;
            this.groupControl2.Text = "BU AY EN ÇOK ÜRÜN ALAN MÜŞTERİ";
            // 
            // lbl_Adet
            // 
            this.lbl_Adet.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Adet.Appearance.Options.UseFont = true;
            this.lbl_Adet.Appearance.Options.UseTextOptions = true;
            this.lbl_Adet.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lbl_Adet.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_Adet.Location = new System.Drawing.Point(0, 95);
            this.lbl_Adet.Name = "lbl_Adet";
            this.lbl_Adet.Size = new System.Drawing.Size(386, 46);
            this.lbl_Adet.TabIndex = 1;
            this.lbl_Adet.Text = "Null";
            // 
            // lbl_BuAyMusteri
            // 
            this.lbl_BuAyMusteri.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_BuAyMusteri.Appearance.Options.UseFont = true;
            this.lbl_BuAyMusteri.Appearance.Options.UseTextOptions = true;
            this.lbl_BuAyMusteri.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lbl_BuAyMusteri.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_BuAyMusteri.Location = new System.Drawing.Point(0, 42);
            this.lbl_BuAyMusteri.Name = "lbl_BuAyMusteri";
            this.lbl_BuAyMusteri.Size = new System.Drawing.Size(386, 47);
            this.lbl_BuAyMusteri.TabIndex = 0;
            this.lbl_BuAyMusteri.Text = "Null";
            // 
            // groupControl4
            // 
            this.groupControl4.AppearanceCaption.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupControl4.AppearanceCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.groupControl4.AppearanceCaption.Options.UseFont = true;
            this.groupControl4.CaptionImageOptions.SvgImage = global::StokTakipProjesi.Properties.Resources.business_cash1;
            this.groupControl4.Controls.Add(this.lbl_BuAyKar);
            this.groupControl4.Location = new System.Drawing.Point(1019, 12);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(386, 141);
            this.groupControl4.TabIndex = 27;
            this.groupControl4.Text = "BU AY EDİLEN KAR";
            // 
            // lbl_BuAyKar
            // 
            this.lbl_BuAyKar.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_BuAyKar.Appearance.Options.UseFont = true;
            this.lbl_BuAyKar.Appearance.Options.UseTextOptions = true;
            this.lbl_BuAyKar.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lbl_BuAyKar.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_BuAyKar.Location = new System.Drawing.Point(5, 39);
            this.lbl_BuAyKar.Name = "lbl_BuAyKar";
            this.lbl_BuAyKar.Size = new System.Drawing.Size(376, 97);
            this.lbl_BuAyKar.TabIndex = 0;
            this.lbl_BuAyKar.Text = "labelControl4";
            // 
            // grp_Kullanici
            // 
            this.grp_Kullanici.AppearanceCaption.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grp_Kullanici.AppearanceCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.grp_Kullanici.AppearanceCaption.Options.UseFont = true;
            this.grp_Kullanici.CaptionImageOptions.SvgImage = global::StokTakipProjesi.Properties.Resources.bo_person;
            this.grp_Kullanici.Controls.Add(this.lbl_KullaniciAd);
            this.grp_Kullanici.Location = new System.Drawing.Point(1489, 12);
            this.grp_Kullanici.Name = "grp_Kullanici";
            this.grp_Kullanici.Size = new System.Drawing.Size(386, 141);
            this.grp_Kullanici.TabIndex = 28;
            this.grp_Kullanici.Text = "KULLANICI PROFİLİ";
            // 
            // lbl_KullaniciAd
            // 
            this.lbl_KullaniciAd.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_KullaniciAd.Appearance.Options.UseFont = true;
            this.lbl_KullaniciAd.Appearance.Options.UseTextOptions = true;
            this.lbl_KullaniciAd.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lbl_KullaniciAd.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_KullaniciAd.Location = new System.Drawing.Point(5, 42);
            this.lbl_KullaniciAd.Name = "lbl_KullaniciAd";
            this.lbl_KullaniciAd.Size = new System.Drawing.Size(376, 94);
            this.lbl_KullaniciAd.TabIndex = 1;
            this.lbl_KullaniciAd.Text = "Null";
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1934, 868);
            this.Controls.Add(this.grp_Kullanici);
            this.Controls.Add(this.Grd_StokCikisi);
            this.Controls.Add(this.groupControl9);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl12);
            this.Name = "AnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ANA SAYFA";
            this.Load += new System.EventHandler(this.AnaSayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl12)).EndInit();
            this.groupControl12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grd_SonAlinanrunler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_StokCikisi)).EndInit();
            this.Grd_StokCikisi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_StokCikis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_AzalanStok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl9)).EndInit();
            this.groupControl9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram3D1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chr_KategoriAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grp_Kullanici)).EndInit();
            this.grp_Kullanici.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl12;
        private DevExpress.XtraGrid.GridControl Grd_SonAlinanrunler;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.GroupControl Grd_StokCikisi;
        private DevExpress.XtraGrid.GridControl grd_StokCikis;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraGrid.GridControl grd_AzalanStok;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraEditors.GroupControl groupControl9;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl lbl_EnKategori;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl lbl_BuAyMusteri;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.LabelControl lbl_BuAyKar;
        private DevExpress.XtraEditors.LabelControl lbl_Adet;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraCharts.ChartControl chr_KategoriAdet;
        public DevExpress.XtraEditors.LabelControl lbl_KullaniciAd;
        public DevExpress.XtraEditors.GroupControl grp_Kullanici;
    }
}