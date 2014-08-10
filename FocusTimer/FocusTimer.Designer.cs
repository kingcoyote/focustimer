namespace FocusTimer
{
    partial class FocusTimer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FocusTimer));
            this.BtnStart = new System.Windows.Forms.Button();
            this.BtnStop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtMinutes = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusRemaining = new System.Windows.Forms.ToolStripStatusLabel();
            this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.startTimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopTimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showTimreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripRemaining = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(93, 38);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(75, 23);
            this.BtnStart.TabIndex = 0;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.StartTimer);
            // 
            // BtnStop
            // 
            this.BtnStop.Location = new System.Drawing.Point(12, 38);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(75, 23);
            this.BtnStop.TabIndex = 1;
            this.BtnStop.Text = "Stop";
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.StopTimer);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Minutes";
            // 
            // TxtMinutes
            // 
            this.TxtMinutes.Location = new System.Drawing.Point(68, 12);
            this.TxtMinutes.Name = "TxtMinutes";
            this.TxtMinutes.Size = new System.Drawing.Size(100, 20);
            this.TxtMinutes.TabIndex = 3;
            this.TxtMinutes.Text = "30";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusRemaining});
            this.statusStrip1.Location = new System.Drawing.Point(0, 69);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(181, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusRemaining
            // 
            this.StatusRemaining.Name = "StatusRemaining";
            this.StatusRemaining.Size = new System.Drawing.Size(34, 17);
            this.StatusRemaining.Text = "00:00";
            // 
            // NotifyIcon
            // 
            this.NotifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.NotifyIcon.ContextMenuStrip = this.contextMenuStrip1;
            this.NotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon.Icon")));
            this.NotifyIcon.Text = "Focus Timer";
            this.NotifyIcon.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripRemaining,
            this.toolStripSeparator1,
            this.startTimerToolStripMenuItem,
            this.stopTimerToolStripMenuItem,
            this.showTimreToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(138, 126);
            this.contextMenuStrip1.Text = "Exit";
            // 
            // startTimerToolStripMenuItem
            // 
            this.startTimerToolStripMenuItem.Name = "startTimerToolStripMenuItem";
            this.startTimerToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.startTimerToolStripMenuItem.Text = "Start Timer";
            this.startTimerToolStripMenuItem.Click += new System.EventHandler(this.StartTimer);
            // 
            // stopTimerToolStripMenuItem
            // 
            this.stopTimerToolStripMenuItem.Name = "stopTimerToolStripMenuItem";
            this.stopTimerToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.stopTimerToolStripMenuItem.Text = "Stop Timer";
            this.stopTimerToolStripMenuItem.Click += new System.EventHandler(this.StopTimer);
            // 
            // showTimreToolStripMenuItem
            // 
            this.showTimreToolStripMenuItem.Name = "showTimreToolStripMenuItem";
            this.showTimreToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.showTimreToolStripMenuItem.Text = "Show Timer";
            this.showTimreToolStripMenuItem.Click += new System.EventHandler(this.ShowTimer);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitFocusTimer);
            // 
            // ToolStripRemaining
            // 
            this.ToolStripRemaining.Enabled = false;
            this.ToolStripRemaining.Name = "ToolStripRemaining";
            this.ToolStripRemaining.Size = new System.Drawing.Size(137, 22);
            this.ToolStripRemaining.Text = "--:--";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(134, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(134, 6);
            // 
            // FocusTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(181, 91);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.TxtMinutes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.BtnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FocusTimer";
            this.Text = "Focus Timer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClosingForm);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtMinutes;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusRemaining;
        private System.Windows.Forms.NotifyIcon NotifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem startTimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopTimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showTimreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripRemaining;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

