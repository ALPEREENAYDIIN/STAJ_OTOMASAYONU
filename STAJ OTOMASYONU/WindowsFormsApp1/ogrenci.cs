using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data.Common;

namespace WindowsFormsApp1
{
    public partial class ogrenci : Form
    {
        SqlDataReader dr;
        SqlConnection baglanti;
        SqlCommand komut;


        public ogrenci()
        {
            InitializeComponent();
        }


        private void ogrenci_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)

        {







        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti = new SqlConnection("Data Source=DESKTOP-2E215I9;Initial Catalog=ogrenci;Integrated Security=True");
            baglanti.Open();
            komut = new SqlCommand();
            string o_no = textBox1.Text;
            string tc_no = textBox2.Text;
            komut.Connection = baglanti;
            komut.CommandText = "Select  *From OgrenciBilgi where OgrenciNo='" + textBox1.Text + "'And TcNo='" + textBox2.Text + "'";
            dr = komut.ExecuteReader();
            if (textBox1.Text.Length < 0 && textBox2.Text.Length < 0)
            {
                MessageBox.Show("Bilgileri Giriniz!");
            }
            if (dr.Read())
            {
                MessageBox.Show("GİRİŞ BAŞARILI");
                ogrenci2 o2 = new ogrenci2();
                o2.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("HATALI GİRİŞ");

            }
            baglanti.Close();




        }

        private void button2_Click(object sender, EventArgs e)
        {
            giris g = new giris();
            g.Show();
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ogrenci_kayıt_ol kayit = new ogrenci_kayıt_ol();
            this.Hide();
            kayit.Show();
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                textBox2.UseSystemPasswordChar = true;
            }
           else if (checkBox1.CheckState == CheckState.Unchecked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
        } 
    }
    
}
