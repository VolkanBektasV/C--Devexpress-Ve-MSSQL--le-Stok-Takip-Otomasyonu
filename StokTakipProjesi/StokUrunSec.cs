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
    public partial class StokUrunSec : DevExpress.XtraEditors.XtraForm
    {
        Stoklar stk;
        public StokUrunSec(Stoklar stoklar)
        {
            InitializeComponent();
            this.stk = stoklar;

        }
        Yardimci yardimci = new Yardimci();
        string id;

        private void StokUrunSec_Load(object sender, EventArgs e)
        {
            yardimci.TabloListele("Select * from UrunlerTablosu", Grd_Urun, "UrunlerTablosu");
            gridView1.BestFitColumns();
            yardimci.KategoriDoldur(1, "Execute Kategori1Getir", Lue_U_Kategori);
        }

        private void StokUrunSec_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
        
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                DataRow dataRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                if (dataRow != null)
                {
                    id = dataRow["ID"].ToString();
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

        private void StokUrunSec_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (id != null)
                { stk.tx_S_UrunID.Text = id.ToString(); }
                else
                { MessageBox.Show("Bir Sorun Oluştu Lütfen Kontrol Edip Tekrar Deneyiniz !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            catch (Exception)
            { MessageBox.Show("Bir Sorun Oluştu Lütfen Kontrol Edip Tekrar Deneyiniz !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

        }

        private void tx_U_Kod_EditValueChanged(object sender, EventArgs e)
        {
            yardimci.TabloListele("execute UrunlerTablosu_KodaGoreArama '%" + tx_U_Kod.Text + "%'", Grd_Urun, "UrunlerTablosu_KodaGoreArama");
        }

        private void Lue_U_Kategori_EditValueChanged(object sender, EventArgs e)
        {
            yardimci.TabloListele("Execute UrunlerTablosu_KategoriyeGoreArama '" + Lue_U_Kategori.EditValue + "'", Grd_Urun, "UrunlerTablosu_KategoriyeGoreArama");
        }
    }
}