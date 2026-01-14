namespace _017_WF_Practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            Clock.Text = DateTime.Now.ToLongTimeString();

            DateTime now  = DateTime.Now;
            DateTime dateAfterWeek = new DateTime(2026,1,21);

            TimeSpan difference = dateAfterWeek - now;
            MessageBox.Show(difference.TotalDays.ToString());

            // MessageBox.Show(DateTime.Now.Year.ToString());

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Clock.Text = DateTime.Now.ToLongTimeString();

        }
    }
}
