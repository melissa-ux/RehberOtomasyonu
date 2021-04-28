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
    public partial class KişiGüncelleİngilizce : Form
    {
        public KişiGüncelleİngilizce()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-6BDNKN2\SQLEXPRESS;Initial Catalog=Rehberr;Integrated Security=True");
        public void Listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from Rehberrrİngilizce", baglanti);
            DataTable dt = new DataTable();//hafızada tutulacak olan sanal tablo
            da.Fill(dt);
            gridControl1.DataSource = dt;

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
                pictureEdit1.Text = dr[9].ToString();


            }
        }

        private void KişiGüncelleİngilizce_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            baglanti.Open();
            SqlCommand komut = new SqlCommand("update rehberrrİngilizce set Name = @p1, Surname = @p2, Birthday = @p3, Job = @p4, Phone_Number = @p5, Phonee_Number = @p6, Home_Adress = @p7, E_Mail=@p8, Photo = @p9 where id=@parametre", baglanti);

            komut.Parameters.AddWithValue("@parametre", dr[0].ToString());
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
            MessageBox.Show("Kayıt Güncelleştirildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Listele();
        }
    }
}
