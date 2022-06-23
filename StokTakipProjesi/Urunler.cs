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
    public partial class Urunler : DevExpress.XtraEditors.XtraForm
    {
        public Urunler()
        {
            InitializeComponent();
        }
        Yardimci yardimci = new Yardimci();
        Random rdn = new Random();

        char karakter;
        public string urunkod;

        public void Temizle()
        {
            tx_Urn_Kod.Text = "";
            Rtx_Urn_Aciklama.Text = "";
            Lue_Urn_Kategori1.EditValue = default;
            Lue_Urn_Marka.EditValue = default;
            Lue_Urn_Kategori2.EditValue = default;
            Lue_Urn_Kategori3.EditValue = default;
        }

        public void UrunTabloGetir()
        {
            yardimci.TabloListele("Select * from UrunlerTablosu", Grd_Urunler, "UrunlerTablosu");
            gridView1.BestFitColumns();
        }

        public void UrunKodUret()
        {
            tx_Urn_Kod.Text = "";
            urunkod = "";
            int sayi = rdn.Next(1000,9999);
            for (int i = 0; i < 3; i++)
            {
               int sayi2 = rdn.Next(65,91);
                karakter = Convert.ToChar(sayi2);
                urunkod += Convert.ToString(karakter);
            }
            tx_Urn_Kod.Text = urunkod + sayi.ToString();
        }

        private void Urunler_Load(object sender, EventArgs e)
        {
            
            UrunTabloGetir();
            UrunKodUret();
            tx_Urn_Kod.Enabled = false;
            yardimci.KategoriDoldur(1, "Execute Kategori1Getir", Lue_Urn_Kategori1);
            yardimci.MarkaDoldur(Lue_Urn_Marka);
           // labelControl11.Text = DateTime.Now.Year.ToString();
        }

        private void Lue_Urn_Kategori1_EditValueChanged(object sender, EventArgs e)
        {
            yardimci.KategoriDoldur(2, "Execute Kategori2Getir '" + Lue_Urn_Kategori1.EditValue + "'", Lue_Urn_Kategori2);
        }

        private void Lue_Urn_Kategori2_EditValueChanged(object sender, EventArgs e)
        {
            yardimci.KategoriDoldur(3, "Execute Kategori3Getir '" + Lue_Urn_Kategori2.EditValue + "'", Lue_Urn_Kategori3);
        }

        private void bt_Urn_Ekle_Click(object sender, EventArgs e)
        {
            if (tx_Urn_Kod == null || Lue_Urn_Kategori1.EditValue == null || Lue_Urn_Marka.EditValue == null)
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                yardimci.CRUDislemleri("Execute UrunlerKayitEkle '" + Lue_Urn_Marka.EditValue + "','" + tx_Urn_Kod.Text + "','" + Lue_Urn_Kategori1.EditValue + "','" + Lue_Urn_Kategori2.EditValue + "','" + Lue_Urn_Kategori3.EditValue + "','" + Rtx_Urn_Aciklama.Text + "'","Kaydet");
                Temizle();
                UrunTabloGetir();
                UrunKodUret();
            }
        }

        private void Grd_Urunler_DoubleClick(object sender, EventArgs e)
        {
            DataRow dataRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dataRow != null)
            {
                tx_Urn_ID.Text = dataRow[0].ToString();
                Lue_Urn_Marka.Text = dataRow[1].ToString();
                tx_Urn_Kod.Text = dataRow[2].ToString();
                Lue_Urn_Kategori1.Text = dataRow[3].ToString();
                Lue_Urn_Kategori2.Text = dataRow[4].ToString();
                Lue_Urn_Kategori3.Text = dataRow[5].ToString();
                Rtx_Urn_Aciklama.Text = dataRow[6].ToString();
            }
        }

        private void bt_Urn_Sil_Click(object sender, EventArgs e)
        {
            if (tx_Urn_ID.Text != "")
            {
                yardimci.CRUDislemleri("Execute UrunlerTablosuKayitSil '" + int.Parse(tx_Urn_ID.Text) + "'", "Sil");
                UrunTabloGetir();
                Temizle();
                UrunKodUret();
            }
            else
            {
                MessageBox.Show("Bir Ürün Seçip Tekrar Deneyiniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bt_U_KodDegis_Click(object sender, EventArgs e)
        {
            UrunKodUret();
        }

        private void bt_Urn_Guncelle_Click(object sender, EventArgs e)
        {
            if (tx_Urn_ID.Text != "")
            {
                yardimci.CRUDislemleri("Execute UrunlerTablosuKayitGuncelleme '" + int.Parse(tx_Urn_ID.Text) + "','" + Lue_Urn_Marka.EditValue + "','" + tx_Urn_Kod.Text + "','" + Lue_Urn_Kategori1.EditValue + "','" + Lue_Urn_Kategori2.EditValue + "','" + Lue_Urn_Kategori3.EditValue + "','" + Rtx_Urn_Aciklama.Text + "'", "Guncelle");
                UrunTabloGetir();
                Temizle();
                UrunKodUret();
            }
            else
            {
                MessageBox.Show("Bir Ürün Seçip Tekrar Deneyiniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
    }
}