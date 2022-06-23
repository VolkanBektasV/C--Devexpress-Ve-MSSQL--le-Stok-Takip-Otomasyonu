using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace StokTakipProjesi
{
    public partial class MainPage : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainPage()
        {
            InitializeComponent();
        }
        Form urunler, musteriler,
            personeller, giderler,
            bankalar, rehber, faturalar,
            depolar, stoklar, hareketler, kasa, raporlar, kullanici;

        AnaSayfa anasayfa = new AnaSayfa();
        public string KullaniciAd;
        private void bt_Depolar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (depolar == null || depolar.IsDisposed)
            {
                depolar = new Depolar();
                depolar.MdiParent = this;
                depolar.Show();
            }
            else
            {
                depolar.Select();
            }
        }

        private void bt_Anasayfa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (anasayfa == null || anasayfa.IsDisposed)
            {
                anasayfa = new AnaSayfa();
                anasayfa.lbl_KullaniciAd.Text = KullaniciAd;
                anasayfa.MdiParent = this;
                anasayfa.Show();
            }
            else
            {
                anasayfa.Select();
            }
        }

        private void MainPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Kapatmak İstediğinize Emin Misiniz ?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void bt_KullaniciEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (kullanici == null || kullanici.IsDisposed)
            {
                kullanici = new Kullaniciislemleri();
                kullanici.Show();
            }
            else
            {
                kullanici.Select();
            }
        }

        private void bt_Office2010Silver_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(DevExpress.LookAndFeel.SkinStyle.Office2010Silver);

        }

        private void bt_DarkSide_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(DevExpress.LookAndFeel.SkinStyle.DarkSide);
        }

        private void bt_Oficce2013DarkGray_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(DevExpress.LookAndFeel.SkinStyle.Office2013DarkGray);
        }

        private void bt_SevenClassic_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(DevExpress.LookAndFeel.SkinStyle.SevenClassic);
        }

        private void bt_SharpPlus_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(DevExpress.LookAndFeel.SkinStyle.SharpPlus);
        }

        private void bt_GlassOceans_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(DevExpress.LookAndFeel.SkinStyle.GlassOceans);
        }

        private void bt_Bezier_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(DevExpress.LookAndFeel.SkinStyle.Bezier);
        }

        private void bT_Foggy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(DevExpress.LookAndFeel.SkinStyle.Foggy);
        }

        private void bt_iMaginary_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(DevExpress.LookAndFeel.SkinStyle.iMaginary);
        }

        private void bt_Stardust_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(DevExpress.LookAndFeel.SkinStyle.Stardust);
        }

        private void bt_TheAsphaltWorld_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(DevExpress.LookAndFeel.SkinStyle.TheAsphaltWorld);
        }

        private void bt_Light_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(DevExpress.LookAndFeel.SkinStyle.DevExpress);
        }

        private void bt_Raporlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (raporlar == null || raporlar.IsDisposed)
            {
                raporlar = new Raporlar();
                raporlar.MdiParent = this;
                raporlar.Show();
            }
            else
            {
                raporlar.Select();
            }
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            Thread.Sleep(6000);
            anasayfa.MdiParent = this;
            anasayfa.lbl_KullaniciAd.Text = KullaniciAd;
            anasayfa.Show();
        }

        private void bt_Kasa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (kasa == null || kasa.IsDisposed)
            {
                kasa = new Kasa();
                kasa.MdiParent = this;
                kasa.Show();
            }
            else
            {
                kasa.Select();
            }
        }

        private void bt_Hareketler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (hareketler == null || hareketler.IsDisposed)
            {
                hareketler = new Hareketler();
                hareketler.MdiParent = this;
                hareketler.Show();
            }
            else
            {
                hareketler.Select();
            }
        }

        private void bt_Stoklar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (stoklar == null || stoklar.IsDisposed)
            {
                stoklar = new Stoklar();
                stoklar.MdiParent = this;
                stoklar.Show();
            }
            else
            {
                stoklar.Select();
            }
        }

        private void bt_Rehber_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (rehber == null || rehber.IsDisposed)
            {
                rehber = new Rehber();
                rehber.MdiParent = this;
                rehber.Show();
            }
            else
            {
                rehber.Select();
            }
        }

        private void bt_Giderler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (giderler == null || giderler.IsDisposed)
            {
                giderler = new Giderler();
                giderler.MdiParent = this;
                giderler.Show();
            }
            else
            {
                giderler.Select();
            }
        }

        private void bt_Bankalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bankalar == null || bankalar.IsDisposed)
            {
                bankalar = new Bankalar();
                bankalar.MdiParent = this;
                bankalar.Show();
            }
            else
            {
                bankalar.Select();
            }
        }

        private void bt_Faturalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (faturalar == null || faturalar.IsDisposed)
            {
                faturalar = new Faturalar();
                faturalar.MdiParent = this;
                faturalar.Show();
            }
            else
            {
                faturalar.Select();
            }
        }

        private void bt_Personeller_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (personeller == null || personeller.IsDisposed)
            {
                personeller = new Personeller();
                personeller.MdiParent = this;
                personeller.Show();
            }
            else
            {
                personeller.Select();
            }
        }

        private void bt_Urunler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (urunler == null || urunler.IsDisposed)
            {
                urunler = new Urunler();
                urunler.MdiParent = this;
                urunler.Show();
            }
            else
            {
                urunler.Select();
            }

        }

        private void bt_Musteriler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (musteriler == null || musteriler.IsDisposed)
            {
                musteriler = new Musteriler();
                musteriler.MdiParent = this;
                musteriler.Show();
            }
            else
            {
                musteriler.Select();
            }
        }
    }
}
