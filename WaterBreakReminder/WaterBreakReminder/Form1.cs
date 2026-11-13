namespace WaterBreakReminder
{
    public partial class Form1 : Form
    {
        int countdown = 0;
        int reminder = 0;
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer4.Interval = 1000;
            UpdateBreakButtons();
            UpdateReminderButtons();
        }

        private void UpdateWaterCountdown()
        {
            if (combo.SelectedItem != null)
            {
                string selected = combo.SelectedItem.ToString();
                int minutes = int.Parse(selected.Split(' ')[0]);

                lblWaterCountdown.Text =
                    $"Next reminder in: {minutes:00}:00";
            }
        }
        private void UpdateBreakCountdown()
        {
            if (cmbBreakInterval.SelectedItem != null)
            {
                string selected = cmbBreakInterval.SelectedItem.ToString();
                int minutes = int.Parse(selected.Split(' ')[0]);

                lblBreakCountdown.Text =
                    $"Next break in: {minutes:00}:00";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateWaterCountdown();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateWaterCountdown();
            UpdateBreakCountdown();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateBreakCountdown();
        }

        private void BreakStartBtn_Click(object sender, EventArgs e)
        {
            StartCountdown();
        }
        private void WaterStartBtn_Click(object sender, EventArgs e)
        {
            StartReminder();
        }

        private void BreakPauseBtn_Click(object sender, EventArgs e)
        {
            PauseCountdown();
        }
        private void WaterPauseBtn_Click(object sender, EventArgs e)
        {
            PauseReminder();
        }
        private void BreakResumeBtn_Click(object sender, EventArgs e)
        {
            ResumeCountdown();
        }
        private void WaterResumeBtn_Click(object sender, EventArgs e)
        {
            ResumeReminder();
        }

        private void BreakResetBtn_Click_1(object sender, EventArgs e)
        {
            ResetCountdown();
        }
        private void WaterResetBtn_Click(object sender, EventArgs e)
        {
            ResetReminder();
        }
        private void StartCountdown()
        {
            if (cmbBreakInterval.SelectedItem != null)
            {
                string selected = cmbBreakInterval.SelectedItem.ToString();
                int minutes = int.Parse(selected.Split(' ')[0]);

                if (minutes > 0)
                {
                    countdown = minutes * 60;

                    UpdateCountdownLabel();
                    timer1.Start();
                    UpdateBreakButtons();
                }
            }
            else
            {
                MessageBox.Show("Please select a break interval.");
            }
        }
        private void StartReminder()
        {
            if (combo.SelectedItem != null)
            {
                string selected = combo.SelectedItem.ToString();
                int minutes = int.Parse(selected.Split(' ')[0]);

                if (minutes > 0)
                {
                    reminder = minutes * 60;

                    UpdateReminderLabel();
                    timer4.Start();
                    UpdateReminderButtons();
                }
            }
            else
            {
                MessageBox.Show("Please select a reminder interval.");
            }
        }

        private void PauseCountdown()
        {
            timer1.Stop();
            UpdateBreakButtons();
        }
        private void PauseReminder()
        {
            timer4.Stop();
            UpdateReminderButtons();
        }

        private void ResumeCountdown()
        {
            if (countdown > 0)
            {
                timer1.Start();
                UpdateBreakButtons();
            }
        }
        private void ResumeReminder()
        {
            if (reminder > 0)
            {
                timer4.Start();
                UpdateReminderButtons();
            }
        }


        private void ResetCountdown()
        {
            timer1.Stop();
            countdown = 0;
            lblBreakCountdown.Text = "Next break in: 00:00";
            UpdateBreakButtons();
        }
        private void ResetReminder()
        {
            timer4.Stop();
            reminder = 0;
            lblWaterCountdown.Text = "Next reminder in: 00:00";
            UpdateReminderButtons();
        }

        private void UpdateCountdownLabel()
        {
            lblBreakCountdown.Text = $"Next break in: {countdown / 60:00}:{countdown % 60:00}";
        }
        private void UpdateReminderLabel()
        {
            lblWaterCountdown.Text = $"Next reminder in: {reminder / 60:00}:{reminder % 60:00}";
        }

        private void UpdateBreakButtons()
        {
            bool isRunning = timer1.Enabled;
            bool hasTime = countdown > 0;

            BreakStartBtn.Visible = !isRunning && !hasTime;
            BreakPauseBtn.Visible = isRunning;
            BreakResumeBtn.Visible = !isRunning && hasTime;
            BreakResetBtn.Visible = hasTime;
        }
        private void UpdateReminderButtons()
        {
            bool isRunning = timer4.Enabled;
            bool hasTime = reminder > 0;

            WaterStartBtn.Visible = !isRunning && !hasTime;
            WaterPauseBtn.Visible = isRunning;
            WaterResumeBtn.Visible = !isRunning && hasTime;
            WaterResetBtn.Visible = hasTime;
        }

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
        private void timer4_Tick_1(object sender, EventArgs e)
        {
            if (reminder > 0)
            {
                reminder--;

                UpdateReminderLabel();

                if (reminder == 0)
                {
                    FinishReminder();
                }
            }
        }

        private void FinishCountdown()
        {
            timer1.Stop();

            lblBreakCountdown.Text = "Time is up!";

            MessageBox.Show(
                "Hey dude, it's your break time!",
                "Break Reminder",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
            UpdateBreakButtons();
        }
        private void FinishReminder()
        {
            timer4.Stop();

            lblWaterCountdown.Text = "Time is up!";

            MessageBox.Show(
                "Hey dude, it's your water time!",
                "Water Reminder",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
            UpdateReminderButtons();
        }
    }
}