using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakipProjesi
{
    public partial class Personelsec : DevExpress.XtraEditors.XtraForm
    {
        Kullaniciislemleri kullaniciislem;
        public Personelsec(Kullaniciislemleri klnci)
        {
            InitializeComponent();
            this.kullaniciislem = klnci;
        }
        Yardimci yardimci = new Yardimci();
        private void Personelsec_Load(object sender, EventArgs e)
        {
            yardimci.TabloListele("Select ID,TC,concat(ADI,' ',SOYADI)AS 'ADI SOYADI',BİRİM from PersonellerTablosu", grd_Personeller, "PersonellerTablosu");
        }
        string tc, adsoyad, birim,id;

        private void Personelsec_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (tc != "" || adsoyad != "" || birim != "")
                {
                    kullaniciislem.pid = id;
                    kullaniciislem.tx_Personeltc.Text = tc;
                    kullaniciislem.tx_PersonelAd.Text = adsoyad;
                    kullaniciislem.tx_PersonelBirim.Text = birim;
                    kullaniciislem.secilenTc = tc;
                }
                else
                { MessageBox.Show("Bir Sorun Oluştu Lütfen Kontrol Edip Tekrar Deneyiniz !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            catch (Exception)
            { MessageBox.Show("Bir Sorun Oluştu Lütfen Kontrol Edip Tekrar Deneyiniz !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

        }

        private void grd_Personeller_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                DataRow dataRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                if (dataRow != null)
                {
                    id = dataRow["ID"].ToString();
                    tc = dataRow["TC"].ToString();
                    adsoyad = dataRow["ADI SOYADI"].ToString();
                    birim = dataRow["BİRİM"].ToString();
                }
                DialogResult dialogResult;
                dialogResult = MessageBox.Show("Seçiminizi Değiştirmek İstermisiniz ?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.No)
                {
                    this.Close();
                }
            }
            catch (Exception)
            { MessageBox.Show("Ürün Seçilemedi !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
    }
}