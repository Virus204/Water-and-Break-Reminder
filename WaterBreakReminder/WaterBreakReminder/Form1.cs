
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
            UpdateButtons();
        }

        // START BUTTON
        private void button1_Click(object sender, EventArgs e)
        {
            StartCountdown();
        }

        // PAUSE BUTTON
        private void button2_Click(object sender, EventArgs e)
        {
            PauseCountdown();
        }

        // RESUME BUTTON
        private void button3_Click(object sender, EventArgs e)
        {
            ResumeCountdown();
        }

        // RESET BUTTON
        private void button4_Click(object sender, EventArgs e)
        {
            ResetCountdown();
        }

        private void StartCountdown()
        {
            if (int.TryParse(textBox1.Text, out int minutes) && minutes > 0)
            {
                countdown = minutes * 60;

                UpdateCountdownLabel();

                timer1.Start();

                UpdateButtons();
            }
            else
            {
                MessageBox.Show("Please enter a whole number greater than 0.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                textBox1.Clear();
                textBox1.Focus();
            }
        }

        // PAUSE COUNTDOWN
        private void PauseCountdown()
        {
            timer1.Stop();

            UpdateButtons();
        }

        // RESUME COUNTDOWN
        private void ResumeCountdown()
        {
            if (countdown > 0)
            {
                timer1.Start();

                UpdateButtons();
            }
        }

        // RESET COUNTDOWN
        private void ResetCountdown()
        {
            timer1.Stop();

            countdown = 0;

            label1.Text = "00:00";

            UpdateButtons();
        }

        // UPDATE COUNTDOWN LABEL
        private void UpdateCountdownLabel()
        {
            label1.Text = $"{countdown / 60:00}:{countdown % 60:00}";
        }

        // UPDATE BUTTON VISIBILITY
        private void UpdateButtons()
        {
            bool isRunning = timer1.Enabled;
            bool hasTime = countdown > 0;

            button1.Visible = !isRunning && !hasTime;
            button2.Visible = isRunning;
            button3.Visible = !isRunning && hasTime;
            button4.Visible = hasTime;
        }

        // TIMER TICK
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (countdown > 0)
            {
                countdown--;

                UpdateCountdownLabel();

                if (countdown == 0)
                {
                    FinishCountdown();
                }
            }
        }

        // FINISH COUNTDOWN
        private void FinishCountdown()
        {
            timer1.Stop();

            label1.Text = "Time is up!";

            UpdateButtons();
        }
    }
}
