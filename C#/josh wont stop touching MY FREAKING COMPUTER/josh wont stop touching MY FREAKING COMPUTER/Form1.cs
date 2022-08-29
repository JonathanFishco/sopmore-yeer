using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace josh_wont_stop_touching_MY_FREAKING_COMPUTER
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }


        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value++;
        }

        private void Form1_KeyDown_2(object sender, KeyEventArgs e)
        {
            int speed = 5;
            if (e.Shift && progressBar1.Value > 2)
            {
                speed = 10;
                progressBar1.Value--;
            }


            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                pictureBox2.Location = new Point(pictureBox2.Location.X - speed, pictureBox2.Location.Y);
            }
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                pictureBox2.Location = new Point(pictureBox2.Location.X + speed, pictureBox2.Location.Y);
            }
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y - speed);
            }
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y + speed);
            }
        }

    }
}
