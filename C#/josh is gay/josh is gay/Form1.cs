using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace josh_is_gay
{
    public partial class Form1 : Form
    {
        private void Form1_Load(object sender, EventArgs e)
        {
            //convertextbox.Clear();
            //textBox1.Clear();
            //textBox2.Clear();
            //textBox3.Clear();
            //textBox4.Clear();
            //textBox5.Clear();
            //textBox6.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double amt;
            double.TryParse(convertextbox.Text, out amt);
            textBox1.Text =(amt* 0.000231176).ToString("c2");



        }


    }
}
