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
    public partial class FaturaUrunSec : DevExpress.XtraEditors.XtraForm
    {
        Faturalar Fatura;
        FaturaUrunGuncelleSil guncelleSil;
        public FaturaUrunSec(Faturalar ftra,FaturaUrunGuncelleSil faturaUrunGuncelle)
        {
            InitializeComponent();
            this.Fatura = ftra;
            this.guncelleSil = faturaUrunGuncelle;
        }
        Yardimci yardimci = new Yardimci();

        string Urunid, Stokid, SatisFiyat, marka;
        public string adet;

        private void FaturaUrunSec_Load(object sender, EventArgs e)
        {
            yardimci.TabloListele("Select * From StokTablosu", Grd_StokUrun, "StokTablosu");
            gridView1.BestFitColumns();
        }
        private void FaturaUrunSec_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (Urunid != null || Stokid != null || SatisFiyat != null || adet == null)
                {
                    Fatura.tx_F_UrunID.Text = Urunid;
                    Fatura.tx_F_StokID.Text = Stokid;
                    Fatura.tx_F_SatisFiyat.Text = SatisFiyat;
                    Fatura.adet = adet;
                    Fatura.marka = marka;
                    guncelleSil.tx_F_UrunID.Text = Urunid;
                    guncelleSil.tx_F_StokID.Text = Stokid;
                    guncelleSil.tx_F_SatisFiyat.Text = SatisFiyat;
                    guncelleSil.adet = adet;
                }
                else
                { MessageBox.Show("Seçtiğiniz Üründe Adet Veya Satış Fiyatı Bulunmamaktadır"); }
            }
            catch (Exception)
            { MessageBox.Show("Kayıt Eklenirken Bir Sorun Oluştu !!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void Grd_StokUrun_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                DataRow dataRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                if (dataRow != null)
                {
                    Urunid = dataRow["URUN ID"].ToString();
                    Stokid = dataRow["STOK ID"].ToString();
                    SatisFiyat = dataRow["SATIŞ FİYAT"].ToString();
                    adet =dataRow["ADET"].ToString();
                    marka = dataRow["MARKA"].ToString();
                }
                DialogResult dialogResult;
                dialogResult = MessageBox.Show("Seçiminizi Değiştirmek İstermisiniz ?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.No)
                {
                    this.Close();
                }
            }
            catch (Exception)
            { MessageBox.Show("Ürün Seçilemedi !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
    }
}