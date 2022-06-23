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
    public partial class Bankalar : DevExpress.XtraEditors.XtraForm
    {
        public Bankalar()
        {
            InitializeComponent();
        }
        Yardimci yardimci = new Yardimci();

        void Temizle()
        {
            tx_B_Sube.Text = "";
            tx_B_YetkiliAd.Text = "";
            tx_B_YetkiliSoyad.Text = "";
            Mtx_B_HesapNo.Text = "";
            Mtx_B_Iban.Text = "";
            Lue_B_BankaAdi.EditValue = default;
            Lue_B_HesapTur.EditValue = default;
            Lue_B_il.EditValue = default;
            Lue_B_ilce.EditValue = default;
            Lue_B_Musteri.EditValue = default;
        }

        void BankaTabloGetir()
        {
            yardimci.TabloListele("Select * from BankalarTablosu", Grd_Bankalar, "BankalarTablosu");
            gridView1.BestFitColumns();
        }

        private void Bankalar_Load(object sender, EventArgs e)
        {
            tx_B_ID.Enabled = false;
            BankaTabloGetir();
            yardimci.ililceDoldur("il", "Execute illerGetir ", Lue_B_il);
            yardimci.BankaAdıMusteriDoldur("Musteri", "Select * from BankaMusteriBilgisi", Lue_B_Musteri);
            yardimci.BankaAdıMusteriDoldur("Bankaadı", "Select * from BankaAdlariGetir", Lue_B_BankaAdi);
            yardimci.BankaAdıMusteriDoldur("Hesaptur", "Select * from HesapTurGetir", Lue_B_HesapTur);
        }

        private void Lue_B_il_EditValueChanged(object sender, EventArgs e)
        {
            yardimci.ililceDoldur("ilce", "Execute ilcelerGetir '" + Lue_B_il.EditValue + "'", Lue_B_ilce);

        }

        private void bt_B_Ekle_Click(object sender, EventArgs e)
        {
            if (tx_B_Sube.Text == null || tx_B_YetkiliAd.Text == null || tx_B_YetkiliSoyad.Text == null
           || Lue_B_BankaAdi.EditValue == null || Lue_B_HesapTur.EditValue == null || Lue_B_il.EditValue == null
           || Lue_B_ilce.EditValue == null || Lue_B_Musteri.EditValue == null || dt_B_Tarih.Value == null)
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                yardimci.CRUDislemleri("Execute BankaTablosunaKayitEkle '" + Lue_B_BankaAdi.EditValue + "','" + tx_B_Sube.Text + "','" + Mtx_B_Iban.Text + "','" + Mtx_B_HesapNo.Text + "','" + tx_B_YetkiliAd.Text + "','" + tx_B_YetkiliSoyad.Text + "','" + dt_B_Tarih.Value.ToString("yyyy-MM-dd") + "','" + Lue_B_HesapTur.EditValue + "','" + Lue_B_Musteri.EditValue + "','" + Lue_B_il.EditValue + "','" + Lue_B_ilce.EditValue + "'", "Kaydet");
                BankaTabloGetir();
                Temizle();
            }
        }

        private void Grd_Bankalar_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                DataRow dataRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                if (dataRow != null)
                {
                    tx_B_ID.Text = dataRow[0].ToString();
                    Lue_B_BankaAdi.Text = dataRow[1].ToString();
                    tx_B_Sube.Text = dataRow[2].ToString();
                    Mtx_B_Iban.Text = dataRow[3].ToString();
                    Mtx_B_HesapNo.Text = dataRow[4].ToString();
                    tx_B_YetkiliAd.Text = dataRow[5].ToString();
                    tx_B_YetkiliSoyad.Text = dataRow[6].ToString();
                    dt_B_Tarih.Text = dataRow[7].ToString();
                    Lue_B_Musteri.Text = dataRow[8].ToString();
                    Lue_B_il.Text = dataRow[9].ToString();
                    Lue_B_ilce.Text = dataRow[10].ToString();
                    Lue_B_HesapTur.Text = dataRow[11].ToString();

                }
            }
            catch (Exception)
            { MessageBox.Show("Bir Sorun Oluştu !!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void bt_P_Sil_Click(object sender, EventArgs e)
        {
            if (tx_B_ID.Text == "")
            {
                MessageBox.Show("Lütfen Seçiminizi Yapıp Tekrar Deneyiniz !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                yardimci.CRUDislemleri("Execute  BankaTablosuKayitSil '" + int.Parse(tx_B_ID.Text) + "'", "Sil");
                BankaTabloGetir();
                Temizle();
            }
        }

        private void bt_P_Guncelle_Click(object sender, EventArgs e)
        {
            if (tx_B_ID.Text != "")
            {
                yardimci.CRUDislemleri("Execute BankaKayitGuncelleme '" + int.Parse(tx_B_ID.Text) + "','" + Lue_B_BankaAdi.EditValue + "','" + tx_B_Sube.Text + "','" + Mtx_B_Iban.Text + "','" + Mtx_B_HesapNo.Text + "','" + tx_B_YetkiliAd.Text + "','" + tx_B_YetkiliSoyad.Text + "','" + dt_B_Tarih.Value.ToString("yyyy-MM-dd") + "','" + Lue_B_HesapTur.EditValue + "','" + Lue_B_Musteri.EditValue + "','" + Lue_B_il.EditValue + "','" + Lue_B_ilce.EditValue + "'","Guncelle");
                BankaTabloGetir();
                Temizle();
            }
            else
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}