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
    public partial class Kasa : DevExpress.XtraEditors.XtraForm
    {
        public Kasa()
        {
            InitializeComponent();
        }
        Yardimci yardimci = new Yardimci();
        int ay = DateTime.Now.Month;//Ay ALmak
        int yil = DateTime.Now.Year;//Yıl Almak
        public void Giderler()
        {
            try
            {
                yardimci.KasaGelirGiderler(1, lbl_ToplamGider, null, "select * from KasaToplamGider");
                yardimci.KasaGelirGiderler(2, lbl_G_PersonelSayisi, null, "select * from KasaToplamPersonelSayisi");
                yardimci.KasaGelirGiderler(1, lbl_G_ToplamAUrunFiyat, null, "select * from KasaToplamUrunAlisFiyat");
                yardimci.KasaGelirGiderler(2, lbl_G_ToplamUrun, null, "select * from KasaToplamUrunAdet");
                yardimci.KasaGelirGiderler(1, lbl_PersonelMaas, null, "select * from KasaToplamPersonelMaas");
            }
            catch (Exception)
            { MessageBox.Show("Gider Alanları Dolduralamadı !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information); }


        }

        public void Gelirler()
        {
            try
            {
                yardimci.KasaGelirGiderler(1, lbt_ToplamGelir, null, "select * from KasaToplamGelir");
                yardimci.KasaGelirGiderler(1, lbl_K_Edilenkar, null, "select * from KasaToplamEdilenKar");
                yardimci.KasaGelirGiderler(2, lbl_UrunAdet, null, "select * from KasaGelirUrunAdet");
            }
            catch (Exception)
            { MessageBox.Show("Gelir Alanları Dolduralamadı !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information); }

        }

        public void Tablolar()
        {
            try
            {
                yardimci.TabloListele("Select * From FaturaUrunDetayTablosu", Grd_Gelir, "FaturaUrunDetayTablosu");
                yardimci.TabloListele("Select * From KasaFaturaTablosu", Grd_FaturaGider, "KasaFaturaTablosu");
                yardimci.TabloListele("Select * From StokAlisTablosu", Grd_StokAlis, "StokAlisTablosu");
            }
            catch (Exception)
            { MessageBox.Show("Gelir - Gider Tabloları Getirilemedi !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information); }

        }

        void Chart()
        {
            try
            {
                yardimci.KasaGelirGiderler(3, null, chr_Gelir, "select MARKA,sum(Adet) from FaturaUrunDetayTablosu inner join Fatura on FaturaUrunDetayTablosu.[FATURA ID] = Fatura.FaturaID where MONTH(Fatura.Tarih) = '"+ay+"' and YEAR(Fatura.Tarih) = '"+yil+"'group by MARKA", "ÜRÜNLER");
            }
            catch (Exception)
            { MessageBox.Show("Grafik Alanları Dolduralamadı !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void Kasa_Load(object sender, EventArgs e)
        {
            try
            {
                Giderler();
                Gelirler();
                Tablolar();
                Chart();
                //KATEGORİ DOLDUR
                yardimci.KategoriDoldur(1, "Execute Kategori1Getir", Lue_K_Kategori);
            }
            catch (Exception)
            { MessageBox.Show("Kasa Modülü Yüklenirken Bir Hata Oluştu !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void Lue_K_Kategori_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                yardimci.KasaGelirGiderler(2, lbl_K_Kategoriadet, null, "Select sum([ADET]) from FaturaUrunDetayTablosu Where [KATEGORİ 1]='" + Lue_K_Kategori.Text + "'");
            }
            catch (Exception)
            { MessageBox.Show("Kategori Adetleri Dolduralamadı !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        //Chart Değiştir
        int sayac = 0;
        
        private void GiderlerTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                string elektrik, Su, Dogalgaz, Internet, Ekstra;
                elektrik = "select top 5 MONTH(TARİH) as 'Tarih',GiderlerTablosu.ELEKTİRİK from GiderlerTablosu Where YEAR(TARİH)>='" + yil + "'order by  TARİH asc";
                Su = "select top 5 MONTH(TARİH) as 'Tarih' ,GiderlerTablosu.SU from GiderlerTablosu where YEAR(TARİH)>='" + yil + "'order by  TARİH asc";
                Dogalgaz = "select top 5 MONTH(TARİH) as 'Tarih',GiderlerTablosu.DOĞALGAZ from GiderlerTablosu Where YEAR(TARİH)>='" + yil + "'order by  TARİH asc";
                Internet = "select top 5 MONTH(TARİH) as 'Tarih' ,GiderlerTablosu.İNTERNET from GiderlerTablosu where YEAR(TARİH)>= '" + yil + "'order by  TARİH asc";
                Ekstra = "select top 5 MONTH(TARİH) as 'Tarih' ,GiderlerTablosu.EKSTRA from GiderlerTablosu Where YEAR(TARİH)>='" + yil + "'order by  TARİH asc";
                sayac++;
                if (sayac > 0 && sayac <= 5)
                {
                    yardimci.KasaGelirGiderler(4, null, chr_Gider, elektrik, "AYLAR", grp_Fatura, "ELEKTRİK");
                    yardimci.KasaGelirGiderler(5, lbl_FaturaGider, null, "Select sum(ELEKTİRİK) from GiderlerTablosu Where Month(TARİH)='" + ay + "'and Year(TARİH)='" + yil + "'", null, grp_Faturagider, "ELEKTRİK");
                }
                if (sayac > 5 && sayac <= 10)
                {
                    yardimci.KasaGelirGiderler(4, null, chr_Gider, Su, "AYLAR", grp_Fatura, "SU");
                    yardimci.KasaGelirGiderler(5, lbl_FaturaGider, null, "Select sum(SU) from GiderlerTablosu Where Month(TARİH)='" + ay + "'and Year(TARİH)='" + yil + "'", null, grp_Faturagider, "SU");
                }
                if (sayac > 10 && sayac <= 15)
                {
                    yardimci.KasaGelirGiderler(4, null, chr_Gider, Dogalgaz, "AYLAR", grp_Fatura, "DOĞALGAZ");
                    yardimci.KasaGelirGiderler(5, lbl_FaturaGider, null, "Select sum(DOĞALGAZ) from GiderlerTablosu Where Month(TARİH)='" + ay + "'and Year(TARİH)='" + yil + "'", null, grp_Faturagider, "DOĞALGAZ");
                }
                if (sayac > 15 && sayac <= 20)
                {
                    yardimci.KasaGelirGiderler(4, null, chr_Gider, Internet, "AYLAR", grp_Fatura, "İNTERNET");
                    yardimci.KasaGelirGiderler(5, lbl_FaturaGider, null, "Select sum(İNTERNET) from GiderlerTablosu Where Month(TARİH)='" + ay + "'and Year(TARİH)='" + yil + "'", null, grp_Faturagider, "İNTERNET");
                }
                if (sayac > 20 && sayac <= 25)
                {
                    yardimci.KasaGelirGiderler(4, null, chr_Gider, Ekstra, "AYLAR", grp_Fatura, "EKSTRA");
                    yardimci.KasaGelirGiderler(5, lbl_FaturaGider, null, "Select sum(EKSTRA) from GiderlerTablosu Where Month(TARİH)='" + ay + "'and Year(TARİH)='" + yil + "'", null, grp_Faturagider, "EKSTRA");
                }
                if (sayac == 26)
                {
                    sayac = 0;
                }
            }
            catch (Exception)
            { MessageBox.Show("Grafikler Yüklenirken Bir Hata Oluştu !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information); }


        }

        private void chr_Gider_MouseHover(object sender, EventArgs e)
        {
            GiderlerTimer.Enabled = false;
        }

        private void chr_Gider_MouseLeave(object sender, EventArgs e)
        {
            GiderlerTimer.Enabled = true;
        }

    }
}