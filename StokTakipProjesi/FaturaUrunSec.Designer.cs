
namespace StokTakipProjesi
{
    partial class FaturaUrunSec
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
            this.Grd_StokUrun = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_StokUrun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Grd_StokUrun
            // 
            this.Grd_StokUrun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grd_StokUrun.Location = new System.Drawing.Point(0, 0);
            this.Grd_StokUrun.MainView = this.gridView1;
            this.Grd_StokUrun.Name = "Grd_StokUrun";
            this.Grd_StokUrun.Size = new System.Drawing.Size(1812, 566);
            this.Grd_StokUrun.TabIndex = 1;
            this.Grd_StokUrun.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.Grd_StokUrun.DoubleClick += new System.EventHandler(this.Grd_StokUrun_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.Grd_StokUrun;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // FaturaUrunSec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1812, 566);
            this.Controls.Add(this.Grd_StokUrun);
            this.Name = "FaturaUrunSec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FATURA ÜRÜN SEÇ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FaturaUrunSec_FormClosing);
            this.Load += new System.EventHandler(this.FaturaUrunSec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grd_StokUrun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl Grd_StokUrun;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}