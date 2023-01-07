using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Auto Auto;

        private void button1_Click(object sender, EventArgs e)
        {
            Auto = new Auto(textBox1.Text, (int)numericUpDown1.Value, (int)numericUpDown2.Value);
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Auto.Rozjezd();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random rng = new Random();
            int cislo = rng.Next(10, 100);
            Auto.Zastav(cislo);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Auto.ToString());
        }
    }
}
