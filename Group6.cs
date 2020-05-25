using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taxx
{
    public partial class Group6 : Form
    {
        public Group6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int outcomefinal = int.Parse(textBox1.Text);
            int pay;


            if (outcomefinal > 5000001)
            {
                pay = (outcomefinal * 35 / 100);
            }
            else if (outcomefinal > 2000001)
            {
                pay = (outcomefinal * 30 / 100);
            }
            else if (outcomefinal > 1000001)
            {
                pay = (outcomefinal * 25 / 100);
            }
            else if (outcomefinal > 750001)
            {
                pay = (outcomefinal * 20 / 100);
            }
            else if (outcomefinal > 500001)
            {
                pay = (outcomefinal * 15 / 100);
            }
            else if (outcomefinal > 300001)
            {
                pay = (outcomefinal * 10 / 100);
            }
            else if (outcomefinal > 150001)
            {
                pay = (outcomefinal * 5 / 100);
            }
            else
            {
                pay = (0);
            }

            textBox2.Text = pay.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 tax = new Form1();
            tax.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
