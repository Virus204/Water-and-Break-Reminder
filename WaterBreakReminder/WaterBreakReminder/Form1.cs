
using System;
using System.Windows.Forms;

namespace WaterBreakReminder
{
    public partial class Form1 : Form
    {
        private NotificationManager notificationManager;

        public Form1()
        {
            InitializeComponent();

            notificationManager = new NotificationManager();

            // Restore form when tray icon is double-clicked
            notificationManager.TrayIconDoubleClick += (sender, e) =>
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
            };

            // Load saved settings
            AppSettings savedSettings = AppSettings.Load();
            chkSound.Checked = savedSettings.SoundEnabled;

            // Connect events
            chkSound.CheckedChanged += chkSound_CheckedChanged;
            this.Resize += Form1_Resize;
            this.FormClosing += Form1_FormClosing;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            notificationManager.ShowWaterNotification();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            notificationManager.ShowBreakNotification();
        }

        private void chkSound_CheckedChanged(object sender, EventArgs e)
        {
            notificationManager.SetSoundEnabled(chkSound.Checked);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
            }
        }

        private void Form1_FormClosing(object? sender, FormClosingEventArgs e)
        {
            notificationManager.Dispose();
        }
    }
}
