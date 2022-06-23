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
    public partial class LoginPage : DevExpress.XtraEditors.XtraForm
    {
        public LoginPage()
        {
            InitializeComponent();

        }
        Yardimci yardimci = new Yardimci();
        MainPage mainPage = new MainPage();
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tx_User_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tx_Pass.Focus();
            }
        }

        public string yetkiid, adsoyad, user, passwrd;
        private void tx_Pass_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (tx_User.Text != "" || tx_Pass.Text != "")
                {
                    if (e.KeyCode == Keys.Enter)
                    {
                        yardimci.con();
                        SqlCommand cmd = new SqlCommand("Execute AdminAdsoyadAnasayfa '" + tx_User.Text + "'", yardimci.con());
                        SqlDataReader sqlDataReader = cmd.ExecuteReader();
                        while (sqlDataReader.Read())
                        {
                            adsoyad = sqlDataReader[0].ToString();
                            mainPage.KullaniciAd = adsoyad;
                        }
                        sqlDataReader.Close();
                        SqlCommand adapter = new SqlCommand("Execute Login '"+tx_User.Text+"','"+tx_Pass.Text+"'", yardimci.con());
                        SqlDataReader reader = adapter.ExecuteReader();
                        while (reader.Read())
                        {
                            user = reader[1].ToString();
                            passwrd = reader[2].ToString();
                            yetkiid = reader[3].ToString();
                        }
                        if (tx_User.Text == user && tx_Pass.Text == passwrd)
                        {
                            if (yetkiid == "1")
                            {
                                mainPage.bt_Depolar.Enabled = false;
                                mainPage.bt_Urunler.Enabled = false;
                                mainPage.bt_Stoklar.Enabled = false;
                                mainPage.bt_KullaniciEkle.Enabled = false;
                                mainPage.Show();
                                this.Hide();
                            }
                            if (yetkiid == "2")
                            {
                                mainPage.bt_Personeller.Enabled = false;
                                mainPage.bt_Bankalar.Enabled = false;
                                mainPage.bt_Kasa.Enabled = false;
                                mainPage.bt_Giderler.Enabled = false;
                                mainPage.bt_KullaniciEkle.Enabled = false;
                                mainPage.Show();
                                this.Hide();
                            }
                            if (yetkiid == "3")
                            {
                                mainPage.bt_Urunler.Enabled = false;
                                mainPage.bt_Stoklar.Enabled = false;
                                mainPage.bt_Faturalar.Enabled = false;
                                mainPage.bt_Bankalar.Enabled = false;
                                mainPage.bt_Giderler.Enabled = false;
                                mainPage.bt_Depolar.Enabled = false;
                                mainPage.bt_KullaniciEkle.Enabled = false;
                                mainPage.Show();
                                this.Hide();
                            }
                            if (yetkiid == "4")
                            {
                                mainPage.bt_Urunler.Enabled = false;
                                mainPage.bt_Stoklar.Enabled = false;
                                mainPage.bt_Faturalar.Enabled = false;
                                mainPage.bt_Bankalar.Enabled = false;
                                mainPage.bt_Giderler.Enabled = false;
                                mainPage.bt_Depolar.Enabled = false;
                                mainPage.bt_Hareketler.Enabled = false;
                                mainPage.bt_Kasa.Enabled = false;
                                mainPage.bt_Personeller.Enabled = false;
                                mainPage.bt_Musteriler.Enabled = false;
                                mainPage.bt_Raporlar.Enabled = false;
                                mainPage.bt_KullaniciEkle.Enabled = false;
                                mainPage.Show();
                                this.Hide();
                            }
                            if (yetkiid == "5")
                            {
                                mainPage.bt_Urunler.Enabled = false;
                                mainPage.bt_Stoklar.Enabled = false;
                                mainPage.bt_Giderler.Enabled = false;
                                mainPage.bt_Depolar.Enabled = false;
                                mainPage.bt_Personeller.Enabled = false;
                                mainPage.bt_KullaniciEkle.Enabled = false;
                                mainPage.Show();
                                this.Hide();
                            }
                            if (yetkiid == "6")
                            {

                                mainPage.bt_KullaniciEkle.Enabled = true;
                                mainPage.Show();
                                this.Hide();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı Adı Veya Şifre Yanlış Lütfen Tekrar Deneyiniz !", "Bİlgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        yardimci.con().Close();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bir Sorun Oluştu Lütfen Tekrar Deneyiniz !", "Bİlgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}