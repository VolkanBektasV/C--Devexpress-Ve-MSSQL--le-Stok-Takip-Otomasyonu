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
    public partial class Hareketler : DevExpress.XtraEditors.XtraForm
    {
        public Hareketler()
        {
            InitializeComponent();
        }
        Yardimci yardimci = new Yardimci();
        private void Hareketler_Load(object sender, EventArgs e)
        {
            yardimci.TabloListele("Select * from MusteriHareketTablosu", Grd_Hareket_Musteri,"MusteriHareketTablosu");
            gridView1.BestFitColumns();
            yardimci.TabloListele("Select * from StokHareketTablosu", Grd_Hareket_Stok,"StokHareketTablosu");
            gridView2.BestFitColumns();
        }

        private void Grd_Hareket_Musteri_DoubleClick(object sender, EventArgs e)
        {
            FaturaUrunDetay detay = new FaturaUrunDetay();
            DataRow datarow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (datarow != null)
            {
                detay.id = datarow["FATURA ID"].ToString();
            }
            detay.Show();
        }
    }
}