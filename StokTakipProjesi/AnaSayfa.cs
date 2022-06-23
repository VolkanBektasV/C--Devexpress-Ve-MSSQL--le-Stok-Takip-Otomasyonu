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
    public partial class AnaSayfa : DevExpress.XtraEditors.XtraForm
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        Yardimci yardimci = new Yardimci();
        int ay = DateTime.Now.Month;
        int yil = DateTime.Now.Year;
        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            string sorgu = "select FaturaUrunDetayTablosu.[KATEGORİ 1],sum(FaturaUrunDetayTablosu.Adet) as 'Adet' from FaturaUrunDetayTablosu group by FaturaUrunDetayTablosu.[KATEGORİ 1]";
            yardimci.TabloListele("Select * From SatilanSonUrunler", grd_StokCikis, "SatilanSonUrunler");
            yardimci.TabloListele("Select * From StokAzalanUrunler", grd_AzalanStok, "StokAzalanUrunler");
            yardimci.TabloListele("select top 20  * from StokHareketTablosu order by [GİRİŞ TARİH] desc", Grd_SonAlinanrunler, "StokHareketTablosu");
            yardimci.KasaGelirGiderler(3, null, chr_KategoriAdet, sorgu, "ÜRÜNLER");
            yardimci.AnaSayfaDoldur("Execute BuAyEnCokSatanKategori", lbl_EnKategori, 1);
            yardimci.AnaSayfaDoldur("Execute EnCokUrunAlanMusteri ", lbl_BuAyMusteri, 1);
            yardimci.AnaSayfaDoldur("Execute BuAyEdilenKar ", lbl_BuAyKar, 3);
            yardimci.AnaSayfaDoldur("Execute EnCokUrunAlanMusteri ", lbl_Adet, 2);
        }

    }
}