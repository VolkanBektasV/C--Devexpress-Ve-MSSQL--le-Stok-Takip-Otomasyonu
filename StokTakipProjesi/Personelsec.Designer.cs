
namespace StokTakipProjesi
{
    partial class Personelsec
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
            this.grd_Personeller = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Personeller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grd_Personeller
            // 
            this.grd_Personeller.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_Personeller.Location = new System.Drawing.Point(0, 0);
            this.grd_Personeller.MainView = this.gridView1;
            this.grd_Personeller.Name = "grd_Personeller";
            this.grd_Personeller.Size = new System.Drawing.Size(969, 418);
            this.grd_Personeller.TabIndex = 0;
            this.grd_Personeller.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.grd_Personeller.DoubleClick += new System.EventHandler(this.grd_Personeller_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grd_Personeller;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // Personelsec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 418);
            this.Controls.Add(this.grd_Personeller);
            this.Name = "Personelsec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PERSONEL SEÇ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Personelsec_FormClosing);
            this.Load += new System.EventHandler(this.Personelsec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_Personeller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grd_Personeller;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}