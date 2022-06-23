
namespace StokTakipProjesi
{
    partial class Depolar
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.Lue_D_ilce = new DevExpress.XtraEditors.LookUpEdit();
            this.Lue_D_il = new DevExpress.XtraEditors.LookUpEdit();
            this.bt_P_Guncelle = new DevExpress.XtraEditors.SimpleButton();
            this.bt_P_Sil = new DevExpress.XtraEditors.SimpleButton();
            this.bt_P_Ekle = new DevExpress.XtraEditors.SimpleButton();
            this.Rtx_D_AcikAdres = new System.Windows.Forms.RichTextBox();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.tx_D_Ad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.tx_D_ID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.Grd_Depolar = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Lue_D_ilce.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lue_D_il.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_D_Ad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_D_ID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Depolar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AutoSize = true;
            this.groupControl1.CaptionImageOptions.Image = global::StokTakipProjesi.Properties.Resources.home_32x32;
            this.groupControl1.Controls.Add(this.Lue_D_ilce);
            this.groupControl1.Controls.Add(this.Lue_D_il);
            this.groupControl1.Controls.Add(this.bt_P_Guncelle);
            this.groupControl1.Controls.Add(this.bt_P_Sil);
            this.groupControl1.Controls.Add(this.bt_P_Ekle);
            this.groupControl1.Controls.Add(this.Rtx_D_AcikAdres);
            this.groupControl1.Controls.Add(this.labelControl15);
            this.groupControl1.Controls.Add(this.tx_D_Ad);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.tx_D_ID);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(869, 868);
            this.groupControl1.TabIndex = 19;
            this.groupControl1.Text = "DEPOLAR";
            // 
            // Lue_D_ilce
            // 
            this.Lue_D_ilce.Location = new System.Drawing.Point(139, 241);
            this.Lue_D_ilce.Name = "Lue_D_ilce";
            this.Lue_D_ilce.Properties.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lue_D_ilce.Properties.Appearance.Options.UseFont = true;
            this.Lue_D_ilce.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Lue_D_ilce.Properties.DropDownItemHeight = 40;
            this.Lue_D_ilce.Properties.NullText = "Bir İlçe Seçiniz...";
            this.Lue_D_ilce.Size = new System.Drawing.Size(207, 26);
            this.Lue_D_ilce.TabIndex = 55;
            // 
            // Lue_D_il
            // 
            this.Lue_D_il.Location = new System.Drawing.Point(139, 201);
            this.Lue_D_il.Name = "Lue_D_il";
            this.Lue_D_il.Properties.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lue_D_il.Properties.Appearance.Options.UseFont = true;
            this.Lue_D_il.Properties.AutoHeight = false;
            this.Lue_D_il.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Lue_D_il.Properties.DropDownItemHeight = 40;
            this.Lue_D_il.Properties.NullText = "Bir İl Seçiniz...";
            this.Lue_D_il.Size = new System.Drawing.Size(207, 26);
            this.Lue_D_il.TabIndex = 54;
            this.Lue_D_il.EditValueChanged += new System.EventHandler(this.Lue_D_il_EditValueChanged);
            // 
            // bt_P_Guncelle
            // 
            this.bt_P_Guncelle.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_P_Guncelle.Appearance.Options.UseFont = true;
            this.bt_P_Guncelle.ImageOptions.Image = global::StokTakipProjesi.Properties.Resources.refresh_32x32;
            this.bt_P_Guncelle.Location = new System.Drawing.Point(599, 551);
            this.bt_P_Guncelle.Name = "bt_P_Guncelle";
            this.bt_P_Guncelle.Size = new System.Drawing.Size(175, 53);
            this.bt_P_Guncelle.TabIndex = 53;
            this.bt_P_Guncelle.Text = "Güncelle";
            this.bt_P_Guncelle.Click += new System.EventHandler(this.bt_P_Guncelle_Click);
            // 
            // bt_P_Sil
            // 
            this.bt_P_Sil.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_P_Sil.Appearance.Options.UseFont = true;
            this.bt_P_Sil.ImageOptions.Image = global::StokTakipProjesi.Properties.Resources.cancel_32x32;
            this.bt_P_Sil.Location = new System.Drawing.Point(370, 551);
            this.bt_P_Sil.Name = "bt_P_Sil";
            this.bt_P_Sil.Size = new System.Drawing.Size(175, 53);
            this.bt_P_Sil.TabIndex = 52;
            this.bt_P_Sil.Text = "Sil";
            this.bt_P_Sil.Click += new System.EventHandler(this.bt_P_Sil_Click);
            // 
            // bt_P_Ekle
            // 
            this.bt_P_Ekle.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_P_Ekle.Appearance.Options.UseFont = true;
            this.bt_P_Ekle.ImageOptions.Image = global::StokTakipProjesi.Properties.Resources.add_32x322;
            this.bt_P_Ekle.Location = new System.Drawing.Point(139, 551);
            this.bt_P_Ekle.Name = "bt_P_Ekle";
            this.bt_P_Ekle.Size = new System.Drawing.Size(175, 53);
            this.bt_P_Ekle.TabIndex = 51;
            this.bt_P_Ekle.Text = "Ekle";
            this.bt_P_Ekle.Click += new System.EventHandler(this.bt_P_Ekle_Click);
            // 
            // Rtx_D_AcikAdres
            // 
            this.Rtx_D_AcikAdres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.Rtx_D_AcikAdres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Rtx_D_AcikAdres.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Rtx_D_AcikAdres.Location = new System.Drawing.Point(139, 280);
            this.Rtx_D_AcikAdres.Name = "Rtx_D_AcikAdres";
            this.Rtx_D_AcikAdres.Size = new System.Drawing.Size(635, 158);
            this.Rtx_D_AcikAdres.TabIndex = 42;
            this.Rtx_D_AcikAdres.Text = "";
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl15.Appearance.Options.UseFont = true;
            this.labelControl15.Location = new System.Drawing.Point(44, 280);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(89, 19);
            this.labelControl15.TabIndex = 41;
            this.labelControl15.Text = "Açık Adres :";
            // 
            // tx_D_Ad
            // 
            this.tx_D_Ad.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tx_D_Ad.Location = new System.Drawing.Point(139, 164);
            this.tx_D_Ad.Name = "tx_D_Ad";
            this.tx_D_Ad.Properties.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_D_Ad.Properties.Appearance.Options.UseFont = true;
            this.tx_D_Ad.Size = new System.Drawing.Size(207, 26);
            this.tx_D_Ad.TabIndex = 2;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(99, 167);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(34, 19);
            this.labelControl7.TabIndex = 31;
            this.labelControl7.Text = "Adı :";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(96, 244);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(37, 19);
            this.labelControl9.TabIndex = 16;
            this.labelControl9.Text = "İlçe :";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(113, 204);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(20, 19);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "İl :";
            // 
            // tx_D_ID
            // 
            this.tx_D_ID.Location = new System.Drawing.Point(139, 121);
            this.tx_D_ID.Name = "tx_D_ID";
            this.tx_D_ID.Properties.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_D_ID.Properties.Appearance.Options.UseFont = true;
            this.tx_D_ID.Size = new System.Drawing.Size(207, 26);
            this.tx_D_ID.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(105, 124);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(28, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID :";
            // 
            // Grd_Depolar
            // 
            this.Grd_Depolar.Dock = System.Windows.Forms.DockStyle.Right;
            this.Grd_Depolar.Location = new System.Drawing.Point(869, 0);
            this.Grd_Depolar.MainView = this.gridView1;
            this.Grd_Depolar.Name = "Grd_Depolar";
            this.Grd_Depolar.Size = new System.Drawing.Size(1065, 868);
            this.Grd_Depolar.TabIndex = 18;
            this.Grd_Depolar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.Grd_Depolar.DoubleClick += new System.EventHandler(this.Grd_Depolar_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.Grd_Depolar;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // Depolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1934, 868);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.Grd_Depolar);
            this.Name = "Depolar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DEPOLAR";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Depolar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Lue_D_ilce.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lue_D_il.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_D_Ad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_D_ID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Depolar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.RichTextBox Rtx_D_AcikAdres;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.TextEdit tx_D_Ad;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit tx_D_ID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl Grd_Depolar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton bt_P_Guncelle;
        private DevExpress.XtraEditors.SimpleButton bt_P_Sil;
        private DevExpress.XtraEditors.SimpleButton bt_P_Ekle;
        private DevExpress.XtraEditors.LookUpEdit Lue_D_ilce;
        private DevExpress.XtraEditors.LookUpEdit Lue_D_il;
    }
}