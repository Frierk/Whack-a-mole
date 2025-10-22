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
        int mole, points;
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
            points += 25;
            pictureBox.Image = Resources.Mole_Wacked;
            label1.Text = "Points: " + points;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            mole = RandomNumberGenerator.GetInt32(1, 10);
            if (mole == 1) { pictureBox1.Image = Resources.Mole_Up; pictureBox1.Enabled = true; }
            if (mole == 2) { pictureBox2.Image = Resources.Mole_Up; pictureBox2.Enabled = true; }
            if (mole == 3) { pictureBox3.Image = Resources.Mole_Up; pictureBox3.Enabled = true; }
            if (mole == 4) { pictureBox4.Image = Resources.Mole_Up; pictureBox4.Enabled = true; }
            if (mole == 5) { pictureBox5.Image = Resources.Mole_Up; pictureBox5.Enabled = true; }
            if (mole == 6) { pictureBox6.Image = Resources.Mole_Up; pictureBox6.Enabled = true; }
            if (mole == 7) { pictureBox7.Image = Resources.Mole_Up; pictureBox7.Enabled = true; }
            if (mole == 8) { pictureBox8.Image = Resources.Mole_Up; pictureBox8.Enabled = true; }
            if (mole == 9) { pictureBox9.Image = Resources.Mole_Up; pictureBox9.Enabled = true; }
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
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 750;
            timer2.Interval = 2000;
        }

        private void fastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 500;
            timer2.Interval = 1000;
        }

        private void crazyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 150;
            timer2.Interval = 500;
        }
    }
}
