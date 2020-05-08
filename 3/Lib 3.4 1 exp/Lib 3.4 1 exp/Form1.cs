using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lib_3._4_1_exp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double y = Convert.ToDouble(textBox2.Text);

            textBox3.Text += "Резултаты работы программы " +
                "ст. Николаева М.В." +
                Environment.NewLine;
            textBox3.Text += "При X= " + textBox1.Text +
                Environment.NewLine;
            textBox3.Text += "При Y= " + textBox2.Text +
                Environment.NewLine;

            double u;

            if ((x * y) > 0)
            {
                u = Math.Pow(Math.Pow(x, 2) + y, 2) - Math.Sqrt(Math.Pow(x, 2) * y);
            }
            else if ((x * y) < 0)
            {
                u = Math.Pow(Math.Pow(x, 2) + y, 2) + Math.Sqrt(Math.Abs(Math.Pow(x, 2) * y));
            }
            else if ((x * y) == 0)
            {
                u = Math.Pow(Math.Pow(x, 2) + y, 2) + 1;
            }
            else u = 0;

            //Вывод результата
            textBox3.Text += "U = " + u.ToString() +
                Environment.NewLine;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}
