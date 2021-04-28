using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RehberOtomasyonu
{
    public partial class KişiEkleİngilizce : Form
    {
        KişiEkleİngilizce ekle;
        public KişiEkleİngilizce()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-6BDNKN2\SQLEXPRESS;Initial Catalog=Rehberr;Integrated Security=True");
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Rehberrrİngilizce(Name, Surname, Birthday, Job, Phone_Number, Phonee_Number, Home_adress, E_Mail,Photo) values (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8,@p9)", baglanti);
            komut.Parameters.AddWithValue("@p1", textEdit1.Text);
            komut.Parameters.AddWithValue("@p2", textEdit2.Text);
            komut.Parameters.AddWithValue("@p3", textEdit3.Text);
            komut.Parameters.AddWithValue("@p4", textEdit8.Text);
            komut.Parameters.AddWithValue("@p5", textEdit4.Text);
            komut.Parameters.AddWithValue("@p6", textEdit5.Text);
            komut.Parameters.AddWithValue("@p7", memoEdit1.Text);
            komut.Parameters.AddWithValue("@p8", textEdit7.Text);
            komut.Parameters.AddWithValue("@p9", pictureEdit1.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Person Added to Directory.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void KişiEkleİngilizce_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }
    }
    
}
