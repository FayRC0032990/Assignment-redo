using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_redo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double R1 = Convert.ToDouble(textBox1.Text);
            Double R2 = Convert.ToDouble(textBox2.Text);
            Double R3 = Convert.ToDouble(textBox3.Text);
            Double R4 = Convert.ToDouble(textBox4.Text);
            Double R5 = Convert.ToDouble(textBox5.Text);

            Double RS = R1 + R2 + R3 + R4 + R5;
            Double RP = 1 / (R1 + 1 / R2 + 1 / R3 + 1 / R4 + 1 / R5);
            label6.Text = " Answer Series" + RS;
            label7.Text = " Answer Parallel" + RP;
        }
    }
}
