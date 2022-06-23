
namespace StokTakipProjesi
{
    partial class LoginPage
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
            this.tx_User = new DevExpress.XtraEditors.TextEdit();
            this.tx_Pass = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.tx_User.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_Pass.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tx_User
            // 
            this.tx_User.Location = new System.Drawing.Point(92, 328);
            this.tx_User.Name = "tx_User";
            this.tx_User.Properties.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_User.Properties.Appearance.Options.UseFont = true;
            this.tx_User.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.tx_User.Properties.Mask.BeepOnError = true;
            this.tx_User.Properties.Mask.EditMask = "99900000000";
            this.tx_User.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.tx_User.Size = new System.Drawing.Size(189, 28);
            this.tx_User.TabIndex = 0;
            this.tx_User.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tx_User_KeyDown);
            // 
            // tx_Pass
            // 
            this.tx_Pass.Location = new System.Drawing.Point(322, 328);
            this.tx_Pass.Name = "tx_Pass";
            this.tx_Pass.Properties.Appearance.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_Pass.Properties.Appearance.Options.UseFont = true;
            this.tx_Pass.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.tx_Pass.Properties.UseSystemPasswordChar = true;
            this.tx_Pass.Size = new System.Drawing.Size(191, 28);
            this.tx_Pass.TabIndex = 1;
            this.tx_Pass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tx_Pass_KeyDown);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(131, 302);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(107, 20);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Kullanıcı Adı :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(390, 302);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 20);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Şifre :";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = global::StokTakipProjesi.Properties.Resources.close_16x16;
            this.simpleButton1.Location = new System.Drawing.Point(589, 1);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(23, 24);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(150, 371);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(317, 20);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "- ENTER İLE GİRİŞ YAPABİLİRSİNİZ -";
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = global::StokTakipProjesi.Properties.Resources.ihracat;
            this.ClientSize = new System.Drawing.Size(612, 406);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.tx_Pass);
            this.Controls.Add(this.tx_User);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginPage";
            ((System.ComponentModel.ISupportInitialize)(this.tx_User.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tx_Pass.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit tx_User;
        private DevExpress.XtraEditors.TextEdit tx_Pass;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}