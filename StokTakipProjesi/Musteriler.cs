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
    public partial class Musteriler : DevExpress.XtraEditors.XtraForm
    {
        public Musteriler()
        {
            InitializeComponent();
        }
        Yardimci yardimci = new Yardimci();

        void Temizle()
        {
            tx_M_ID.Text = "";
            tx_M_Ad.Text = "";
            tx_M_Soyad.Text = "";
            tx_M_TC.Text = "";
            tx_M_MailAdres.Text = ""; ;
            Mtx_M_Telefon.Text = "";
            Lue_M_il.EditValue = default;
            Lue_M_ilce.EditValue = default;
            Rtx_M_AcikAdres.Text = "";
        }

        void MusteriTabloGetir()
        {
            yardimci.TabloListele("Select * from MusterilerTablosu", Grd_Musteriler, "MusterilerTablosu");
            gridView1.BestFitColumns();
        }

        private void Musteriler_Load(object sender, EventArgs e)
        {
            MusteriTabloGetir();
            yardimci.ililceDoldur("il", "Execute illerGetir ", Lue_M_il);
            tx_M_TC.Properties.MaxLength = 11;
        }

        private void Lue_D_il_EditValueChanged(object sender, EventArgs e)
        {
            yardimci.ililceDoldur("ilce", "Execute ilcelerGetir '" + Lue_M_il.EditValue + "'", Lue_M_ilce);

        }

        private void bt_M_Ekle_Click(object sender, EventArgs e)
        {
            if (tx_M_Ad.Text == null || tx_M_MailAdres.Text == null || tx_M_Soyad.Text == null || tx_M_TC.Text == null || tx_M_TC.Properties.MaxLength != 11
                           || Lue_M_il.EditValue == null || Lue_M_ilce.EditValue == null || Mtx_M_Telefon.Text == null)
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                yardimci.CRUDislemleri("Execute MusteriTablosuKayitEkle '" + tx_M_Ad.Text + "','" + tx_M_Soyad.Text + "'" +
                    ",'" + Mtx_M_Telefon.Text + "','" + tx_M_TC.Text + "','" + tx_M_MailAdres.Text + "','" + Lue_M_il.EditValue + "'" +
                    ",'" + Lue_M_ilce.EditValue + "','" + Rtx_M_AcikAdres.Text + "'","Kaydet");
                MusteriTabloGetir();
                Temizle();
            }
        }

        private void Grd_Musteriler_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                DataRow dataRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                if (dataRow != null)
                {
                    tx_M_ID.Text = dataRow[0].ToString();
                    tx_M_TC.Text = dataRow[4].ToString();
                    tx_M_Ad.Text = dataRow[1].ToString();
                    tx_M_Soyad.Text = dataRow[2].ToString();
                    Mtx_M_Telefon.Text = dataRow[3].ToString();
                    tx_M_MailAdres.Text = dataRow[5].ToString();
                    Lue_M_il.Text = dataRow[6].ToString();
                    Lue_M_ilce.Text = dataRow[7].ToString();
                    Rtx_M_AcikAdres.Text = dataRow[8].ToString();
                }
            }
            catch (Exception)
            { MessageBox.Show("Bir Hata Oluştu !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void bt_M_Sil_Click(object sender, EventArgs e)
        {
            if (tx_M_ID.Text!="")
            {
                yardimci.CRUDislemleri("Execute MusteriTablosuKayitSil '" + int.Parse(tx_M_ID.Text) + "'", "Sil");
                MusteriTabloGetir();
                Temizle();
                
            }
            else
            {
                MessageBox.Show("Bir Müşteri Seçip Tekrar Deneyiniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }           
        }

        private void bt_M_Guncelle_Click(object sender, EventArgs e)
        {
            if (tx_M_TC.Text!="")
            {
                yardimci.CRUDislemleri("Execute MusteriKayitGuncelle '"+int.Parse(tx_M_ID.Text)+"','"+tx_M_Ad.Text+"','"+tx_M_Soyad.Text+"','"+Mtx_M_Telefon.Text+"','"+tx_M_TC.Text+"','"+tx_M_MailAdres.Text+"','"+Lue_M_il.EditValue+"','"+Lue_M_ilce.EditValue+"','"+Rtx_M_AcikAdres.Text+"'","Guncelle");
                MusteriTabloGetir();
                Temizle();
            }
            else
            {
                MessageBox.Show("Bir Müşteri Seçip Tekrar Deneyiniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}