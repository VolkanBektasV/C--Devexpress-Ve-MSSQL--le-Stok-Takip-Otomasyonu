using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraEditors;
using DevExpress.XtraCharts;
using System.Data.SqlClient;

namespace StokTakipProjesi
{
    public class Yardimci
    {
        //SQL BAĞLANTI CONNECTİON STRİNG
        public SqlConnection con()
        {
            SqlConnection connect = new SqlConnection(@"Data Source=VOLKAN;Initial Catalog=TeknolojiMagazaDb;Integrated Security=True");
            connect.Open();
            return connect;
        }

        // TABLO DOLDURMAK İÇİN METOT
        public void TabloListele(string komut, GridControl gridControl, string tabloismi)
        {
            try
            {
                con();
                SqlDataAdapter adapter = new SqlDataAdapter(komut, con());
                DataSet datatable = new DataSet();
                adapter.Fill(datatable, tabloismi);
                gridControl.DataSource = datatable.Tables[tabloismi];
                con().Close();
            }
            catch (Exception)
            { MessageBox.Show("Tablo Yüklenemiyor !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

        }

        //CRUD İŞLEMLERİ İÇİN METOT 
        public void CRUDislemleri(string sorgu,string işlem=null)
        {
           try
           {
               
                con();
                SqlCommand cmd = new SqlCommand(sorgu, con());
                cmd.ExecuteNonQuery();
                if (işlem == "Kaydet")
                {
                    MessageBox.Show("Kayıt Eklendi !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (işlem == "Sil")
                {
                    MessageBox.Show("Kayıt Silindi !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (işlem == "Guncelle")
                {
                    MessageBox.Show("Kayıt Güncellendi !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                con().Close();
           }
           catch (Exception)
          { MessageBox.Show("Yapmak İstediğiniz İşlemi Alanları Kontrol Ederek Tekrar Ediniz !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        // İL İLÇE DOLDURMAK İÇİN METOT
        public void ililceDoldur(string secim, string sorgu, LookUpEdit ililce)
        {
            try
            {
                con();
                DataTable dataTable = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(sorgu, con());
                adapter.Fill(dataTable);
                if (secim == "il")
                {


                    ililce.Properties.DataSource = dataTable;
                    ililce.Properties.ValueMember = "id";
                    ililce.Properties.DisplayMember = "İLLER";
                    ililce.Properties.PopulateColumns();
                    ililce.Properties.Columns[0].Visible = false;
                }

                if (secim == "ilce")
                {


                    ililce.Properties.DataSource = dataTable;
                    ililce.Properties.ValueMember = "id";
                    ililce.Properties.DisplayMember = "İLÇELER";
                    ililce.Properties.PopulateColumns();
                    ililce.Properties.Columns[0].Visible = false;
                    ililce.Properties.Columns[2].Visible = false;


                }
                con().Close();
            }
            catch (Exception)
            { MessageBox.Show("İller İlçeler Yüklenmedi !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information); }


        }

        // KATEGORİ DOLDURMAK İÇİN METOT
        public void KategoriDoldur(int hangikategori, string sorgu, LookUpEdit kategori1 = null)
        {
            try
            {
                con();
                DataTable datatable = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(sorgu, con());
                adapter.Fill(datatable);
                if (hangikategori == 1)
                {
                    kategori1.Properties.DataSource = datatable;
                    kategori1.Properties.ValueMember = "K1_ID";
                    kategori1.Properties.DisplayMember = "KATEGORİ 1";
                    kategori1.Properties.PopulateColumns();
                    kategori1.Properties.Columns[0].Visible = false;
                }
                if (hangikategori == 2)
                {
                    kategori1.Properties.DataSource = datatable;
                    kategori1.Properties.ValueMember = "K2_ID";
                    kategori1.Properties.DisplayMember = "KATEGORİ 2";
                    kategori1.Properties.PopulateColumns();
                    kategori1.Properties.Columns[0].Visible = false;
                    kategori1.Properties.Columns[2].Visible = false;
                }
                if (hangikategori == 3)
                {
                    kategori1.Properties.DataSource = datatable;
                    kategori1.Properties.ValueMember = "K3_ID";
                    kategori1.Properties.DisplayMember = "KATEGORİ 3";
                    kategori1.Properties.PopulateColumns();
                    kategori1.Properties.Columns[0].Visible = false;
                    kategori1.Properties.Columns[2].Visible = false;
                }
                con().Close();
            }
            catch (Exception)
            { MessageBox.Show("Kategoriler Yüklenmedi !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        // MARKA DOLDURMAK İÇİN METOT
        public void MarkaDoldur(LookUpEdit marka)
        {
            try
            {
                con();
                DataTable dataTable = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter("Select * from MarkaAdiGetir", con());
                adapter.Fill(dataTable);
                marka.Properties.DataSource = dataTable;
                marka.Properties.ValueMember = "MarkaID";
                marka.Properties.DisplayMember = "MARKA ADI";
                marka.Properties.PopulateColumns();
                marka.Properties.Columns[0].Visible = false;
                con().Close();
            }
            catch (Exception)
            { MessageBox.Show("Markalar Yüklenmedi !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        // DEPO DOLDURMAK İÇİN METOT
        public void DepoDoldur(LookUpEdit depo)
        {
            try
            {
                con();
                DataTable dataTable = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter("Select * from DepoAdiGetir", con());
                adapter.Fill(dataTable);
                depo.Properties.DataSource = dataTable;
                depo.Properties.ValueMember = "DepoID";
                depo.Properties.DisplayMember = "DEPO ADI";
                depo.Properties.PopulateColumns();
                depo.Properties.Columns[0].Visible = false;
                con().Close();
            }
            catch (Exception)
            { MessageBox.Show("Depolar Yüklenmedi !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
        
        //PERSONEL DOLDUR
        public void PersonelDoldur(LookUpEdit personel)
        {
            try
            {
                con();
                DataTable dataTable = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter("Select * from PersonelGetir", con());
                adapter.Fill(dataTable);
                personel.Properties.DataSource = dataTable;
                personel.Properties.ValueMember = "ID";
                personel.Properties.DisplayMember = "PERSONELLER";
                personel.Properties.PopulateColumns();
                personel.Properties.Columns[0].Visible = false;
                con().Close();
            }
            catch (Exception)
            { MessageBox.Show("Personeller Yüklenmedi !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        // BANKA ADI Ve MUSTERi DOLDURMAK İÇİN METOT
        public void BankaAdıMusteriDoldur(string secim, string sorgu, LookUpEdit lookUpEdit)
        {
            con();
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sorgu, con());
            adapter.Fill(dataTable);
            if (secim == "Musteri")
            {
                try
                {
                    lookUpEdit.Properties.DataSource = dataTable;
                    lookUpEdit.Properties.ValueMember = "MusteriID";
                    lookUpEdit.Properties.DisplayMember = "MUSTERİ";
                    lookUpEdit.Properties.PopulateColumns();
                    lookUpEdit.Properties.Columns[0].Visible = false;
                    con().Close();
                }
                catch (Exception)
                { MessageBox.Show("Müşteriler Yüklenmedi !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            if (secim == "Bankaadı")
            {
                try
                {
                    lookUpEdit.Properties.DataSource = dataTable;
                    lookUpEdit.Properties.ValueMember = "Banka_ID";
                    lookUpEdit.Properties.DisplayMember = "BANKA ADI";
                    lookUpEdit.Properties.PopulateColumns();
                    lookUpEdit.Properties.Columns[0].Visible = false;
                    con().Close();
                }
                catch (Exception)
                { MessageBox.Show("Banka Adları Yüklenmedi !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            if (secim == "Hesaptur")
            {
                try
                {
                    lookUpEdit.Properties.DataSource = dataTable;
                    lookUpEdit.Properties.ValueMember = "HesapID";
                    lookUpEdit.Properties.DisplayMember = "HESAP TÜRÜ";
                    lookUpEdit.Properties.PopulateColumns();
                    lookUpEdit.Properties.Columns[0].Visible = false;
                    con().Close();
                }
                catch (Exception)
                { MessageBox.Show("Hesap Türleri Yüklenmedi !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
        }

        // BİRİM,GÖREV VE CİNSİYET DOLDURMAK İÇİN METOT
        public void BirimCinsiyetveGorevDoldur(string secim, string sorgu, LookUpEdit birimgorev)
        {
            try
            {
                con();
                DataTable dataTable = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(sorgu, con());
                adapter.Fill(dataTable);
                if (secim == "Birim")
                {
                    birimgorev.Properties.DataSource = dataTable;
                    birimgorev.Properties.ValueMember = "BirimID";
                    birimgorev.Properties.DisplayMember = "BİRİM ADI";
                    birimgorev.Properties.PopulateColumns();
                    birimgorev.Properties.Columns[0].Visible = false;
                }
                if (secim == "Gorev")
                {
                    birimgorev.Properties.DataSource = dataTable;
                    birimgorev.Properties.ValueMember = "GorevID";
                    birimgorev.Properties.DisplayMember = "GOREV ADI";
                    birimgorev.Properties.PopulateColumns();
                    birimgorev.Properties.Columns[0].Visible = false;
                }
                if (secim == "Cinsiyet")
                {
                    birimgorev.Properties.DataSource = dataTable;
                    birimgorev.Properties.ValueMember = "CinsiyetID";
                    birimgorev.Properties.DisplayMember = "CİNSİYET";
                    birimgorev.Properties.PopulateColumns();
                    birimgorev.Properties.Columns[0].Visible = false;
                }
                con().Close();
            }
            catch (Exception)
            { MessageBox.Show("Alanlar Yüklenmedi !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

        }

        // KASA GELİR VE GİDER LİSTELE
        string GelenAy, GelenFatura, Ay;
        public void KasaGelirGiderler(int a, LabelControl label = null, ChartControl chartControl = null, string sorgu = null, string chartname = null, GroupControl groupControl = null, string Fatura = null)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(sorgu, con());
                SqlDataReader reader = cmd.ExecuteReader();
                if (a == 1)
                {
                    while (reader.Read())
                    {
                        label.Text = reader[0].ToString() + " TL";
                    }
                }
                if (a == 2)
                {
                    while (reader.Read())
                    {
                        label.Text = reader[0].ToString();
                    }
                }
                if (a == 3)
                {
                    while (reader.Read())
                    {
                        chartControl.Series[chartname].Points.Add(new DevExpress.XtraCharts.SeriesPoint(reader[0], reader[1]));
                    }
                }
                // Chart DEĞİŞTİR
                if (a == 4)
                {
                    groupControl.Text = "SON 5 AY " + Fatura + " GİDERLERİ";
                    chartControl.Series[chartname].Points.Clear();
                    while (reader.Read())
                    {
                        GelenAy = reader[0].ToString();
                        GelenFatura = reader[1].ToString();
                        switch (GelenAy)
                        {
                            case "1":
                                Ay = "OCAK";
                                break;
                            case "2":
                                Ay = "ŞUBAT";
                                break;
                            case "3":
                                Ay = "MART";
                                break;
                            case "4":
                                Ay = "NİSAN";
                                break;
                            case "5":
                                Ay = "MAYIS";
                                break;
                            case "6":
                                Ay = "HAZİRAN";
                                break;
                            case "7":
                                Ay = "TEMMUZ";
                                break;
                            case "8":
                                Ay = "AĞUSTOS";
                                break;
                            case "9":
                                Ay = "EYLÜL";
                                break;
                            case "10":
                                Ay = "EKİM";
                                break;
                            case "11":
                                Ay = "KASIM";
                                break;
                            case "12":
                                Ay = "ARALIK";
                                break;
                            default:
                                break;
                        }
                        chartControl.Series[chartname].Points.Add(new DevExpress.XtraCharts.SeriesPoint(Ay, reader[1]));
                    }
                    con().Close();
                }
                if (a == 5)
                {
                    while (reader.Read())
                    {
                        label.Text = reader[0].ToString() + " TL";
                        groupControl.Text = "SON AYIN " + Fatura + " GİDERLERİ";
                    }
                }
            }
            catch (Exception)
            { MessageBox.Show("Kasa Hareketleri Görüntülenemiyor !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
        
        //ANASAYFA İÇİN METOT
        int ay = DateTime.Now.Month;
        int yil = DateTime.Now.Year;
        public void AnaSayfaDoldur (string sorgu,LabelControl label,int a)
        {

            try
            {
                con();
                SqlCommand cmd = new SqlCommand(sorgu + "'" + ay + "','" + yil + "'", con());
                SqlDataReader reader = cmd.ExecuteReader();
                if (a == 1)
                {
                    while (reader.Read())
                    {
                        label.Text = reader[0].ToString();
                    }
                }
                if (a == 2)
                {
                    while (reader.Read())
                    {
                        label.Text = reader[1].ToString() + " ADET";
                    }
                }
                if (a == 3)
                {
                    while (reader.Read())
                    {
                        label.Text = reader[0].ToString() + " TL";
                    }
                }
                con().Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Ana Sayfa Yüklenirken Bir Sorun Oluştu Lütfen Daha Sonra Tekrar Deneyiniz !","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
           
        }
    }


}
