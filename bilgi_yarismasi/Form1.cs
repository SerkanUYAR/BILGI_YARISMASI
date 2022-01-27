using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bilgi_yarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruno = 0, dogru = 0, yanlis=0;

        private void Form1_Load(object sender, EventArgs e)
        {
            picturedogru.Visible = false;
            pictureyanlis.Visible = false;
            richTextBox1.Text = "Bilgi yarışmasına hoş geldiniz..!";
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            richTextBox1.Enabled = false;
        }

        private void btnb_Click(object sender, EventArgs e)
        {
            label6.Text = btnb.Text;
            if (label5.Text == label6.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                picturedogru.Visible = true;
                pictureyanlis.Visible = false;
            }
            else
            {
                yanlis++;
                lblyanlis.Text = yanlis.ToString();
                picturedogru.Visible = false;
                pictureyanlis.Visible = true;
            }
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btnsonraki.Enabled = true;
            richTextBox1.Enabled = false;
            richTextBox1.Text = "Bilgi yarışması sonlanmıştır";
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            label6.Text = btnc.Text;
            if (label5.Text == label6.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                picturedogru.Visible = true;
                pictureyanlis.Visible = false;
            }
            else
            {
                yanlis++;
                lblyanlis.Text = yanlis.ToString();
                picturedogru.Visible = false;
                pictureyanlis.Visible = true;
            }
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btnsonraki.Enabled = true;
            richTextBox1.Enabled = false;
            richTextBox1.Text = "Bilgi yarışması sonlanmıştır";
        }

        private void btnd_Click(object sender, EventArgs e)
        {
            label6.Text = btnd.Text;
            if (label5.Text == label6.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                picturedogru.Visible = true;
                pictureyanlis.Visible = false;
            }
            else
            {
                yanlis++;
                lblyanlis.Text = yanlis.ToString();
                picturedogru.Visible = false;
                pictureyanlis.Visible = true;
            }
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btnsonraki.Enabled = true;
            richTextBox1.Enabled = false;
            richTextBox1.Text = "Bilgi yarışması sonlanmıştır";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            btna.Enabled = true;
            btnb.Enabled = true;
            btnc.Enabled = true;
            btnd.Enabled = true;
            btnsonraki.Enabled = false;

            picturedogru.Visible = false;
            pictureyanlis.Visible = false;
            soruno++;
            lblsoruno.Text = soruno.ToString();
            if (soruno==1)
            {
                richTextBox1.Text = "Türkiye'nin başkenti neresidir?";
                btna.Text = "İstanbul";
                btnb.Text = "Ankara";
                btnc.Text = "Yozgat";
                btnd.Text = "Sivas";
                label5.Text = "Ankara";

            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Aşağıdakilerden hangisi bir giriş birimidir";
                btna.Text = "Klavye";
                btnb.Text = "Ekran";
                btnc.Text = "Yazıcı";
                btnd.Text = "Hoparlör";
                label5.Text = "Klavye";

            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Aşağıdakilerden hangisi Karadeniz Bölgesindedir?";
                btna.Text = "Ankara";
                btnb.Text = "Bursa";
                btnc.Text = "Ordu";
                btnd.Text = "Erzurum";
                label5.Text = "Ordu";

            }
            if (soruno==4)
            {
                btna.Enabled = false;
                btnb.Enabled = false;
                btnc.Enabled = false;
                btnd.Enabled = false;
                btnsonraki.Enabled = false;
                btnsonraki.Text = "Bitmiştir";

                picturedogru.Visible = false;
                pictureyanlis.Visible = false;

                MessageBox.Show("Doğru sayısı:"+dogru+ "\n" +"Yanlış Sayısı:"+yanlis);
            }
        }

        private void btna_Click(object sender, EventArgs e)
        {
            label6.Text = btna.Text;
            if (label5.Text==label6.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                picturedogru.Visible = true;
                pictureyanlis.Visible = false;
            }
            else
            {
                yanlis++;
                lblyanlis.Text = yanlis.ToString();
                picturedogru.Visible = false;
                pictureyanlis.Visible = true;
            }
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btnsonraki.Enabled = true;
            richTextBox1.Enabled = false;
            richTextBox1.Text = "Bilgi yarışması sonlanmıştır";
        }
    }
}
