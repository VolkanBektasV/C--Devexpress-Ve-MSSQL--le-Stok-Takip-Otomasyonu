
namespace StokTakipProjesi
{
    partial class FaturaUrunDetay
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
            this.grd_FaturaUrunleri = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.grd_FaturaUrunleri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grd_FaturaUrunleri
            // 
            this.grd_FaturaUrunleri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_FaturaUrunleri.Location = new System.Drawing.Point(0, 0);
            this.grd_FaturaUrunleri.MainView = this.gridView1;
            this.grd_FaturaUrunleri.Name = "grd_FaturaUrunleri";
            this.grd_FaturaUrunleri.Size = new System.Drawing.Size(1225, 500);
            this.grd_FaturaUrunleri.TabIndex = 0;
            this.grd_FaturaUrunleri.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.grd_FaturaUrunleri.DoubleClick += new System.EventHandler(this.grd_FaturaUrunleri_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grd_FaturaUrunleri;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // FaturaUrunDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1225, 500);
            this.Controls.Add(this.grd_FaturaUrunleri);
            this.Name = "FaturaUrunDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FATURAYA AİT ÜRÜNLER LİSTESİ";
            this.Load += new System.EventHandler(this.FaturaUrunDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_FaturaUrunleri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grd_FaturaUrunleri;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}