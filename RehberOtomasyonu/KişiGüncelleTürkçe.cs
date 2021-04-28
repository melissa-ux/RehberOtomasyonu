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
    public partial class KişiGüncelleTürkçe : Form
    {
        public byte[] resimadres;
        public KişiGüncelleTürkçe()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-6BDNKN2\SQLEXPRESS;Initial Catalog=Rehberr;Integrated Security=True");
        public void Listele()
        {

            SqlDataAdapter da = new SqlDataAdapter("Select * from RehberrrTürkçe", baglanti);
            DataTable dt = new DataTable();//hafızada tutulacak olan sanal tablo
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }
        private void KişiGüncelleTürkçe_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                textEdit1.Text = dr[1].ToString();
                textEdit2.Text = dr[2].ToString();
                textEdit3.Text = dr[3].ToString();
                textEdit8.Text = dr[4].ToString();
                textEdit4.Text = dr[5].ToString();
                textEdit5.Text = dr[6].ToString();
                memoEdit1.Text = dr[7].ToString();
                textEdit7.Text = dr[8].ToString();


            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand(" Select * from rehberrrTürkçe where id=@parametre", baglanti);
            MessageBox.Show(dr[0].ToString());
            komut.Parameters.AddWithValue("@parametre", dr[0].ToString());  
            komut.ExecuteNonQuery();
            SqlDataReader da = komut.ExecuteReader();

            da.Read();

            Byte[] data = new Byte[0];
            data = (Byte[])(da["Fotoğraf"]);
            MemoryStream mem = new MemoryStream(data);
            pictureEdit1.Image = Image.FromStream(mem);
            resimadres = data;
            baglanti.Close();
            if (string.IsNullOrEmpty(pictureEdit1.GetLoadedImageLocation()) == false)
            {



            }
        }
    
        private void simpleButton1_Click(object sender, EventArgs e)
        {

            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);


            FileStream fs;
            BinaryReader br;
            byte[] resim;




            string resimpath = pictureEdit1.GetLoadedImageLocation();

            if (string.IsNullOrEmpty(resimpath) == false)
            {
                fs = new FileStream(resimpath, FileMode.Open, FileAccess.Read);
                br = new BinaryReader(fs);
                resim = br.ReadBytes((int)fs.Length);
                br.Close();
                fs.Close();
            }
            else
            {
                resim = resimadres;
            }

            baglanti.Open();
            SqlCommand komut = new SqlCommand("update rehberrrTürkçe set İsim = @p1, Soyisim = @p2, Doğum_Tarihi = @p3, Meslek = @p4, Telefon_Numarası = @p5, Telefonn_Numarası = @p6, Ev_Adresi = @p7, E_Mail=@p8, Fotoğraf = @p9 where id=@parametre", baglanti);
            komut.Parameters.AddWithValue("@parametre",dr[0].ToString());
            komut.Parameters.AddWithValue("@p1", textEdit1.Text);
            komut.Parameters.AddWithValue("@p2", textEdit2.Text);
            komut.Parameters.AddWithValue("@p3", textEdit3.Text);
            komut.Parameters.AddWithValue("@p4", textEdit8.Text);
            komut.Parameters.AddWithValue("@p5", textEdit4.Text);
            komut.Parameters.AddWithValue("@p6", textEdit5.Text);
            komut.Parameters.AddWithValue("@p7", memoEdit1.Text);
            komut.Parameters.AddWithValue("@p8", textEdit7.Text);
            komut.Parameters.Add("@p9", SqlDbType.Image, resim.Length).Value = resim;
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Güncelleştirildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
