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
using System.Data.SqlClient;

namespace StokTakipProjesi
{
    public partial class Faturalar : DevExpress.XtraEditors.XtraForm
    {
        public Faturalar()
        {
            InitializeComponent();
        }
        Yardimci yardimci = new Yardimci();

        public string adet;
        public string marka;

        Random rnd = new Random();
        void SiraNoUret()
        {
            int sayı = rnd.Next(100000, 999999);
            tx_F_Sira.Text = sayı.ToString();
            int Seri = rnd.Next(65, 91);
            char karakter = Convert.ToChar(Seri);
            tx_F_Seri.Text = karakter.ToString();
        }

        void temizle()
        {
            tx_F_ID.Text = "";
            tx_F_StokID.Text = "";
            tx_F_UrunID.Text = "";
            tx_F_SatisFiyat.Text = "";
            tx_F_Seri.Text = "";
            tx_F_ToplamTutar.Text = "";
            tx_F_Sira.Text = "";
            Lue_F_Musteri.EditValue = default;
            Mtx_F_Saat.Text = null;
            Nud_F_Adet.Value = 0;
        }

        void SatisFaturaTablo()
        {
            yardimci.TabloListele("Select * from KesilenFaturaTablosu", Grd_Faturalar, "KesilenFaturaTablosu");
            gridView1.BestFitColumns();
        }

        private void Faturalar_Load(object sender, EventArgs e)
        {
            SatisFaturaTablo();
            yardimci.BankaAdıMusteriDoldur("Musteri", "Select * from BankaMusteriBilgisi", Lue_F_Musteri);
            yardimci.PersonelDoldur(Lue_F_Personel);
            SiraNoUret();
            tx_F_ID.Enabled = false;
            tx_F_Seri.Enabled = false;
            tx_F_UrunID.Enabled = false;
            tx_F_StokID.Enabled = false;
            tx_F_Sira.Enabled = false;
            tx_F_SatisFiyat.Enabled = false;
            tx_F_ToplamTutar.Enabled = false;
        }

        public void Nud_F_Adet_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (Nud_F_Adet.Value.ToString() == adet)
                {
                    MessageBox.Show("Stokta '" + adet + "' Kadar Urun Var Lutfen Daha Fazla Girmek İçin Stok Güncelleyiniz !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Nud_F_Adet.Maximum = Convert.ToInt32(adet);
                }
                else
                {
                    decimal toplam;
                    toplam = Convert.ToDecimal(tx_F_SatisFiyat.Text) * Convert.ToInt32(Nud_F_Adet.Value);
                    tx_F_ToplamTutar.Text = toplam.ToString();
                }

            }
            catch (Exception)
            { MessageBox.Show("Bir Sorun Oluştu !!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void bt_F_Ekle_Click(object sender, EventArgs e)
        {
            if (tx_F_SatisFiyat.Text == null || tx_F_Seri.Text == null
                || tx_F_ToplamTutar.Text == null || tx_F_Sira.Text == null
                || Lue_F_Musteri.EditValue == null || dt_F_Tarih.Value == null || Mtx_F_Saat.Text == null)
            {
                MessageBox.Show("Lütfen Bütün Alanları Doldurunuz !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                yardimci.CRUDislemleri("Execute YeniFaturaKayit '" + tx_F_Seri.Text + "','" + int.Parse(tx_F_Sira.Text) + "','"
               + dt_F_Tarih.Value.ToString("yyyy-MM-dd") + "','" + Mtx_F_Saat.Text + "','" + Lue_F_Musteri.EditValue + "','" + Lue_F_Personel.EditValue + "'", "Kaydet");
                SatisFaturaTablo();
                SiraNoUret();
                temizle();
            }
        }


        FaturaUrunDetay detay;
        private void Grd_Faturalar_DoubleClick(object sender, EventArgs e)
        {
            if (detay == null || detay.IsDisposed)
            {
                detay = new FaturaUrunDetay();
                DataRow datarow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                if (datarow != null)
                {
                    detay.id = datarow["FATURA ID"].ToString();
                }
                detay.Show();
            }
            else
            {
                detay.Select();
            }

        }

        private void bt_F_Sil_Click(object sender, EventArgs e)
        {
            if (tx_F_ID.Text == "")
            {
                MessageBox.Show("Lütfen Seçim Yapıp Tekrar Deneyiniz !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                yardimci.CRUDislemleri("Execute FaturaTablosuKayitSil '" + int.Parse(tx_F_ID.Text) + "'", "Sil");
                SatisFaturaTablo();
                temizle();
            }
        }

        FaturaUrunSec urunSec;
        private void bt_F_UrunSec_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (urunSec == null || urunSec.IsDisposed)
                {
                    urunSec = new FaturaUrunSec(this, new FaturaUrunGuncelleSil());
                    urunSec.Show();
                }
                else
                {
                    urunSec.Select();
                }
            }
            catch (Exception)
            { MessageBox.Show("Urun Seçme Penceresi Açılırken Bir Sorun Oluştu !!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void bt_F_SeriUret_Click(object sender, EventArgs e)
        {
            SiraNoUret();
        }

        private void bt_F_FaturaUrunEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (tx_F_FATURAID.Text != "")
                {
                    decimal toplam, fiyat, adet;
                    adet = Convert.ToDecimal(Nud_F_Adet.Value);
                    fiyat = Convert.ToDecimal(tx_F_SatisFiyat.Text);
                    toplam = fiyat * adet;
                    tx_F_ToplamTutar.Text = toplam.ToString();
                    SqlCommand cmd = new SqlCommand("FaturaUrunKayit", yardimci.con());
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@StokID", SqlDbType.Int).Value = tx_F_StokID.Text;
                    cmd.Parameters.Add("@UrunID", SqlDbType.Int).Value = tx_F_UrunID.Text;
                    cmd.Parameters.Add("@Adet", SqlDbType.Int).Value = Nud_F_Adet.Value;
                    cmd.Parameters.Add("@SatisFiyat", SqlDbType.Decimal).Value = tx_F_SatisFiyat.Text;
                    cmd.Parameters.Add("@ToplamFiyat", SqlDbType.Decimal).Value = tx_F_ToplamTutar.Text;
                    cmd.Parameters.Add("@FaturaID", SqlDbType.Decimal).Value = tx_F_FATURAID.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ürün Faturaya Eklendi !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SiraNoUret();
                    temizle();
                }
                else
                {
                    MessageBox.Show("Lütfen Ürün Eklemek İçin Bir Fatura Seçiniz !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Ürün Eklemek İçin Bir Fatura Seçiniz !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        private void Grd_Faturalar_Click(object sender, EventArgs e)
        {
            DataRow datarow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (datarow != null)
            {
                tx_F_FATURAID.Text = datarow[0].ToString();
                tx_F_ID.Text = datarow[0].ToString();
                tx_F_Seri.Text = datarow[1].ToString();
                tx_F_Sira.Text = datarow[2].ToString();
                dt_F_Tarih.Text = datarow[3].ToString();
                Mtx_F_Saat.Text = datarow[4].ToString();
                Lue_F_Musteri.Text = datarow[5].ToString();
                Lue_F_Personel.Text = datarow[6].ToString();
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (tx_F_ID.Text != "")
            {
                yardimci.CRUDislemleri("Execute FaturaTablosuGuncelleme '" + int.Parse(tx_F_ID.Text) + "','" + dt_F_Tarih.Value.ToString("yyyy-MM-dd") + "','" + Mtx_F_Saat.Text + "','" + Lue_F_Musteri.EditValue + "','" + Lue_F_Personel.EditValue + "'", "Guncelle");
                SatisFaturaTablo();
                temizle();
                SiraNoUret();
            }
            else
            {
                MessageBox.Show("Lütfen Bir Fatura Seçiniz !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}