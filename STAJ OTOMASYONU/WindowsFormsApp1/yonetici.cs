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
using System.Data.Sql;
using System.Data.Common;
namespace WindowsFormsApp1
{
    public partial class yonetici : Form
    {
        SqlDataReader dr;
        SqlCommand komut;
        SqlConnection baglanti;
        public yonetici()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti = new SqlConnection("Data Source=DESKTOP-2E215I9;Initial Catalog=ogrenci;Integrated Security=True");
            baglanti.Open();
            komut = new SqlCommand();
            string gmail = textBox1.Text;
            string sifre = textBox2.Text;
            komut.Connection = baglanti;
            komut.CommandText = "Select  *From Akademsiyen where gmail='" + textBox1.Text + "'And sifre='" + textBox2.Text + "'";
            dr = komut.ExecuteReader();
            if (textBox1.Text.Length < 0 && textBox2.Text.Length < 0)
            {
                MessageBox.Show("Bilgileri Giriniz!");
            }
            if (dr.Read())
            {
                MessageBox.Show("GİRİŞ BAŞARILI");
                akademisyen2 akademisyen2 = new akademisyen2();
                akademisyen2.Show();
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
            akademisyen_kayıt a_kayıt = new akademisyen_kayıt();
            a_kayıt.Show();
            this.Hide();
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
