
namespace StokTakipProjesi
{
    partial class Musteriler
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
            this.Grd_Musteriler = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.Lue_M_ilce = new DevExpress.XtraEditors.LookUpEdit();
            this.Lue_M_il = new DevExpress.XtraEditors.LookUpEdit();
            this.tx_M_MailAdres = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.Mtx_M_Telefon = new System.Windows.Forms.MaskedTextBox();
            this.tx_M_Soyad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.Rtx_M_AcikAdres = new System.Windows.Forms.RichTextBox();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.tx_M_TC = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.tx_M_Ad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.tx_M_ID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.bt_M_Guncelle = new DevExpress.XtraEditors.SimpleButton();
            this.bt_M_Sil = new DevExpress.XtraEditors.SimpleButton();
            this.bt_M_Ekle = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Musteriler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Lue_M_ilce.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lue_M_il.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_M_MailAdres.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_M_Soyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_M_TC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_M_Ad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_M_ID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // Grd_Musteriler
            // 
            this.Grd_Musteriler.Dock = System.Windows.Forms.DockStyle.Right;
            this.Grd_Musteriler.Location = new System.Drawing.Point(495, 0);
            this.Grd_Musteriler.MainView = this.gridView1;
            this.Grd_Musteriler.Name = "Grd_Musteriler";
            this.Grd_Musteriler.Size = new System.Drawing.Size(1435, 868);
            this.Grd_Musteriler.TabIndex = 1;
            this.Grd_Musteriler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.Grd_Musteriler.DoubleClick += new System.EventHandler(this.Grd_Musteriler_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.Grd_Musteriler;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // groupControl1
            // 
            this.groupControl1.AutoSize = true;
            this.groupControl1.CaptionImageOptions.SvgImage = global::StokTakipProjesi.Properties.Resources.employeequickwelcome1;
            this.groupControl1.Controls.Add(this.Lue_M_ilce);
            this.groupControl1.Controls.Add(this.Lue_M_il);
            this.groupControl1.Controls.Add(this.tx_M_MailAdres);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.Mtx_M_Telefon);
            this.groupControl1.Controls.Add(this.tx_M_Soyad);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.Rtx_M_AcikAdres);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.tx_M_TC);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.tx_M_Ad);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.tx_M_ID);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.bt_M_Guncelle);
            this.groupControl1.Controls.Add(this.bt_M_Sil);
            this.groupControl1.Controls.Add(this.bt_M_Ekle);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(495, 868);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "MÜŞTERİLER";
            // 
            // Lue_M_ilce
            // 
            this.Lue_M_ilce.Location = new System.Drawing.Point(108, 361);
            this.Lue_M_ilce.Name = "Lue_M_ilce";
            this.Lue_M_ilce.Properties.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lue_M_ilce.Properties.Appearance.Options.UseFont = true;
            this.Lue_M_ilce.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Lue_M_ilce.Properties.DropDownItemHeight = 40;
            this.Lue_M_ilce.Properties.NullText = "Bir İlçe Seçiniz...";
            this.Lue_M_ilce.Size = new System.Drawing.Size(207, 26);
            this.Lue_M_ilce.TabIndex = 65;
            // 
            // Lue_M_il
            // 
            this.Lue_M_il.Location = new System.Drawing.Point(108, 320);
            this.Lue_M_il.Name = "Lue_M_il";
            this.Lue_M_il.Properties.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lue_M_il.Properties.Appearance.Options.UseFont = true;
            this.Lue_M_il.Properties.AutoHeight = false;
            this.Lue_M_il.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Lue_M_il.Properties.DropDownItemHeight = 40;
            this.Lue_M_il.Properties.NullText = "Bir İl Seçiniz...";
            this.Lue_M_il.Size = new System.Drawing.Size(207, 26);
            this.Lue_M_il.TabIndex = 64;
            this.Lue_M_il.EditValueChanged += new System.EventHandler(this.Lue_D_il_EditValueChanged);
            // 
            // tx_M_MailAdres
            // 
            this.tx_M_MailAdres.Location = new System.Drawing.Point(108, 280);
            this.tx_M_MailAdres.Name = "tx_M_MailAdres";
            this.tx_M_MailAdres.Properties.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_M_MailAdres.Properties.Appearance.Options.UseFont = true;
            this.tx_M_MailAdres.Size = new System.Drawing.Size(207, 26);
            this.tx_M_MailAdres.TabIndex = 50;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(15, 283);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(87, 19);
            this.labelControl7.TabIndex = 63;
            this.labelControl7.Text = "Mail Adres :";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(36, 242);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(66, 19);
            this.labelControl4.TabIndex = 62;
            this.labelControl4.Text = "Telefon :";
            // 
            // Mtx_M_Telefon
            // 
            this.Mtx_M_Telefon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.Mtx_M_Telefon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Mtx_M_Telefon.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Mtx_M_Telefon.Location = new System.Drawing.Point(108, 239);
            this.Mtx_M_Telefon.Mask = "(999) 000-0000";
            this.Mtx_M_Telefon.Name = "Mtx_M_Telefon";
            this.Mtx_M_Telefon.Size = new System.Drawing.Size(207, 26);
            this.Mtx_M_Telefon.TabIndex = 49;
            // 
            // tx_M_Soyad
            // 
            this.tx_M_Soyad.Location = new System.Drawing.Point(108, 200);
            this.tx_M_Soyad.Name = "tx_M_Soyad";
            this.tx_M_Soyad.Properties.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_M_Soyad.Properties.Appearance.Options.UseFont = true;
            this.tx_M_Soyad.Size = new System.Drawing.Size(207, 26);
            this.tx_M_Soyad.TabIndex = 48;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(43, 203);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(59, 19);
            this.labelControl2.TabIndex = 61;
            this.labelControl2.Text = "Soyad :";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(13, 403);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(89, 19);
            this.labelControl11.TabIndex = 60;
            this.labelControl11.Text = "Açık Adres :";
            // 
            // Rtx_M_AcikAdres
            // 
            this.Rtx_M_AcikAdres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.Rtx_M_AcikAdres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Rtx_M_AcikAdres.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Rtx_M_AcikAdres.Location = new System.Drawing.Point(108, 403);
            this.Rtx_M_AcikAdres.Name = "Rtx_M_AcikAdres";
            this.Rtx_M_AcikAdres.Size = new System.Drawing.Size(343, 158);
            this.Rtx_M_AcikAdres.TabIndex = 54;
            this.Rtx_M_AcikAdres.Text = "";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(65, 363);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(37, 19);
            this.labelControl9.TabIndex = 59;
            this.labelControl9.Text = "İlçe :";
            // 
            // tx_M_TC
            // 
            this.tx_M_TC.Location = new System.Drawing.Point(108, 118);
            this.tx_M_TC.Name = "tx_M_TC";
            this.tx_M_TC.Properties.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_M_TC.Properties.Appearance.Options.UseFont = true;
            this.tx_M_TC.Size = new System.Drawing.Size(207, 26);
            this.tx_M_TC.TabIndex = 45;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(70, 121);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(32, 19);
            this.labelControl8.TabIndex = 58;
            this.labelControl8.Text = "TC :";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(82, 323);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(20, 19);
            this.labelControl5.TabIndex = 52;
            this.labelControl5.Text = "İl :";
            // 
            // tx_M_Ad
            // 
            this.tx_M_Ad.Location = new System.Drawing.Point(108, 159);
            this.tx_M_Ad.Name = "tx_M_Ad";
            this.tx_M_Ad.Properties.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_M_Ad.Properties.Appearance.Options.UseFont = true;
            this.tx_M_Ad.Size = new System.Drawing.Size(207, 26);
            this.tx_M_Ad.TabIndex = 46;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(71, 162);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(31, 19);
            this.labelControl3.TabIndex = 47;
            this.labelControl3.Text = "Ad :";
            // 
            // tx_M_ID
            // 
            this.tx_M_ID.Enabled = false;
            this.tx_M_ID.Location = new System.Drawing.Point(108, 78);
            this.tx_M_ID.Name = "tx_M_ID";
            this.tx_M_ID.Properties.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_M_ID.Properties.Appearance.Options.UseFont = true;
            this.tx_M_ID.Size = new System.Drawing.Size(207, 26);
            this.tx_M_ID.TabIndex = 44;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(74, 81);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(28, 19);
            this.labelControl1.TabIndex = 43;
            this.labelControl1.Text = "ID :";
            // 
            // bt_M_Guncelle
            // 
            this.bt_M_Guncelle.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_M_Guncelle.Appearance.Options.UseFont = true;
            this.bt_M_Guncelle.ImageOptions.Image = global::StokTakipProjesi.Properties.Resources.refresh_32x32;
            this.bt_M_Guncelle.Location = new System.Drawing.Point(321, 206);
            this.bt_M_Guncelle.Name = "bt_M_Guncelle";
            this.bt_M_Guncelle.Size = new System.Drawing.Size(130, 53);
            this.bt_M_Guncelle.TabIndex = 42;
            this.bt_M_Guncelle.Text = "Güncelle";
            this.bt_M_Guncelle.Click += new System.EventHandler(this.bt_M_Guncelle_Click);
            // 
            // bt_M_Sil
            // 
            this.bt_M_Sil.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_M_Sil.Appearance.Options.UseFont = true;
            this.bt_M_Sil.ImageOptions.Image = global::StokTakipProjesi.Properties.Resources.cancel_32x32;
            this.bt_M_Sil.Location = new System.Drawing.Point(321, 144);
            this.bt_M_Sil.Name = "bt_M_Sil";
            this.bt_M_Sil.Size = new System.Drawing.Size(130, 53);
            this.bt_M_Sil.TabIndex = 41;
            this.bt_M_Sil.Text = "Sil";
            this.bt_M_Sil.Click += new System.EventHandler(this.bt_M_Sil_Click);
            // 
            // bt_M_Ekle
            // 
            this.bt_M_Ekle.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_M_Ekle.Appearance.Options.UseFont = true;
            this.bt_M_Ekle.ImageOptions.Image = global::StokTakipProjesi.Properties.Resources.add_32x322;
            this.bt_M_Ekle.Location = new System.Drawing.Point(321, 81);
            this.bt_M_Ekle.Name = "bt_M_Ekle";
            this.bt_M_Ekle.Size = new System.Drawing.Size(130, 53);
            this.bt_M_Ekle.TabIndex = 39;
            this.bt_M_Ekle.Text = "Ekle";
            this.bt_M_Ekle.Click += new System.EventHandler(this.bt_M_Ekle_Click);
            // 
            // Musteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1930, 868);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.Grd_Musteriler);
            this.Name = "Musteriler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MÜŞTERİLER";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Musteriler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Musteriler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Lue_M_ilce.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lue_M_il.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_M_MailAdres.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_M_Soyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_M_TC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_M_Ad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_M_ID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl Grd_Musteriler;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton bt_M_Guncelle;
        private DevExpress.XtraEditors.SimpleButton bt_M_Sil;
        private DevExpress.XtraEditors.SimpleButton bt_M_Ekle;
        private DevExpress.XtraEditors.TextEdit tx_M_MailAdres;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.MaskedTextBox Mtx_M_Telefon;
        private DevExpress.XtraEditors.TextEdit tx_M_Soyad;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private System.Windows.Forms.RichTextBox Rtx_M_AcikAdres;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit tx_M_TC;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit tx_M_Ad;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit tx_M_ID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit Lue_M_ilce;
        private DevExpress.XtraEditors.LookUpEdit Lue_M_il;
    }
}