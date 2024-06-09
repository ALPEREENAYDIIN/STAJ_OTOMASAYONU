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
    public partial class staj_defteri : Form
    {
        public staj_defteri()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                openFileDialog1.Title = "Resim seç.";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                    imagepath = openFileDialog1.FileName;
                }

            }
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-2E215I9;Initial Catalog=ogrenci;Integrated Security=True");
        string imagepath;
        private void KAYDET_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(imagepath)) // Eğer imagepath değeri boş değilse (yani bir dosya seçildiyse)
            {
                baglanti.Open();
                FileStream fs = new FileStream(imagepath, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                byte[] resim = br.ReadBytes((int)fs.Length);
                br.Close();
                fs.Close();
                SqlCommand komut = new SqlCommand("insert into StajDefteri(defter,numara) values ( @s_defteri,@o_numara)", baglanti);
                komut.Parameters.Add("@s_defteri", SqlDbType.Image, resim.Length).Value = resim;

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ogrenci2 o2 = new ogrenci2();
            o2.Show();
            this.Hide();

        }
    }
}
