using Timer = System.Windows.Forms.Timer;
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

        private void UpdateWaterCountdown()
        {
            if (combo.SelectedItem != null)
            {
                string selected = combo.SelectedItem.ToString();
                int minutes = int.Parse(selected.Split(' ')[0]);

                lblWaterCountdown.Text =
                    $"Next reminder in: {minutes:00}:00";
            }

        // RESET BUTTON
        private void button4_Click(object sender, EventArgs e)
        {
            ResetCountdown();
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

        private void button1_Click(object sender, EventArgs e)
        {
                countdown--;

                UpdateCountdownLabel();
    
                if (countdown == 0)
                {
                    FinishCountdown();
                }
            }
        }

        private void WRstop_interval_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            label1.Text = "Time is up!";

            UpdateButtons();
        }
    }
}
