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
    public partial class YeniKişiEkleİngilizce : Form
    {
        KişiEkleİngilizce ekle;
        Rehberİngilizce liste;
        KişiSilİngilizce sil;
        KişiGüncelleİngilizce güncelle;
        Hakkındaİngilizce hakkında;
        public YeniKişiEkleİngilizce()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ekle == null || ekle.IsDisposed)
            {
                ekle = new KişiEkleİngilizce();
                ekle.MdiParent = this; //form içinde form açarken
                ekle.Show();
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (liste == null || liste.IsDisposed)
            {
                liste = new Rehberİngilizce();
                liste.MdiParent = this; //form içinde form açarken
                liste.Show();
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(sil==null|| sil.IsDisposed)
            {
                sil = new KişiSilİngilizce();
                sil.MdiParent=this;
                sil.Show();

            }
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form1 giris = new Form1();
            giris.Show();
            this.Hide();
        }

        private void YeniKişiEkleİngilizce_Load(object sender, EventArgs e)
        {

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (güncelle == null || güncelle.IsDisposed)
            {
                güncelle = new KişiGüncelleİngilizce();
                güncelle.MdiParent = this;
                güncelle.Show();

            }
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (hakkında == null || hakkında.IsDisposed)
            {
                hakkında = new Hakkındaİngilizce();
                hakkında.MdiParent = this;
                hakkında.Show();

            }
        }
    }
}
