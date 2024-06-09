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
    public partial class firma_kayıt : Form
    {
        public firma_kayıt()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-2E215I9;Initial Catalog=ogrenci;Integrated Security=True");

        // Gerekli alanların doldurulup doldurulmadığını kontrol eden yöntem
        private bool AreFieldsFilled()
        {
            return !string.IsNullOrWhiteSpace(textBox1.Text) &&
                   !string.IsNullOrWhiteSpace(textBox2.Text) &&
                   !string.IsNullOrWhiteSpace(comboBox1.Text) &&
                   !string.IsNullOrWhiteSpace(textBox3.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (AreFieldsFilled())
            {
                baglanti.Open();
                SqlCommand kayit = new SqlCommand("INSERT INTO FirmaBilgi (firma_adı, sicil, firma_türü, sifre) VALUES (@f_isim, @f_sicil, @f_tur, @f_sifre)", baglanti);

                kayit.Parameters.AddWithValue("@f_isim", textBox1.Text);
                kayit.Parameters.AddWithValue("@f_sicil", textBox2.Text);
                kayit.Parameters.AddWithValue("@f_tur", comboBox1.Text);
                kayit.Parameters.AddWithValue("@f_sifre", textBox3.Text);

                kayit.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("KAYIT BAŞARIYLA EKLENDİı.");
            }
            else
            {
                MessageBox.Show("LÜTFEN TÜM ALANLARI DOLDURUNUZ.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            firma firma = new firma();
            firma.Show();
            this.Hide();
        }
    }
}
