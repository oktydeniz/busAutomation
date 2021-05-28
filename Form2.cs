using System;
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
    public partial class Form2 : Form
    {
        String line;
        string cinsiyet = "Erkek";
        public Form2()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            line = button1.Text;
        }
        private void button11_Click(object sender, EventArgs e)
        {
            listBox3.Items.Add(textBox1.Text);
            listBox4.Items.Add(textBox2.Text);
            listBox5.Items.Add(comboBox1.Text);
            listBox7.Items.Add(comboBox2.Text);
            listBox2.Items.Add(line);
            if (radioButton2.Checked == true)
            {
                cinsiyet = "Kadın";
            }
            listBox6.Items.Add(cinsiyet);
            textBox1.Text = "";
            textBox2.Text = "";
            line = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            line = button2.Text;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            line = button3.Text;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            line = button4.Text;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            line = button5.Text;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            line = button6.Text;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            line = button7.Text;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            line = button8.Text;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            line = button9.Text;
        }
        private void button10_Click(object sender, EventArgs e)
        {
            line = button10.Text;
        }
    }
}
