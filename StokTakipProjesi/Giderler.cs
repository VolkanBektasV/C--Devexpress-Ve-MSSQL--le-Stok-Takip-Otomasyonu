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
using System.Data.SqlTypes;

namespace StokTakipProjesi
{
    public partial class Giderler : DevExpress.XtraEditors.XtraForm
    {
        public Giderler()
        {
            InitializeComponent();
        }
        Yardimci yardimci = new Yardimci();

        decimal elektrik, su, dogalgaz, internet, ekstra, toplam, personelmaas;

        void Temizle()
        {
            tx_G_ID.Text = "";
            tx_G_Elektirik.Text = "";
            tx_G_Su.Text = "";
            tx_G_Dogalgaz.Text = "";
            tx_G_PersonelMaas.Text = "";
            tx_G_Internet.Text = "";
            tx_G_Ekstra.Text = "";
            dt_G_Tarih.Text = default;
            Rtx_G_Notlar.Text = "";
            PersonelMaasGetir();
        }

        private void bt_P_Guncelle_Click(object sender, EventArgs e)
        {
            if (tx_G_ID.Text != "")
            {
                yardimci.con();
                SqlCommand cmd = new SqlCommand("GiderKayitGuncelleme", yardimci.con());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@GiderID", SqlDbType.Int).Value = tx_G_ID.Text;
                cmd.Parameters.Add("@elektrik", SqlDbType.Decimal).Value = tx_G_Elektirik.Text;
                cmd.Parameters.Add("@Su", SqlDbType.Decimal).Value = tx_G_Su.Text;
                cmd.Parameters.Add("@Dogalgaz", SqlDbType.Decimal).Value = tx_G_Dogalgaz.Text;
                cmd.Parameters.Add("@Internet", SqlDbType.Decimal).Value = tx_G_Internet.Text;
                cmd.Parameters.Add("@PersonelMaas", SqlDbType.Decimal).Value = tx_G_PersonelMaas.Text;
                cmd.Parameters.Add("@Ekstra", SqlDbType.Decimal).Value = tx_G_Ekstra.Text;
                cmd.Parameters.Add("@notlar", SqlDbType.VarChar, 200).Value = Rtx_G_Notlar.Text;
                cmd.Parameters.Add("@Tarih", SqlDbType.Date).Value = dt_G_Tarih.Value.ToString("yyyy-MM-dd");
                cmd.Parameters.Add("@Toplam", SqlDbType.Decimal).Value = toplama();
                cmd.ExecuteNonQuery();
                yardimci.con().Close();
                MessageBox.Show("Kayıt Güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Gidertablolistele();
                Temizle();
            }
            else
            {
                MessageBox.Show("Lütfen Bir Kayıt Seçiniz !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        public decimal toplama()
        {
            toplam = 0;
            elektrik = decimal.Parse(tx_G_Elektirik.Text);
            su = decimal.Parse(tx_G_Su.Text);
            internet = decimal.Parse(tx_G_Internet.Text);
            ekstra = decimal.Parse(tx_G_Ekstra.Text);
            dogalgaz = decimal.Parse(tx_G_Dogalgaz.Text);
            personelmaas = decimal.Parse(tx_G_PersonelMaas.Text);
            toplam = elektrik + su + internet + ekstra + dogalgaz + personelmaas;
            return toplam;
        }

        void Gidertablolistele()
        {
            yardimci.TabloListele("select * from GiderlerTablosu", Grd_Giderler, "GiderlerTablosu");
            gridView1.BestFitColumns();
        }

        void PersonelMaasGetir()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("Select sum(Maas) from Personeller where Durum=1 ", yardimci.con()))
                {
                    object result = cmd.ExecuteScalar();
                    tx_G_PersonelMaas.Text = result.ToString();
                }
                tx_G_PersonelMaas.Enabled = false;
            }
            catch (Exception)
            { MessageBox.Show("Bir Sorun Oluştu !!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void Giderler_Load(object sender, EventArgs e)
        {
            Gidertablolistele();
            tx_G_ID.Enabled = false;
            PersonelMaasGetir();
        }
        private void Grd_Giderler_DoubleClick(object sender, EventArgs e)
        {
            DataRow dataRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dataRow != null)
            {
                tx_G_ID.Text = dataRow[0].ToString();
                tx_G_Elektirik.Text = dataRow[1].ToString();
                tx_G_Su.Text = dataRow[2].ToString();
                tx_G_Dogalgaz.Text = dataRow[3].ToString();
                tx_G_PersonelMaas.Text = dataRow[4].ToString();
                tx_G_Internet.Text = dataRow[5].ToString();
                tx_G_Ekstra.Text = dataRow[6].ToString();
                dt_G_Tarih.Text = dataRow[8].ToString();
                Rtx_G_Notlar.Text = dataRow[9].ToString();
            }
        }

        private void bt_P_Ekle_Click(object sender, EventArgs e)
        {
            if (tx_G_Elektirik.Text == null || tx_G_Su.Text == null
                || tx_G_Internet.Text == null || tx_G_Dogalgaz.Text == null || tx_G_PersonelMaas.Text == null)
            {
                MessageBox.Show("Lütfen Alanları Boş Geçmeyiniz !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                yardimci.con();
                SqlCommand cmd = new SqlCommand("GiderlerTabloKayitEkle", yardimci.con());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Elektrik", SqlDbType.Decimal).Value = tx_G_Elektirik.Text;
                cmd.Parameters.Add("@Su", SqlDbType.Decimal).Value = tx_G_Su.Text;
                cmd.Parameters.Add("@Dogalgaz", SqlDbType.Decimal).Value = tx_G_Dogalgaz.Text;
                cmd.Parameters.Add("@Internet", SqlDbType.Decimal).Value = tx_G_Internet.Text;
                cmd.Parameters.Add("@Personelmaas", SqlDbType.Decimal).Value = tx_G_PersonelMaas.Text;
                cmd.Parameters.Add("@Ekstra", SqlDbType.Decimal).Value = tx_G_Ekstra.Text;
                cmd.Parameters.Add("@Notlar", SqlDbType.VarChar, 200).Value = Rtx_G_Notlar.Text;
                cmd.Parameters.Add("@Tarih", SqlDbType.Date).Value = dt_G_Tarih.Value.ToString("yyyy-MM-dd");
                cmd.Parameters.Add("@Toplam", SqlDbType.Decimal).Value = toplama();
                cmd.ExecuteNonQuery();
                yardimci.con().Close();
                MessageBox.Show("Kayıt Eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Gidertablolistele();
                Temizle();
            }
        }

        private void bt_G_Sil_Click(object sender, EventArgs e)
        {
            if (tx_G_ID.Text == "")
            {
                MessageBox.Show("Lütfen Seçiminizi Yapıp Tekrar Deneyiniz !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                yardimci.CRUDislemleri("Execute GiderlerTablosuKayitSil'" + int.Parse(tx_G_ID.Text) + "'", "Sil");
                Gidertablolistele();
                Temizle();
            }
        }

    }
}