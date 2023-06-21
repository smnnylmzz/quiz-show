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
                richTextBox1.Text = "�lk sinema filmi Bir Trenin La Ciotat Gar�na Geli�i ka� y�l�nda g�sterime girmi�tir?\r\n";
                btnA.Text = "1990";
                btnB.Text = "1895";
                btnC.Text = "1886";
                btnD.Text = "1992";
                label5.Text = "1895";
                btnNext.Enabled = true;
            }
            if (soruno == 2)
            {
                richTextBox1.Text = "ABD ba�kan� John F. Kennedy hangi �ehirde �ld�r�ld�?";
                btnA.Text = "Dallas";
                btnB.Text = "New York";
                btnC.Text = "Boston";
                btnD.Text = "Chicago";
                label5.Text = "Dallas";
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Uzaya giden ilk kad�n kimdir?";
                btnA.Text = "H�lya Av�ar";
                btnB.Text = "Valentina Tere�kova";
                btnC.Text = "Fatma Girik";
                btnD.Text = "Seda Sayan";
                label5.Text = "Valentina Tere�kova";
            }
            if (soruno == 4)
            {
                richTextBox1.Text = "Kara Veba'n�n sebebi neydi?";
                btnA.Text = "Fareler";
                btnB.Text = "Tanr�n�n Gazab�";
                btnC.Text = "Un Kurabiyesi";
                btnD.Text = "Yersinia pestis";
                label5.Text = "Yersinia pestis";
                btnNext.Text = "Sonu�lar";
            }
            if(soruno == 5)
            {
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnNext.Enabled = false;
                MessageBox.Show("Do�ru: " + dogru + "\n" + " Yanli�: " + yanlis);
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