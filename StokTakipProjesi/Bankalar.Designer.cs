
namespace StokTakipProjesi
{
    partial class Bankalar
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Grd_Bankalar = new DevExpress.XtraGrid.GridControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dt_B_Tarih = new System.Windows.Forms.DateTimePicker();
            this.Lue_B_HesapTur = new DevExpress.XtraEditors.LookUpEdit();
            this.Lue_B_BankaAdi = new DevExpress.XtraEditors.LookUpEdit();
            this.Mtx_B_HesapNo = new System.Windows.Forms.MaskedTextBox();
            this.Mtx_B_Iban = new System.Windows.Forms.MaskedTextBox();
            this.Lue_B_ilce = new DevExpress.XtraEditors.LookUpEdit();
            this.Lue_B_il = new DevExpress.XtraEditors.LookUpEdit();
            this.bt_P_Guncelle = new DevExpress.XtraEditors.SimpleButton();
            this.bt_P_Sil = new DevExpress.XtraEditors.SimpleButton();
            this.bt_B_Ekle = new DevExpress.XtraEditors.SimpleButton();
            this.Lue_B_Musteri = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.tx_B_YetkiliSoyad = new DevExpress.XtraEditors.TextEdit();
            this.tx_B_Sube = new DevExpress.XtraEditors.TextEdit();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.tx_B_YetkiliAd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.tx_B_ID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Bankalar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Lue_B_HesapTur.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lue_B_BankaAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lue_B_ilce.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lue_B_il.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lue_B_Musteri.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_B_YetkiliSoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_B_Sube.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_B_YetkiliAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_B_ID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.Grd_Bankalar;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // Grd_Bankalar
            // 
            this.Grd_Bankalar.Dock = System.Windows.Forms.DockStyle.Right;
            gridLevelNode1.RelationName = "Level1";
            this.Grd_Bankalar.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.Grd_Bankalar.Location = new System.Drawing.Point(474, 0);
            this.Grd_Bankalar.MainView = this.gridView1;
            this.Grd_Bankalar.Name = "Grd_Bankalar";
            this.Grd_Bankalar.Size = new System.Drawing.Size(1460, 868);
            this.Grd_Bankalar.TabIndex = 17;
            this.Grd_Bankalar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.Grd_Bankalar.DoubleClick += new System.EventHandler(this.Grd_Bankalar_DoubleClick);
            // 
            // groupControl1
            // 
            this.groupControl1.AutoSize = true;
            this.groupControl1.CaptionImageOptions.SvgImage = global::StokTakipProjesi.Properties.Resources.financial;
            this.groupControl1.Controls.Add(this.dt_B_Tarih);
            this.groupControl1.Controls.Add(this.Lue_B_HesapTur);
            this.groupControl1.Controls.Add(this.Lue_B_BankaAdi);
            this.groupControl1.Controls.Add(this.Mtx_B_HesapNo);
            this.groupControl1.Controls.Add(this.Mtx_B_Iban);
            this.groupControl1.Controls.Add(this.Lue_B_ilce);
            this.groupControl1.Controls.Add(this.Lue_B_il);
            this.groupControl1.Controls.Add(this.bt_P_Guncelle);
            this.groupControl1.Controls.Add(this.bt_P_Sil);
            this.groupControl1.Controls.Add(this.bt_B_Ekle);
            this.groupControl1.Controls.Add(this.Lue_B_Musteri);
            this.groupControl1.Controls.Add(this.labelControl12);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.tx_B_YetkiliSoyad);
            this.groupControl1.Controls.Add(this.tx_B_Sube);
            this.groupControl1.Controls.Add(this.labelControl15);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.tx_B_YetkiliAd);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.tx_B_ID);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(474, 868);
            this.groupControl1.TabIndex = 19;
            this.groupControl1.Text = "BANKALAR";
            // 
            // dt_B_Tarih
            // 
            this.dt_B_Tarih.CalendarForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dt_B_Tarih.CalendarMonthBackground = System.Drawing.Color.Gray;
            this.dt_B_Tarih.CalendarTitleBackColor = System.Drawing.Color.DimGray;
            this.dt_B_Tarih.CalendarTitleForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dt_B_Tarih.CalendarTrailingForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dt_B_Tarih.Cursor = System.Windows.Forms.Cursors.Default;
            this.dt_B_Tarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_B_Tarih.Location = new System.Drawing.Point(120, 447);
            this.dt_B_Tarih.Name = "dt_B_Tarih";
            this.dt_B_Tarih.Size = new System.Drawing.Size(313, 26);
            this.dt_B_Tarih.TabIndex = 77;
            // 
            // Lue_B_HesapTur
            // 
            this.Lue_B_HesapTur.Location = new System.Drawing.Point(120, 488);
            this.Lue_B_HesapTur.Name = "Lue_B_HesapTur";
            this.Lue_B_HesapTur.Properties.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lue_B_HesapTur.Properties.Appearance.Options.UseFont = true;
            this.Lue_B_HesapTur.Properties.AutoHeight = false;
            this.Lue_B_HesapTur.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Lue_B_HesapTur.Properties.DropDownItemHeight = 40;
            this.Lue_B_HesapTur.Properties.NullText = "Bir Hesap Türü Seçiniz...";
            this.Lue_B_HesapTur.Size = new System.Drawing.Size(313, 26);
            this.Lue_B_HesapTur.TabIndex = 57;
            // 
            // Lue_B_BankaAdi
            // 
            this.Lue_B_BankaAdi.Location = new System.Drawing.Point(120, 135);
            this.Lue_B_BankaAdi.Name = "Lue_B_BankaAdi";
            this.Lue_B_BankaAdi.Properties.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lue_B_BankaAdi.Properties.Appearance.Options.UseFont = true;
            this.Lue_B_BankaAdi.Properties.AutoHeight = false;
            this.Lue_B_BankaAdi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Lue_B_BankaAdi.Properties.DropDownItemHeight = 40;
            this.Lue_B_BankaAdi.Properties.NullText = "Bir Banka Seçiniz...";
            this.Lue_B_BankaAdi.Size = new System.Drawing.Size(313, 26);
            this.Lue_B_BankaAdi.TabIndex = 56;
            // 
            // Mtx_B_HesapNo
            // 
            this.Mtx_B_HesapNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.Mtx_B_HesapNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Mtx_B_HesapNo.Location = new System.Drawing.Point(120, 329);
            this.Mtx_B_HesapNo.Mask = "0000-0000-0000-0000";
            this.Mtx_B_HesapNo.Name = "Mtx_B_HesapNo";
            this.Mtx_B_HesapNo.Size = new System.Drawing.Size(313, 26);
            this.Mtx_B_HesapNo.TabIndex = 55;
            // 
            // Mtx_B_Iban
            // 
            this.Mtx_B_Iban.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.Mtx_B_Iban.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Mtx_B_Iban.Location = new System.Drawing.Point(120, 286);
            this.Mtx_B_Iban.Mask = "TR00-0000-0000-0000-0000-0000-00";
            this.Mtx_B_Iban.Name = "Mtx_B_Iban";
            this.Mtx_B_Iban.Size = new System.Drawing.Size(313, 26);
            this.Mtx_B_Iban.TabIndex = 54;
            // 
            // Lue_B_ilce
            // 
            this.Lue_B_ilce.Location = new System.Drawing.Point(120, 212);
            this.Lue_B_ilce.Name = "Lue_B_ilce";
            this.Lue_B_ilce.Properties.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lue_B_ilce.Properties.Appearance.Options.UseFont = true;
            this.Lue_B_ilce.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Lue_B_ilce.Properties.DropDownItemHeight = 40;
            this.Lue_B_ilce.Properties.NullText = "Bir İlçe Seçiniz...";
            this.Lue_B_ilce.Size = new System.Drawing.Size(313, 26);
            this.Lue_B_ilce.TabIndex = 53;
            // 
            // Lue_B_il
            // 
            this.Lue_B_il.Location = new System.Drawing.Point(120, 172);
            this.Lue_B_il.Name = "Lue_B_il";
            this.Lue_B_il.Properties.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lue_B_il.Properties.Appearance.Options.UseFont = true;
            this.Lue_B_il.Properties.AutoHeight = false;
            this.Lue_B_il.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Lue_B_il.Properties.DropDownItemHeight = 40;
            this.Lue_B_il.Properties.NullText = "Bir İl Seçiniz...";
            this.Lue_B_il.Size = new System.Drawing.Size(313, 26);
            this.Lue_B_il.TabIndex = 52;
            this.Lue_B_il.EditValueChanged += new System.EventHandler(this.Lue_B_il_EditValueChanged);
            // 
            // bt_P_Guncelle
            // 
            this.bt_P_Guncelle.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_P_Guncelle.Appearance.Options.UseFont = true;
            this.bt_P_Guncelle.ImageOptions.Image = global::StokTakipProjesi.Properties.Resources.refresh_32x32;
            this.bt_P_Guncelle.Location = new System.Drawing.Point(149, 700);
            this.bt_P_Guncelle.Name = "bt_P_Guncelle";
            this.bt_P_Guncelle.Size = new System.Drawing.Size(175, 53);
            this.bt_P_Guncelle.TabIndex = 50;
            this.bt_P_Guncelle.Text = "Güncelle";
            this.bt_P_Guncelle.Click += new System.EventHandler(this.bt_P_Guncelle_Click);
            // 
            // bt_P_Sil
            // 
            this.bt_P_Sil.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_P_Sil.Appearance.Options.UseFont = true;
            this.bt_P_Sil.ImageOptions.Image = global::StokTakipProjesi.Properties.Resources.cancel_32x32;
            this.bt_P_Sil.Location = new System.Drawing.Point(149, 641);
            this.bt_P_Sil.Name = "bt_P_Sil";
            this.bt_P_Sil.Size = new System.Drawing.Size(175, 53);
            this.bt_P_Sil.TabIndex = 49;
            this.bt_P_Sil.Text = "Sil";
            this.bt_P_Sil.Click += new System.EventHandler(this.bt_P_Sil_Click);
            // 
            // bt_B_Ekle
            // 
            this.bt_B_Ekle.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_B_Ekle.Appearance.Options.UseFont = true;
            this.bt_B_Ekle.ImageOptions.Image = global::StokTakipProjesi.Properties.Resources.add_32x322;
            this.bt_B_Ekle.Location = new System.Drawing.Point(149, 582);
            this.bt_B_Ekle.Name = "bt_B_Ekle";
            this.bt_B_Ekle.Size = new System.Drawing.Size(175, 53);
            this.bt_B_Ekle.TabIndex = 48;
            this.bt_B_Ekle.Text = "Ekle";
            this.bt_B_Ekle.Click += new System.EventHandler(this.bt_B_Ekle_Click);
            // 
            // Lue_B_Musteri
            // 
            this.Lue_B_Musteri.Location = new System.Drawing.Point(120, 530);
            this.Lue_B_Musteri.Name = "Lue_B_Musteri";
            this.Lue_B_Musteri.Properties.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lue_B_Musteri.Properties.Appearance.Options.UseFont = true;
            this.Lue_B_Musteri.Properties.AutoHeight = false;
            this.Lue_B_Musteri.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Lue_B_Musteri.Properties.DropDownItemHeight = 40;
            this.Lue_B_Musteri.Properties.NullText = "Bir Müşteri Seçiniz...";
            this.Lue_B_Musteri.Size = new System.Drawing.Size(313, 26);
            this.Lue_B_Musteri.TabIndex = 12;
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(48, 533);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(66, 19);
            this.labelControl12.TabIndex = 47;
            this.labelControl12.Text = "Müşteri :";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(27, 491);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(87, 19);
            this.labelControl10.TabIndex = 45;
            this.labelControl10.Text = "Hesap Tur :";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(66, 453);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(48, 19);
            this.labelControl4.TabIndex = 43;
            this.labelControl4.Text = "Tarih :";
            // 
            // tx_B_YetkiliSoyad
            // 
            this.tx_B_YetkiliSoyad.Location = new System.Drawing.Point(120, 413);
            this.tx_B_YetkiliSoyad.Name = "tx_B_YetkiliSoyad";
            this.tx_B_YetkiliSoyad.Properties.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_B_YetkiliSoyad.Properties.Appearance.Options.UseFont = true;
            this.tx_B_YetkiliSoyad.Size = new System.Drawing.Size(313, 26);
            this.tx_B_YetkiliSoyad.TabIndex = 9;
            // 
            // tx_B_Sube
            // 
            this.tx_B_Sube.Location = new System.Drawing.Point(120, 248);
            this.tx_B_Sube.Name = "tx_B_Sube";
            this.tx_B_Sube.Properties.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_B_Sube.Properties.Appearance.Options.UseFont = true;
            this.tx_B_Sube.Size = new System.Drawing.Size(313, 26);
            this.tx_B_Sube.TabIndex = 5;
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl15.Appearance.Options.UseFont = true;
            this.labelControl15.Location = new System.Drawing.Point(65, 251);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(49, 19);
            this.labelControl15.TabIndex = 41;
            this.labelControl15.Text = "Şube :";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(27, 138);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(85, 19);
            this.labelControl7.TabIndex = 31;
            this.labelControl7.Text = "Banka Adı :";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(8, 416);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(106, 19);
            this.labelControl6.TabIndex = 29;
            this.labelControl6.Text = "Yetkili Soyad :";
            // 
            // tx_B_YetkiliAd
            // 
            this.tx_B_YetkiliAd.Location = new System.Drawing.Point(120, 370);
            this.tx_B_YetkiliAd.Name = "tx_B_YetkiliAd";
            this.tx_B_YetkiliAd.Properties.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_B_YetkiliAd.Properties.Appearance.Options.UseFont = true;
            this.tx_B_YetkiliAd.Size = new System.Drawing.Size(313, 26);
            this.tx_B_YetkiliAd.TabIndex = 8;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(36, 373);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(78, 19);
            this.labelControl2.TabIndex = 25;
            this.labelControl2.Text = "Yetkili Ad :";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(77, 215);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(37, 19);
            this.labelControl9.TabIndex = 16;
            this.labelControl9.Text = "İlçe :";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(66, 289);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(48, 19);
            this.labelControl8.TabIndex = 14;
            this.labelControl8.Text = "IBAN :";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(94, 175);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(20, 19);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "İl :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(30, 331);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(84, 19);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Hesap No :";
            // 
            // tx_B_ID
            // 
            this.tx_B_ID.Location = new System.Drawing.Point(120, 92);
            this.tx_B_ID.Name = "tx_B_ID";
            this.tx_B_ID.Properties.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_B_ID.Properties.Appearance.Options.UseFont = true;
            this.tx_B_ID.Size = new System.Drawing.Size(313, 26);
            this.tx_B_ID.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(86, 95);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(28, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID :";
            // 
            // Bankalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1934, 868);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.Grd_Bankalar);
            this.Name = "Bankalar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BANKALAR";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Bankalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Bankalar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Lue_B_HesapTur.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lue_B_BankaAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lue_B_ilce.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lue_B_il.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lue_B_Musteri.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_B_YetkiliSoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_B_Sube.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_B_YetkiliAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_B_ID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl Grd_Bankalar;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LookUpEdit Lue_B_ilce;
        private DevExpress.XtraEditors.LookUpEdit Lue_B_il;
        private DevExpress.XtraEditors.SimpleButton bt_P_Guncelle;
        private DevExpress.XtraEditors.SimpleButton bt_P_Sil;
        private DevExpress.XtraEditors.SimpleButton bt_B_Ekle;
        private DevExpress.XtraEditors.LookUpEdit Lue_B_Musteri;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit tx_B_YetkiliSoyad;
        private DevExpress.XtraEditors.TextEdit tx_B_Sube;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit tx_B_YetkiliAd;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit tx_B_ID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.MaskedTextBox Mtx_B_Iban;
        private DevExpress.XtraEditors.LookUpEdit Lue_B_BankaAdi;
        private System.Windows.Forms.MaskedTextBox Mtx_B_HesapNo;
        private DevExpress.XtraEditors.LookUpEdit Lue_B_HesapTur;
        private System.Windows.Forms.DateTimePicker dt_B_Tarih;
    }
}