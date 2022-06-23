using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakipProjesi
{
    public partial class Kullaniciislemleri : DevExpress.XtraEditors.XtraForm
    {
        public Kullaniciislemleri()
        {
            InitializeComponent();
        }
        Yardimci yardimci = new Yardimci();
        public string yetkiid, pid, secilenTc;
        int Adminid;

        void BirimYetkiAl()
        {
            if (tx_PersonelBirim.Text != "")
            {
                yardimci.con();
                SqlCommand cmd = new SqlCommand("Execute BirimYetkiGetir '" + tx_PersonelBirim.Text + "'", yardimci.con());
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    yetkiid = reader["YetkiID"].ToString();
                }
                yardimci.con().Close();
            }
        }

        void AdminTabloListele()
        {
            yardimci.TabloListele("select * from AdminTablosu", grd_Kullanici, "AdminTablosu");
        }

        void Temizle()
        {
            tx_Personeltc.Text = "";
            tx_PersonelSifre.Text = "";
            tx_PersonelBirim.Text = "";
            tx_PersonelAd.Text = "";
        }

        private void Kullaniciislemleri_Load(object sender, EventArgs e)
        {
            AdminTabloListele();
        }

        private void bt_S_PersonelSec_Click(object sender, EventArgs e)
        {
            try
            {
                Personelsec personelsec = new Personelsec(this);
                personelsec.Show();
            }
            catch (Exception)
            { MessageBox.Show("Yapmak İstediğiniz İşlem Şuan da Yapılamıyor !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information); }

        }

        string TC;
        private void bt_P_Ekle_Click(object sender, EventArgs e)
        {
            try
            {

                yardimci.con();
                SqlCommand cmd = new SqlCommand("Select * from AdminTablosu", yardimci.con());
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    TC = reader[2].ToString();
                }
                yardimci.con().Close();
                if (tx_Personeltc.Text == TC || pid == null||secilenTc==TC)
                {
                    MessageBox.Show("Bu Kullanıcı Sisteme Tanımlı Lütfen Şifre Güncelleyin Veya Başka Bir Personel seçip Bir Daha Deneyin !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (tx_PersonelAd.Text == "" || tx_PersonelSifre.Text == "" || tx_PersonelBirim.Text == "" || tx_Personeltc.Text == "")
                {
                    MessageBox.Show("Lütfen Bir Kullanıcı Seçiniz Veya Tüm Alanları Doldurunuz !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    BirimYetkiAl();
                    yardimci.CRUDislemleri("Execute AdminKayitEkle '" + tx_Personeltc.Text + "','" + tx_PersonelSifre.Text + "','" + int.Parse(yetkiid) + "','" + tx_PersonelAd.Text + "','" + tx_PersonelBirim.Text + "','" + int.Parse(pid.ToString()) + "'", "Kaydet");
                    AdminTabloListele();
                    Temizle();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bu Kullanıcı Sisteme Lütfen Güncelleyin !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void bt_P_Sil_Click(object sender, EventArgs e)
        {
            if (tx_Personeltc.Text == "")
            {
                MessageBox.Show("Bir Kullanıcı Seçip Tekrar Deneyiniz !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                yardimci.CRUDislemleri("Execute AdminKayitSil '" + tx_Personeltc.Text + "'", "Sil");
                AdminTabloListele();
                Temizle();
            }
        }

        private void bt_P_Guncelle_Click(object sender, EventArgs e)
        {
            if (Adminid != 0)
            {
                yardimci.CRUDislemleri("Execute AdminKayitGuncelleme '" + Adminid + "','" + tx_PersonelSifre.Text + "'", "Guncelleme");
                AdminTabloListele();
                Temizle();
            }
            else
            {
                MessageBox.Show("Bir Kullanıcı Seçip Tekrar Deneyiniz !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grd_Kullanici_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                DataRow dataRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                if (dataRow != null)
                {
                    Adminid = Convert.ToInt32(dataRow[0].ToString());
                    tx_PersonelAd.Text = dataRow[1].ToString();
                    tx_Personeltc.Text = dataRow[2].ToString();
                    tx_PersonelBirim.Text = dataRow[3].ToString();
                }
            }
            catch (Exception)
            { MessageBox.Show("Bir Sorun Oluştu !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}