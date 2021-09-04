using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NitroGen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random x = new Random();
            int x1 = x.Next(000, 9999);
            int x2 = x.Next(000, 9999);
            int x3 = x.Next(000, 9999);
            int x4 = x.Next(000, 9999);
            textBox1.AppendText("0" + x1 + x2 + x3 + x4);





        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}
