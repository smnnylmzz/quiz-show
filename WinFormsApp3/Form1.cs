namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruno = 0, dogru = 0, yanlis = 0;
        private void btnNext_Click(object sender, EventArgs e)
        {
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnNext.Enabled = false;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            soruno++;
            lblSoruNo.Text = soruno.ToString();
            if (soruno == 1)
            {
                richTextBox1.Text = "Ýlk sinema filmi Bir Trenin La Ciotat Garýna Geliþi kaç yýlýnda gösterime girmiþtir?\r\n";
                btnA.Text = "1990";
                btnB.Text = "1895";
                btnC.Text = "1886";
                btnD.Text = "1992";
                label5.Text = "1895";
                btnNext.Enabled = true;
            }
            if (soruno == 2)
            {
                richTextBox1.Text = "ABD baþkaný John F. Kennedy hangi þehirde öldürüldü?";
                btnA.Text = "Dallas";
                btnB.Text = "New York";
                btnC.Text = "Boston";
                btnD.Text = "Chicago";
                label5.Text = "Dallas";
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Uzaya giden ilk kadýn kimdir?";
                btnA.Text = "Hülya Avþar";
                btnB.Text = "Valentina Tereþkova";
                btnC.Text = "Fatma Girik";
                btnD.Text = "Seda Sayan";
                label5.Text = "Valentina Tereþkova";
            }
            if (soruno == 4)
            {
                richTextBox1.Text = "Kara Veba'nýn sebebi neydi?";
                btnA.Text = "Fareler";
                btnB.Text = "Tanrýnýn Gazabý";
                btnC.Text = "Un Kurabiyesi";
                btnD.Text = "Yersinia pestis";
                label5.Text = "Yersinia pestis";
                btnNext.Text = "Sonuçlar";
            }
            if(soruno == 5)
            {
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnNext.Enabled = false;
                MessageBox.Show("Doðru: " + dogru + "\n" + " Yanliþ: " + yanlis);
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnNext.Enabled = true;
            label6.Text = btnA.Text;

            if (label5.Text == label6.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                pictureBox2.Visible = true;
            }
            else
            {
                yanlis++;
                lblyanlis.Text = yanlis.ToString();
                pictureBox1.Visible = true;
            }
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnNext.Enabled = true;
            label6.Text = btnB.Text;
            if (label5.Text == label6.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                pictureBox2.Visible = true;
            }
            else
            {
                yanlis++;
                lblyanlis.Text = yanlis.ToString();
                pictureBox1.Visible = true;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnNext.Enabled = true;
            label6.Text = btnC.Text;
            if (label5.Text == label6.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                pictureBox2.Visible = true;
            }
            else
            {
                yanlis++;
                lblyanlis.Text = yanlis.ToString();
                pictureBox1.Visible = true;
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnNext.Enabled = true;
            label6.Text = btnD.Text;
            if (label5.Text == label6.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                pictureBox2.Visible = true;
            }
            else
            {
                yanlis++;
                lblyanlis.Text = yanlis.ToString();
                pictureBox1.Visible = true;
            }
        }
    }
}