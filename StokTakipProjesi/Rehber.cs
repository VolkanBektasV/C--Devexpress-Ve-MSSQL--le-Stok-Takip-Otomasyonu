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
    public partial class Rehber : DevExpress.XtraEditors.XtraForm
    {
        public Rehber()
        {
            InitializeComponent();
        }
        Yardimci yardimci = new Yardimci();
        void personelRehberTabloGetir()
        {
            yardimci.TabloListele("Select * from PersonelRehberTablosu", Grd_Rehber_Personel,"PersonelRehberTablosu");
            yardimci.TabloListele("Select * from MusteriRehberTablosu", Grd_Rehber_Musteri,"MusteriRehberTablosu");
            
        }
        private void Rehber_Load(object sender, EventArgs e)
        {
            personelRehberTabloGetir();
        }
    }
}