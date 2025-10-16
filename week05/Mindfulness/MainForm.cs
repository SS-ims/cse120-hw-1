using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MindfulnessApp
{
    public partial class MainForm : Form
    {
        private readonly User _user;
        private readonly string logFile = "activity_log.txt";

        public MainForm(User user)
        {
            InitializeComponent();
            _user = user;
            lblWelcome.Text = $"Welcome, {_user.Username}!";
            LoadLog();
        }

        private void btnBreathing_Click(object sender, EventArgs e)
        {
            new BreathingForm(_user).ShowDialog();
            LoadLog();
        }

        private void btnReflecting_Click(object sender, EventArgs e)
        {
            new ReflectingForm(_user).ShowDialog();
            LoadLog();
        }

        private void btnListing_Click(object sender, EventArgs e)
        {
            new ListingForm(_user).ShowDialog();
            LoadLog();
        }

        private void LoadLog()
        {
            dgvLog.Rows.Clear();
            if (!File.Exists(logFile)) return;

            var lines = File.ReadAllLines(logFile)
                .Where(l => l.StartsWith(_user.Username + "|"))
                .Reverse();

            foreach (var line in lines)
            {
                var parts = line.Split('|');
                if (parts.Length == 4)
                    dgvLog.Rows.Add(parts[1], parts[2], parts[3]);
            }
        }
    }
}
