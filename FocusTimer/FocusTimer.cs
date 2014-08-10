using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FocusTimer
{
    public partial class FocusTimer : Form
    {
        private Timer _uiTimer;
        private readonly Stopwatch _stopwatch;
        private bool _running = false;
        private int _minutes;
        private bool _closing = false;

        public FocusTimer()
        {
            InitializeComponent();
            _stopwatch = new Stopwatch();
            StartUITimer();
            
        }

        private void StartUITimer()
        {
            _uiTimer = new Timer();
            _uiTimer.Interval = 100;
            _uiTimer.Enabled = true;
            _uiTimer.Tick += UpdateUI;
        }

        private void UpdateUI(object sender, EventArgs e)
        {
            BtnStart.Enabled = !_running;
            BtnStop.Enabled = _running;
            TxtMinutes.Enabled = !_running;
            startTimerToolStripMenuItem.Text = string.Format("Start Timer ({0})", TxtMinutes.Text);

            if (_running)
            {
                var remainingMs = _minutes*60000 - _stopwatch.ElapsedMilliseconds;
                if (remainingMs < 0)
                {
                    EndTimer();
                    StopTimer(null, null);
                    return;
                }
                var displayTime = PrintTime(remainingMs);
                StatusRemaining.Text = displayTime;
                ToolStripRemaining.Text = displayTime;
                

            } else
            {
                StatusRemaining.Text = "--:--";
                ToolStripRemaining.Text = "--:--";
            }
        }

        private void StartTimer(object sender, EventArgs e)
        {
            _running = true;
            _stopwatch.Restart();
            _minutes = int.Parse(TxtMinutes.Text);
        }

        private void StopTimer(object sender, EventArgs e)
        {
            _running = false;
            _stopwatch.Reset();
            _minutes = 0;
        }

        private void EndTimer()
        {
            NotifyIcon.Visible = true;
            NotifyIcon.BalloonTipTitle = "Focus session completed!";
            NotifyIcon.BalloonTipText = string.Format("{0} minute focus session has finished.", _minutes);
            NotifyIcon.ShowBalloonTip(2000);
        }

        private string PrintTime(long ms)
        {
            return string.Format("{0:00}:{1:00.00}", ms / 60000, (ms % 60000) / 1000.0);
        }

        private void ExitFocusTimer(object sender, EventArgs e)
        {
            _closing = true;
            Application.Exit();
        }

        private void ShowTimer(object sender, EventArgs e)
        {
            Show();
        }

        private void ClosingForm(object sender, FormClosingEventArgs e)
        {
            if (_closing)
            {
                NotifyIcon.Visible = false;
                return;
            }
            e.Cancel = true;
            Hide();
            NotifyIcon.BalloonTipText = "FocusTimer minimized to system tray";
            NotifyIcon.ShowBalloonTip(2000);
        }
    }
}
