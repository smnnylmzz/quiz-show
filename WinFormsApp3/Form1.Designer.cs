namespace WinFormsApp3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnA = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            richTextBox1 = new RichTextBox();
            btnD = new Button();
            btnB = new Button();
            btnC = new Button();
            btnNext = new Button();
            lblSoruNo = new Label();
            lbldogru = new Label();
            lblyanlis = new Label();
            label5 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(863, 242);
            label1.Name = "label1";
            label1.Size = new Size(159, 48);
            label1.TabIndex = 0;
            label1.Text = "Soru No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(906, 395);
            label2.Name = "label2";
            label2.Size = new Size(116, 48);
            label2.TabIndex = 1;
            label2.Text = "Yanlış:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(894, 318);
            label3.Name = "label3";
            label3.Size = new Size(128, 48);
            label3.TabIndex = 2;
            label3.Text = "Doğru:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Snap ITC", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(364, 37);
            label4.Name = "label4";
            label4.Size = new Size(541, 73);
            label4.TabIndex = 3;
            label4.Text = "Bilgi Yarışması";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnA
            // 
            btnA.Location = new Point(117, 626);
            btnA.Name = "btnA";
            btnA.Size = new Size(327, 69);
            btnA.TabIndex = 4;
            btnA.Text = "A";
            btnA.UseVisualStyleBackColor = true;
            btnA.Click += btnA_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Info;
            panel1.Controls.Add(label4);
            panel1.Location = new Point(117, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(1320, 181);
            panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1206, 591);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(231, 189);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(879, 559);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(300, 243);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            richTextBox1.Location = new Point(117, 239);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(717, 324);
            richTextBox1.TabIndex = 8;
            richTextBox1.Text = "";
            // 
            // btnD
            // 
            btnD.Location = new Point(507, 733);
            btnD.Name = "btnD";
            btnD.Size = new Size(327, 69);
            btnD.TabIndex = 4;
            btnD.Text = "D";
            btnD.UseVisualStyleBackColor = true;
            btnD.Click += btnD_Click;
            // 
            // btnB
            // 
            btnB.Location = new Point(507, 626);
            btnB.Name = "btnB";
            btnB.Size = new Size(327, 69);
            btnB.TabIndex = 4;
            btnB.Text = "B";
            btnB.UseVisualStyleBackColor = true;
            btnB.Click += btnB_Click;
            // 
            // btnC
            // 
            btnC.Location = new Point(117, 733);
            btnC.Name = "btnC";
            btnC.Size = new Size(327, 69);
            btnC.TabIndex = 4;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            btnC.Click += btnC_Click;
            // 
            // btnNext
            // 
            btnNext.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnNext.Location = new Point(879, 470);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(252, 69);
            btnNext.TabIndex = 9;
            btnNext.Text = "Sonraki Soru";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // lblSoruNo
            // 
            lblSoruNo.AutoSize = true;
            lblSoruNo.Location = new Point(1028, 242);
            lblSoruNo.Name = "lblSoruNo";
            lblSoruNo.Size = new Size(39, 48);
            lblSoruNo.TabIndex = 10;
            lblSoruNo.Text = "0";
            // 
            // lbldogru
            // 
            lbldogru.AutoSize = true;
            lbldogru.Location = new Point(1028, 318);
            lbldogru.Name = "lbldogru";
            lbldogru.Size = new Size(39, 48);
            lbldogru.TabIndex = 11;
            lbldogru.Text = "0";
            // 
            // lblyanlis
            // 
            lblyanlis.AutoSize = true;
            lblyanlis.Location = new Point(1028, 395);
            lblyanlis.Name = "lblyanlis";
            lblyanlis.Size = new Size(39, 48);
            lblyanlis.TabIndex = 12;
            lblyanlis.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(132, 860);
            label5.Name = "label5";
            label5.Size = new Size(115, 48);
            label5.TabIndex = 13;
            label5.Text = "label5";
            label5.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(295, 860);
            label6.Name = "label6";
            label6.Size = new Size(115, 48);
            label6.TabIndex = 14;
            label6.Text = "label6";
            label6.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1526, 947);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(lblyanlis);
            Controls.Add(lbldogru);
            Controls.Add(lblSoruNo);
            Controls.Add(btnNext);
            Controls.Add(richTextBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(btnB);
            Controls.Add(btnC);
            Controls.Add(btnD);
            Controls.Add(btnA);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnA;
        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private RichTextBox richTextBox1;
        private Button btnD;
        private Button btnB;
        private Button btnC;
        private Button btnNext;
        private Label lblSoruNo;
        private Label lbldogru;
        private Label lblyanlis;
        private Label label5;
        private Label label6;
    }
}