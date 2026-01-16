using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _018_WF_Controls
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label5.Text = (2 * Math.PI * Convert.ToInt32(textBox4.Text)).ToString();
            }
            if (radioButton2.Checked)
            {
                label5.Text = (Math.PI * Math.Pow(Convert.ToInt32(textBox4.Text), 2)).ToString();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // MessageBox.Show(listBox1.SelectedItem.ToString());


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(listBox1.Items.Contains(textBox5.Text))
            {
                MessageBox.Show("Такий елемент вже є в списку!");
            }
            else if (textBox5.Text == "")
            {
                MessageBox.Show("Введіть колір!");
            }
            else
               listBox1.Items.Add(textBox5.Text);
        }
    }
}
