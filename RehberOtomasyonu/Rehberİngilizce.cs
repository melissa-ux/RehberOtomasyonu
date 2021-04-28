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
    public partial class Rehberİngilizce : Form
    {
        public Rehberİngilizce()
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

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void Rehberİngilizce_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
