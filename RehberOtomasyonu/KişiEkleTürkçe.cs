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
using System.IO;
namespace RehberOtomasyonu
{
    public partial class KişiEkleTürkçe : Form
    {
        public KişiEkleTürkçe()
        {
            InitializeComponent();
        }

        private void KişiEkleTürkçe_Load(object sender, EventArgs e)
        {

        }
            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-6BDNKN2\SQLEXPRESS;Initial Catalog=Rehberr;Integrated Security=True");

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string resimpath = pictureEdit1.GetLoadedImageLocation();
            FileStream fs = new FileStream(resimpath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            byte[] resim = br.ReadBytes((int)fs.Length);
            br.Close();
            fs.Close();
            baglanti.Open(); //kapatmış olduğumuz bağlantıyı açtık
                SqlCommand komut = new SqlCommand("insert into RehberrrTürkçe(İsim, Soyisim, Doğum_Tarihi, Meslek, Telefon_Numarası, Telefonn_Numarası, Ev_Adresi, E_Mail,Fotoğraf) values ( @p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9)", baglanti);
                komut.Parameters.AddWithValue("@p1", textEdit1.Text);
                komut.Parameters.AddWithValue("@p2", textEdit2.Text);
                komut.Parameters.AddWithValue("@p3", textEdit3.Text);
                komut.Parameters.AddWithValue("@p4", textEdit8.Text);
                komut.Parameters.AddWithValue("@p5", textEdit4.Text);
                komut.Parameters.AddWithValue("@p6", textEdit5.Text);
                komut.Parameters.AddWithValue("@p7", memoEdit1.Text);
                komut.Parameters.AddWithValue("@p8", textEdit7.Text);
                komut.Parameters.Add("@p9", SqlDbType.Image,resim.Length).Value=resim;

                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kişi Rehbere Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
