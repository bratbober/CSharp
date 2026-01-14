namespace _017_WF_Basics
{
    public partial class Form1 : Form
    {
        int count, count1 = 0;
        public Form1()
        {
            InitializeComponent();


            /*MessageBox.Show(DateTime.Now.ToLongTimeString());*/


            /*DialogResult result = MessageBox.Show("Test", "Message", MessageBoxButtons.RetryCancel);

            while (result == DialogResult.Retry)
            {
                result = MessageBox.Show("Test", "Message", MessageBoxButtons.RetryCancel);
            }*/


            /*if (result == DialogResult.OK)
            {
                MessageBox.Show("Ви натиснули OK");
            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Ви натиснули Cancel");
            }*/
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            /*if(e.Button == MouseButtons.Left)
            {
                MessageBox.Show("Ви натиснули ліву кнопку",
                    "Повідомлення",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning
                    );
            }
            else if(e.Button == MouseButtons.Right)
            {
                MessageBox.Show("Ви натиснули праву кнопку",
                    "Повідомлення",
                    MessageBoxButtons.YesNo
                    );
            }*/

            this.Text = count++.ToString();


        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //this.Text = $"X: {e.X}, Y: {e.Y}";
            TextLabel.Text = $"X: {e.X}, Y: {e.Y}";
        }



        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Random random = new Random();

            this.BackColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // MessageBox.Show("Message");
            LabelCount.Text = count1++.ToString();
        }

        private void yes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Звісно вам подобається 1000 за місяць");
            timer1.Start();
        }

        private void no_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void no_MouseMove(object sender, MouseEventArgs e)
        {
            no.Top -= e.Y;
            no.Left += e.X;
            if (no.Top < -10 || no.Top > 100)
                no.Top = 60;
            if(no.Left < -80 || no.Left > 250) 
                no.Left = 120;
        }
    }
}



