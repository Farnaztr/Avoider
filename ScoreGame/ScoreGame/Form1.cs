using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoreGame
{
    public partial class Form1 : Form
    {
        bool end = false;
        public Form1()
        {
            InitializeComponent();

        }
        void endgm()
        {

            if (end)
                return;
            
            end = true;

            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            timer4.Stop();

            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            count = 0;
            label3.Text = count.ToString();
            MessageBox.Show("You Lost!", "End", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            pbBackground.SendToBack();
            label3.Text = count.ToString();

            pictureBox1.Parent = pbBackground;
            pictureBox2.Parent = pbBackground;
            pictureBox3.Parent = pbBackground;
            pictureBox4.Parent = pbBackground;
            pictureBox5.Parent = pbBackground;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox5.BackColor = Color.Transparent;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int nd = rnd.Next(1, 7);
            label6.Text = nd.ToString();
            if (nd == 6)
            {
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                timer1.Start();
                timer2.Start();
                timer3.Start();
                timer4.Start();
                button5.Enabled = true;
                button1.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            pictureBox1.Left -= 30;

            if (pictureBox1.Left <= 0)
            {
                pictureBox1.Left = 0;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
        int second = 0;
        int step = 10;
        int step2 = 10;
        int step3 = 10;
        private void timer1_Tick(object sender, EventArgs e)
        {
           
            pictureBox2.Left -= step;
            if (pictureBox2.Left <= 0)
            {
                pictureBox2.Left = 0;
                step = -step;

            }
            if (pictureBox2.Right >= this.ClientSize.Width)
            {
                pictureBox2.Left = (this.ClientSize.Width) - pictureBox2.Width;
                step = -step;
            }

            if (pictureBox1.Bounds.IntersectsWith(pictureBox2.Bounds))
            {
                count -= 5;
                label3.Text = count.ToString();
                pictureBox1.Top += 50;
                pictureBox2.Left = this.ClientSize.Width - pictureBox2.Width;
                if(count<0)
                {
                    endgm();

                }
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Left += 40;
           if(pictureBox1.Right>=this.ClientSize.Width)
            {
                pictureBox1.Left = (this.ClientSize.Width) - pictureBox1.Width;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox1.Top += 40;
            if (pictureBox1.Bottom >= this.ClientSize.Height)
            {
                pictureBox1.Top = (this.ClientSize.Height) - pictureBox1.Height;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Top -= 40;
            if (pictureBox1.Top <= 0)
            {
                pictureBox1.Top = 0;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
           
        }
        int count = 15;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
          
          

            pictureBox3.Left -= step2;
            if (pictureBox3.Left <= 0)
            {
                pictureBox3.Left = 0;
                step2 = -step2;

            }
            if (pictureBox3.Right >= this.ClientSize.Width)
            {
                pictureBox3.Left = (this.ClientSize.Width) - pictureBox3.Width;
                step2 = -step2;
            }

            label3.Text = count.ToString();
            if (pictureBox1.Bounds.IntersectsWith(pictureBox3.Bounds))
            {
                count -= 5;
                label3.Text = count.ToString();
                pictureBox1.Top += 50;
                pictureBox3.Left = this.ClientSize.Width - pictureBox3.Width;
                if (count < 0)
                {
                    endgm();

                }
            }

        }

        private void timer3_Tick(object sender, EventArgs e)
        {

    
            pictureBox4.Left -= step3;
            if (pictureBox4.Left <= 0)
            {
                pictureBox4.Left = 0;
                step3 = -step3;

            }
            if (pictureBox4.Right >= this.ClientSize.Width)
            {
                pictureBox4.Left = (this.ClientSize.Width) - pictureBox4.Width;
                step3 = -step3;
            }
            if (pictureBox1.Bounds.IntersectsWith(pictureBox4.Bounds))
            {
                count -= 5;
                label3.Text = count.ToString();
                pictureBox1.Top += 50;
                pictureBox4.Left = this.ClientSize.Width - pictureBox4.Width;
                if (count < 0)
                {
                    endgm();

                }
            }


        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            second++;
            int remain = 25 - second;
            label2.Text = remain.ToString();
            if (second == 25)
            {
            
                button5.Enabled = false;
               
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                timer4.Stop();
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                MessageBox.Show($"The Game finished! Your Points: {count}","End",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
            if(pictureBox1.Bounds.IntersectsWith(pictureBox5.Bounds))
            {
                button5.Enabled = false;
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                timer4.Stop();
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                pictureBox1.Visible = false;
                MessageBox.Show("You Reached!Congratulations:)","Won",MessageBoxButtons.OK ,MessageBoxIcon.Information);

            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pbBackground_Click(object sender, EventArgs e)
        {

        }
    }
}