using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace josh_lost_his_highlighter_cap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            convertextbox.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double amt;
            double.TryParse(convertextbox.Text, out amt);
            textBox1.Text = (amt * 0.000231176).ToString("c2");

            double.TryParse(convertextbox.Text, out amt);
            textBox2.Text = (amt * .77).ToString("c2");

            double.TryParse(convertextbox.Text, out amt);
            textBox3.Text = (amt * 0.0073).ToString("c2");

            double.TryParse(convertextbox.Text, out amt);
            textBox4.Text = (amt * 1).ToString("c2");

            double.TryParse(convertextbox.Text, out amt);
            textBox5.Text = (amt * .050).ToString("c2");

            double.TryParse(convertextbox.Text, out amt);
            textBox6.Text = (amt * 1.18).ToString("c2");
        }
    }
}
