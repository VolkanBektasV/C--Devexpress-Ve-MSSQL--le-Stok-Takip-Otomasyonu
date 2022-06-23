
namespace StokTakipProjesi
{
    partial class Personeller
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
            this.Grd_Personeller = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.tx_P_Yas = new System.Windows.Forms.MaskedTextBox();
            this.tx_P_TC = new System.Windows.Forms.MaskedTextBox();
            this.dt_P_isegiris = new System.Windows.Forms.DateTimePicker();
            this.Lue_P_Cinsiyet = new DevExpress.XtraEditors.LookUpEdit();
            this.Lue_P_ilce = new DevExpress.XtraEditors.LookUpEdit();
            this.Lue_P_il = new DevExpress.XtraEditors.LookUpEdit();
            this.Lue_P_Gorev = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.Lue_P_Birim = new DevExpress.XtraEditors.LookUpEdit();
            this.tx_P_Maas = new DevExpress.XtraEditors.TextEdit();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.tx_P_MailAdres = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.Mtx_P_Telefon = new System.Windows.Forms.MaskedTextBox();
            this.tx_P_Soyad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.Rtx_P_AcikAdres = new System.Windows.Forms.RichTextBox();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.tx_P_Ad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.tx_P_ID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.bt_P_Guncelle = new DevExpress.XtraEditors.SimpleButton();
            this.bt_P_Sil = new DevExpress.XtraEditors.SimpleButton();
            this.bt_P_Ekle = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Personeller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Lue_P_Cinsiyet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lue_P_ilce.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lue_P_il.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lue_P_Gorev.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lue_P_Birim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_P_Maas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_P_MailAdres.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_P_Soyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_P_Ad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_P_ID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // Grd_Personeller
            // 
            this.Grd_Personeller.Dock = System.Windows.Forms.DockStyle.Right;
            this.Grd_Personeller.Location = new System.Drawing.Point(528, 0);
            this.Grd_Personeller.MainView = this.gridView1;
            this.Grd_Personeller.Name = "Grd_Personeller";
            this.Grd_Personeller.Size = new System.Drawing.Size(1406, 868);
            this.Grd_Personeller.TabIndex = 2;
            this.Grd_Personeller.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.Grd_Personeller.DoubleClick += new System.EventHandler(this.Grd_Personeller_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.Grd_Personeller;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // groupControl1
            // 
            this.groupControl1.AutoSize = true;
            this.groupControl1.CaptionImageOptions.SvgImage = global::StokTakipProjesi.Properties.Resources.bo_position1;
            this.groupControl1.Controls.Add(this.tx_P_Yas);
            this.groupControl1.Controls.Add(this.tx_P_TC);
            this.groupControl1.Controls.Add(this.dt_P_isegiris);
            this.groupControl1.Controls.Add(this.Lue_P_Cinsiyet);
            this.groupControl1.Controls.Add(this.Lue_P_ilce);
            this.groupControl1.Controls.Add(this.Lue_P_il);
            this.groupControl1.Controls.Add(this.Lue_P_Gorev);
            this.groupControl1.Controls.Add(this.labelControl16);
            this.groupControl1.Controls.Add(this.Lue_P_Birim);
            this.groupControl1.Controls.Add(this.tx_P_Maas);
            this.groupControl1.Controls.Add(this.labelControl15);
            this.groupControl1.Controls.Add(this.labelControl14);
            this.groupControl1.Controls.Add(this.labelControl12);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.tx_P_MailAdres);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.Mtx_P_Telefon);
            this.groupControl1.Controls.Add(this.tx_P_Soyad);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.Rtx_P_AcikAdres);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.tx_P_Ad);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.tx_P_ID);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.bt_P_Guncelle);
            this.groupControl1.Controls.Add(this.bt_P_Sil);
            this.groupControl1.Controls.Add(this.bt_P_Ekle);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(528, 868);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "PERSONELLER";
            // 
            // tx_P_Yas
            // 
            this.tx_P_Yas.Location = new System.Drawing.Point(143, 262);
            this.tx_P_Yas.Mask = "00";
            this.tx_P_Yas.Name = "tx_P_Yas";
            this.tx_P_Yas.Size = new System.Drawing.Size(207, 26);
            this.tx_P_Yas.TabIndex = 79;
            // 
            // tx_P_TC
            // 
            this.tx_P_TC.Location = new System.Drawing.Point(143, 97);
            this.tx_P_TC.Mask = "00000000000";
            this.tx_P_TC.Name = "tx_P_TC";
            this.tx_P_TC.Size = new System.Drawing.Size(207, 26);
            this.tx_P_TC.TabIndex = 78;
            // 
            // dt_P_isegiris
            // 
            this.dt_P_isegiris.CalendarForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dt_P_isegiris.CalendarMonthBackground = System.Drawing.Color.Gray;
            this.dt_P_isegiris.CalendarTitleBackColor = System.Drawing.Color.DimGray;
            this.dt_P_isegiris.CalendarTitleForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dt_P_isegiris.CalendarTrailingForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dt_P_isegiris.Cursor = System.Windows.Forms.Cursors.Default;
            this.dt_P_isegiris.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_P_isegiris.Location = new System.Drawing.Point(143, 419);
            this.dt_P_isegiris.Name = "dt_P_isegiris";
            this.dt_P_isegiris.Size = new System.Drawing.Size(207, 26);
            this.dt_P_isegiris.TabIndex = 76;
            // 
            // Lue_P_Cinsiyet
            // 
            this.Lue_P_Cinsiyet.Location = new System.Drawing.Point(143, 218);
            this.Lue_P_Cinsiyet.Name = "Lue_P_Cinsiyet";
            this.Lue_P_Cinsiyet.Properties.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lue_P_Cinsiyet.Properties.Appearance.Options.UseFont = true;
            this.Lue_P_Cinsiyet.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Lue_P_Cinsiyet.Properties.NullText = "Cinsiyet Seçiniz...";
            this.Lue_P_Cinsiyet.Size = new System.Drawing.Size(207, 26);
            this.Lue_P_Cinsiyet.TabIndex = 5;
            // 
            // Lue_P_ilce
            // 
            this.Lue_P_ilce.Location = new System.Drawing.Point(143, 381);
            this.Lue_P_ilce.Name = "Lue_P_ilce";
            this.Lue_P_ilce.Properties.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lue_P_ilce.Properties.Appearance.Options.UseFont = true;
            this.Lue_P_ilce.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Lue_P_ilce.Properties.DropDownItemHeight = 40;
            this.Lue_P_ilce.Properties.NullText = "Bir İlçe Seçiniz...";
            this.Lue_P_ilce.Size = new System.Drawing.Size(207, 26);
            this.Lue_P_ilce.TabIndex = 9;
            // 
            // Lue_P_il
            // 
            this.Lue_P_il.Location = new System.Drawing.Point(143, 341);
            this.Lue_P_il.Name = "Lue_P_il";
            this.Lue_P_il.Properties.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lue_P_il.Properties.Appearance.Options.UseFont = true;
            this.Lue_P_il.Properties.AutoHeight = false;
            this.Lue_P_il.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Lue_P_il.Properties.DropDownItemHeight = 40;
            this.Lue_P_il.Properties.NullText = "Bir İl Seçiniz...";
            this.Lue_P_il.Size = new System.Drawing.Size(207, 26);
            this.Lue_P_il.TabIndex = 8;
            this.Lue_P_il.EditValueChanged += new System.EventHandler(this.Lue_P_il_EditValueChanged);
            // 
            // Lue_P_Gorev
            // 
            this.Lue_P_Gorev.Location = new System.Drawing.Point(143, 498);
            this.Lue_P_Gorev.Name = "Lue_P_Gorev";
            this.Lue_P_Gorev.Properties.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lue_P_Gorev.Properties.Appearance.Options.UseFont = true;
            this.Lue_P_Gorev.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Lue_P_Gorev.Properties.NullText = "Görev Seçiniz...";
            this.Lue_P_Gorev.Size = new System.Drawing.Size(207, 26);
            this.Lue_P_Gorev.TabIndex = 13;
            // 
            // labelControl16
            // 
            this.labelControl16.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl16.Appearance.Options.UseFont = true;
            this.labelControl16.Location = new System.Drawing.Point(81, 501);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(58, 19);
            this.labelControl16.TabIndex = 74;
            this.labelControl16.Text = "Görev :";
            // 
            // Lue_P_Birim
            // 
            this.Lue_P_Birim.Location = new System.Drawing.Point(143, 458);
            this.Lue_P_Birim.Name = "Lue_P_Birim";
            this.Lue_P_Birim.Properties.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lue_P_Birim.Properties.Appearance.Options.UseFont = true;
            this.Lue_P_Birim.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Lue_P_Birim.Properties.NullText = "Birim Seçiniz...";
            this.Lue_P_Birim.Size = new System.Drawing.Size(207, 26);
            this.Lue_P_Birim.TabIndex = 12;
            // 
            // tx_P_Maas
            // 
            this.tx_P_Maas.Location = new System.Drawing.Point(143, 580);
            this.tx_P_Maas.Name = "tx_P_Maas";
            this.tx_P_Maas.Properties.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_P_Maas.Properties.Appearance.Options.UseFont = true;
            this.tx_P_Maas.Size = new System.Drawing.Size(207, 26);
            this.tx_P_Maas.TabIndex = 15;
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl15.Appearance.Options.UseFont = true;
            this.labelControl15.Location = new System.Drawing.Point(88, 583);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(51, 19);
            this.labelControl15.TabIndex = 72;
            this.labelControl15.Text = "Maaş :";
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl14.Appearance.Options.UseFont = true;
            this.labelControl14.Location = new System.Drawing.Point(90, 461);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(49, 19);
            this.labelControl14.TabIndex = 70;
            this.labelControl14.Text = "Birim :";
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(35, 425);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(104, 19);
            this.labelControl12.TabIndex = 68;
            this.labelControl12.Text = "İşe Alış Tarih :";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(101, 265);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(38, 19);
            this.labelControl10.TabIndex = 67;
            this.labelControl10.Text = "Yaş :";
            // 
            // tx_P_MailAdres
            // 
            this.tx_P_MailAdres.Location = new System.Drawing.Point(143, 303);
            this.tx_P_MailAdres.Name = "tx_P_MailAdres";
            this.tx_P_MailAdres.Properties.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_P_MailAdres.Properties.Appearance.Options.UseFont = true;
            this.tx_P_MailAdres.Size = new System.Drawing.Size(207, 26);
            this.tx_P_MailAdres.TabIndex = 7;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(50, 306);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(87, 19);
            this.labelControl7.TabIndex = 66;
            this.labelControl7.Text = "Mail Adres :";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(69, 221);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(70, 19);
            this.labelControl6.TabIndex = 65;
            this.labelControl6.Text = "Cinsiyet :";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(73, 542);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(66, 19);
            this.labelControl4.TabIndex = 64;
            this.labelControl4.Text = "Telefon :";
            // 
            // Mtx_P_Telefon
            // 
            this.Mtx_P_Telefon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.Mtx_P_Telefon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Mtx_P_Telefon.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Mtx_P_Telefon.Location = new System.Drawing.Point(143, 539);
            this.Mtx_P_Telefon.Mask = "(999) 000-0000";
            this.Mtx_P_Telefon.Name = "Mtx_P_Telefon";
            this.Mtx_P_Telefon.Size = new System.Drawing.Size(207, 26);
            this.Mtx_P_Telefon.TabIndex = 14;
            // 
            // tx_P_Soyad
            // 
            this.tx_P_Soyad.Location = new System.Drawing.Point(143, 179);
            this.tx_P_Soyad.Name = "tx_P_Soyad";
            this.tx_P_Soyad.Properties.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_P_Soyad.Properties.Appearance.Options.UseFont = true;
            this.tx_P_Soyad.Size = new System.Drawing.Size(207, 26);
            this.tx_P_Soyad.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(80, 182);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(59, 19);
            this.labelControl2.TabIndex = 63;
            this.labelControl2.Text = "Soyad :";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(50, 619);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(89, 19);
            this.labelControl11.TabIndex = 62;
            this.labelControl11.Text = "Açık Adres :";
            // 
            // Rtx_P_AcikAdres
            // 
            this.Rtx_P_AcikAdres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.Rtx_P_AcikAdres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Rtx_P_AcikAdres.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Rtx_P_AcikAdres.Location = new System.Drawing.Point(143, 619);
            this.Rtx_P_AcikAdres.Name = "Rtx_P_AcikAdres";
            this.Rtx_P_AcikAdres.Size = new System.Drawing.Size(377, 158);
            this.Rtx_P_AcikAdres.TabIndex = 16;
            this.Rtx_P_AcikAdres.Text = "";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(102, 384);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(37, 19);
            this.labelControl9.TabIndex = 61;
            this.labelControl9.Text = "İlçe :";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(107, 100);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(32, 19);
            this.labelControl8.TabIndex = 60;
            this.labelControl8.Text = "TC :";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(119, 344);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(20, 19);
            this.labelControl5.TabIndex = 52;
            this.labelControl5.Text = "İl :";
            // 
            // tx_P_Ad
            // 
            this.tx_P_Ad.Location = new System.Drawing.Point(143, 138);
            this.tx_P_Ad.Name = "tx_P_Ad";
            this.tx_P_Ad.Properties.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_P_Ad.Properties.Appearance.Options.UseFont = true;
            this.tx_P_Ad.Size = new System.Drawing.Size(207, 26);
            this.tx_P_Ad.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(108, 141);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(31, 19);
            this.labelControl3.TabIndex = 47;
            this.labelControl3.Text = "Ad :";
            // 
            // tx_P_ID
            // 
            this.tx_P_ID.Enabled = false;
            this.tx_P_ID.Location = new System.Drawing.Point(143, 57);
            this.tx_P_ID.Name = "tx_P_ID";
            this.tx_P_ID.Properties.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_P_ID.Properties.Appearance.Options.UseFont = true;
            this.tx_P_ID.Size = new System.Drawing.Size(207, 26);
            this.tx_P_ID.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(111, 60);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(28, 19);
            this.labelControl1.TabIndex = 43;
            this.labelControl1.Text = "ID :";
            // 
            // bt_P_Guncelle
            // 
            this.bt_P_Guncelle.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_P_Guncelle.Appearance.Options.UseFont = true;
            this.bt_P_Guncelle.ImageOptions.Image = global::StokTakipProjesi.Properties.Resources.refresh_32x32;
            this.bt_P_Guncelle.Location = new System.Drawing.Point(370, 201);
            this.bt_P_Guncelle.Name = "bt_P_Guncelle";
            this.bt_P_Guncelle.Size = new System.Drawing.Size(137, 53);
            this.bt_P_Guncelle.TabIndex = 19;
            this.bt_P_Guncelle.Text = "Güncelle";
            this.bt_P_Guncelle.Click += new System.EventHandler(this.bt_P_Guncelle_Click);
            // 
            // bt_P_Sil
            // 
            this.bt_P_Sil.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_P_Sil.Appearance.Options.UseFont = true;
            this.bt_P_Sil.ImageOptions.Image = global::StokTakipProjesi.Properties.Resources.cancel_32x32;
            this.bt_P_Sil.Location = new System.Drawing.Point(370, 127);
            this.bt_P_Sil.Name = "bt_P_Sil";
            this.bt_P_Sil.Size = new System.Drawing.Size(137, 53);
            this.bt_P_Sil.TabIndex = 18;
            this.bt_P_Sil.Text = "Sil";
            this.bt_P_Sil.Click += new System.EventHandler(this.bt_P_Sil_Click);
            // 
            // bt_P_Ekle
            // 
            this.bt_P_Ekle.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_P_Ekle.Appearance.Options.UseFont = true;
            this.bt_P_Ekle.ImageOptions.Image = global::StokTakipProjesi.Properties.Resources.add_32x322;
            this.bt_P_Ekle.Location = new System.Drawing.Point(370, 57);
            this.bt_P_Ekle.Name = "bt_P_Ekle";
            this.bt_P_Ekle.Size = new System.Drawing.Size(137, 53);
            this.bt_P_Ekle.TabIndex = 17;
            this.bt_P_Ekle.Text = "Ekle";
            this.bt_P_Ekle.Click += new System.EventHandler(this.bt_P_Ekle_Click);
            // 
            // Personeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1934, 868);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.Grd_Personeller);
            this.Name = "Personeller";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PERSONELLER";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Personeller_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Personeller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Lue_P_Cinsiyet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lue_P_ilce.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lue_P_il.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lue_P_Gorev.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lue_P_Birim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_P_Maas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_P_MailAdres.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_P_Soyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_P_Ad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_P_ID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl Grd_Personeller;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.MaskedTextBox tx_P_Yas;
        private System.Windows.Forms.MaskedTextBox tx_P_TC;
        private System.Windows.Forms.DateTimePicker dt_P_isegiris;
        private DevExpress.XtraEditors.LookUpEdit Lue_P_Cinsiyet;
        private DevExpress.XtraEditors.LookUpEdit Lue_P_ilce;
        private DevExpress.XtraEditors.LookUpEdit Lue_P_il;
        private DevExpress.XtraEditors.LookUpEdit Lue_P_Gorev;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.LookUpEdit Lue_P_Birim;
        private DevExpress.XtraEditors.TextEdit tx_P_Maas;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit tx_P_MailAdres;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.MaskedTextBox Mtx_P_Telefon;
        private DevExpress.XtraEditors.TextEdit tx_P_Soyad;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private System.Windows.Forms.RichTextBox Rtx_P_AcikAdres;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit tx_P_Ad;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit tx_P_ID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton bt_P_Guncelle;
        private DevExpress.XtraEditors.SimpleButton bt_P_Sil;
        private DevExpress.XtraEditors.SimpleButton bt_P_Ekle;
    }
}