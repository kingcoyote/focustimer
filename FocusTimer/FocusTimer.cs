using System;
using System.Diagnostics;
using System.Windows.Forms;
using FocusTimer.Properties;

namespace FocusTimer
{
    public partial class FocusTimer : Form
    {
        private Timer _uiTimer;
        private readonly Stopwatch _stopwatch;
        private bool _running;
        private int _minutes;
        private bool _closing;

        public FocusTimer()
        {
            InitializeComponent();
            _stopwatch = new Stopwatch();
            StartUITimer();
            ResetSettings();
        }

        private void StartUITimer()
        {
            _uiTimer = new Timer { Interval = 10, Enabled = true };
            _uiTimer.Tick += UpdateUI;
        }

        private void UpdateUI(object sender, EventArgs e)
        {
            TxtMinutes.Enabled = !_running;
            startTimerToolStripMenuItem.Text = string.Format("Start Timer ({0})", TxtMinutes.Text);

            if (_running)
            {
                var remainingMs = _minutes*60000 - _stopwatch.ElapsedMilliseconds;
                if (remainingMs < 0)
                {
                    EndTimer();
                    StopTimer();
                    return;
                }
                var displayTime = PrintTime(remainingMs);
                ToolStripRemaining.Text = displayTime;
            } else
            {
                ToolStripRemaining.Text = "--:--";
            }
        }

        private void EndTimer()
        {
            NotifyIcon.Visible = true;
            NotifyIcon.BalloonTipTitle = Settings.Default.Title;
            NotifyIcon.BalloonTipText = Settings.Default.Message;
            NotifyIcon.ShowBalloonTip(2000);
        }

        private string PrintTime(long ms)
        {
            return string.Format("{0:00}:{1:00.00}", ms / 60000, (ms % 60000) / 1000.0);
        }

        private void ShowOptions()
        {
            Show();
        }

        private void MinimizeToTray()
        {
            Hide();
            NotifyIcon.BalloonTipText = "FocusTimer has minimized to the system tray";
            NotifyIcon.ShowBalloonTip(2000);
        }

        private void ResetSettings()
        {
            TxtMinutes.Text = Settings.Default.Minutes;
            TxtTitle.Text = Settings.Default.Title;
            TxtMessage.Text = Settings.Default.Message;
            MinimizeToTray();
        }

        private void SaveSettings()
        {
            Settings.Default.Minutes = TxtMinutes.Text;
            Settings.Default.Title = TxtTitle.Text;
            Settings.Default.Message = TxtMessage.Text;
            Settings.Default.Save();
            MinimizeToTray();
        }

        private void StartTimer()
        {
            _running = true;
            _stopwatch.Restart();
            _minutes = int.Parse(TxtMinutes.Text);
        }

        private void StopTimer()
        {
            _running = false;
            _stopwatch.Reset();
            _minutes = 0;
        }

        #region "UI Event handlers"

        private void BtnCancelClick(object sender, EventArgs e)
        {
            ResetSettings();
        }

        private void BtnSaveClick(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void ShowTimer(object sender, EventArgs e)
        {
            ShowOptions();
        }

        private void ClosingForm(object sender, FormClosingEventArgs e)
        {
            ResetSettings();

            if (_closing)
            {
                NotifyIcon.Visible = false;
                return;
            }
            e.Cancel = true;
            MinimizeToTray();
        }

        private void ExitFocusTimer(object sender, EventArgs e)
        {
            _closing = true;
            Application.Exit();
        }

        private void StartTimer(object sender, EventArgs e)
        {
            StartTimer();
        }

        private void StopTimer(object sender, EventArgs e)
        {
            StopTimer();
        }

        #endregion
    }
}
