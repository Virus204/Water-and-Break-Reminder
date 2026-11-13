namespace WaterBreakReminder
{
    public partial class Form1 : Form
    {
        int countdown = 0;
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            label1.Text = "00:00";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //start
        {
            countdown = int.Parse(textBox1.Text) * 60; // Convert minutes to seconds
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e) //pause
        {
            timer1.Stop();
        }

        private void button3_Click(object sender, EventArgs e) //resume
        {
            timer1.Start();
        }
        private void button4_Click(object sender, EventArgs e) //reset
        {
            timer1.Stop();
            countdown = 0;
            label1.Text = "00:00";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (countdown > 0)
            {
                countdown--;
                label1.Text = TimeSpan.FromMilliseconds(countdown).ToString("m\\:ss");
            }
            else
            {
                timer1.Stop();
                label1.Text = "Time is up!";
            }
        }
    }
}
