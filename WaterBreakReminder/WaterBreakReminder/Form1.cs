using Timer = System.Windows.Forms.Timer;
namespace WaterBreakReminder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
    
        }

        private void WRstop_interval_Click(object sender, EventArgs e)
        {

        }
    }
}
