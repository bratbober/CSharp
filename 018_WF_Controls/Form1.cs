namespace _018_WF_Controls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clicked");
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            // button1.BackColor = Color.FromArgb(100, 29, 130);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            // button1.BackColor = Color.FromArgb(34, 56, 150);
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            // button1.BackColor = Color.FromArgb(100, 100, 100);
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            // button1.BackColor = Color.FromArgb(50, 100, 150);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                MessageBox.Show("Ви любите футбол!");
            else
                MessageBox.Show("Ви не любите футбол!");
        }



        private void button3_Click(object sender, EventArgs e)
        {
            if (checkBox2.CheckState == CheckState.Checked)
                MessageBox.Show("Давай");
            else if (checkBox2.CheckState == CheckState.Unchecked)
                MessageBox.Show("Не хочу");
            else
                MessageBox.Show("Ну не знаю");
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                this.BackColor = Color.Black;
                this.ForeColor = Color.White;
            }
            else
            {
                this.BackColor = Color.White;
                this.ForeColor = Color.Black;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                MessageBox.Show("Ви чоловік");
            if (radioButton2.Checked)
                MessageBox.Show("Ви жінка");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text);
            textBox1.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();          
        }
    }

}
