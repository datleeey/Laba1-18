using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba1_18
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double xn, xk, h, a, x, y;
            try
            {
                xn = Convert.ToDouble(textBox1.Text);
                xk = Convert.ToDouble(textBox2.Text);
                h = Convert.ToDouble(textBox3.Text);
                a = Convert.ToDouble(textBox4.Text);

                x = xn;

                dg.Rows.Clear();
                chart1.Series[0].Points.Clear();

                while (x <= xk)
                {
                    if (x <= 0)
                    {
                        y = Math.Pow(x, 4) + 2 * Math.Pow(x, 3) - x;
                    }
                    else if (x > 0 && x <= a)
                    {
                        y = Math.Exp(-x) + Math.Pow(x, 0.25);
                    }
                    else
                    {
                        y = Math.Log(Math.Pow(x, 3) + Math.Pow(x, 3));
                    }

                    dg.Rows.Add(x.ToString(), y.ToString());
                    chart1.Series[0].Points.AddXY(x, y);

                    x += h;
                }
            }
            catch
            {
                MessageBox.Show("Помилка введення даних. Будь ласка, перевірте введені значення.");
            }
        }
    }
}
