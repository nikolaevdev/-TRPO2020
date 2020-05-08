using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lib_3._4
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
            double z = Convert.ToDouble(textBox3.Text);

            textBox4.Text += "Резултаты работы программы " +
                "ст. Николаева М.В." +
                Environment.NewLine;
            textBox4.Text += "При X= " + textBox1.Text +
                Environment.NewLine;
            textBox4.Text += "При Y= " + textBox2.Text +
                Environment.NewLine;
            textBox4.Text += "При Z= " + textBox3.Text +
                Environment.NewLine;

            double u;

            if ((z - x) == 0)
                u = y * Math.Sin(x) * Math.Sin(x) + z;
            else
                if ((z - x) < 0)
                   u = y * Math.Exp(Math.Sin(x)) - z;
                else u = y * Math.Exp(Math.Sin(x)) + z;

            //Вывод результата
            textBox4.Text += "U = " + u.ToString() +
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
