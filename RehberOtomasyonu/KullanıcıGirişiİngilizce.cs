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
    public partial class KullanıcıGirişiİngilizce : Form
    {
        public KullanıcıGirişiİngilizce()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (textEdit1.Text == "Melissa" && textEdit2.Text == "123")
            {
                MessageBox.Show("Login Successful");

                YeniKişiEkleİngilizce sec = new YeniKişiEkleİngilizce();
                sec.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Entry");
                textEdit1.Text = "";
                textEdit2.Text = "";
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Form1 giris = new Form1();
            giris.Show();
            this.Hide();
        }

        private void KullanıcıGirişiİngilizce_Load(object sender, EventArgs e)
        {

        }
    }
}
