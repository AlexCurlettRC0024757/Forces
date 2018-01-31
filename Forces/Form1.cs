using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double F = Convert.ToDouble(textBox1.Text);
            double A = 
            double Fx = F * cos(A);
            double Fy = 
        }

        double sin(double X)
        {
            return (Math.Sin(X * Math.PI / 180.0));
        }
    }
}
 