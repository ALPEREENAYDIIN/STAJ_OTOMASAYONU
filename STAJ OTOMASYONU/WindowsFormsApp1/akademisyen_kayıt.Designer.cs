namespace WindowsFormsApp1
{
    partial class akademisyen_kayıt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.text_soyad = new System.Windows.Forms.TextBox();
            this.text_ad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.text_sifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.text_gmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(115, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 46);
            this.label2.TabIndex = 9;
            this.label2.Text = "SOYİSİM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(157, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 46);
            this.label1.TabIndex = 8;
            this.label1.Text = "İSİM";
            // 
            // text_soyad
            // 
            this.text_soyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.text_soyad.Location = new System.Drawing.Point(70, 286);
            this.text_soyad.Name = "text_soyad";
            this.text_soyad.Size = new System.Drawing.Size(274, 53);
            this.text_soyad.TabIndex = 7;
            // 
            // text_ad
            // 
            this.text_ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.text_ad.Location = new System.Drawing.Point(42, 92);
            this.text_ad.Name = "text_ad";
            this.text_ad.Size = new System.Drawing.Size(330, 53);
            this.text_ad.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(551, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(426, 46);
            this.label5.TabIndex = 10;
            this.label5.Text = "TELEFON NUMARASI";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.maskedTextBox1.Location = new System.Drawing.Point(546, 92);
            this.maskedTextBox1.Mask = "(999) 000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(436, 53);
            this.maskedTextBox1.TabIndex = 22;
            // 
            // text_sifre
            // 
            this.text_sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.text_sifre.Location = new System.Drawing.Point(795, 286);
            this.text_sifre.Name = "text_sifre";
            this.text_sifre.Size = new System.Drawing.Size(278, 53);
            this.text_sifre.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(866, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 46);
            this.label3.TabIndex = 24;
            this.label3.Text = "ŞİFRE";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(495, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 123);
            this.button1.TabIndex = 25;
            this.button1.Text = "KAYIT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // text_gmail
            // 
            this.text_gmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.text_gmail.Location = new System.Drawing.Point(410, 286);
            this.text_gmail.Name = "text_gmail";
            this.text_gmail.Size = new System.Drawing.Size(297, 53);
            this.text_gmail.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(487, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 46);
            this.label6.TabIndex = 28;
            this.label6.Text = "GMAİL";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(-1, 552);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(196, 93);
            this.button2.TabIndex = 29;
            this.button2.Text = "GERİ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // akademisyen_kayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1128, 647);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.text_gmail);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_sifre);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_soyad);
            this.Controls.Add(this.text_ad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "akademisyen_kayıt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "akademisyen_kayıt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_soyad;
        private System.Windows.Forms.TextBox text_ad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox text_sifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox text_gmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
    }
}