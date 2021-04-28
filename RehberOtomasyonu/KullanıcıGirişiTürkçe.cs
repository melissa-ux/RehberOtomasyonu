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
    public partial class KullanıcıGirişiTürkçe : Form
    {
        Form1 giris;
        public KullanıcıGirişiTürkçe()
        {
            InitializeComponent();
        }

        private void textEdit4_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
         /*   if (textEdit4.Text == "Melissa" && textEdit3.Text == "123")
            {
                MessageBox.Show("Giriş Başarılı");
*/
                YeniKişiEkleTürkçe KisiEkle = new YeniKişiEkleTürkçe();
                KisiEkle.Show();
                this.Hide();
/*
            }
            else
            {
                MessageBox.Show("Hatalı Giriş");
                textEdit4.Text = "";
                textEdit3.Text = "";
            }/*/
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            giris = new Form1();
            giris.Show();
            this.Hide();
        }

        private void KullanıcıGirişiTürkçe_Load(object sender, EventArgs e)
        {

        }
    }
}
