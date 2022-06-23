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
    public partial class Raporlar : DevExpress.XtraEditors.XtraForm
    {
        public Raporlar()
        {
            InitializeComponent();
        }

        private void Raporlar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'TeknolojiMagazaDbDataSet.PersonellerRapor' table. You can move, or remove it, as needed.
            this.PersonellerRaporTableAdapter.Fill(this.TeknolojiMagazaDbDataSet.PersonellerRapor);
            // TODO: This line of code loads data into the 'TeknolojiMagazaDbDataSet.SatilanUrunlerRapor' table. You can move, or remove it, as needed.
            this.SatilanUrunlerRaporTableAdapter.Fill(this.TeknolojiMagazaDbDataSet.SatilanUrunlerRapor);
            // TODO: This line of code loads data into the 'TeknolojiMagazaDbDataSet.StokTablosuRapor' table. You can move, or remove it, as needed.
            this.StokTablosuRaporTableAdapter.Fill(this.TeknolojiMagazaDbDataSet.StokTablosuRapor);
            // TODO: This line of code loads data into the 'TeknolojiMagazaDbDataSet.UrunlerRapor' table. You can move, or remove it, as needed.
            this.UrunlerRaporTableAdapter.Fill(this.TeknolojiMagazaDbDataSet.UrunlerRapor);

            reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            reportViewer2.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            reportViewer3.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            reportViewer4.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
            this.reportViewer4.RefreshReport();
        }
    }
}