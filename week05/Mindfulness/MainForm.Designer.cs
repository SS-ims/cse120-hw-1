namespace MindfulnessApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnBreathing;
        private System.Windows.Forms.Button btnReflecting;
        private System.Windows.Forms.Button btnListing;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.DataGridView dgvLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn colActivity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnBreathing = new System.Windows.Forms.Button();
            this.btnReflecting = new System.Windows.Forms.Button();
            this.btnListing = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.dgvLog = new System.Windows.Forms.DataGridView();
            this.colActivity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.Location = new System.Drawing.Point(20, 20);
            this.lblWelcome.Text = "Welcome!";
            // 
            // Buttons
            // 
            this.btnBreathing.Text = "Breathing";
            this.btnBreathing.Location = new System.Drawing.Point(20, 60);
            this.btnBreathing.Click += new System.EventHandler(this.btnBreathing_Click);

            this.btnReflecting.Text = "Reflecting";
            this.btnReflecting.Location = new System.Drawing.Point(140, 60);
            this.btnReflecting.Click += new System.EventHandler(this.btnReflecting_Click);

            this.btnListing.Text = "Listing";
            this.btnListing.Location = new System.Drawing.Point(260, 60);
            this.btnListing.Click += new System.EventHandler(this.btnListing_Click);

            // 
            // DataGridView
            // 
            this.dgvLog.Location = new System.Drawing.Point(20, 110);
            this.dgvLog.Size = new System.Drawing.Size(460, 250);
            this.dgvLog.ReadOnly = true;
            this.dgvLog.AllowUserToAddRows = false;
            this.dgvLog.Columns.AddRange(
                new System.Windows.Forms.DataGridViewColumn[] {
                    this.colActivity, this.colDuration, this.colDate
                });

            this.colActivity.HeaderText = "Activity";
            this.colDuration.HeaderText = "Duration (s)";
            this.colDate.HeaderText = "Date";

            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(520, 400);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnBreathing);
            this.Controls.Add(this.btnReflecting);
            this.Controls.Add(this.btnListing);
            this.Controls.Add(this.dgvLog);
            this.Text = "Mindfulness Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
