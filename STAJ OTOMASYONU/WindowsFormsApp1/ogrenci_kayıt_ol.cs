
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class ogrenci_kayıt_ol : Form
    {
        public ogrenci_kayıt_ol()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-2E215I9;Initial Catalog=ogrenci;Integrated Security=True");
        string imagepath;
        private bool AreFieldsFilled()
        {
            return !string.IsNullOrWhiteSpace(text_ad.Text) &&
                   !string.IsNullOrWhiteSpace(text_soyad.Text) &&
                   !string.IsNullOrWhiteSpace(text_gmail.Text) &&
                   !string.IsNullOrWhiteSpace(maskedTextBox1.Text) &&
                   !string.IsNullOrWhiteSpace(text_ogr_no.Text) &&
                   !string.IsNullOrWhiteSpace(text_tc.Text) &&
                   !string.IsNullOrWhiteSpace(comboBox1.Text) &&
                   !string.IsNullOrWhiteSpace(comboBox2.Text) &&
                   !string.IsNullOrWhiteSpace(comboBox3.Text) &&
                   !string.IsNullOrWhiteSpace(comboBox4.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (AreFieldsFilled())
            {
                baglanti.Open();

                SqlCommand kayit = new SqlCommand("insert into OgrenciBilgi(OgrenciAdi,OgrenciSoyadi,Gmail,TelefonNo,OgrenciNo,TcNo,Sehir,Okul,Bolum,Alan)values(@o_a,@o_s,@o_gm,@o_tel,@o_no,@o_tc,@o_sehir,@o_okul,@o_bolum,@o_alan)", baglanti);
                
                kayit.Parameters.AddWithValue("@o_a", text_ad.Text);
                kayit.Parameters.AddWithValue("@o_s", text_soyad.Text);
                kayit.Parameters.AddWithValue("@o_gm", text_gmail.Text);
                kayit.Parameters.AddWithValue("@o_tel", maskedTextBox1.Text);
                kayit.Parameters.AddWithValue("@o_no", text_ogr_no.Text);
                kayit.Parameters.AddWithValue("@o_tc", text_tc.Text);
                kayit.Parameters.AddWithValue("@o_sehir", comboBox1.Text);
                kayit.Parameters.AddWithValue("@o_okul", comboBox2.Text);
                kayit.Parameters.AddWithValue("@o_bolum", comboBox3.Text);
                kayit.Parameters.AddWithValue("@o_alan", comboBox4.Text);

                kayit.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("KAYIT BAŞARIYLA TAMAMLANDI.");
            }
            else
            {
                MessageBox.Show("LÜTFEN TÜM ALANLARI DOLDURUN.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ogrenci ogrenci = new ogrenci();
            ogrenci.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(imagepath)) // Eğer imagepath değeri boş değilse (yani bir dosya seçildiyse)
            {
                baglanti.Open();
                FileStream fs = new FileStream(imagepath, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                byte[] resim = br.ReadBytes((int)fs.Length);
                br.Close();
                fs.Close();
                SqlCommand komut = new SqlCommand("insert into ogrenci_cv(cv, numara) values (@o_cv, @o_numara)", baglanti);
                komut.Parameters.Add("@o_cv", SqlDbType.Image, resim.Length).Value = resim;
               
                komut.Parameters.AddWithValue("@o_numara", text_ogr_no.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("KAYIT EKLENDİ", "KAYIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen bir resim seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Resim seç.";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                imagepath = openFileDialog1.FileName;
            }
                
        }
    }
}