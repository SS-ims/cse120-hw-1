namespace MindfulnessApp
{
    partial class ListingForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.NumericUpDown numericDuration;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ListBox listBoxItems;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Label lblTimeLeft;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Timer prepareTimer;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblPrompt = new System.Windows.Forms.Label();
            this.numericDuration = new System.Windows.Forms.NumericUpDown();
            this.lblDuration = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.listBoxItems = new System.Windows.Forms.ListBox();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.lblTimeLeft = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.prepareTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrompt
            // 
            this.lblPrompt.AutoSize = true;
            this.lblPrompt.Location = new System.Drawing.Point(20, 15);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(150, 13);
            this.lblPrompt.TabIndex = 0;
            this.lblPrompt.Text = "Set duration and press Start.";
            // 
            // numericDuration
            // 
            this.numericDuration.Location = new System.Drawing.Point(120, 40);
            this.numericDuration.Maximum = new decimal(new int[] { 600, 0, 0, 0 });
            this.numericDuration.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            this.numericDuration.Name = "numericDuration";
            this.numericDuration.Size = new System.Drawing.Size(80, 20);
            this.numericDuration.TabIndex = 1;
            this.numericDuration.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(20, 42);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(89, 13);
            this.lblDuration.TabIndex = 2;
            this.lblDuration.Text = "Duration (seconds)";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(220, 36);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(80, 28);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(20, 70);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(120, 13);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Status messages appear.";
            // 
            // listBoxItems
            // 
            this.listBoxItems.FormattingEnabled = true;
            this.listBoxItems.Location = new System.Drawing.Point(20, 110);
            this.listBoxItems.Name = "listBoxItems";
            this.listBoxItems.Size = new System.Drawing.Size(360, 95);
            this.listBoxItems.TabIndex = 5;
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(20, 215);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(280, 20);
            this.txtItem.TabIndex = 6;
            this.txtItem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtItem_KeyDown);
            // 
            // lblTimeLeft
            // 
            this.lblTimeLeft.AutoSize = true;
            this.lblTimeLeft.Location = new System.Drawing.Point(320, 218);
            this.lblTimeLeft.Name = "lblTimeLeft";
            this.lblTimeLeft.Size = new System.Drawing.Size(64, 13);
            this.lblTimeLeft.TabIndex = 7;
            this.lblTimeLeft.Text = "Time left: - ";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(300, 250);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 28);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ListingForm
            // 
            this.ClientSize = new System.Drawing.Size(410, 300);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTimeLeft);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.listBoxItems);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.numericDuration);
            this.Controls.Add(this.lblPrompt);
            this.Name = "ListingForm";
            this.Text = "Listing Activity";
            ((System.ComponentModel.ISupportInitialize)(this.numericDuration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
