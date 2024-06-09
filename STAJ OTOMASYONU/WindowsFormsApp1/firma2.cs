using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class firma2 : Form
    {
        public firma2()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-2E215I9;Initial Catalog=ogrenci;Integrated Security=True");
        private void button3_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from OgrenciBilgi", baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        public void verisil (string ad)
        {
            string sil = "Delete From OgrenciBilgi Where OgrenciAdi=@o_a  ";
           
            SqlCommand komut = new SqlCommand(sil,baglanti);
            komut.Parameters.AddWithValue("@o_a", ad);
            komut.ExecuteNonQuery();
            baglanti.Close();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView1.SelectedRows) 
            {
                baglanti.Open();
                string ad = Convert.ToString(drow.Cells[0].Value);
                verisil (ad);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
          
        }
        
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
          

          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ogrenci_cv o_cv = new ogrenci_cv();
            o_cv.Show();
            this.Hide();
        }
    }
}
