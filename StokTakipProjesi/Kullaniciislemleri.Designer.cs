
namespace StokTakipProjesi
{
    partial class Kullaniciislemleri
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
            this.grd_Kullanici = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.bt_S_PersonelSec = new DevExpress.XtraEditors.SimpleButton();
            this.tx_PersonelAd = new DevExpress.XtraEditors.TextEdit();
            this.tx_PersonelBirim = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.bt_P_Guncelle = new DevExpress.XtraEditors.SimpleButton();
            this.bt_P_Sil = new DevExpress.XtraEditors.SimpleButton();
            this.bt_P_Ekle = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tx_PersonelSifre = new DevExpress.XtraEditors.TextEdit();
            this.tx_Personeltc = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Kullanici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tx_PersonelAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_PersonelBirim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_PersonelSifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_Personeltc.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grd_Kullanici
            // 
            this.grd_Kullanici.Dock = System.Windows.Forms.DockStyle.Right;
            this.grd_Kullanici.Location = new System.Drawing.Point(359, 0);
            this.grd_Kullanici.MainView = this.gridView1;
            this.grd_Kullanici.Name = "grd_Kullanici";
            this.grd_Kullanici.Size = new System.Drawing.Size(632, 508);
            this.grd_Kullanici.TabIndex = 0;
            this.grd_Kullanici.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.grd_Kullanici.DoubleClick += new System.EventHandler(this.grd_Kullanici_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grd_Kullanici;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImageOptions.SvgImage = global::StokTakipProjesi.Properties.Resources.bo_user1;
            this.groupControl1.Controls.Add(this.bt_S_PersonelSec);
            this.groupControl1.Controls.Add(this.tx_PersonelAd);
            this.groupControl1.Controls.Add(this.tx_PersonelBirim);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.bt_P_Guncelle);
            this.groupControl1.Controls.Add(this.bt_P_Sil);
            this.groupControl1.Controls.Add(this.bt_P_Ekle);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.tx_PersonelSifre);
            this.groupControl1.Controls.Add(this.tx_Personeltc);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(359, 508);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "KULLANICI İŞLEMLERİ";
            // 
            // bt_S_PersonelSec
            // 
            this.bt_S_PersonelSec.ImageOptions.Image = global::StokTakipProjesi.Properties.Resources.add_16x16;
            this.bt_S_PersonelSec.Location = new System.Drawing.Point(293, 53);
            this.bt_S_PersonelSec.Name = "bt_S_PersonelSec";
            this.bt_S_PersonelSec.Size = new System.Drawing.Size(60, 26);
            this.bt_S_PersonelSec.TabIndex = 26;
            this.bt_S_PersonelSec.Text = "Seç";
            this.bt_S_PersonelSec.Click += new System.EventHandler(this.bt_S_PersonelSec_Click);
            // 
            // tx_PersonelAd
            // 
            this.tx_PersonelAd.Enabled = false;
            this.tx_PersonelAd.Location = new System.Drawing.Point(127, 53);
            this.tx_PersonelAd.Name = "tx_PersonelAd";
            this.tx_PersonelAd.Size = new System.Drawing.Size(161, 26);
            this.tx_PersonelAd.TabIndex = 25;
            // 
            // tx_PersonelBirim
            // 
            this.tx_PersonelBirim.Enabled = false;
            this.tx_PersonelBirim.Location = new System.Drawing.Point(127, 177);
            this.tx_PersonelBirim.Name = "tx_PersonelBirim";
            this.tx_PersonelBirim.Size = new System.Drawing.Size(187, 26);
            this.tx_PersonelBirim.TabIndex = 24;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(46, 433);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(276, 19);
            this.labelControl5.TabIndex = 23;
            this.labelControl5.Text = "Kullanıcı Adınız TC\'niz Olacaktır...";
            // 
            // bt_P_Guncelle
            // 
            this.bt_P_Guncelle.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_P_Guncelle.Appearance.Options.UseFont = true;
            this.bt_P_Guncelle.ImageOptions.Image = global::StokTakipProjesi.Properties.Resources.refresh_32x32;
            this.bt_P_Guncelle.Location = new System.Drawing.Point(114, 289);
            this.bt_P_Guncelle.Name = "bt_P_Guncelle";
            this.bt_P_Guncelle.Size = new System.Drawing.Size(130, 42);
            this.bt_P_Guncelle.TabIndex = 22;
            this.bt_P_Guncelle.Text = "Güncelle";
            this.bt_P_Guncelle.Click += new System.EventHandler(this.bt_P_Guncelle_Click);
            // 
            // bt_P_Sil
            // 
            this.bt_P_Sil.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_P_Sil.Appearance.Options.UseFont = true;
            this.bt_P_Sil.ImageOptions.Image = global::StokTakipProjesi.Properties.Resources.cancel_32x32;
            this.bt_P_Sil.Location = new System.Drawing.Point(33, 222);
            this.bt_P_Sil.Name = "bt_P_Sil";
            this.bt_P_Sil.Size = new System.Drawing.Size(130, 42);
            this.bt_P_Sil.TabIndex = 21;
            this.bt_P_Sil.Text = "Sil";
            this.bt_P_Sil.Click += new System.EventHandler(this.bt_P_Sil_Click);
            // 
            // bt_P_Ekle
            // 
            this.bt_P_Ekle.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_P_Ekle.Appearance.Options.UseFont = true;
            this.bt_P_Ekle.ImageOptions.Image = global::StokTakipProjesi.Properties.Resources.add_32x322;
            this.bt_P_Ekle.Location = new System.Drawing.Point(184, 222);
            this.bt_P_Ekle.Name = "bt_P_Ekle";
            this.bt_P_Ekle.Size = new System.Drawing.Size(130, 42);
            this.bt_P_Ekle.TabIndex = 20;
            this.bt_P_Ekle.Text = "Ekle";
            this.bt_P_Ekle.Click += new System.EventHandler(this.bt_P_Ekle_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(7, 180);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(116, 19);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Personel Yetki :";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(8, 139);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(113, 19);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Personel Şifre :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(23, 97);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(100, 19);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Personel TC :";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(46, 56);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(75, 19);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Personel :";
            // 
            // tx_PersonelSifre
            // 
            this.tx_PersonelSifre.Location = new System.Drawing.Point(127, 136);
            this.tx_PersonelSifre.Name = "tx_PersonelSifre";
            this.tx_PersonelSifre.Properties.UseSystemPasswordChar = true;
            this.tx_PersonelSifre.Size = new System.Drawing.Size(187, 26);
            this.tx_PersonelSifre.TabIndex = 3;
            // 
            // tx_Personeltc
            // 
            this.tx_Personeltc.Enabled = false;
            this.tx_Personeltc.Location = new System.Drawing.Point(127, 94);
            this.tx_Personeltc.Name = "tx_Personeltc";
            this.tx_Personeltc.Size = new System.Drawing.Size(187, 26);
            this.tx_Personeltc.TabIndex = 1;
            // 
            // Kullaniciislemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 508);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.grd_Kullanici);
            this.Name = "Kullaniciislemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KULLANICI İŞLEMLERİ";
            this.Load += new System.EventHandler(this.Kullaniciislemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_Kullanici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tx_PersonelAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_PersonelBirim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_PersonelSifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_Personeltc.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grd_Kullanici;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit tx_PersonelSifre;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton bt_P_Guncelle;
        private DevExpress.XtraEditors.SimpleButton bt_P_Sil;
        private DevExpress.XtraEditors.SimpleButton bt_P_Ekle;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton bt_S_PersonelSec;
        public DevExpress.XtraEditors.TextEdit tx_Personeltc;
        public DevExpress.XtraEditors.TextEdit tx_PersonelBirim;
        public DevExpress.XtraEditors.TextEdit tx_PersonelAd;
    }
}