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
    public partial class FaturaUrunDetay : DevExpress.XtraEditors.XtraForm
    {
        FaturaUrunGuncelleSil FGuncellesil;
        public FaturaUrunDetay()
        {
            InitializeComponent();
        }
        public string id;
        Yardimci yardimci = new Yardimci();
        public void FaturaUrunDetayTablo()
        {
            yardimci.TabloListele("select * from FaturaUrunDetayTablo2 where [FATURA ID]='"+id+"'",grd_FaturaUrunleri,"FaturaUrunDetayTablo2");
            gridView1.BestFitColumns();
        }
        private void FaturaUrunDetay_Load(object sender, EventArgs e)
        {
            FaturaUrunDetayTablo();
        }

        private void grd_FaturaUrunleri_DoubleClick(object sender, EventArgs e)
        {
            FGuncellesil = new FaturaUrunGuncelleSil();
            DataRow dataRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dataRow!=null)
            {
                FGuncellesil.tx_F_FATURAID.Text = dataRow["FATURA ID"].ToString();
                FGuncellesil.tx_F_SatisFiyat.Text = dataRow[9].ToString();
                FGuncellesil.tx_F_StokID.Text = dataRow[2].ToString();
                FGuncellesil.tx_F_ToplamTutar.Text = dataRow[10].ToString();
                FGuncellesil.tx_F_UrunID.Text = dataRow[1].ToString();
                FGuncellesil.Nud_F_Adet.Text = dataRow[8].ToString();
                FGuncellesil.FaturaID = dataRow[0].ToString();
            }
            FGuncellesil.ShowDialog();
        }
    }
}