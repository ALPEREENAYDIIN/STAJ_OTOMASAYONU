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
    public partial class akademisyen_kayıt : Form
    {
        public akademisyen_kayıt()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-2E215I9;Initial Catalog=ogrenci;Integrated Security=True");

        // Gerekli alanların doldurulup doldurulmadığını kontrol eden yöntem
        private bool AreFieldsFilled()
        {
            return !string.IsNullOrWhiteSpace(text_ad.Text) &&
                   !string.IsNullOrWhiteSpace(text_soyad.Text) &&
                   !string.IsNullOrWhiteSpace(maskedTextBox1.Text) &&
                   !string.IsNullOrWhiteSpace(text_sifre.Text) &&
                   !string.IsNullOrWhiteSpace(text_gmail.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (AreFieldsFilled())
            {
                baglanti.Open();
                SqlCommand kayit = new SqlCommand("INSERT INTO Akademsiyen (ad, soyad, telefon_no, sifre, gmail) VALUES (@a_isim, @a_soyisim, @a_tel, @a_sifre, @a_gmail)", baglanti);

                kayit.Parameters.AddWithValue("@a_isim", text_ad.Text);
                kayit.Parameters.AddWithValue("@a_soyisim", text_soyad.Text);
                kayit.Parameters.AddWithValue("@a_tel", maskedTextBox1.Text);
                kayit.Parameters.AddWithValue("@a_sifre", text_sifre.Text);
                kayit.Parameters.AddWithValue("@a_gmail", text_gmail.Text);

                kayit.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("KAYIT BAŞARIYLA TAMAMLANDI.");
            }
            else
            {
                MessageBox.Show("LÜTFEN BİLGİLERİ EKSİKSİZ DOLDURUN.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            yonetici yonetici = new yonetici();
            yonetici.Show();
            this.Hide();
        }
    }
}