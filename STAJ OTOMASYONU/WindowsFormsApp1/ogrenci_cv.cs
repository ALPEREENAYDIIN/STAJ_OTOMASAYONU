using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ogrenci_cv : Form
    {
        public ogrenci_cv()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string numara = text_ogrenci_no.Text.Trim(); // Textbox'tan numarayı alınır

            if (string.IsNullOrEmpty(numara))
            {
                MessageBox.Show("Lütfen bir numara girin.");
                return; // Numara girilmemişse işlemi sonlandır
            }

            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-2E215I9;Initial Catalog=ogrenci;Integrated Security=True");
            SqlCommand komut = new SqlCommand("SELECT cv FROM ogrenci_cv WHERE numara = @Numara", baglanti);
            komut.Parameters.AddWithValue("@Numara", numara);

            try
            {
                baglanti.Open();
                byte[] imageData = (byte[])komut.ExecuteScalar();
                if (imageData != null)
                {
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        pictureBox1.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    MessageBox.Show("Numaraya ait kayıt bulunamadı.");
                }
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            firma2 f2 = new firma2();
            f2.Show();
            this.Hide();
        }
    }
}
