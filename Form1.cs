using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double dAns;
            dAns = double.Parse(Op1.Text) * double.Parse(Op2.Text);
            lblResult.Text = dAns.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double dAns;
            dAns = double.Parse(Op1.Text) / double.Parse(Op2.Text);
            lblResult.Text = dAns.ToString();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            double dAns;
            dAns = double.Parse(Op1.Text) + double.Parse(Op2.Text);
            lblResult.Text = dAns.ToString();
        }

        private void Op1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Sub_Click(object sender, EventArgs e)
        {
            double dAns;
            dAns = double.Parse(Op1.Text) - double.Parse(Op2.Text);
            lblResult.Text = dAns.ToString();
        }
    }
}
