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
namespace WindowsFormsApp1
{
    public partial class firma : Form
    {
        SqlCommand komut;
        
        SqlDataReader dr;
            
        public firma()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti = new SqlConnection("Data Source=DESKTOP-2E215I9;Initial Catalog=ogrenci;Integrated Security=True");
            baglanti.Open();
            komut = new SqlCommand();
            string s_no = textBox1.Text;
            string sifre = textBox2.Text;
            komut.Connection = baglanti;
            komut.CommandText = "Select  *From FirmaBilgi where sicil='" + textBox1.Text + "'And sifre='" + textBox2.Text + "'";
            dr = komut.ExecuteReader();
            if (textBox1.Text.Length < 0 && textBox2.Text.Length<0)
            {
                MessageBox.Show("Bilgileri Giriniz!");
            }
            if (dr.Read())
            {
                MessageBox.Show("GİRİŞ BAŞARILI");
                firma2 f2 = new firma2();
                f2.Show();
                this.Hide();


            }
            else
            {
                MessageBox.Show("HATALI GİRİŞ");

            }
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-2E215I9;Initial Catalog=ogrenci;Integrated Security=True");


        private void button2_Click(object sender, EventArgs e)
        {
          giris g = new giris();
            g.Show();
            this.Close();


        }

        private void firma_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            firma_kayıt fk = new firma_kayıt();
            fk.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkedBox1.CheckState == CheckState.Checked)
            {
                textBox2.UseSystemPasswordChar = true;
            }
            else if (checkedBox1.CheckState == CheckState.Unchecked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
        }
    }
}
