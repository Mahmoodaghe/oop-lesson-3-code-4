using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace المحاضرة_الثالثة_برمجة_عملي_الكود_الرابع
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int z = Convert.ToInt16(textBox1.Text);
            int sum=0;
            for (int i = 1; i <= z; i++)
                sum += i;

            label1.Text = Convert.ToString(sum);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int z = Convert.ToInt16(textBox1.Text);
            int mul=1;
            for (int i = 1; i <=z; i++)
                mul *= i;
            label2.Text = Convert.ToString(mul);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int z = Convert.ToInt16(textBox1.Text);
            double s = Math.Sqrt(z);
            label3.Text = s.ToString();
        }
    }
}
