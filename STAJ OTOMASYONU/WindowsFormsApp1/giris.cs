using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ogrenci o = new ogrenci();
            o.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            yonetici y = new yonetici();
            y.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            firma firma = new firma();
            firma.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ogrenci_kayıt_ol kayıt = new ogrenci_kayıt_ol();
            kayıt.Show();
             this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
