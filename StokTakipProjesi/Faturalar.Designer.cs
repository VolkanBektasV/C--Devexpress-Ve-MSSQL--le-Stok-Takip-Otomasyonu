
namespace StokTakipProjesi
{
    partial class Faturalar
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
            this.Grd_Faturalar = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.bt_F_SeriUret = new DevExpress.XtraEditors.SimpleButton();
            this.Lue_F_Personel = new DevExpress.XtraEditors.LookUpEdit();
            this.dt_F_Tarih = new System.Windows.Forms.DateTimePicker();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.bt_F_Sil = new DevExpress.XtraEditors.SimpleButton();
            this.bt_F_Ekle = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.Mtx_F_Saat = new System.Windows.Forms.MaskedTextBox();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.Lue_F_Musteri = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.tx_F_Sira = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.tx_F_Seri = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.tx_F_ID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.tx_F_FATURAID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.bt_F_FaturaUrunEkle = new DevExpress.XtraEditors.SimpleButton();
            this.tx_F_ToplamTutar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.tx_F_SatisFiyat = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.Nud_F_Adet = new System.Windows.Forms.NumericUpDown();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.bt_F_UrunSec = new DevExpress.XtraEditors.SimpleButton();
            this.tx_F_UrunID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tx_F_StokID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Faturalar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Lue_F_Personel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lue_F_Musteri.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_F_Sira.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_F_Seri.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_F_ID.Properties)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tx_F_FATURAID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_F_ToplamTutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_F_SatisFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_F_Adet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_F_UrunID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_F_StokID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // Grd_Faturalar
            // 
            this.Grd_Faturalar.Dock = System.Windows.Forms.DockStyle.Right;
            this.Grd_Faturalar.Location = new System.Drawing.Point(610, 0);
            this.Grd_Faturalar.MainView = this.gridView1;
            this.Grd_Faturalar.Name = "Grd_Faturalar";
            this.Grd_Faturalar.Size = new System.Drawing.Size(1324, 868);
            this.Grd_Faturalar.TabIndex = 4;
            this.Grd_Faturalar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.Grd_Faturalar.Click += new System.EventHandler(this.Grd_Faturalar_Click);
            this.Grd_Faturalar.DoubleClick += new System.EventHandler(this.Grd_Faturalar_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.Grd_Faturalar;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.xtraTabControl1.Appearance.Options.UseFont = true;
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(610, 868);
            this.xtraTabControl1.TabIndex = 7;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Appearance.Header.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.xtraTabPage1.Appearance.Header.Options.UseFont = true;
            this.xtraTabPage1.Controls.Add(this.labelControl14);
            this.xtraTabPage1.Controls.Add(this.bt_F_SeriUret);
            this.xtraTabPage1.Controls.Add(this.Lue_F_Personel);
            this.xtraTabPage1.Controls.Add(this.dt_F_Tarih);
            this.xtraTabPage1.Controls.Add(this.simpleButton3);
            this.xtraTabPage1.Controls.Add(this.bt_F_Sil);
            this.xtraTabPage1.Controls.Add(this.bt_F_Ekle);
            this.xtraTabPage1.Controls.Add(this.labelControl6);
            this.xtraTabPage1.Controls.Add(this.Mtx_F_Saat);
            this.xtraTabPage1.Controls.Add(this.labelControl9);
            this.xtraTabPage1.Controls.Add(this.Lue_F_Musteri);
            this.xtraTabPage1.Controls.Add(this.labelControl13);
            this.xtraTabPage1.Controls.Add(this.labelControl8);
            this.xtraTabPage1.Controls.Add(this.tx_F_Sira);
            this.xtraTabPage1.Controls.Add(this.labelControl10);
            this.xtraTabPage1.Controls.Add(this.tx_F_Seri);
            this.xtraTabPage1.Controls.Add(this.labelControl11);
            this.xtraTabPage1.Controls.Add(this.tx_F_ID);
            this.xtraTabPage1.Controls.Add(this.labelControl12);
            this.xtraTabPage1.ImageOptions.SvgImage = global::StokTakipProjesi.Properties.Resources.bo_contract;
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(605, 824);
            this.xtraTabPage1.Text = "Fatura Bilgileri";
            // 
            // bt_F_SeriUret
            // 
            this.bt_F_SeriUret.ImageOptions.Image = global::StokTakipProjesi.Properties.Resources.refresh_32x321;
            this.bt_F_SeriUret.Location = new System.Drawing.Point(358, 102);
            this.bt_F_SeriUret.Name = "bt_F_SeriUret";
            this.bt_F_SeriUret.Size = new System.Drawing.Size(39, 28);
            this.bt_F_SeriUret.TabIndex = 77;
            this.bt_F_SeriUret.Click += new System.EventHandler(this.bt_F_SeriUret_Click);
            // 
            // Lue_F_Personel
            // 
            this.Lue_F_Personel.Location = new System.Drawing.Point(190, 254);
            this.Lue_F_Personel.Name = "Lue_F_Personel";
            this.Lue_F_Personel.Properties.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lue_F_Personel.Properties.Appearance.Options.UseFont = true;
            this.Lue_F_Personel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Lue_F_Personel.Properties.NullText = "Bİr Personel Seçiniz...";
            this.Lue_F_Personel.Size = new System.Drawing.Size(207, 26);
            this.Lue_F_Personel.TabIndex = 76;
            // 
            // dt_F_Tarih
            // 
            this.dt_F_Tarih.CalendarForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dt_F_Tarih.CalendarMonthBackground = System.Drawing.Color.Gray;
            this.dt_F_Tarih.CalendarTitleBackColor = System.Drawing.Color.DimGray;
            this.dt_F_Tarih.CalendarTitleForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dt_F_Tarih.CalendarTrailingForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dt_F_Tarih.Cursor = System.Windows.Forms.Cursors.Default;
            this.dt_F_Tarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_F_Tarih.Location = new System.Drawing.Point(190, 143);
            this.dt_F_Tarih.Name = "dt_F_Tarih";
            this.dt_F_Tarih.Size = new System.Drawing.Size(207, 26);
            this.dt_F_Tarih.TabIndex = 75;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.ImageOptions.Image = global::StokTakipProjesi.Properties.Resources.refresh_32x322;
            this.simpleButton3.Location = new System.Drawing.Point(177, 403);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(175, 53);
            this.simpleButton3.TabIndex = 72;
            this.simpleButton3.Text = "Güncelle";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // bt_F_Sil
            // 
            this.bt_F_Sil.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_F_Sil.Appearance.Options.UseFont = true;
            this.bt_F_Sil.ImageOptions.Image = global::StokTakipProjesi.Properties.Resources.cancel_32x32;
            this.bt_F_Sil.Location = new System.Drawing.Point(290, 323);
            this.bt_F_Sil.Name = "bt_F_Sil";
            this.bt_F_Sil.Size = new System.Drawing.Size(175, 53);
            this.bt_F_Sil.TabIndex = 71;
            this.bt_F_Sil.Text = "Sil";
            this.bt_F_Sil.Click += new System.EventHandler(this.bt_F_Sil_Click);
            // 
            // bt_F_Ekle
            // 
            this.bt_F_Ekle.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_F_Ekle.Appearance.Options.UseFont = true;
            this.bt_F_Ekle.ImageOptions.Image = global::StokTakipProjesi.Properties.Resources.add_32x32;
            this.bt_F_Ekle.Location = new System.Drawing.Point(77, 323);
            this.bt_F_Ekle.Name = "bt_F_Ekle";
            this.bt_F_Ekle.Size = new System.Drawing.Size(175, 53);
            this.bt_F_Ekle.TabIndex = 70;
            this.bt_F_Ekle.Text = "Ekle";
            this.bt_F_Ekle.Click += new System.EventHandler(this.bt_F_Ekle_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(16, 257);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(168, 19);
            this.labelControl6.TabIndex = 65;
            this.labelControl6.Text = "Teslim Eden Personel :";
            // 
            // Mtx_F_Saat
            // 
            this.Mtx_F_Saat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.Mtx_F_Saat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Mtx_F_Saat.Location = new System.Drawing.Point(190, 181);
            this.Mtx_F_Saat.Mask = "00:00";
            this.Mtx_F_Saat.Name = "Mtx_F_Saat";
            this.Mtx_F_Saat.Size = new System.Drawing.Size(207, 26);
            this.Mtx_F_Saat.TabIndex = 63;
            this.Mtx_F_Saat.ValidatingType = typeof(System.DateTime);
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(138, 184);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(46, 19);
            this.labelControl9.TabIndex = 61;
            this.labelControl9.Text = "Saat :";
            // 
            // Lue_F_Musteri
            // 
            this.Lue_F_Musteri.Location = new System.Drawing.Point(190, 216);
            this.Lue_F_Musteri.Name = "Lue_F_Musteri";
            this.Lue_F_Musteri.Properties.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lue_F_Musteri.Properties.Appearance.Options.UseFont = true;
            this.Lue_F_Musteri.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Lue_F_Musteri.Properties.NullText = "Bİr Müşteri Seçiniz...";
            this.Lue_F_Musteri.Size = new System.Drawing.Size(207, 26);
            this.Lue_F_Musteri.TabIndex = 6;
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(136, 149);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(48, 19);
            this.labelControl13.TabIndex = 57;
            this.labelControl13.Text = "Tarih :";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(145, 219);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(39, 19);
            this.labelControl8.TabIndex = 53;
            this.labelControl8.Text = "Alıcı :";
            // 
            // tx_F_Sira
            // 
            this.tx_F_Sira.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tx_F_Sira.Location = new System.Drawing.Point(190, 104);
            this.tx_F_Sira.Name = "tx_F_Sira";
            this.tx_F_Sira.Properties.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_F_Sira.Properties.Appearance.Options.UseFont = true;
            this.tx_F_Sira.Size = new System.Drawing.Size(162, 26);
            this.tx_F_Sira.TabIndex = 3;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(115, 107);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(66, 19);
            this.labelControl10.TabIndex = 49;
            this.labelControl10.Text = "Sıra No :";
            // 
            // tx_F_Seri
            // 
            this.tx_F_Seri.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tx_F_Seri.Location = new System.Drawing.Point(190, 67);
            this.tx_F_Seri.Name = "tx_F_Seri";
            this.tx_F_Seri.Properties.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_F_Seri.Properties.Appearance.Options.UseFont = true;
            this.tx_F_Seri.Size = new System.Drawing.Size(207, 26);
            this.tx_F_Seri.TabIndex = 2;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(135, 70);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(46, 19);
            this.labelControl11.TabIndex = 47;
            this.labelControl11.Text = "SERİ :";
            // 
            // tx_F_ID
            // 
            this.tx_F_ID.Location = new System.Drawing.Point(190, 24);
            this.tx_F_ID.Name = "tx_F_ID";
            this.tx_F_ID.Properties.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_F_ID.Properties.Appearance.Options.UseFont = true;
            this.tx_F_ID.Size = new System.Drawing.Size(207, 26);
            this.tx_F_ID.TabIndex = 1;
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(156, 27);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(28, 19);
            this.labelControl12.TabIndex = 44;
            this.labelControl12.Text = "ID :";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.labelControl15);
            this.xtraTabPage2.Controls.Add(this.tx_F_FATURAID);
            this.xtraTabPage2.Controls.Add(this.labelControl7);
            this.xtraTabPage2.Controls.Add(this.bt_F_FaturaUrunEkle);
            this.xtraTabPage2.Controls.Add(this.tx_F_ToplamTutar);
            this.xtraTabPage2.Controls.Add(this.labelControl5);
            this.xtraTabPage2.Controls.Add(this.tx_F_SatisFiyat);
            this.xtraTabPage2.Controls.Add(this.labelControl4);
            this.xtraTabPage2.Controls.Add(this.Nud_F_Adet);
            this.xtraTabPage2.Controls.Add(this.labelControl1);
            this.xtraTabPage2.Controls.Add(this.bt_F_UrunSec);
            this.xtraTabPage2.Controls.Add(this.tx_F_UrunID);
            this.xtraTabPage2.Controls.Add(this.labelControl2);
            this.xtraTabPage2.Controls.Add(this.tx_F_StokID);
            this.xtraTabPage2.Controls.Add(this.labelControl3);
            this.xtraTabPage2.ImageOptions.SvgImage = global::StokTakipProjesi.Properties.Resources.bo_sale2;
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(605, 824);
            this.xtraTabPage2.Text = "Fatura Ürün Ekle";
            // 
            // tx_F_FATURAID
            // 
            this.tx_F_FATURAID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tx_F_FATURAID.Location = new System.Drawing.Point(179, 242);
            this.tx_F_FATURAID.Name = "tx_F_FATURAID";
            this.tx_F_FATURAID.Properties.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_F_FATURAID.Properties.Appearance.Options.UseFont = true;
            this.tx_F_FATURAID.Size = new System.Drawing.Size(207, 26);
            this.tx_F_FATURAID.TabIndex = 82;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(89, 245);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(81, 19);
            this.labelControl7.TabIndex = 83;
            this.labelControl7.Text = "Fatura ID :";
            // 
            // bt_F_FaturaUrunEkle
            // 
            this.bt_F_FaturaUrunEkle.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_F_FaturaUrunEkle.Appearance.Options.UseFont = true;
            this.bt_F_FaturaUrunEkle.ImageOptions.Image = global::StokTakipProjesi.Properties.Resources.add_32x32;
            this.bt_F_FaturaUrunEkle.Location = new System.Drawing.Point(190, 298);
            this.bt_F_FaturaUrunEkle.Name = "bt_F_FaturaUrunEkle";
            this.bt_F_FaturaUrunEkle.Size = new System.Drawing.Size(175, 53);
            this.bt_F_FaturaUrunEkle.TabIndex = 81;
            this.bt_F_FaturaUrunEkle.Text = "Ekle";
            this.bt_F_FaturaUrunEkle.Click += new System.EventHandler(this.bt_F_FaturaUrunEkle_Click);
            // 
            // tx_F_ToplamTutar
            // 
            this.tx_F_ToplamTutar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tx_F_ToplamTutar.Location = new System.Drawing.Point(179, 205);
            this.tx_F_ToplamTutar.Name = "tx_F_ToplamTutar";
            this.tx_F_ToplamTutar.Properties.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_F_ToplamTutar.Properties.Appearance.Options.UseFont = true;
            this.tx_F_ToplamTutar.Size = new System.Drawing.Size(207, 26);
            this.tx_F_ToplamTutar.TabIndex = 79;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(59, 208);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(111, 19);
            this.labelControl5.TabIndex = 80;
            this.labelControl5.Text = "Toplam Tutar :";
            // 
            // tx_F_SatisFiyat
            // 
            this.tx_F_SatisFiyat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tx_F_SatisFiyat.Location = new System.Drawing.Point(179, 165);
            this.tx_F_SatisFiyat.Name = "tx_F_SatisFiyat";
            this.tx_F_SatisFiyat.Properties.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_F_SatisFiyat.Properties.Appearance.Options.UseFont = true;
            this.tx_F_SatisFiyat.Size = new System.Drawing.Size(207, 26);
            this.tx_F_SatisFiyat.TabIndex = 77;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(81, 168);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(89, 19);
            this.labelControl4.TabIndex = 78;
            this.labelControl4.Text = "Satis Fiyat :";
            // 
            // Nud_F_Adet
            // 
            this.Nud_F_Adet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.Nud_F_Adet.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Nud_F_Adet.Location = new System.Drawing.Point(179, 127);
            this.Nud_F_Adet.Name = "Nud_F_Adet";
            this.Nud_F_Adet.Size = new System.Drawing.Size(207, 26);
            this.Nud_F_Adet.TabIndex = 75;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(124, 129);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(46, 19);
            this.labelControl1.TabIndex = 76;
            this.labelControl1.Text = "Adet :";
            // 
            // bt_F_UrunSec
            // 
            this.bt_F_UrunSec.ImageOptions.Image = global::StokTakipProjesi.Properties.Resources.add_16x16;
            this.bt_F_UrunSec.Location = new System.Drawing.Point(326, 48);
            this.bt_F_UrunSec.Name = "bt_F_UrunSec";
            this.bt_F_UrunSec.Size = new System.Drawing.Size(60, 28);
            this.bt_F_UrunSec.TabIndex = 74;
            this.bt_F_UrunSec.Text = "Seç";
            this.bt_F_UrunSec.Click += new System.EventHandler(this.bt_F_UrunSec_Click_1);
            // 
            // tx_F_UrunID
            // 
            this.tx_F_UrunID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tx_F_UrunID.Location = new System.Drawing.Point(179, 87);
            this.tx_F_UrunID.Name = "tx_F_UrunID";
            this.tx_F_UrunID.Properties.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_F_UrunID.Properties.Appearance.Options.UseFont = true;
            this.tx_F_UrunID.Size = new System.Drawing.Size(207, 26);
            this.tx_F_UrunID.TabIndex = 71;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(102, 90);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(68, 19);
            this.labelControl2.TabIndex = 73;
            this.labelControl2.Text = "Ürün ID :";
            // 
            // tx_F_StokID
            // 
            this.tx_F_StokID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tx_F_StokID.Location = new System.Drawing.Point(179, 50);
            this.tx_F_StokID.Name = "tx_F_StokID";
            this.tx_F_StokID.Properties.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_F_StokID.Properties.Appearance.Options.UseFont = true;
            this.tx_F_StokID.Size = new System.Drawing.Size(139, 26);
            this.tx_F_StokID.TabIndex = 70;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(107, 53);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(63, 19);
            this.labelControl3.TabIndex = 72;
            this.labelControl3.Text = "Stok ID:";
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl14.Appearance.Options.UseFont = true;
            this.labelControl14.Location = new System.Drawing.Point(40, 553);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(537, 19);
            this.labelControl14.TabIndex = 78;
            this.labelControl14.Text = "FATURA DETAYLARI İÇİN FATURANIN ÜSTÜNE ÇİFT TIKLAYINIZ...";
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl15.Appearance.Options.UseFont = true;
            this.labelControl15.Location = new System.Drawing.Point(38, 556);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(537, 19);
            this.labelControl15.TabIndex = 84;
            this.labelControl15.Text = "FATURA DETAYLARI İÇİN FATURANIN ÜSTÜNE ÇİFT TIKLAYINIZ...";
            // 
            // Faturalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1934, 868);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.Grd_Faturalar);
            this.Name = "Faturalar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FATURALAR";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Faturalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Faturalar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Lue_F_Personel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lue_F_Musteri.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_F_Sira.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_F_Seri.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_F_ID.Properties)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tx_F_FATURAID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_F_ToplamTutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_F_SatisFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_F_Adet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_F_UrunID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_F_StokID.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl Grd_Faturalar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LookUpEdit Lue_F_Musteri;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit tx_F_ID;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private System.Windows.Forms.MaskedTextBox Mtx_F_Saat;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton bt_F_Sil;
        private DevExpress.XtraEditors.SimpleButton bt_F_Ekle;
        public DevExpress.XtraEditors.TextEdit tx_F_Sira;
        public DevExpress.XtraEditors.TextEdit tx_F_Seri;
        private System.Windows.Forms.DateTimePicker dt_F_Tarih;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.LookUpEdit Lue_F_Personel;
        private DevExpress.XtraEditors.SimpleButton bt_F_FaturaUrunEkle;
        public DevExpress.XtraEditors.TextEdit tx_F_ToplamTutar;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        public DevExpress.XtraEditors.TextEdit tx_F_SatisFiyat;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.NumericUpDown Nud_F_Adet;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton bt_F_UrunSec;
        public DevExpress.XtraEditors.TextEdit tx_F_UrunID;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        public DevExpress.XtraEditors.TextEdit tx_F_StokID;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        public DevExpress.XtraEditors.TextEdit tx_F_FATURAID;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton bt_F_SeriUret;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl15;
    }
}