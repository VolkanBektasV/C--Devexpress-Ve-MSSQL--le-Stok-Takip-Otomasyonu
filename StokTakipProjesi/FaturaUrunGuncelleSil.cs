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
    public partial class FaturaUrunGuncelleSil : DevExpress.XtraEditors.XtraForm
    {
        public FaturaUrunGuncelleSil()
        {
            InitializeComponent();
        }
        Yardimci yardimci = new Yardimci();

        void TabloYenile()
        {
            Stoklar stoklar = (Stoklar)Application.OpenForms["Stoklar"];
            stoklar.StokTabloGetir();
            FaturaUrunDetay FUD = (FaturaUrunDetay)Application.OpenForms["FaturaUrunDetay"];
            FUD.FaturaUrunDetayTablo();
        }

        void temizle()
        {
            tx_F_FATURAID.Text = "";
            tx_F_SatisFiyat.Text = "";
            tx_F_StokID.Text = "";
            tx_F_ToplamTutar.Text = "";
            tx_F_UrunID.Text = "";
            Nud_F_Adet.Value = 0;
        }

        public string FaturaID;
        public string adet;

        private void FaturaUrunGuncelleSil_Load(object sender, EventArgs e)
        {

        }

        private void bt_Guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (FaturaID != "")
                {
                    decimal toplam, fiyat, adet;
                    adet = Convert.ToDecimal(Nud_F_Adet.Value);
                    fiyat = Convert.ToDecimal(tx_F_SatisFiyat.Text);
                    toplam = fiyat * adet;
                    tx_F_ToplamTutar.Text = toplam.ToString();
                    yardimci.con();
                    SqlCommand command = new SqlCommand("FaturaUrunGuncelleme", yardimci.con());
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@FaturaUrunID", SqlDbType.Int).Value = FaturaID;
                    command.Parameters.Add("@UrunID", SqlDbType.Int).Value = tx_F_UrunID.Text;
                    command.Parameters.Add("@StokID", SqlDbType.Int).Value = tx_F_StokID.Text;
                    command.Parameters.Add("@Adet", SqlDbType.Int).Value = Nud_F_Adet.Value;
                    command.Parameters.Add("@SatisFiyat", SqlDbType.Decimal).Value = tx_F_SatisFiyat.Text;
                    command.Parameters.Add("@Toplamtutar", SqlDbType.Decimal).Value = tx_F_ToplamTutar.Text;
                    command.ExecuteNonQuery();
                    yardimci.con().Close();
                    MessageBox.Show("Ürün Güncellendi !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TabloYenile();
                    temizle();
                }
            }
            catch (Exception)
            { MessageBox.Show("Ürün Güncellenemedi !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void bt_F_Sil_Click(object sender, EventArgs e)
        {
            try
            {
                if (FaturaID != "")
                {
                    yardimci.CRUDislemleri("Execute FaturaUrunSil '" + int.Parse(FaturaID) + "'", "Sil");
                    TabloYenile();
                    temizle();
                }
            }
            catch (Exception)
            { MessageBox.Show("Ürün Silinemedi Tekrar Deneyiniz!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information); }

        }

        Faturalar faturalar = new Faturalar();
        FaturaUrunSec urunSec;
        private void bt_F_UrunSec_Click(object sender, EventArgs e)
        {
            if (urunSec==null||urunSec.IsDisposed)
            {
                urunSec = new FaturaUrunSec(faturalar,this);
                urunSec.Show();
            }
            
        }

        private void Nud_F_Adet_ValueChanged(object sender, EventArgs e)
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
    }
}