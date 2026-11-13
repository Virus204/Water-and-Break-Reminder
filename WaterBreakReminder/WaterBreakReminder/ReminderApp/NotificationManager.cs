
using System;
using System.IO;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace WaterBreakReminder
{
    public class NotificationManager
    {
        private AppSettings appSettings;
        private NotifyIcon trayIcon;
        private SoundPlayer soundPlayer;

        private bool soundEnabled = true;

        public event EventHandler? TrayIconDoubleClick;

        public NotificationManager()
        {
            appSettings = AppSettings.Load();
            soundEnabled = appSettings.SoundEnabled;

            // Create system tray icon
            trayIcon = new NotifyIcon();
            trayIcon.Icon = SystemIcons.Information;
            trayIcon.Text = "Water & Break Reminder";
            trayIcon.Visible = true;

            trayIcon.DoubleClick += (sender, e) =>
            {
                TrayIconDoubleClick?.Invoke(this, EventArgs.Empty);
            };

            // Load notification sound
            string soundPath = Path.Combine(
                AppContext.BaseDirectory,
                "Resources",
                "notification.wav"
            );

            soundPlayer = new SoundPlayer(soundPath);
            soundPlayer.Load();
        }

        public void SetSoundEnabled(bool enabled)
        {
            soundEnabled = enabled;
            appSettings.SoundEnabled = enabled;
            appSettings.Save();
        }

        public void PlayNotificationSound()
        {
            if (soundEnabled)
            {
                soundPlayer.Play();
            }
        }

        public void ShowWaterNotification()
        {
            trayIcon.BalloonTipTitle = "Water Reminder";
            trayIcon.BalloonTipText = "Time to drink some water!";
            trayIcon.BalloonTipIcon = ToolTipIcon.Info;
            trayIcon.ShowBalloonTip(5000);

            PlayNotificationSound();
        }

        public void ShowBreakNotification()
        {
            trayIcon.BalloonTipTitle = "Break Reminder";
            trayIcon.BalloonTipText = "Time to take a break!";
            trayIcon.BalloonTipIcon = ToolTipIcon.Info;
            trayIcon.ShowBalloonTip(5000);

            PlayNotificationSound();
        }

        public void Dispose()
        {
            trayIcon.Visible = false;
            trayIcon.Dispose();
            soundPlayer.Dispose();
        }
    }
}
