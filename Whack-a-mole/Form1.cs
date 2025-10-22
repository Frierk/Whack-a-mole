using System.Media;
using System.Security.Cryptography;
using Whack_a_mole.Properties;

namespace Whack_a_mole
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int mole, mole2, mole3, mole4, mode = 1, tid;
        double mod = 1, points, highscore;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            click(pictureBox1);
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            click(pictureBox2);
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            click(pictureBox3);
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            click(pictureBox4);
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            click(pictureBox5);
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            click(pictureBox6);
        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            click(pictureBox7);
        }
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            click(pictureBox8);
        }
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            click(pictureBox9);
        }

        private void click(System.Windows.Forms.PictureBox pictureBox)
        {
            points = points + (25 * mod);
            pictureBox.Image = Resources.Mole_Wacked;
            label1.Text = "Points: " + points;
            if (points > highscore)
            {
                highscore = points;
                label2.Text = "Hightscore: " + highscore;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (mode == 1) { mole = RandomNumberGenerator.GetInt32(1, 10); mole2 = 0; mole3 = 0; mole4 = 0; }
            if (mode == 2)
            {
                mole = RandomNumberGenerator.GetInt32(1, 10); mole2 = RandomNumberGenerator.GetInt32(1, 10); mole3 = 0; mole4 = 0;
                if (mole == mole2) { mole += 1; }
            }
            if (mode == 3)
            {
                mole = RandomNumberGenerator.GetInt32(1, 10); mole2 = RandomNumberGenerator.GetInt32(1, 10); mole3 = RandomNumberGenerator.GetInt32(1, 10); mole4 = 0;
                if (mole == mole2 || mole == mole3) { mole += 1; } else if (mole2 == mole3) { mole += 2; }
            }
            if (mode == 4)
            {
                mole = RandomNumberGenerator.GetInt32(1, 10); mole2 = RandomNumberGenerator.GetInt32(1, 10); mole3 = RandomNumberGenerator.GetInt32(1, 10); mole4 = RandomNumberGenerator.GetInt32(1, 10);
                if (mole == mole2 || mole == mole3 || mole == mole4) { mole += 1; } else if (mole2 == mole3 || mole2 == mole4) { mole2 += 1; } else if (mole3 == mole4) { mole3 += 1; }
            }
            if (mole == 1 || mole2 == 1 || mole3 == 1 || mole4 == 1) { pictureBox1.Image = Resources.Mole_Up; pictureBox1.Enabled = true; }
            if (mole == 2 || mole2 == 2 || mole3 == 2 || mole4 == 2) { pictureBox2.Image = Resources.Mole_Up; pictureBox2.Enabled = true; }
            if (mole == 3 || mole2 == 3 || mole3 == 3 || mole4 == 3) { pictureBox3.Image = Resources.Mole_Up; pictureBox3.Enabled = true; }
            if (mole == 4 || mole2 == 4 || mole3 == 4 || mole4 == 4) { pictureBox4.Image = Resources.Mole_Up; pictureBox4.Enabled = true; }
            if (mole == 5 || mole2 == 5 || mole3 == 5 || mole4 == 5) { pictureBox5.Image = Resources.Mole_Up; pictureBox5.Enabled = true; }
            if (mole == 6 || mole2 == 6 || mole3 == 6 || mole4 == 6) { pictureBox6.Image = Resources.Mole_Up; pictureBox6.Enabled = true; }
            if (mole == 7 || mole2 == 7 || mole3 == 7 || mole4 == 7) { pictureBox7.Image = Resources.Mole_Up; pictureBox7.Enabled = true; }
            if (mole == 8 || mole2 == 8 || mole3 == 8 || mole4 == 8) { pictureBox8.Image = Resources.Mole_Up; pictureBox8.Enabled = true; }
            if (mole == 9 || mole2 == 9 || mole3 == 9 || mole4 == 9) { pictureBox9.Image = Resources.Mole_Up; pictureBox9.Enabled = true; }
            timer1.Stop();
            timer2.Start();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Mole_Down; pictureBox1.Enabled = false;
            pictureBox2.Image = Resources.Mole_Down; pictureBox2.Enabled = false;
            pictureBox3.Image = Resources.Mole_Down; pictureBox3.Enabled = false;
            pictureBox4.Image = Resources.Mole_Down; pictureBox4.Enabled = false;
            pictureBox5.Image = Resources.Mole_Down; pictureBox5.Enabled = false;
            pictureBox6.Image = Resources.Mole_Down; pictureBox6.Enabled = false;
            pictureBox7.Image = Resources.Mole_Down; pictureBox7.Enabled = false;
            pictureBox8.Image = Resources.Mole_Down; pictureBox8.Enabled = false;
            pictureBox9.Image = Resources.Mole_Down; pictureBox9.Enabled = false;
            timer2.Stop();
            timer1.Start();
        }

        private void slowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer2.Interval = 3000;
            mod = 0.25;
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 750;
            timer2.Interval = 2000;
            mod = 1;
        }

        private void fastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 500;
            timer2.Interval = 1000;
            mod = 2;
        }

        private void crazyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 150;
            timer2.Interval = 500;
            mod = 5;
        }

        private void molesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = 1;
        }

        private void molesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mode = 2;
        }

        private void molesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            mode = 3;
        }

        private void molesToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            mode = 4;
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            points = 0;
            highscore = 0;
            label2.Text = "Highscore: ";
            label1.Text = "Points: ";
            tid = 0;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            tid += 1;
            if (tid < 30)
            {
                label3.Text = "Tid kvar: " + (30 - tid);
                progressBar1.Value = progressBar1.Value + 1;
            }
            else
            {
                label3.Text = "Tid kvar: 0";
                progressBar1.Value = 30;
                timer1.Stop();
                timer2.Stop();
                button1.Visible = true;
                timer3.Stop();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            points = 0;
            label1.Text = "Points: ";
            tid = 0;
            progressBar1.Value = 0;
            pictureBox1.Image = Resources.Mole_Down; pictureBox1.Enabled = false;
            pictureBox2.Image = Resources.Mole_Down; pictureBox2.Enabled = false;
            pictureBox3.Image = Resources.Mole_Down; pictureBox3.Enabled = false;
            pictureBox4.Image = Resources.Mole_Down; pictureBox4.Enabled = false;
            pictureBox5.Image = Resources.Mole_Down; pictureBox5.Enabled = false;
            pictureBox6.Image = Resources.Mole_Down; pictureBox6.Enabled = false;
            pictureBox7.Image = Resources.Mole_Down; pictureBox7.Enabled = false;
            pictureBox8.Image = Resources.Mole_Down; pictureBox8.Enabled = false;
            pictureBox9.Image = Resources.Mole_Down; pictureBox9.Enabled = false;
            button1.Visible = false;
            timer3.Start();
            timer1.Start();
            timer2.Start();
        }
    }
}
