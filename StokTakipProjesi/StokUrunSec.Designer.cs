
namespace StokTakipProjesi
{
    partial class StokUrunSec
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
            this.Grd_Urun = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.Lue_U_Kategori = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tx_U_Kod = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Urun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Lue_U_Kategori.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_U_Kod.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // Grd_Urun
            // 
            this.Grd_Urun.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Grd_Urun.Location = new System.Drawing.Point(0, 68);
            this.Grd_Urun.MainView = this.gridView1;
            this.Grd_Urun.Name = "Grd_Urun";
            this.Grd_Urun.Size = new System.Drawing.Size(1027, 397);
            this.Grd_Urun.TabIndex = 0;
            this.Grd_Urun.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.Grd_Urun;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // groupControl1
            // 
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControl1.CaptionImageOptions.Image = global::StokTakipProjesi.Properties.Resources.find_16x161;
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.Lue_U_Kategori);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.tx_U_Kod);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1027, 68);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "ÜRÜN ARA";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(630, 24);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(114, 19);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Ürün Kategori :";
            // 
            // Lue_U_Kategori
            // 
            this.Lue_U_Kategori.Location = new System.Drawing.Point(750, 21);
            this.Lue_U_Kategori.Name = "Lue_U_Kategori";
            this.Lue_U_Kategori.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Lue_U_Kategori.Properties.NullText = "Kategori Seçiniz...";
            this.Lue_U_Kategori.Size = new System.Drawing.Size(216, 26);
            this.Lue_U_Kategori.TabIndex = 3;
            this.Lue_U_Kategori.EditValueChanged += new System.EventHandler(this.Lue_U_Kategori_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(45, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(81, 19);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Ürün Kod :";
            // 
            // tx_U_Kod
            // 
            this.tx_U_Kod.Location = new System.Drawing.Point(132, 21);
            this.tx_U_Kod.Name = "tx_U_Kod";
            this.tx_U_Kod.Size = new System.Drawing.Size(206, 26);
            this.tx_U_Kod.TabIndex = 0;
            this.tx_U_Kod.EditValueChanged += new System.EventHandler(this.tx_U_Kod_EditValueChanged);
            // 
            // StokUrunSec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 465);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.Grd_Urun);
            this.Name = "StokUrunSec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Seçme";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StokUrunSec_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StokUrunSec_FormClosed);
            this.Load += new System.EventHandler(this.StokUrunSec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Urun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Lue_U_Kategori.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_U_Kod.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl Grd_Urun;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit tx_U_Kod;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LookUpEdit Lue_U_Kategori;
    }
}