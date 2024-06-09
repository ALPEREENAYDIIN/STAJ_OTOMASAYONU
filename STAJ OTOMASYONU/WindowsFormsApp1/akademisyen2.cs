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


namespace WindowsFormsApp1
{
    public partial class akademisyen2 : Form
    {
        public akademisyen2()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-2E215I9;Initial Catalog=ogrenci;Integrated Security=True");


        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            staj_defteri2 staj = new staj_defteri2();
            staj.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            if (textBox1.Text == "") foreach (Control items in Controls) if (items is TextBox) items.Text = "";
            SqlCommand komut = new SqlCommand("select *from OgrenciBilgi where OgrenciNo like '" + textBox1.Text + "'", baglanti);


            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                textBox2.Text = Convert.ToString(dr["OgrenciAdi"]).ToUpper();
                textBox3.Text = Convert.ToString(dr["OgrenciSoyadi"].ToString()).ToUpper();
                textBox4.Text = Convert.ToString(dr["TelefonNo"].ToString()).ToUpper();
                textBox5.Text = Convert.ToString(dr["Gmail"].ToString());
                textBox6.Text = Convert.ToString(dr["Okul"].ToString()).ToUpper();
                textBox7.Text = Convert.ToString(dr["Alan"].ToString()).ToUpper();



            }
            baglanti.Close();
        }
    }
}
