using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//SQL KÜTPHANESİ KULLANMAK İÇİN
using System.Data.SqlClient;
//***********************************
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.IO;
using System.Diagnostics.Eventing.Reader;

namespace WindowsFormsApp1
{
    public partial class ogrenci2 : Form
    {

        public ogrenci2()
        {

            InitializeComponent();
        }
      
       
        //SQL BAĞLANTISI KURMAK İÇİN
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-2E215I9;Initial Catalog=ogrenci;Integrated Security=True");





        private void button3_Click_1(object sender, EventArgs e)
        {
           
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            if (textBox1.Text == "") foreach (Control items in Controls) if (items is TextBox) items.Text = "";
            SqlCommand komut = new SqlCommand("select *from OgrenciBilgi where TcNo like '" + textBox1.Text + "'", baglanti);


            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                textBox2.Text = dr["OgrenciAdi"].ToString().ToUpper();
                    
                textBox3.Text = dr["OgrenciSoyadi"].ToString().ToUpper();
                textBox4.Text = dr["TelefonNo"].ToString();
                textBox5.Text = dr["Gmail"].ToString();
                textBox6.Text = dr["Okul"].ToString().ToUpper();


            }

            if (dr.Read())
            {
                MessageBox.Show("GİRİŞ BAŞARILI");
            }



            baglanti.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            staj_defteri s2 = new staj_defteri();
            s2.Show();
            this.Hide();
        }
    }
}
