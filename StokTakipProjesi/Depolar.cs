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
    public partial class Depolar : DevExpress.XtraEditors.XtraForm
    {
        public Depolar()
        {
            InitializeComponent();
        }
        Yardimci yardimci = new Yardimci();
        void temizle()
        {
            tx_D_ID.Text = "";
            tx_D_Ad.Text = "";
            Lue_D_il.EditValue = default;
            Lue_D_ilce.EditValue = default;
            Rtx_D_AcikAdres.Clear();
        }
        void DepoTabloGetir()
        {
            yardimci.TabloListele("Select * from DepolarTablosu", Grd_Depolar, "DepolarTablosu");
            gridView1.BestFitColumns();
        }

        private void Depolar_Load(object sender, EventArgs e)
        {
            tx_D_ID.Enabled = false;
            DepoTabloGetir();
            yardimci.ililceDoldur("il", "Execute illerGetir ", Lue_D_il);
        }

        private void Lue_D_il_EditValueChanged(object sender, EventArgs e)
        {
            yardimci.ililceDoldur("ilce", "Execute ilcelerGetir '" + Lue_D_il.EditValue + "'", Lue_D_ilce);
        }

        private void bt_P_Ekle_Click(object sender, EventArgs e)
        {
            if (Lue_D_il.EditValue == null || Lue_D_ilce.EditValue == null || tx_D_Ad.Text == "" || Rtx_D_AcikAdres.Text == "")
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                yardimci.CRUDislemleri("Execute DepoEkle '" + tx_D_Ad.Text + "','" + Lue_D_il.EditValue + "','" + Lue_D_ilce.EditValue + "','" + Rtx_D_AcikAdres.Text + "'","Kaydet");
                DepoTabloGetir();
                temizle();
            }
        }

        private void Grd_Depolar_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                DataRow datarow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                if (datarow != null)
                {
                    tx_D_ID.Text = datarow[0].ToString();
                    tx_D_Ad.Text = datarow[1].ToString();
                    Lue_D_il.Text = datarow[2].ToString();
                    Lue_D_ilce.Text = datarow[3].ToString();
                    Rtx_D_AcikAdres.Text = datarow[4].ToString();
                }
            }
            catch (Exception)
            { MessageBox.Show("Bir Sorun Oluştu !!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void bt_P_Sil_Click(object sender, EventArgs e)
        {
            if (tx_D_ID.Text=="") 
            {
                MessageBox.Show("Bir Kayıt Seçip tekrar deneyiniz!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                yardimci.CRUDislemleri("Execute DepoTablosuKayitSil '"+int.Parse(tx_D_ID.Text)+"'","Sil");
                DepoTabloGetir();
                temizle();
            }
        }

        private void bt_P_Guncelle_Click(object sender, EventArgs e)
        {
            if (tx_D_ID.Text!="")
            {
                yardimci.CRUDislemleri("Execute DepoKayitGuncelleme '"+int.Parse(tx_D_ID.Text)+"','"+tx_D_Ad.Text+"','"+Lue_D_il.EditValue+"','"+Lue_D_ilce.EditValue+"','"+Rtx_D_AcikAdres.Text+"'", "Guncelle");
                DepoTabloGetir();
                temizle();
            }
            else
            {
                MessageBox.Show("Bir Kayıt Seçip tekrar deneyiniz!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}