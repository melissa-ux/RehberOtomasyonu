﻿using System;
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
    public partial class KişiSilTürkçe : Form
    {
        public KişiSilTürkçe()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
         //   rehberrrTürkçeTableAdapter1.Fill(rehberrDataSet1.RehberrrTürkçe);
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-6BDNKN2\SQLEXPRESS;Initial Catalog=Rehberr;Integrated Security=True");

        public void Listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from RehberrrTürkçe", baglanti);
            DataTable dt = new DataTable();//hafızada tutulacak olan sanal tablo
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }

        private void KişiSilTürkçe_Load(object sender, EventArgs e)
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
                pictureEdit1.Text = dr[9].ToString();


            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            baglanti.Open();
            SqlCommand komutsil = new SqlCommand("delete from rehberrrTürkçe  where id=@parametre ", baglanti);
            komutsil.Parameters.AddWithValue("@parametre", dr[0].ToString()); //dr 0 isime denk geliyor iyi ama güncellemei bu şekilde yaptık
            komutsil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
