﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seyahat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text =="i" && textBox2.Text == "1")
            {
                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Giriş Başarısız ");
            }
        }
    }
}
