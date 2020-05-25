﻿using System;
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
            int oc = int.Parse(textBox1.Text);
            int pay;


            if (oc > 5000001)
            {
                pay = (oc * 35 / 100);
            }
            else if (oc > 2000001)
            {
                pay = (oc * 30 / 100);
            }
            else if (oc > 1000001)
            {
                pay = (oc * 25 / 100);
            }
            else if (oc > 750001)
            {
                pay = (oc * 20 / 100);
            }
            else if (oc > 500001)
            {
                pay = (oc * 15 / 100);
            }
            else if (oc > 300001)
            {
                pay = (oc * 10 / 100);
            }
            else if (oc > 150001)
            {
                pay = (oc * 5 / 100);
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
