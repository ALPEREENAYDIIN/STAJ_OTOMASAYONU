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
    public partial class staj_defteri2 : Form
    {
        public staj_defteri2()
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
            SqlCommand komut = new SqlCommand("SELECT defter FROM StajDefteri WHERE numara = @Numara", baglanti);
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

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            akademisyen2 a2=new akademisyen2();
            a2.Show();  
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
