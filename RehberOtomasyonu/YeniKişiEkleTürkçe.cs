using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RehberOtomasyonu
{
    public partial class YeniKişiEkleTürkçe : Form
    {
        KişiEkleTürkçe ekle;
        RehberTürkçe liste;
        KişiSilTürkçe sil;
        Form1 giris;
        HakkındaTürkçe hakkında;
        KişiGüncelleTürkçe güncelle;
        public YeniKişiEkleTürkçe()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(ekle == null || ekle.IsDisposed)
            {
                ekle = new KişiEkleTürkçe();
                ekle.MdiParent = this;
                ekle.Show();
            }

        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(liste == null || liste.IsDisposed)
            {
                liste = new RehberTürkçe();
                liste.MdiParent = this;
                liste.Show();
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (sil == null || sil.IsDisposed)
            {
                sil = new KişiSilTürkçe();
                sil.MdiParent = this;
                sil.Show();
            }
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            giris = new Form1();
            giris.Show();
            this.Hide();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (güncelle == null || güncelle.IsDisposed)
            {
                güncelle = new KişiGüncelleTürkçe();
                güncelle.MdiParent = this;
                güncelle.Show();
            }
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (hakkında == null || hakkında.IsDisposed)
            {
               hakkında = new HakkındaTürkçe();
                hakkında.MdiParent = this;
                hakkında.Show();
            }
        }

        private void YeniKişiEkleTürkçe_Load(object sender, EventArgs e)
        {

        }
    }
}
