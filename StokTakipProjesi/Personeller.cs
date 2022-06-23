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
    public partial class Personeller : DevExpress.XtraEditors.XtraForm
    {
        public Personeller()
        {
            InitializeComponent();
        }
        Yardimci yardimci = new Yardimci();

        void Temizle()
        {
            tx_P_Ad.Text = "";
            tx_P_ID.Text = "";
            tx_P_Maas.Text = "";
            tx_P_MailAdres.Text = "";
            tx_P_Soyad.Text = "";
            tx_P_TC.Text = "";
            tx_P_Yas.Text = "";
            Lue_P_Birim.EditValue = default;
            Lue_P_Cinsiyet.EditValue = default;
            Lue_P_Gorev.EditValue = default;
            Lue_P_il.EditValue = default;
            Lue_P_ilce.EditValue = default;
            Rtx_P_AcikAdres.Text = "";
            Mtx_P_Telefon.Text = "";
        }

        void PersonelTabloGetir()
        {

            yardimci.TabloListele("Select * from PersonellerTablosu", Grd_Personeller, "PersonellerTablosu");
        }

        private void Personeller_Load(object sender, EventArgs e)
        {
            PersonelTabloGetir();
            gridView1.BestFitColumns();
            yardimci.ililceDoldur("il", "Execute illerGetir ", Lue_P_il);
            yardimci.BirimCinsiyetveGorevDoldur("Birim", "Select * from BirimGetir", Lue_P_Birim);
            yardimci.BirimCinsiyetveGorevDoldur("Gorev", "Select * from  GorevGetir", Lue_P_Gorev);
            yardimci.BirimCinsiyetveGorevDoldur("Cinsiyet", "Select * from  CinsiyetiGetir", Lue_P_Cinsiyet);
        }

        private void Lue_P_il_EditValueChanged(object sender, EventArgs e)
        {
            yardimci.ililceDoldur("ilce", "Execute ilcelerGetir '" + Lue_P_il.EditValue + "'", Lue_P_ilce);
        }

        private void bt_P_Ekle_Click(object sender, EventArgs e)
        {
            if (tx_P_Ad.Text == "" || tx_P_Maas.Text == "" || tx_P_MailAdres.Text == "" || tx_P_Soyad.Text == ""
                      || tx_P_TC.Text == "" || tx_P_Yas.Text == "" || Lue_P_Birim.EditValue == null ||
                      Lue_P_Cinsiyet.EditValue == null || Lue_P_Gorev.EditValue == null || Lue_P_il.EditValue == null
                      || Lue_P_ilce.Text == null || Mtx_P_Telefon.Text == "" || dt_P_isegiris.Value == null)
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                yardimci.CRUDislemleri("Execute PersonelTablosuKayitEkle '" + tx_P_Ad.Text + "','" + tx_P_Soyad.Text + "','" + Mtx_P_Telefon.Text + "'" +
               ",'" + tx_P_TC.Text + "','" + int.Parse(tx_P_Yas.Text) + "','" + Lue_P_Cinsiyet.EditValue + "','" + tx_P_MailAdres.Text + "'" +
               ",'" + Lue_P_il.EditValue + "','" + Lue_P_ilce.EditValue + "','" + Rtx_P_AcikAdres.Text + "','" + Lue_P_Gorev.EditValue + "'" +
               ",'" + dt_P_isegiris.Value.ToString("yyyy-MM-dd") + "','" + decimal.Parse(tx_P_Maas.Text) + "'" +
               ",'" + Lue_P_Birim.EditValue + "'");
                PersonelTabloGetir();
                Temizle();
            }
        }

        private void Grd_Personeller_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                DataRow dataRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                if (dataRow != null)
                {
                    tx_P_ID.Text = dataRow[0].ToString();
                    tx_P_TC.Text = dataRow[4].ToString();
                    tx_P_Ad.Text = dataRow[1].ToString();
                    tx_P_Soyad.Text = dataRow[2].ToString();
                    Lue_P_Cinsiyet.Text = dataRow[6].ToString();
                    tx_P_Yas.Text = dataRow[5].ToString();
                    tx_P_MailAdres.Text = dataRow[7].ToString();
                    Lue_P_il.Text = dataRow[8].ToString();
                    Lue_P_ilce.Text = dataRow[9].ToString();
                    dt_P_isegiris.Text = dataRow[13].ToString();
                    Lue_P_Birim.Text = dataRow[12].ToString();
                    Lue_P_Gorev.Text = dataRow[11].ToString();
                    Mtx_P_Telefon.Text = dataRow[3].ToString();
                    tx_P_Maas.Text = dataRow[14].ToString();
                    Rtx_P_AcikAdres.Text = dataRow[10].ToString();
                }
            }
            catch (Exception)
            { MessageBox.Show("Kayıt Eklenirken Bir Sorun Oluştu !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void bt_P_Sil_Click(object sender, EventArgs e)
        {
            if (tx_P_ID.Text == null)
            {
                MessageBox.Show("Bir Personel Seçip Tekrar Deneyiniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                yardimci.CRUDislemleri("Execute PersonelTablosuKayitSil '" + int.Parse(tx_P_ID.Text) + "'", "Sil");
                PersonelTabloGetir();
                Temizle();
            }
        }

        private void bt_P_Guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (tx_P_ID.Text != "")
                {

                    yardimci.con();
                    SqlCommand cmd = new SqlCommand("PersonelKayitGuncelle", yardimci.con());
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Personelid", SqlDbType.Int).Value = tx_P_ID.Text;
                    cmd.Parameters.Add("@PersonelAd", SqlDbType.VarChar, 50).Value = tx_P_Ad.Text;
                    cmd.Parameters.Add("@PersonelSoyad", SqlDbType.VarChar, 50).Value = tx_P_Soyad.Text;
                    cmd.Parameters.Add("@Telefon", SqlDbType.VarChar, 15).Value = Mtx_P_Telefon.Text;
                    cmd.Parameters.Add("@TC", SqlDbType.VarChar, 11).Value = tx_P_TC.Text;
                    cmd.Parameters.Add("@Yas", SqlDbType.Int).Value = tx_P_Yas.Text;
                    cmd.Parameters.Add("@Cinsiyet", SqlDbType.Int).Value = Lue_P_Cinsiyet.EditValue;
                    cmd.Parameters.Add("@PersonelEmail", SqlDbType.VarChar, 100).Value = tx_P_MailAdres.Text;
                    cmd.Parameters.Add("@il", SqlDbType.Int).Value = Lue_P_il.EditValue;
                    cmd.Parameters.Add("@ilce", SqlDbType.Int).Value = Lue_P_ilce.EditValue;
                    cmd.Parameters.Add("@Acikadres", SqlDbType.VarChar, 400).Value = Rtx_P_AcikAdres.Text;
                    cmd.Parameters.Add("@Gorev", SqlDbType.Int).Value = Lue_P_Gorev.EditValue;
                    cmd.Parameters.Add("@IseGirisTarih", SqlDbType.Date).Value = dt_P_isegiris.Value.ToString("yyyy-MM-dd");
                    cmd.Parameters.Add("@MAas", SqlDbType.Decimal).Value = tx_P_Maas.Text;
                    cmd.Parameters.Add("@Birim", SqlDbType.Int).Value = Lue_P_Birim.EditValue;
                    cmd.ExecuteNonQuery();
                    yardimci.con().Close();
                    MessageBox.Show("Kayıt Güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PersonelTabloGetir();
                    Temizle();
                }
                else
                {
                    MessageBox.Show("Bir Personel Seçip Tekrar Deneyiniz !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception)
            {
                    MessageBox.Show("Bir Sorun Oluştu Tekrar Deneyiniz !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


    }
}