
namespace StokTakipProjesi
{
    partial class Urunler
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
            this.Grd_Urunler = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tx_Urn_ID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.tx_Urn_Kod = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.Rtx_Urn_Aciklama = new System.Windows.Forms.RichTextBox();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.bt_Urn_Ekle = new DevExpress.XtraEditors.SimpleButton();
            this.bt_Urn_Sil = new DevExpress.XtraEditors.SimpleButton();
            this.bt_Urn_Guncelle = new DevExpress.XtraEditors.SimpleButton();
            this.Lue_Urn_Kategori1 = new DevExpress.XtraEditors.LookUpEdit();
            this.Lue_Urn_Kategori2 = new DevExpress.XtraEditors.LookUpEdit();
            this.Lue_Urn_Kategori3 = new DevExpress.XtraEditors.LookUpEdit();
            this.Lue_Urn_Marka = new DevExpress.XtraEditors.LookUpEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.bt_U_KodDegis = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Urunler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_Urn_ID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_Urn_Kod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lue_Urn_Kategori1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lue_Urn_Kategori2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lue_Urn_Kategori3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lue_Urn_Marka.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grd_Urunler
            // 
            this.Grd_Urunler.Dock = System.Windows.Forms.DockStyle.Right;
            this.Grd_Urunler.Location = new System.Drawing.Point(592, 0);
            this.Grd_Urunler.MainView = this.gridView1;
            this.Grd_Urunler.Name = "Grd_Urunler";
            this.Grd_Urunler.Size = new System.Drawing.Size(1338, 867);
            this.Grd_Urunler.TabIndex = 0;
            this.Grd_Urunler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.Grd_Urunler.DoubleClick += new System.EventHandler(this.Grd_Urunler_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.Grd_Urunler;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(76, 134);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(28, 19);
            this.labelControl1.TabIndex = 22;
            this.labelControl1.Text = "ID :";
            // 
            // tx_Urn_ID
            // 
            this.tx_Urn_ID.Enabled = false;
            this.tx_Urn_ID.Location = new System.Drawing.Point(110, 131);
            this.tx_Urn_ID.Name = "tx_Urn_ID";
            this.tx_Urn_ID.Properties.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_Urn_ID.Properties.Appearance.Options.UseFont = true;
            this.tx_Urn_ID.Size = new System.Drawing.Size(207, 26);
            this.tx_Urn_ID.TabIndex = 23;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(46, 174);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(58, 19);
            this.labelControl2.TabIndex = 25;
            this.labelControl2.Text = "Marka :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(59, 213);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(41, 19);
            this.labelControl3.TabIndex = 29;
            this.labelControl3.Text = "Kod :";
            // 
            // tx_Urn_Kod
            // 
            this.tx_Urn_Kod.Location = new System.Drawing.Point(110, 210);
            this.tx_Urn_Kod.Name = "tx_Urn_Kod";
            this.tx_Urn_Kod.Properties.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_Urn_Kod.Properties.Appearance.Options.UseFont = true;
            this.tx_Urn_Kod.Size = new System.Drawing.Size(163, 26);
            this.tx_Urn_Kod.TabIndex = 26;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(15, 250);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(89, 19);
            this.labelControl5.TabIndex = 35;
            this.labelControl5.Text = "Kategori 1 :";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(15, 329);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(89, 19);
            this.labelControl7.TabIndex = 40;
            this.labelControl7.Text = "Kategori 3 :";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(15, 289);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(89, 19);
            this.labelControl9.TabIndex = 44;
            this.labelControl9.Text = "Kategori 2 :";
            // 
            // Rtx_Urn_Aciklama
            // 
            this.Rtx_Urn_Aciklama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.Rtx_Urn_Aciklama.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Rtx_Urn_Aciklama.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Rtx_Urn_Aciklama.Location = new System.Drawing.Point(110, 372);
            this.Rtx_Urn_Aciklama.Name = "Rtx_Urn_Aciklama";
            this.Rtx_Urn_Aciklama.Size = new System.Drawing.Size(423, 158);
            this.Rtx_Urn_Aciklama.TabIndex = 38;
            this.Rtx_Urn_Aciklama.Text = "";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(26, 372);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(78, 19);
            this.labelControl11.TabIndex = 46;
            this.labelControl11.Text = "Açıklama :";
            // 
            // bt_Urn_Ekle
            // 
            this.bt_Urn_Ekle.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_Urn_Ekle.Appearance.Options.UseFont = true;
            this.bt_Urn_Ekle.ImageOptions.Image = global::StokTakipProjesi.Properties.Resources.add_32x322;
            this.bt_Urn_Ekle.Location = new System.Drawing.Point(358, 134);
            this.bt_Urn_Ekle.Name = "bt_Urn_Ekle";
            this.bt_Urn_Ekle.Size = new System.Drawing.Size(175, 53);
            this.bt_Urn_Ekle.TabIndex = 39;
            this.bt_Urn_Ekle.Text = "Ekle";
            this.bt_Urn_Ekle.Click += new System.EventHandler(this.bt_Urn_Ekle_Click);
            // 
            // bt_Urn_Sil
            // 
            this.bt_Urn_Sil.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_Urn_Sil.Appearance.Options.UseFont = true;
            this.bt_Urn_Sil.ImageOptions.Image = global::StokTakipProjesi.Properties.Resources.cancel_32x32;
            this.bt_Urn_Sil.Location = new System.Drawing.Point(358, 220);
            this.bt_Urn_Sil.Name = "bt_Urn_Sil";
            this.bt_Urn_Sil.Size = new System.Drawing.Size(175, 53);
            this.bt_Urn_Sil.TabIndex = 41;
            this.bt_Urn_Sil.Text = "Sil";
            this.bt_Urn_Sil.Click += new System.EventHandler(this.bt_Urn_Sil_Click);
            // 
            // bt_Urn_Guncelle
            // 
            this.bt_Urn_Guncelle.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_Urn_Guncelle.Appearance.Options.UseFont = true;
            this.bt_Urn_Guncelle.ImageOptions.Image = global::StokTakipProjesi.Properties.Resources.refresh_32x32;
            this.bt_Urn_Guncelle.Location = new System.Drawing.Point(358, 306);
            this.bt_Urn_Guncelle.Name = "bt_Urn_Guncelle";
            this.bt_Urn_Guncelle.Size = new System.Drawing.Size(175, 53);
            this.bt_Urn_Guncelle.TabIndex = 42;
            this.bt_Urn_Guncelle.Text = "Güncelle";
            this.bt_Urn_Guncelle.Click += new System.EventHandler(this.bt_Urn_Guncelle_Click);
            // 
            // Lue_Urn_Kategori1
            // 
            this.Lue_Urn_Kategori1.Location = new System.Drawing.Point(110, 247);
            this.Lue_Urn_Kategori1.Name = "Lue_Urn_Kategori1";
            this.Lue_Urn_Kategori1.Properties.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lue_Urn_Kategori1.Properties.Appearance.Options.UseFont = true;
            this.Lue_Urn_Kategori1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Lue_Urn_Kategori1.Properties.NullText = "1.Kategori Seçiniz...";
            this.Lue_Urn_Kategori1.Size = new System.Drawing.Size(207, 26);
            this.Lue_Urn_Kategori1.TabIndex = 30;
            this.Lue_Urn_Kategori1.EditValueChanged += new System.EventHandler(this.Lue_Urn_Kategori1_EditValueChanged);
            // 
            // Lue_Urn_Kategori2
            // 
            this.Lue_Urn_Kategori2.Location = new System.Drawing.Point(110, 287);
            this.Lue_Urn_Kategori2.Name = "Lue_Urn_Kategori2";
            this.Lue_Urn_Kategori2.Properties.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lue_Urn_Kategori2.Properties.Appearance.Options.UseFont = true;
            this.Lue_Urn_Kategori2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Lue_Urn_Kategori2.Properties.NullText = "2.Kategori Seçiniz...";
            this.Lue_Urn_Kategori2.Size = new System.Drawing.Size(207, 26);
            this.Lue_Urn_Kategori2.TabIndex = 31;
            this.Lue_Urn_Kategori2.EditValueChanged += new System.EventHandler(this.Lue_Urn_Kategori2_EditValueChanged);
            // 
            // Lue_Urn_Kategori3
            // 
            this.Lue_Urn_Kategori3.Location = new System.Drawing.Point(110, 326);
            this.Lue_Urn_Kategori3.Name = "Lue_Urn_Kategori3";
            this.Lue_Urn_Kategori3.Properties.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lue_Urn_Kategori3.Properties.Appearance.Options.UseFont = true;
            this.Lue_Urn_Kategori3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Lue_Urn_Kategori3.Properties.NullText = "3.Kategori Seçiniz...";
            this.Lue_Urn_Kategori3.Size = new System.Drawing.Size(207, 26);
            this.Lue_Urn_Kategori3.TabIndex = 32;
            // 
            // Lue_Urn_Marka
            // 
            this.Lue_Urn_Marka.Location = new System.Drawing.Point(110, 171);
            this.Lue_Urn_Marka.Name = "Lue_Urn_Marka";
            this.Lue_Urn_Marka.Properties.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lue_Urn_Marka.Properties.Appearance.Options.UseFont = true;
            this.Lue_Urn_Marka.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Lue_Urn_Marka.Properties.NullText = "Marka Seçiniz...";
            this.Lue_Urn_Marka.Size = new System.Drawing.Size(207, 26);
            this.Lue_Urn_Marka.TabIndex = 24;
            // 
            // groupControl1
            // 
            this.groupControl1.AutoSize = true;
            this.groupControl1.CaptionImageOptions.SvgImage = global::StokTakipProjesi.Properties.Resources.shipmentreceived;
            this.groupControl1.Controls.Add(this.bt_U_KodDegis);
            this.groupControl1.Controls.Add(this.Lue_Urn_Marka);
            this.groupControl1.Controls.Add(this.Lue_Urn_Kategori3);
            this.groupControl1.Controls.Add(this.Lue_Urn_Kategori2);
            this.groupControl1.Controls.Add(this.Lue_Urn_Kategori1);
            this.groupControl1.Controls.Add(this.bt_Urn_Guncelle);
            this.groupControl1.Controls.Add(this.bt_Urn_Sil);
            this.groupControl1.Controls.Add(this.bt_Urn_Ekle);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.Rtx_Urn_Aciklama);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.tx_Urn_Kod);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.tx_Urn_ID);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(592, 867);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "ÜRÜNLER";
            // 
            // bt_U_KodDegis
            // 
            this.bt_U_KodDegis.ImageOptions.Image = global::StokTakipProjesi.Properties.Resources.reset_32x32;
            this.bt_U_KodDegis.Location = new System.Drawing.Point(279, 208);
            this.bt_U_KodDegis.Name = "bt_U_KodDegis";
            this.bt_U_KodDegis.Size = new System.Drawing.Size(38, 28);
            this.bt_U_KodDegis.TabIndex = 71;
            this.bt_U_KodDegis.Click += new System.EventHandler(this.bt_U_KodDegis_Click);
            // 
            // Urunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1930, 867);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.Grd_Urunler);
            this.Name = "Urunler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ÜRÜNLER";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Urunler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Urunler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_Urn_ID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_Urn_Kod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lue_Urn_Kategori1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lue_Urn_Kategori2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lue_Urn_Kategori3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lue_Urn_Marka.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl Grd_Urunler;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit tx_Urn_ID;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit tx_Urn_Kod;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private System.Windows.Forms.RichTextBox Rtx_Urn_Aciklama;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.SimpleButton bt_Urn_Ekle;
        private DevExpress.XtraEditors.SimpleButton bt_Urn_Sil;
        private DevExpress.XtraEditors.SimpleButton bt_Urn_Guncelle;
        private DevExpress.XtraEditors.LookUpEdit Lue_Urn_Kategori1;
        private DevExpress.XtraEditors.LookUpEdit Lue_Urn_Kategori2;
        private DevExpress.XtraEditors.LookUpEdit Lue_Urn_Kategori3;
        private DevExpress.XtraEditors.LookUpEdit Lue_Urn_Marka;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton bt_U_KodDegis;
    }
}