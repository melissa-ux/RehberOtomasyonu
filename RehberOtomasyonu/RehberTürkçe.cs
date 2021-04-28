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
    public partial class RehberTürkçe : Form
    {
        public RehberTürkçe()
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

        private void RehberTürkçe_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
