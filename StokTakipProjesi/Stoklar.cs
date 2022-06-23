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
    public partial class Stoklar : DevExpress.XtraEditors.XtraForm
    {
        public Stoklar()
        {
            InitializeComponent();
        }
        Yardimci yardimci = new Yardimci();
        Random rnd = new Random();
        public string stokkod;
        char karakter;

        void Temizle()
        {
            tx_S_ID.Text = "";
            tx_S_StokKod.Text = "";
            tx_S_UrunID.Text = "";
            tx_S_UrunAlisFiyat.Text = "";
            tx_S_UrunSatisFiyat.Text = "";
            Nud_S_Adet.Value = 0;
            Lue_S_Depo.EditValue=default;
        }

       public void StokTabloGetir()
        {
            yardimci.TabloListele("Select * from StokTablosu", Grd_Stoklar, "StokTablosu");
            gridView1.BestFitColumns();
        }

        void StokKodUret()
        {
            tx_S_StokKod.Text = "";
            stokkod = "";
            int sayi = rnd.Next(1000000, 9999999);
            for (int i = 0; i < 3; i++)
            {
                int krak = rnd.Next(65, 91);
                karakter = Convert.ToChar(krak);
                stokkod += Convert.ToString(karakter);
            }
            tx_S_StokKod.Text = stokkod + sayi.ToString();
        }

        private void Stoklar_Load(object sender, EventArgs e)
        {
            StokTabloGetir();
            StokKodUret();
            yardimci.DepoDoldur(Lue_S_Depo);
        }

        private void bt_S_KodDegis_Click(object sender, EventArgs e)
        {
            StokKodUret();
        }

        private void bt_S_UrunSec_Click(object sender, EventArgs e)
        {
            try
            {
                StokUrunSec urun = new StokUrunSec(this);
                urun.Show();
            }
            catch (Exception)
            { MessageBox.Show("Form Yüklenirken Bir Sorun Oluştu !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        string Urun_id;
        private void bt_P_Ekle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from StokTablosu", yardimci.con());
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Urun_id = reader[2].ToString();
            }
            yardimci.con().Close();
            if (tx_S_StokKod.Text == null || tx_S_UrunAlisFiyat.Text == null ||
                tx_S_UrunSatisFiyat.Text == null || tx_S_UrunID.Text == null ||
                Lue_S_Depo.EditValue == default)
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (tx_S_UrunID.Text == Urun_id)
            {
                MessageBox.Show("Eklemek İstediğiniz Ürün Stokta Var Lütfen Stok Güncelleyiniz !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                yardimci.CRUDislemleri("Execute StokTabloKayitEkle '" + int.Parse(tx_S_UrunID.Text) + "','" + int.Parse((Nud_S_Adet.Value).ToString()) + "','"
                 + Lue_S_Depo.EditValue + "','" + tx_S_StokKod.Text + "','" + decimal.Parse(tx_S_UrunSatisFiyat.Text) + "','"
                 + decimal.Parse(tx_S_UrunAlisFiyat.Text) + "','" + dt_S_Tarih.Value.ToString("yyyy-MM-dd") + "'", "Kaydet");
                StokTabloGetir();
                Temizle();
                StokKodUret();
            }
        }

        private void Grd_Stoklar_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                DataRow dataRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                if (dataRow != null)
                {
                    tx_S_ID.Text = dataRow[0].ToString();
                    tx_S_StokKod.Text = dataRow[1].ToString();
                    tx_S_UrunID.Text = dataRow[2].ToString();
                    Nud_S_Adet.Text = dataRow[9].ToString();
                    tx_S_UrunAlisFiyat.Text = dataRow[10].ToString();
                    tx_S_UrunSatisFiyat.Text = dataRow[11].ToString();
                    dt_S_Tarih.Text = dataRow[12].ToString();
                    Lue_S_Depo.Text = dataRow[13].ToString();
                }
            }
            catch (Exception)
            { MessageBox.Show("Bir Sorun Oluştu !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void bt_P_Sil_Click(object sender, EventArgs e)
        {
            if (tx_S_ID.Text == "")
            {
                MessageBox.Show("Bir Stok Seçip Tekrar Deneyiniz !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                yardimci.CRUDislemleri("Execute StoklarTablosuKayitSil '" + int.Parse(tx_S_ID.Text) + "'", "Sil");
                StokTabloGetir();
                Temizle();
                StokKodUret();
            }
        }

        private void bt_P_Guncelle_Click(object sender, EventArgs e)
        {
            if (tx_S_ID.Text!="")
            {
                yardimci.con();
                SqlCommand cmd = new SqlCommand("StokKayitGuncelle", yardimci.con());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Stokid", SqlDbType.Int).Value = tx_S_ID.Text;
                cmd.Parameters.Add("@UrunID", SqlDbType.Int).Value = tx_S_UrunID.Text;
                cmd.Parameters.Add("@StokAdet", SqlDbType.Int).Value = Nud_S_Adet.Value;
                cmd.Parameters.Add("@Hangidepo", SqlDbType.Int).Value = Lue_S_Depo.EditValue;
                cmd.Parameters.Add("@Stokkod", SqlDbType.VarChar,50).Value = tx_S_StokKod.Text;
                cmd.Parameters.Add("@SatisFiyat", SqlDbType.Decimal).Value = tx_S_UrunSatisFiyat.Text;
                cmd.Parameters.Add("@AlisFiyat", SqlDbType.Decimal).Value = tx_S_UrunAlisFiyat.Text;
                cmd.Parameters.Add("@Tarih", SqlDbType.Date).Value = dt_S_Tarih.Value.ToString("yyyy-MM-dd");
                cmd.ExecuteNonQuery();
                yardimci.con().Close();
                MessageBox.Show("Kayıt Güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                StokTabloGetir();
                Temizle();
                StokKodUret();
            }
            else
            {
                MessageBox.Show("Bir Stok Seçip Tekrar Deneyiniz !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                    
        }
    }
}